using System;
namespace Polymorphism
{
    public class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension: 10x11 ");
        }
        public void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}