using SOLID.ISP.Interfaces;
using System;

namespace SOLID.ISP.Entities
{
    class HPLaserPrinter : IPrinterTasks, IFaxTasks
    {
        public void Fax(string content)
        {
            Console.WriteLine("Fax done in HPLaser");
        }

        public void Print(string content)
        {
            Console.WriteLine("Print done in HPLaser");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan done in HPLaser");
        }
    }
}
