using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Dog : Animal
    {
        // Fields
        private string dogBreed;

        // Constructor
        public Dog(string name, int age, string sex, string dogBreed)
            : base(name, age, sex)
        {
            this.dogBreed = dogBreed;
        }

        // Properties
        public string DogBreed 
        {
            get { return this.dogBreed; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Dog breed cannot be null!");
                }
                else
                {
                    this.dogBreed = value;
                }
            }
        }

        //Methods
        // Produce sound
        public override void Sound()
        {
            Console.WriteLine("Dog {0} say: bow-wowwww", this.Name);
        }
    }
}
