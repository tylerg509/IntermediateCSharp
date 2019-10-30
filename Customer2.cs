
using System.Collections.Generic;


namespace IntermediateCSharp
{
    public class Customer2
    {
        public int Id;
        public string Name;
        public readonly List<Order2> Orders = new List<Order2>(); //could also create another constructor for this

        public Customer2(int id)
        {
            this.Id = id;
        }
        public Customer2(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            
        }
    }
}