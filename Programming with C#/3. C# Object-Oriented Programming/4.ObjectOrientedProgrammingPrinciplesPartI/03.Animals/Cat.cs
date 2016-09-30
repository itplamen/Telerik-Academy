using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Cat : Animal
    {
        // Fields
        private string catBreed;

        // Constructor
        public Cat(string name, int age, string sex, string catBreed)
            : base(name, age, sex)
        {
            this.catBreed = catBreed;
        }

        // Properties
        public string CatBreed 
        {
            get { return this.catBreed; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cat breed cannot be null!");
                }
                else
                {
                    this.catBreed = value;
                }
            }
        }

        //Methods
        // Produce sound
        public override void Sound()
        {
            Console.WriteLine("Cat {0} say: miaowwww", this.Name);
        }
    }
}
