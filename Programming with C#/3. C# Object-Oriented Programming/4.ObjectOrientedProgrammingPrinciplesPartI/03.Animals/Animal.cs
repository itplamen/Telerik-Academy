using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        // Fields
        private string name;
        private int age;
        private string sex;

        // Constructor
        public Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        // Properties
        public string Name 
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Animal name cannot be null!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Animal age cannot be negative or zero!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public string Sex 
        {
            get { return this.sex; }
            set
            {
                if (value == null || (value != "male" && value != "female"))
                {
                    throw new ArgumentNullException("Animal sex cannot be null or different from male or female!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        // Methods

        // Produce sound
        public abstract void Sound();

        // Calculate average age of each kind of animal
        public static double CalculateAverageAge(Animal [] animal)
        {
            double sum = 0;

            foreach (var element in animal)
            {
                sum += element.Age;
            }

            double result = sum / animal.Length;

            return result;
        }
    }
}
