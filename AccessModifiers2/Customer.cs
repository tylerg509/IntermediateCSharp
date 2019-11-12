
using System;

namespace IntermediateCSharp
{
    public class Customer12
    {
        public int Id {get;set;}
        public string Name {get;set;}

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if(rating == 0)
                Console.WriteLine("promoted lev 1");
            
            else 
                Console.WriteLine("promted lev 2");
        }

        private int CalculateRating(bool excludeOrders){
            return 0;
        }
    }
}