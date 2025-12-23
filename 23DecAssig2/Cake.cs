using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace _23DecAssig2
{
    public class Cake
    {
        public int QuantityInKg { get; set; }
        public string Flavor { get; set; }
        public double PricePerKg { get; set; }

        /// <summary>
        /// Formula :
        ///   Total Price = Quantity In Kg * Price Per Kg
        ///   Discounted Price = Total Price - (Total Price * Discount /100)
        ///   Flavour Discount :Vanilla-3 Chocolate-5  Red Velvet-10
        ///   Note :  Flavour is case sensitive.
        /// </summary>

        private int Discount()
        {
            if (Flavor.Equals("vanilla")) return 3;
            if (Flavor.Equals("chocolate")) return 5;
            if (Flavor.Equals("red velvet")) return 6;
            return 0;

        }
        public bool CakeOrder()
        {

            if (!(Flavor.Equals("vanilla") || Flavor.Equals("chocolate") || Flavor.Equals("red velvet")))
            {
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
            }
            
            if (QuantityInKg<=0)
            {
                throw new Exception("Quantity cannot be negative");
            }

            return true;

        }

        public double CalculatePrice()
        {
            double discount = Discount();
            double total = QuantityInKg * PricePerKg;
            return total-(total * discount / 100);

        }
    }
}
