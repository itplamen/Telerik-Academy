//02.Refactor the following examples to produce code with well-named identifiers in C#:

namespace _02.RefactorSecondExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            PersonFactory personFactory = new PersonFactory();
            personFactory.CreatePerson(23);
        }
    }
}
