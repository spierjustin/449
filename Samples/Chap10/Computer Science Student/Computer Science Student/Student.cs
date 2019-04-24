using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Computer_Science_Student
{
    abstract class Student
    {
        //Fields
        private string _name;
        private string _id;

        //constructor 
        public Student(string name, string id)
        {
            _name = name;
            _id = id;

        }
        //name pr9operty
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        //Id property
        public string ID
        {
            get { return _id; }
            set { _id = value; }

        }

        //RequiredHours property (abstract)
        public abstract double RequiredHours
        {
            get;
        }
    }
}
