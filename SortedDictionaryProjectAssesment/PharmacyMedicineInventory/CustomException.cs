using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyMedicineInventory
{
    // Invalid price exception
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }

    // Duplicate medicine exception
    public class DuplicateMedicineException : Exception
    {
        public DuplicateMedicineException(string message) : base(message) { }
    }

    // Invalid expiry year exception
    public class InvalidExpiryYearException : Exception
    {
        public InvalidExpiryYearException(string message) : base(message) { }
    }

    // Medicine not found exception
    public class MedicineNotFoundException : Exception
    {
        public MedicineNotFoundException(string message) : base(message) { }
    }
}
