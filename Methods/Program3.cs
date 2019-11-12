using System;

namespace IntermediateCSharp
{

    class Program3
    {
        static void Main3(string[] args)
        {
            var customer = new Customer9();
            customer.Id = 1;
            customer.Name = "John";
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine("id: " + customer.Id);
            Console.WriteLine("name: " + customer.Name);
            
        }
    }
}
