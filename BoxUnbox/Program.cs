using System;
using System.Collections;
namespace IntermediateCSharp
{
    public class Program15
    {
        static void Main15(string[] args){
            var list = new ArrayList();
            list.Add(1);
            list.Add("T");
            list.Add(DateTime.Today);
            var number = (int)list[1];


        }
    }
}