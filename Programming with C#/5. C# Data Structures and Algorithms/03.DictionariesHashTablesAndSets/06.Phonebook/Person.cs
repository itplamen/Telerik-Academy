namespace _06.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        private string name;
        private string city;
        private string telephone;

        public Person(string name, string city, string telephone)
        {
            this.Name = name;
            this.City = city;
            this.Telephone = telephone;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                this.name = value;
            } 
        }

        public string City 
        {
            get
            {
                return this.city;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("City cannot be null or empty!");
                }

                this.city = value;
            }
        }

        public string Telephone
        {
            get
            {
                return this.telephone;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Telephone cannot be null or empty!");
                }

                this.telephone = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nCity: " + this.City + "\nTelephone: " + this.Telephone + "\n";
        }
    }
}
