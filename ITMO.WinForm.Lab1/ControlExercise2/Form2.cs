using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExercise2
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
            f1= new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                f1.Show();
                f1.Activate();
            }
            catch(ObjectDisposedException)
            {
                Form1 f1 = new Form1();
                f1.Show();
                f1.Activate();
            }
        }
    }
}
