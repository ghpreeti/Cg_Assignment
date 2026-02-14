using System;
using System.Collections.Generic;
using System.Text;

namespace SmartBank
{
    public class InvalidCreditDataException:Exception
    {
        public InvalidCreditDataException(string message) : base(message)
        {
        }
    }
}
