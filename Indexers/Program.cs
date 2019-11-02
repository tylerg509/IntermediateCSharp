using System;

namespace IntermediateCSharp
{

    public class Program9
    {
        static void Main9(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Tyler";
            Console.WriteLine(cookie["name"]);

        }
    }
}