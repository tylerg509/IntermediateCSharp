using System;

namespace IntermediateCSharp
{
    public class Person1
    {
    
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person1 Parse(string str){
            var person = new Person1();
            person.Name = str;
            return person;
        }
    }
    class Program2
    {
        static void Main2(string[] args)
        {
            var person = Person1.Parse("John");
            person.Introduce("Tyler");
        }
    }
}
