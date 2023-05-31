using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeddelelsessystemTilAkademiet
{
    public class Academy : Subject
    {
        public string Name {get;}

        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                Notify(); // Notify observers when the message changes
            }
        }

        public Academy(string name)
        {
            Name = name;
        }

        //private List<Student> students { get; set; } = new List<Student>();

        //public void Attach(Student s)
        //{
        //    students.Add(s);
        //}

        //public void Detach(Student s)
        //{
        //    students.Remove(s);
        //}

    }
}
