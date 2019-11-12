using System;
using System.Collections.Generic;


namespace IntermediateCSharp
{
    public class Customer9{
        public int Id;
        public string Name;
        public List<Order> Orders;
        
        //overloading == can use multiple same constructors
        //rule of thumb do not initialize objects using Customer customer = new Customer();
        //rather use constructors to initalize each time the class is needed
        public Customer9()
        {
            Orders = new List<Order>();
        }

        public Customer9(int id)
            :this() //call constructor without params
        {
            this.Id = id;
        }

        public Customer9(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
    }

}
