using SOLID.ISP.Interfaces;
using System;

namespace SOLID.ISP.Entities
{
    class LiquidInkPrinter : IPrinterTasks
    {
        public void Print(string content)
        {
            Console.WriteLine("Print done in LiquidInk");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan done in LiquidInk");
        }
    }
}
