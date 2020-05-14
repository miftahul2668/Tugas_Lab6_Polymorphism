using System;
namespace Polymorphism
{
    public class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension: 12x12");
        }
        public void Print()
        {
            Console.WriteLine("LaserJet printer printing...");
        }
    }
}