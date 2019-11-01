using System;

namespace IntermediateCSharp
{

    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Tyler";
            Console.WriteLine(cookie["name"]);

        }
    }
}