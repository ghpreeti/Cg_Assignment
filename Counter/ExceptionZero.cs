using System;
using System.Collections.Generic;
using System.Text;

namespace CounterTask
{
    public class ExceptionZero : Exception
    {
        public ExceptionZero() : base() { }
        public ExceptionZero(string message) : base(message) { }
    }
}
