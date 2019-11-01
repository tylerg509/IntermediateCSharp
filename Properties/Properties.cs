using System.ComponentModel;
using System;
namespace IntermediateCSharp
{
    class Program8
    {
        static void Main8(string[] args)
        {
            var person = new Person(new DateTime(1992,9,1));
            Console.WriteLine(person.Age);

        }
    }
}