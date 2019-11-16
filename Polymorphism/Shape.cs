using System;

namespace IntermediateCSharp
{
    public abstract class Shape16
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw ();
        public void Copy()
        {
            Console.WriteLine("copy into clip");
        }
        public void Select()
        {
            Console.WriteLine("select");
        }
    }
}