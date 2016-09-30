using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FieldWithNullValue
{
    public class Person
    {
        /* FIELDS */
        private string name;
        private Nullable<int> age; // similar to private int? age;

        /* PROPERTIES */
        public string Name 
        {
            get {return this.name ;}
            set
            {
                if (this.name == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Nullable<int> Age 
        {
            get { return this.age; }
            set
            {
                if (age <= 0 || age >= 120)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or bigger than 120!");
                }
            }
        }

        /* CONSTRUCTOR */
        public Person(string name, Nullable<int> age)
        {
            this.name = name;
            this.age = age;
        }


        /* METHODS */

        // Override ToString() method
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Name: " + this.name);

            if (this.age == null)
            {
                stringBuilder.Append("Age: null");
            }
            else
            {
                stringBuilder.Append("Age: " + this.age);
            }

            return stringBuilder.ToString();
        }
    }
}
