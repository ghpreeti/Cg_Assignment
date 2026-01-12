using System;
using System.Collections.Generic;
using System.Text;

namespace BankingNUnitTest
{
    internal class UnitTest
    {
        Program pObj = new Program();

        public void Test_Deposit_ValidAmount()
        {
            pObj.Deposit(pObj.CurrentBalance);
        }

    }
}
