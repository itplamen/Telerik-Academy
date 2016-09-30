using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Kitten : Cat
    {
        // Constructor
        public Kitten(string name, int age, string sex, string gender)
            : base(name, age, "female", gender)
        {

        }

        // Methods
        // Produce sound
        public override void Sound()
        {
            Console.WriteLine("Kitten {0} say: miaowwww", this.Name);
        }
    }
}
