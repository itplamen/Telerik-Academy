//Open project located in 4. Code Documentation and Comments Homework.zip and:
//-Add comments where necessary
//-For each public member add documentation as C# XML Documentation Comments
// * Play with Sandcastle / other tools and try to generate CHM book

namespace AddCodeDocumentation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Test
    {
        public static void Main(string[] args)
        {
            string toHash = "Hello World!";
            Console.WriteLine(StringExtensions.ToMd5Hash(toHash));

            string isTrue = "да";
            Console.WriteLine(StringExtensions.ToBoolean(isTrue));

            string shortNumber = "12321";
            Console.WriteLine(StringExtensions.ToShort(shortNumber));

            string integerNumber = "999101001";
            Console.WriteLine(StringExtensions.ToInteger(integerNumber));

            string longNumber = "8882381231312312";
            Console.WriteLine(StringExtensions.ToLong(longNumber));

            string date = "2014 8 17";
            Console.WriteLine(StringExtensions.ToDateTime(date));

            string testString = "code documentation and comments in the program";
            Console.WriteLine(StringExtensions.CapitalizeFirstLetter(testString));
            Console.WriteLine(StringExtensions.GetStringBetween(testString, "and", "the"));

            string cyrillicLetters = "документиране на кода";
            Console.WriteLine(StringExtensions.ConvertCyrillicToLatinLetters(cyrillicLetters));

            string latinLetters = "dokumentirane na koda";
            Console.WriteLine(StringExtensions.ConvertLatinToCyrillicKeyboard(latinLetters));

            string userName = "it_plamen@@[}{]";
            Console.WriteLine(StringExtensions.ToValidUsername(userName));

            string fileName = "==StringExtensions.cs";
            Console.WriteLine(StringExtensions.ToValidLatinFileName(fileName));

            Console.WriteLine(StringExtensions.GetFirstCharacters(testString, 11));

            Console.WriteLine(StringExtensions.GetFileExtension(fileName));

            string fileExtension = "jpg";
            Console.WriteLine(StringExtensions.ToContentType(fileExtension));

            var input = "Telerik".ToByteArray();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
