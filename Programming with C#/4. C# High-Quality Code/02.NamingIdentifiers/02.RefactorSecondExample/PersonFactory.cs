namespace _02.RefactorSecondExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonFactory
    {
        public enum Gender 
        { 
            male, female
        };

        public void CreatePerson(int age)
        {
            Person person = new Person();
            person.Age = age;

            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.female;
            }

            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Gender: " + person.Gender);
        }

        public class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
