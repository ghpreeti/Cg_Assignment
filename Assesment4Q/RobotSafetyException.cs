using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotHazardAnalyzer
{
    public class RobotSafetyException : Exception
    {
        public RobotSafetyException() : base()
        {
            
        }
        public RobotSafetyException(string message) : base(message) { }
       
        
    }
}
