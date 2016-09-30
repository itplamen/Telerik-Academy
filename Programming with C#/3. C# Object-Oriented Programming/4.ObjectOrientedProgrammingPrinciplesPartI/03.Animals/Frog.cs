using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Frog : Animal
    {
        // Fields
        private string frogBreed;

        // Constructor
        public Frog(string name, int age, string sex, string frogBreed)
            : base(name, age, sex)
        {
            this.frogBreed = frogBreed;
        }

        // Properties
        public string FrogBreed 
        {
            get { return this.frogBreed; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Frog breed cannot be null!");
                }
                else
                {
                    this.frogBreed = value;
                }
            }
        }

        // Methods
        // Produce sound
        public override void Sound()
        {
            Console.WriteLine("Frog {0} say: ribbitttt", this.Name);
        }
    }
}
