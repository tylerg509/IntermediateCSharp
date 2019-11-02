using System;

namespace IntermediateCSharp
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
        public void AddHyperLink(string url)
        {
            Console.WriteLine("added link to " + url);
        }
    }
}