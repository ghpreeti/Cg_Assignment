using System;
using System.Collections.Generic;
using System.Text;

namespace _23DecAssig3
{
    /// <summary>
    /// 
    /// </summary>
    public class Candy
    {
        public string Flavour { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }

        public bool ValidateCandyFlavour()
        {
            if (!(Flavour.Equals("strawberry") || Flavour.Equals("lemon ") || Flavour.Equals("mint")))
            {
                throw new Exception("Invalid Candy Flavour");
            }
            return true;
        }

        public int DiscountPercentage()
        {
            if (Flavour.Equals("strawberry")) return 15;
            if(Flavour.Equals("lemon")) return 10;
            if(Flavour.Equals("mint")) return 5;
            return 0;
        }



    }
}
