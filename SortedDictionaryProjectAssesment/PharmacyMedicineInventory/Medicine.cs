using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyMedicineInventory
{
    public class Medicine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ExpiryYear { get; set; }
    }
}
