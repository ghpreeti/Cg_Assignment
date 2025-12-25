using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class HeightCategory
    {
        public static string GetCategory(int heightCm)
        {
            if (heightCm < 150) return "Short";
            if (heightCm < 180) return "Average";
            return "Tall";
        }
    }
}
