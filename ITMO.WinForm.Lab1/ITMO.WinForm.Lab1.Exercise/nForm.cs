using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinForm.Lab1.Exercise
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public new void Close()
        {
            nclose = true;
            base.Close();
        }
        public nForm()
        {
            InitializeComponent();
        }


        private void nForm_Load(object sender, EventArgs e)
        {

        }

        private void nForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (nclose == true) return;
            e.Cancel = true;
            Hide();
        }

        private void checkBoxClosed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClosed.Checked)
            {
                nclose = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
