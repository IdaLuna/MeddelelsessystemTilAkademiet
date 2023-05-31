using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddelelsessystemTilAkademiet
{
    public abstract class Subject
    {
        private List<Student> students { get; set; } = new List<Student>();

        public void Attach(Student s)
        {
            if (!students.Contains(s))
            {
                students.Add(s);
            }
        }

        public void Detach(Student s)
        {
            students.Remove(s);
        }

        public void Notify()
        {
            foreach (Student s in students)
            {
                s.Update();
            }
        }
    }
}
