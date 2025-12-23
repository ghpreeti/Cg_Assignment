using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramA4
{
    public class HourlyWorker : Employees
    {
        public int HourWorked { get; set; }
        public int WagePerHour { get; set; }

        public override void CalculataSal()
        {
            Console.WriteLine($"totalSal:{HourWorked*WagePerHour}");
        }
    }
}
