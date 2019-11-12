using System;

namespace IntermediateCSharp
{
    public class Vehicle13
    {
        private readonly string _registrationNumber;


        public Vehicle13(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle initializing. {0}", registrationNumber);

        }
    }
}