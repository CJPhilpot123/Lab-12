using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            set
            {
                school = value;
            }
            get
            {
                return school;
            }
        }
        public double Pay
        {
            set
            {
                pay = value;
            }
            get
            {
                return pay;
            }
        }

        public Staff(string s, double p, string n, string a) : base(n, a)
        {
            s = school;
            p = pay;
        }

        public virtual string Persons()
        {
            return "Education!";
        }

        public override string ToString()
        {
            return base.ToString() + school + pay;
        }

    }
}
