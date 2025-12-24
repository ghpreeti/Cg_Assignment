using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class Customer
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public string  CustAddress { get; set; }
        public string CustStatus { get; set; }
        public string CustMobileNo { get; set; }

        public Customer() { }
        public Customer(int custID, string custName, string custAddress, string custStatus, string custMobileNo)
        {
            CustID = custID;
            CustName = custName;
            CustAddress = custAddress;
            CustStatus = custStatus;
            CustMobileNo = custMobileNo;
        }
    }
}
