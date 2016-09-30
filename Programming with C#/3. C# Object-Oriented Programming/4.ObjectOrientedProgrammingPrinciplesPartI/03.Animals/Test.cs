//03.Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female 
//and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds 
//of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Test
    {
        static void Main(string[] args)
        {
            // Array of dogs
            Dog[] dogs = new Dog[] 
            {
                new Dog("Sharo", 3, "male", "Labrador"),
                new Dog("Cujo", 2, "male", "Saint Bernard"),
                new Dog("Rex", 6, "female", "German Shepherd"),
                new Dog("Lassie", 4, "female", "Collie")
            };

            // Array of cats
            Cat[] cats = new Cat[]
            {
                new Cat("Tom", 2, "male", "Balinese"),
                new Cat("Sarah", 5, "female", "Bombay"),
                new Cat("Iva", 1, "female", "Cymric"),
                new Cat("Gosho", 9, "male", "Javanese")
            };

            Tomcat tom = new Tomcat("Kiro", 9, "male", "Bombay");
            Kitten kitten = new Kitten("Sisi", 1, "female", "Cymric");

            // Array of frogs
            Frog[] frogs = new Frog[]
            {
                new Frog("Pesho", 2, "male", "Black Toad"),
                new Frog("Maria", 1, "female", "Arizona Toad"),
                new Frog("Misho", 3, "male", "Texas Toad"),
                new Frog("Petia", 8, "male", "Arroyo Toad")
            };

            // Call methods about dogs
            Console.WriteLine("Average age of dogs are: " + Dog.CalculateAverageAge(dogs));
            dogs[2].Sound();
            dogs[1].Sound();
            dogs[3].Sound();
            dogs[0].Sound();
            
            Console.WriteLine();

            // Call methods about cats
            Console.WriteLine("Average age of cats are " + Cat.CalculateAverageAge(cats));
            cats[0].Sound();
            cats[3].Sound();
            tom.Sound();
            kitten.Sound();

            Console.WriteLine();

            // Call methods about frogs
            Console.WriteLine("Average age of frogs are: " + Frog.CalculateAverageAge(frogs));
            frogs[3].Sound();
            frogs[0].Sound();
            frogs[1].Sound();
            frogs[2].Sound();

            Console.WriteLine();
        }
    }
}
