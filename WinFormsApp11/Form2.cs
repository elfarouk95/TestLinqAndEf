
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form2 : Form
    {
       public Student student;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            textBox2.Text = student.Name;

            Repo repo = new Repo();

            repo.Database.EnsureCreated();

            var alllist = from c in repo.students.ToList()
                          let t = new
                          {
                              Name = c.Name,
                              ID = c.Id,
                              address = c.address,
                              age = c.age,
                              gpa = c.gpa,
                              phone = c.Phone
                          }
                          select t;

            dataGridView1.DataSource = alllist.ToList();

            var list = from c in repo.students.ToList()
                       let t = c.Name
                       select t;

            var MutList = list.ToList();

            MutList.Add("All");


            listBox1.DataSource = list.ToList();

            comboBox1.DataSource = MutList;
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            Repo repo = new Repo();

            repo.Database.EnsureCreated();

            var alllist = from c in repo.students.ToList()
                          let t = new
                          {
                              Name = c.Name,
                              ID = c.Id,
                              address = c.address,
                              age = c.age,
                              gpa = c.gpa,
                              phone = c.Phone
                          }
                          where t.Name.Contains(textBox1.Text)
                          select t;

            dataGridView1.DataSource = alllist.ToList();

            var list = from c in repo.students.ToList()
                       let t = c.Name
                       where t.Contains(textBox1.Text)
                       select t;

            listBox1.DataSource = list.ToList();

           // comboBox1.DataSource = list.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

           string s = comboBox1.Text;
            if (s != "All")
            {
                textBox1.Text = s;
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
