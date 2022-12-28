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
    public partial class Form1 : Form
    {
        nForm myF2;
        public Form1()
        {
            InitializeComponent();
            myF2 = new nForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void btn_border_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btn_nForm_Click(object sender, EventArgs e)
        {

            try
            {
                myF2.Show();
                myF2.Activate();
            }
            catch (ObjectDisposedException ex)
            {
                myF2 = new nForm
                {
                    Text = "Повторное создание формы"
                };
                myF2.Show();
                myF2.Activate();
            }
        }
    }
}
