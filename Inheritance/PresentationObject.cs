using System;

namespace IntermediateCSharp
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Heights { get; set; }

        public void Copy()
        {
            Console.WriteLine("Obj copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Obj was duplicated");
        }
    }
}