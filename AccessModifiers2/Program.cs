using System;


namespace IntermediateCSharp
{
    public class GoldCustomer : Customer12
    {
        public void OfferVoucher()
        {
            Console.WriteLine(this.Name);
        }
    }
    class Program12
    {
        static void Main12(string[] args)
        {
            var customer = new Customer12();
        }
    }
}