using System;

namespace IntermediateCSharp
{    
    public class Car13: Vehicle13
    {
        public Car13(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("car initializing {0}", registrationNumber);
        }
    }
}