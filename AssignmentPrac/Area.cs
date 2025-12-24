using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class Area
    {
        
        public static double CalArea(double radius) { 
            double area = Math.PI * radius * radius;
            return Math.Floor(area*100)/100; 
        }
    }
}
