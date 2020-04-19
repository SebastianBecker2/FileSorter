using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSorter
{
    public partial class CreateDestination : Form
    {
        public IEnumerable<string> FileNames { get; set; }
        public IEnumerable<string> DestinationPaths { get; set; }
        public string DestinationName { get; set; }
        public string SelectedDestinationPath { get; set; }

        public CreateDestination()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (DestinationPaths != null)
            {
                LsbDestinationPaths.Items.AddRange(DestinationPaths.ToArray());
            }

            TxtFileName.Text = FileNames.FirstOrDefault();

            TxtDestinationName.Text = DestinationName;

            base.OnLoad(e);
        }

        private static int GetStartIndexOfWord(string text, int index)
        {
            while (index > 0
                && !char.IsWhiteSpace(text, index - 1)
                && !char.IsPunctuation(text, index - 1))
            {
                index--;
            }
            return index;
        }

        private static int GetEndIndexOfWord(string text, int index)
        {
            while ((index < text.Length - 1)
                && !char.IsWhiteSpace(text, index + 1)
                && !char.IsPunctuation(text, index + 1))
            {
                index++;
            }
            return index;
        }

        private void TxtFileName_MouseMove(object sender, MouseEventArgs e)
        {
            var char_index = TxtFileName.GetCharIndexFromPosition(TxtFileName.PointToClient(MousePosition));

            var @char = TxtFileName.Text[char_index];
            if (char.IsWhiteSpace(@char) || char.IsPunctuation(@char))
            {
                return;
            }

            var word_start_index = GetStartIndexOfWord(TxtFileName.Text, char_index);
            var word_end_index = GetEndIndexOfWord(TxtFileName.Text, char_index);
            var word_lenght = word_end_index + 1 - word_start_index;

            TxtFileName.SelectionBackColor = TxtFileName.BackColor;
            TxtFileName.SelectionColor = TxtFileName.ForeColor;
            TxtFileName.SelectionStart = word_start_index;
            TxtFileName.SelectionLength = word_lenght;
            TxtFileName.SelectionBackColor = SystemColors.Highlight;
            TxtFileName.SelectionColor = SystemColors.HighlightText;
        }

        private void TxtFileName_MouseLeave(object sender, EventArgs e)
        {
            TxtFileName.SelectionBackColor = TxtFileName.BackColor;
            TxtFileName.SelectionColor = TxtFileName.ForeColor;
            TxtFileName.DeselectAll();
        }

        private void TxtFileName_Click(object sender, EventArgs e)
        {
            var char_index = TxtFileName.GetCharIndexFromPosition(TxtFileName.PointToClient(MousePosition));

            var @char = TxtFileName.Text[char_index];
            if (char.IsWhiteSpace(@char) || char.IsPunctuation(@char))
            {
                return;
            }

            var word_start_index = GetStartIndexOfWord(TxtFileName.Text, char_index);
            var word_end_index = GetEndIndexOfWord(TxtFileName.Text, char_index);
            var word_lenght = word_end_index + 1 - word_start_index;

            var selected_text = TxtFileName.Text.Substring(word_start_index, word_lenght);

            if (!string.IsNullOrWhiteSpace(TxtDestinationName.Text)
                && TxtDestinationName.Text.Last() != '('
                && TxtDestinationName.Text.Last() != ' ')
            {
                TxtDestinationName.Text += " ";
            }

            TxtDestinationName.Text += selected_text;
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            if (LsbDestinationPaths.SelectedIndex == -1)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtDestinationName.Text))
            {
                return;
            }

            SelectedDestinationPath = LsbDestinationPaths.SelectedItem as string;

            DestinationName = TxtDestinationName.Text;
            DestinationName = DestinationName.Trim();

            if (DestinationName.Contains("("))
            {
                if (DestinationName.Last() == '('
                    || DestinationName.Last() == ',')
                {
                    DestinationName.Remove(TxtDestinationName.TextLength - 1);
                    // Trim second time. In case the second to last character
                    // was a white space.
                    DestinationName = DestinationName.Trim();
                }
                else
                {
                    DestinationName += ")";
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void BtnAddSubName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtDestinationName.Text))
            {
                return;
            }

            if (!TxtDestinationName.Text.Contains("("))
            {
                TxtDestinationName.Text += " (";
            }

            if (TxtDestinationName.Text.Contains("(")
                && TxtDestinationName.Text.Last() != '(')
            {
                TxtDestinationName.Text += ", ";
            }
        }
    }
}
