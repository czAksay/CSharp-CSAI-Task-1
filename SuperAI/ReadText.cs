using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAI
{
    public partial class ReadText : Form
    {
        Ai ai;
        public ReadText(Ai ai)
        {
            InitializeComponent();
            this.ai = ai;
            cbMenu.SelectedIndex = 0;
            rtbText.Text = ai.FileText;
            cbFontSize.SelectedIndex = 4;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMenu.SelectedIndex)
            {
                case 0: rtbText.Text = ai.FileText; break;
                case 1: rtbText.Text = ai.ObjectsTextBlock; break;
                case 2: rtbText.Text = ai.ConnectionsTextBlock; break;
                case 3: rtbText.Text = ai.RelationsTextBlock; ; break;
                case 4:
                    rtbText.Clear();
                    foreach (string line in ai.RelationsTextBlock.Split('\n'))
                    {
                        rtbText.Text += ai.ConvertToNormalLine(line) + "\n";
                    }
                    break;
            }
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbText.SelectionStart = 0;
            rtbText.SelectionLength = rtbText.TextLength; //End of first word
            Font currentFont = rtbText.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style);
            rtbText.SelectionFont = new Font(currentFont.FontFamily, float.Parse(cbFontSize.Text), newFontStyle);
        }
    }
}
