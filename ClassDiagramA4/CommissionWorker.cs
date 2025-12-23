using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramA4
{
    public class CommissionWorker : Employees
    {
        public int FlatSal { get; set; }
        public double SalesPerc { get; set; }
        public double SalesPerMonth { get; set; }

        public override void CalculataSal()
        {
            Console.WriteLine($"totalSal:{FlatSal + SalesPerc/100 * SalesPerMonth}");
        }


    }
}
