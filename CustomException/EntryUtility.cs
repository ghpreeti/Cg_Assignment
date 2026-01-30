using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomException
{
    public class EntryUtility
    {
        public void ValidateEmployeeId(string empId)
        {
            string pattern = @"^GOAIR/\d{4}$";

            if (!Regex.IsMatch(empId, pattern))
            {
                throw new InvalidEntryException(
                    "Employee ID must be in format GOAIR/1234"
                );
            }
        }

        public void ValidateDuration(int duration)
        {
            if(duration<1 || duration > 5)
            {
                
                    throw new InvalidEntryException("Invalid Duration");
               
            }
           
        }

        public void ValidateDepartment(string dept)
        {
            if (string.IsNullOrWhiteSpace(dept))
            {
                throw new InvalidEntryException("Invalid Department");
            }
        }


    }
}
