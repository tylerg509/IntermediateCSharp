using System.ComponentModel;
using System;
namespace IntermediateCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1992,9,1));
            Console.WriteLine(person.Age);

        }
    }
}