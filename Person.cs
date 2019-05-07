using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }

        public Person(string n, string a)
        {
            name = n;
            address = a;
        }

        public virtual string Persons()
        {
            return "Education!";
        }

        public override string ToString()
        {
            return $"This person's name is {name} \nThis person's address is {address}";
        }
    }
}
