﻿//4. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() 
//to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FieldWithNullValue
{
    class Test
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Plamen", 23);
            Person secondPerson = new Person("Pesho", null);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
