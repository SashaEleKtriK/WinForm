﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Text;

namespace EditPerson
{
    public partial class Form1 : Form
    {
        public static ArrayList pers = new ArrayList();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditPersonForm editForm = new EditPersonForm();
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedItems.Count == 0)
                return;

            ListViewItem item = personsListView.SelectedItems[0];

            EditPersonForm editForm = new EditPersonForm();

            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            
            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
              sb.Append("Сотрудник: \n" + item.ToString());
             }
            richTextBox1.Text = sb.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Person> list = new List<Person>();
            foreach(Person person in pers)
            {
                list.Add(person);
            }
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream fStream = new FileStream("AllMyPerson.dat",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, list);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (FileStream fStream = new FileStream("AllMyPerson.dat",
                FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    List<Person> load = ((List<Person>)binFormat.Deserialize(fStream));
                    foreach (Person person in load)
                    {
                        pers.Add(person);
                        ListViewItem newItem = personsListView.Items.Add(person.FirstName);
                        newItem.SubItems.Add(person.LastName);
                        newItem.SubItems.Add(person.Age.ToString());
                    }
                    
                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
    }

