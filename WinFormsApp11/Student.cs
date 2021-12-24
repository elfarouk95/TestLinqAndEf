

using System.Collections.Generic;

namespace WinFormsApp11
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public string address { get; set; }
        public int age { get; set; }
        public float gpa { get; set; }

        public virtual IEnumerable<Plaing> pl { get; set; }
    }
}
