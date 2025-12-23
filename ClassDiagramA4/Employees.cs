using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramA4
{
    //POCO class
    public class Employees
    {
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int Earning { get; set; }
        public int EmpNo { get; set; }

        public MedicalAid MedicalAid { get; set; }
        public virtual void CalculataSal() { }

    }
}
