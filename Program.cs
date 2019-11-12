using System;


namespace IntermediateCSharp
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            Console.WriteLine(this.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}