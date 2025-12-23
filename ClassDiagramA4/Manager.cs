using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramA4
{
    public class Manager : Employees
    {
        public int MonthlySal { get; set; }
        public int Pention { get; set; }
        public override void CalculataSal()
        {
            Console.WriteLine($"totalSal:{MonthlySal }");
        }

    }
}
