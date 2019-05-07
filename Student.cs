using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            set
            {
                program = value;
            }
            get
            {
                return program;
            }
        }
        public int Year
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }

        public double Fee
        {
            set
            {
                fee = value;
            }
            get
            {
                return fee;
            }
        }

        public Student(string p, int y, double f, string n, string a) :base(n, a)
        {
            program = p;
            year = y;
            fee = f;
            
        }

        public virtual string Persons()
        {
            return "Education!";
        }


        public override string ToString()
        {
            return base.ToString()+ program + year + fee;
        }

    }
}
