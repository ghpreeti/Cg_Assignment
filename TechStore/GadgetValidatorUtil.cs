using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TechStore
{
    public class GadgetValidatorUtil
    {
        public bool validateGadgetID(String gadgetID)
        {
            string pattern = @"^[A-Z]\d{3}$";

            if(!Regex.IsMatch(gadgetID, pattern))
            {
                throw new InvalidGadgetException("Invalid gadget ID");
            }
            else
            {
                return true;
            }
        }

        public bool validateWarrantyPeriod(int period)
        {
            if (period < 6 || period > 36)
            {
                throw new InvalidGadgetException("Invalid Warranty Period");
            }
            else
            {
                return true;
            }
        }

        public void validateGadgetType(String gadgetType)
        {
            if (string.IsNullOrWhiteSpace(gadgetType))
            {
                throw new InvalidGadgetException("Invalid Gadget Type");
            }
        }
    }
}
