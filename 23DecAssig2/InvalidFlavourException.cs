using System;
using System.Collections.Generic;
using System.Text;

namespace _23DecAssig2
{
    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message)
        {
        }
    }
}
