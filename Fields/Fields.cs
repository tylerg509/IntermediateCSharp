using System;
using System.Collections.Generic;

namespace IntermediateCSharp
{

    class Program6
    {
        //use tryparse
        static void Main6(string[] args)
        {
            var customer = new Customer2(1);
            customer.Orders.Add(new Order2());
            customer.Orders.Add(new Order2());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);

        }

        //shows how you can use a method 

    }

}
