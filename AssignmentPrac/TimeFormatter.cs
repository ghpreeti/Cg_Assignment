using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentPrac
{
    public class TimeFormatter
    {
        public static string FormatSeconds(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return minutes + ":" + seconds.ToString("D2");
        }
    }
}