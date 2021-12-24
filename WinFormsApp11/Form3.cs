using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Name = textBox1.Text;
            student.Password = textBox2.Text;
            student.Phone = textBox3.Text;
            student.address = textBox4.Text;
            student.age = int.Parse(textBox5.Text);
            student.gpa = float.Parse(textBox6.Text);

            Repo repo = new Repo();

            repo.Database.EnsureCreated();

            repo.students.Add(student);

            repo.SaveChanges();

            MessageBox.Show("Done");

        }
    }
}
