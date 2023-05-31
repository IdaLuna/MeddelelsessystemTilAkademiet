using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MeddelelsessystemTilAkademiet
{
    public class Student : Observer
    {
        private Academy _subject;
        public string Name { get; }
        public string Message { get; set; }

        public Student(Academy subject, string name) 
        { 
            _subject = subject;
            Name = name;
            _subject.Attach(this); // attach the student as the observer?
        }

        public override void Update() 
        {
            Message = _subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden {Message} fra akademiet {_subject.Name}");
        }

        //public void Notify()
        //{
        //    foreach (Observer o in observers)
        //    {
        //        o.Update();
        //    }
        //}
    }
}
