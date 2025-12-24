using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class Agency
    {
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string AgencyContactNumber { get; set; }

        public Agency() { }
        public Agency(string agencyName, string agencyAddress, string agencyContactNumber)
        {
            AgencyName = agencyName;
            AgencyAddress = agencyAddress;
            AgencyContactNumber = agencyContactNumber;
        }

        public string VerifyCustomer(Customer customer)
        {
            // Simple verification logic
            if (customer.CustStatus == "Active")
            {
                return $"Customer {customer.CustName} is Green.";
            }
            else
            {
                return $"Customer {customer.CustName} is not Red.";
            }
        }
        
    }
}
