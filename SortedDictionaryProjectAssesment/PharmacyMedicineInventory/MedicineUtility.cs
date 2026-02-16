using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyMedicineInventory
{
    public class MedicineUtility
    {
        private SortedDictionary<int,Medicine> _medList = new SortedDictionary<int, Medicine>();
        public void AddMedicine(Medicine medicine)
        {
            if (!_medList.ContainsValue(medicine)) {
                _medList.Add(medicine.ExpiryYear, medicine);
            }
            throw new DuplicateMedicineException("Medicine Already Exists");
        }

        public SortedDictionary<int,Medicine> GetAllMedicines()
        {
            return _medList;
        }

        public void UpdateMedicinePrice(string id, int newPrice)
        {
            var query = _medList.Values.FirstOrDefault(e => e.Id == id);
            if (query != null)
            {
                query.Price = newPrice;
            }
            else
            {
                throw new MedicineNotFoundException("Medicine not found");
            }
        }
    }
}
