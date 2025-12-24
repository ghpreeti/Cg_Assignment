using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class FeetToCm
    {
        public static double ConvertFeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return Math.Floor(cm * 100) / 100;
        }
    }
}
