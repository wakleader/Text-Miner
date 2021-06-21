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
using ScintillaNET;
namespace Text_Miner
{
    public partial class text_viewer : Form
    {
        public text_viewer()
        {
            InitializeComponent();
        }

        private int maxLineNumberCharLength;

        private void text_viewer_Load(object sender, EventArgs e)
        {
            var readlines = File.ReadAllLines(main_search.text_file);

            StringComparison stringcompare = StringComparison.OrdinalIgnoreCase;

            textcontrol_settings();

            foreach (var line in readlines)
            {
                scintilla.AddText(line + Environment.NewLine);
            }

            for (int i = 0; i < scintilla.Lines.Count; i++)
            {
                if (scintilla.Lines[i].Text.IndexOf(main_search.text_find, stringcompare) >= 0)
                {
                    scintilla.Lines[i].MarkerAdd(1);
                }
            }

            scintilla.Lines[main_search.text_line - 1].Goto();

            HighlightWord(main_search.text_find);
        }

        private void textcontrol_settings()
        {
            scintilla.Markers[0].Symbol = MarkerSymbol.Arrow;
            scintilla.Markers[0].SetBackColor(Color.FromArgb(108, 226, 108)); // Green

            scintilla.Markers[1].Symbol = MarkerSymbol.Bookmark;
            scintilla.Markers[1].SetBackColor(Color.FromArgb(255, 238, 98)); // Yellow

            // Set the lexer
            scintilla.Lexer = Lexer.Cpp;

            // Instruct the lexer to calculate folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
        }

        private void HighlightWord(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            // Indicators 0-7 could be in use by a lexer
            // so we'll use indicator 8 to highlight words.
            const int NUM = 8;

            // Remove all uses of our indicator
            scintilla.IndicatorCurrent = NUM;
            scintilla.IndicatorClearRange(0, scintilla.TextLength);

            // Update indicator appearance
            scintilla.Indicators[NUM].Style = IndicatorStyle.StraightBox;
            scintilla.Indicators[NUM].Under = true;
            scintilla.Indicators[NUM].ForeColor = Color.Yellow;
            scintilla.Indicators[NUM].OutlineAlpha = 50;
            scintilla.Indicators[NUM].Alpha = 125;

            // Search the document
            scintilla.TargetStart = 0;
            scintilla.TargetEnd = scintilla.TextLength;
            scintilla.SearchFlags = SearchFlags.None;
            while (scintilla.SearchInTarget(text) != -1)
            {
                // Mark the search results with the current indicator
                scintilla.IndicatorFillRange(scintilla.TargetStart, scintilla.TargetEnd - scintilla.TargetStart);

                // Search the remainder of the document
                scintilla.TargetStart = scintilla.TargetEnd;
                scintilla.TargetEnd = scintilla.TextLength;
            }
        }

        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void text_viewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            scintilla.ClearAll();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            scintilla.Text = "";

            var readlines = File.ReadAllLines(main_search.text_file);

            StringComparison stringcompare = StringComparison.OrdinalIgnoreCase;

            textcontrol_settings();

            foreach (var line in readlines)
            {
                scintilla.AddText(line + Environment.NewLine);
            }

            for (int i = 0; i < scintilla.Lines.Count; i++)
            {
                if (scintilla.Lines[i].Text.IndexOf(main_search.text_find, stringcompare) >= 0)
                {
                    scintilla.Lines[i].MarkerAdd(1);
                }
            }

            scintilla.Lines[main_search.text_line - 1].Goto();

            HighlightWord(main_search.text_find);
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            scintilla.Text = "";

            var readlines = File.ReadAllLines(main_search.text_file);

            StringComparison stringcompare = StringComparison.OrdinalIgnoreCase;

            textcontrol_settings();

            foreach (var line in readlines)
            {
                if (line.IndexOf(main_search.text_find, stringcompare) >= 0)
                {
                    scintilla.AddText(line + Environment.NewLine);
                }
            }

            for (int i = 0; i < scintilla.Lines.Count; i++)
            {
                if (scintilla.Lines[i].Text.IndexOf(main_search.text_find, stringcompare) >= 0)
                {
                    scintilla.Lines[i].MarkerAdd(1);
                }
            }

            scintilla.Lines[main_search.text_line - 1].Goto();

            HighlightWord(main_search.text_find);
        }
    }
}
