using System;

namespace IntermediateCSharp
{


    class Program
    {
        static void Main(string[] args)
        {
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else    
                Console.WriteLine("Converion Fail");

        }

        static void UserParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1,2,3,4));
            Console.WriteLine(calculator.Add(new int[]{5,15,631,5}));

        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10,20);
                point.Move(new Point(40,60));
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
                point.Move(100,200);
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch(Exception)
            {
                Console.WriteLine("Unexpected error occured");
            }
        }
    }

}
