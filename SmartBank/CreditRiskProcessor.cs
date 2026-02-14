using System;
using System.Collections.Generic;
using System.Text;

namespace SmartBank
{
    public class CreditRiskProcessor
    {
        public bool validateCustomerDetails(int age, String employmentType, double monthlyIncome, double dues, int creditScore, int defaults)
        {
            if (age < 21 && age > 65)
            {
                throw new InvalidCreditDataException("Invalid Age");
            }
            if (employmentType != "Salaried" && employmentType != "Self-Employed")
            {
                throw new InvalidCreditDataException("Invalid employment type");
            }
            if (monthlyIncome < 20000)
            {
                throw new InvalidCreditDataException("Invalid Monthly Income");
            }
            if (dues < 0)
            {
                throw new InvalidCreditDataException("Invalid credit dues");
            }
            if (creditScore < 300 && creditScore > 900)
            {
                throw new InvalidCreditDataException("Invalid Credit Score");
            }
            if (defaults < 0)
            {
                throw new InvalidCreditDataException("Invalid Default dues");
            }

            return true;
        }

        public double calculateCreditLimit(double monthlyIncome, double dues, int creditScore, int defaults)
        {
            double debtRatio = dues / (monthlyIncome * 12);
            double creditLimit = 0;

            if (creditScore < 600 || defaults >= 3 || debtRatio > 0.4)
            {
                creditLimit = 50000;
            }
            else if ((creditScore >= 600 && creditScore < 749) || (defaults == 1 || defaults == 2))
            {
                creditLimit = 150000;
            }
            else if (creditScore >= 750 && defaults == 0 && debtRatio < 0.25)
            {
                creditLimit = 300000;
            }

            return creditLimit;

        }
    }
}
