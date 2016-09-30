using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Tomcat : Cat
    {
        // Constructor
        public Tomcat(string name, int age, string sex, string breed)
            : base(name, age, "male", breed)
        {

        }

        // Methods
        // Produce sound
        public override void Sound()
        {
            Console.WriteLine("Tomcat {0} say: miaowwww", this.Name);
        }
    }
}
