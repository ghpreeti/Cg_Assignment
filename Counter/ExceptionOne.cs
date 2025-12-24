using System;
using System.Collections.Generic;
using System.Text;

namespace CounterTask
{
    public class ExceptionOne : Exception
    {
        public ExceptionOne() : base() { }

        public ExceptionOne(string message) : base(message) { }
    }
}
