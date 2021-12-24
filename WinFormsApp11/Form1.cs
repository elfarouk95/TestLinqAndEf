
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click_1(object sender, System.EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;


            Repo repo = new Repo();
            repo.Database.EnsureCreated();

            var list = repo.students.ToList();

            Student s = (from c in list
                         where c.Name == name && c.Password == pass
                         select c).FirstOrDefault();

            if (s != null)
            {
                Form2 f = new Form2();
                f.student = s;
                f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password");
            }

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Name == name && list[i].Password == pass)
            //    {
            //        Form2 f = new Form2();
            //        f.Show();
            //        Hide();
            //    }
            //}

        }
    }
}
