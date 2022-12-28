using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Control
{
    
public partial class validation : UserControl
    {
    
        
        public string name;
        public string familiar;
        public string pAge;
        public string sex;
        public bool valid = false;
        
        public void Refres()
        {
            firstName.Text = name = string.Empty;
            lastName.Text = familiar = string.Empty;
            age.Text = pAge = string.Empty;
            sex = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            valid = false;
            errorProvider1.Clear();
        }

        public void SetPerson()
        {
            valid = false;

            if (firstName.Text.Length > 0 && lastName.Text.Length > 0 && age.Text.Length > 0)
            {
                string text = string.Empty;

                if (radioButton2.Checked)
                {
                    text = "мужчина";
                }
                if (radioButton1.Checked)
                {
                    text = "женщина";
                }

                if (text != string.Empty)
                {
                    name = firstName.Text;
                    familiar = lastName.Text;
                    sex = text;
                    text = string.Empty;
                    pAge = age.Text;
                    valid = true;

                }
                else { MessageBox.Show("Укажите пол"); }
            }
            else
            {
                MessageBox.Show("Проверьте, что все данные указаны!");
                if (firstName.Text.Length == 0)
                    errorProvider1.SetError(firstName, "This field is empty!");
                if ( lastName.Text.Length == 0)
                    errorProvider1.SetError(lastName, "This field is empty!");
                if (age.Text.Length == 0)
                    errorProvider1.SetError(age, "This field is empty!");
            }

        }

        public validation()
        {
            InitializeComponent();
        }
        
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
           
        private void firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Имя не может содержать цифры");
                errorProvider1.SetError(firstName, "Must be letter");
            }
        }

        private void lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Фамилия не может содержать цифры");
                errorProvider1.SetError(lastName, "Must be letter");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Возраст может содержать только цифры");
                errorProvider1.SetError(age, "Must be digit");
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refres();
        }
        
    }
}
