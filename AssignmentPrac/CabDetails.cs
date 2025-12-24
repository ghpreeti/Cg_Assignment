using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentPrac
{
    public class CabDetails : Cab
    {
        public bool ValidateBookingID()
        {
            if (Regex.IsMatch(BookingID, @"^AC@\d{3}$"))
            {
                return true;
            }
            return false;
        }


        //Fare = Distance * Price per km + Waiting Charge
        //Waiting Charge = Square root of Waiting Time
        public double CalculateFareAmount()
        {
            double price = PricePerKm();
            double waitingCharge = Math.Sqrt(WaitingTime);
            double fare = Distance * price + waitingCharge;
            return Math.Floor(fare*100)/100;
        }

        public int PricePerKm()
        {
            if (CabType.Equals("hatchback")) return 10;
            else if (CabType.Equals("sedan")) return 20;
            else if (CabType.Equals("suv")) return 30;
            else return 0;
        }
    }
}
