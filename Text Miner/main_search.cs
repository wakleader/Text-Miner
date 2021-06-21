using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Miner
{
    public partial class main_search : Form
    {
        public main_search()
        {
            InitializeComponent();
        }

        FolderBrowserDialog fbdConf = new FolderBrowserDialog();
        DataTable dtResults = new DataTable();
        BackgroundWorker worker = new BackgroundWorker();
        
        public static string text_file = "";
        public static int text_line = 0;
        public static string text_find = "";

        private void new_design_Load(object sender, EventArgs e)
        {
            dtResults.Columns.Add("Line_No");
            dtResults.Columns.Add("Searh_Results");
            dtResults.Columns.Add("Last_Modified");
            dtResults.Columns.Add("Open_File", typeof(Button));

            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(WorkerDoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(WorkerProgressChanged);
        }

        private void tsmLocation_Click(object sender, System.EventArgs e)
        {
            dgvResults.Rows.Clear();

            tssFilesChecked.Text = "Files Searched: 0";
            tssComplete.Text = "0% Complete";
            tssLinesRead.Text = "Total Lines Searched: 0";
            tssPB.Value = 0;

            DialogResult selectFolder = fbdConf.ShowDialog();

            if (selectFolder == DialogResult.OK)
            {
                tssLocation.Text = "Current Seach Location: " + fbdConf.SelectedPath;

                #region Counting files to search
                if (!cbSearchChild.Checked)
                {
                    int logCount = 0;
                    int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.TopDirectoryOnly).Length;

                    if (cbIncludeLog.Checked)
                    {
                        logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.TopDirectoryOnly).Length;
                    }

                    tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
                }

                if (cbSearchChild.Checked)
                {
                    int logCount = 0;
                    int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.AllDirectories).Length;

                    if (cbIncludeLog.Checked)
                    {
                        logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.AllDirectories).Length;
                    }

                    tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
                }
                #endregion
            }
        }

        private void cbSearchChild_CheckedChanged(object sender, EventArgs e)
        {
            #region Recounting files dependant of child selected or not
            if (!cbSearchChild.Checked)
            {
                int logCount = 0;
                int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.TopDirectoryOnly).Length;

                if (cbIncludeLog.Checked)
                {
                    logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.TopDirectoryOnly).Length;
                }

                tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
            }

            if (cbSearchChild.Checked)
            {
                int logCount = 0;
                int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.AllDirectories).Length;

                if (cbIncludeLog.Checked)
                {
                    logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.AllDirectories).Length;
                }

                tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
            }
            #endregion
        }

        private void cbIncludeLog_CheckedChanged(object sender, EventArgs e)
        {
            #region Recounting files dependant of child selected or not
            if (!cbSearchChild.Checked)
            {
                int logCount = 0;
                int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.TopDirectoryOnly).Length;

                if (cbIncludeLog.Checked)
                {
                    logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.TopDirectoryOnly).Length;
                }

                tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
            }

            if (cbSearchChild.Checked)
            {
                int logCount = 0;
                int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.AllDirectories).Length;

                if (cbIncludeLog.Checked)
                {
                    logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.AllDirectories).Length;
                }

                tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
            }
            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();

            tssFilesChecked.Text = "Files Searched: 0";
            tssComplete.Text = "0% Complete";
            tssLinesRead.Text = "Total Lines Searched: 0";
            tssPB.Value = 0;

            worker.RunWorkerAsync();
        }

        private void WorkerDoWork(object sender, DoWorkEventArgs e)
        {
            float totalfiles = Convert.ToInt32(tssFileCount.Text.Replace("File Count: ",""));

            List<string> configs = new List<string>();

            if (txtTextToFind.Text != "")
            {
                if (tssLocation.Text != "")
                {
                    float filecount = 0;
                    int linecount = 0;
                    var searchoption = SearchOption.TopDirectoryOnly;
                    string[] files = new string[10];

                    text_find = txtTextToFind.Text.ToString();

                    if (cbSearchChild.Checked)
                    {
                        searchoption = SearchOption.AllDirectories;
                    }

                    if (!cbIncludeLog.Checked)
                    {
                        var filestosearch = (string[])Directory.GetFiles(tssLocation.Text.Replace("Current Seach Location: ", ""), "*.txt", searchoption);
                        files = filestosearch;
                    }

                    if (cbIncludeLog.Checked)
                    {
                        var filestosearch = (string[])Directory.GetFiles(tssLocation.Text.Replace("Current Seach Location: ", ""), "*.*", searchoption).Where(s => s.EndsWith(".txt") || s.EndsWith(".log")).ToArray();
                        files = filestosearch;
                    }

                    #region Finding required data in files
                    foreach (var file in files)
                    {
                        try
                        {
                            FileInfo fileinfo = new FileInfo(file);

                            var readlines = File.ReadAllLines(file);
                            int linecount_file = 0;

                            filecount++;

                            StringComparison stringcompare = StringComparison.OrdinalIgnoreCase;

                            foreach (var line in readlines)
                            {
                                linecount_file++;
                                linecount++;

                                if (line.IndexOf(txtTextToFind.Text.ToString(), stringcompare) >= 0)
                                {
                                    DataGridViewRow row = (DataGridViewRow)dgvResults.Rows[0].Clone();

                                    row.Cells[0].Value = linecount_file;
                                    row.Cells[1].Value = "View...";
                                    row.Cells[2].Value = line.TrimStart();
                                    row.Cells[3].Value = fileinfo.LastWriteTime;
                                    row.Cells[4].Value = file;

                                    dgvResults.BeginInvoke((MethodInvoker)delegate
                                        {
                                            dgvResults.Rows.Add(row);
                                        });
                                }
                            }

                            ssBottom.BeginInvoke((MethodInvoker)delegate
                            {
                                tssLinesRead.Text = "Total Lines Searched: " + linecount.ToString();
                            });

                            ssBottom.BeginInvoke((MethodInvoker)delegate
                            {
                                tssFilesChecked.Text = "Files Searched: " + filecount.ToString();
                            });

                            int percent = (int)((filecount / totalfiles) * 100);

                            worker.ReportProgress(percent);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                    ssBottom.BeginInvoke((MethodInvoker)delegate
                    {
                        tssLinesRead.Text = "Total Lines Searched: " + linecount.ToString();
                    });
                    #endregion
                }

                else
                {
                    #region Select search location is not selected
                    MessageBox.Show("Please choose a location to search.");

                    DialogResult selectFolder = fbdConf.ShowDialog();

                    if (selectFolder == DialogResult.OK)
                    {
                        tssLocation.Text = "Current Seach Location: " + fbdConf.SelectedPath;

                        #region Counting files to search
                        if (!cbSearchChild.Checked)
                        {
                            int logCount = 0;
                            int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.TopDirectoryOnly).Length;

                            if (cbIncludeLog.Checked)
                            {
                                logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.TopDirectoryOnly).Length;
                            }

                            tssFileCount.Text = (txtCount + logCount).ToString();
                        }

                        if (cbSearchChild.Checked)
                        {
                            int logCount = 0;
                            int txtCount = Directory.GetFiles(fbdConf.SelectedPath, "*.txt", SearchOption.AllDirectories).Length;

                            if (cbIncludeLog.Checked)
                            {
                                logCount = Directory.GetFiles(fbdConf.SelectedPath, "*.log", SearchOption.AllDirectories).Length;
                            }

                            tssFileCount.Text = "File Count: " + (txtCount + logCount).ToString();
                        }
                        #endregion
                    }
                    #endregion
                }

                MessageBox.Show("Search Completed.");
            }

            else
            {
                MessageBox.Show("Please specify something to search.");

                txtTextToFind.BeginInvoke((MethodInvoker)delegate
                {
                    txtTextToFind.Focus();
                });
            }
        }

        private void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tssPB.Value = e.ProgressPercentage;
            tssComplete.Text = e.ProgressPercentage.ToString() + "% Completed";
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dgvResults.Columns[1].Index)
            {
                return;
            }

            text_file = dgvResults[4, e.RowIndex].Value.ToString();
            text_line = (int)dgvResults[0, e.RowIndex].Value;

            text_viewer tv = new text_viewer();

            tv.Show();
        }

        private void dgvResults_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvResults.Columns[e.ColumnIndex].Name != "Id")
            {
                // Check data for search  
                if (!String.IsNullOrWhiteSpace(txtTextToFind.Text.Trim()))
                {
                    String gridCellValue = e.FormattedValue.ToString();
                    // check the index of search text into grid cell.  
                    int startIndexInCellValue = gridCellValue.ToLower().IndexOf(txtTextToFind.Text.Trim().ToLower());
                    // IF search text is exists inside grid cell then startIndexInCellValue value will be greater then 0 or equal to 0  
                    if (startIndexInCellValue >= 0)
                    {
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, true);
                        //the highlite rectangle  
                        Rectangle hl_rect = new Rectangle();
                        hl_rect.Y = e.CellBounds.Y + 2;
                        hl_rect.Height = e.CellBounds.Height - 5;
                        //find the size of the text before the search word in grid cell data.  
                        String sBeforeSearchword = gridCellValue.Substring(0, startIndexInCellValue);
                        //size of the search word in the grid cell data  
                        String sSearchWord = gridCellValue.Substring(startIndexInCellValue, txtTextToFind.Text.Trim().Length);
                        Size s1 = TextRenderer.MeasureText(e.Graphics, sBeforeSearchword, e.CellStyle.Font, e.CellBounds.Size);
                        Size s2 = TextRenderer.MeasureText(e.Graphics, sSearchWord, e.CellStyle.Font, e.CellBounds.Size);
                        if (s1.Width > 5)
                        {
                            hl_rect.X = e.CellBounds.X + s1.Width - 5;
                            hl_rect.Width = s2.Width - 6;
                        }
                        else
                        {
                            hl_rect.X = e.CellBounds.X + 2;
                            hl_rect.Width = s2.Width - 6;
                        }
                        //color for showing highlighted text in grid cell  
                        SolidBrush hl_brush;
                        hl_brush = new SolidBrush(Color.Yellow);
                        //paint the background behind the search word  
                        e.Graphics.FillRectangle(hl_brush, hl_rect);
                        hl_brush.Dispose();
                        e.PaintContent(e.CellBounds);
                    }
                }
            }
        }
    }
}
