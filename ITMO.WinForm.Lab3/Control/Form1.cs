using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void validation1_Load(object sender, EventArgs e)
        {

        }

        private void validation1_BackColorChanged(object sender, EventArgs e)
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validation1.SetPerson();
            if (validation1.valid)
            {
                checkedListBox1.Items.Add(validation1.name + " " + validation1.familiar + ", " + validation1.sex + ". Возраст: " + validation1.pAge);
                if (checkBox1.Checked)
                {
                    validation1.Refres();
                }
            }
            

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count>0)
            {
                List<string> deleted = new List<string>();
                while (checkedListBox1.CheckedIndices.Count > 0)
                {
                    checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
                }
                   
                
                


            }
        }

        
    }
}
