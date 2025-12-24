using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class Bank
    {
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string BankContactNo { get; set; }
        public int[] Customers { get; set; }

        public Bank() { }
        public Bank(string bankName, string bankAddress, string bankContactNo, int[] customers)
        {
            BankName = bankName;
            BankAddress = bankAddress;
            BankContactNo = bankContactNo;
            Customers = customers;
        }


    }
}
