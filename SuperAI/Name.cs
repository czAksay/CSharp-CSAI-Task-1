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
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        public String GetName { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string txt = tbName.Text;
            while(txt.Length > 0 && txt[0] == ' ')
            {
                txt = txt.Remove(0, 1);
            }
            while (txt.Length > 0 && txt[txt.Length - 1] == ' ')
            {
                txt = txt.Remove(txt.Length - 1, 1);
            }
            if (txt == "")
            {
                MessageBox.Show("Имя не должно состоять из пробелов или пустой строки.");
                return;
            }
            DialogResult = DialogResult.OK;
            GetName = txt;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
