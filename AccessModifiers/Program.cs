using System;

namespace IntermediateCSharp
{
    public class Person7
    {
        private DateTime _birthdate;
        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate(){
            return _birthdate;
        }
    }
    class Program7
    {
        static void Main7(string[] args)
        {
            var person = new Person7();
            person.SetBirthDate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());

        }
        
    }
}