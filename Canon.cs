using System;
namespace Polymorphism
{
    public class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5x12 ");
        }
        public void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}