// See https://aka.ms/new-console-template for more information
using PharmacyMedicineInventory;
using System;
MedicineUtility medicineUtility = new MedicineUtility();
Console.WriteLine("Enter First Line: ");
string input = Console.ReadLine();
string[] ip = input.Split(" ");

Medicine medObj = new Medicine()
{
    Id = ip[0],
    Name = ip[1],
    Price = int.Parse(ip[2]),
    ExpiryYear = int.Parse(ip[3]),

};

Console.WriteLine("------choose--------");
Console.WriteLine("1. Display all medicines (sorted by expiry year)");
Console.WriteLine("2. Update medicine Price");
Console.WriteLine("3. Add medicine");
Console.WriteLine("4. Exit");

int choice = int.Parse(Console.ReadLine());
while (true)
{
    try
    {
        switch (choice)
        {
            case 1:
                medicineUtility.GetAllMedicines();
                break;
            case 2:
                Console.Write("id: ");
                string id = (Console.ReadLine());
                Console.Write("newPrice: ");
                int newPrice = int.Parse(Console.ReadLine());
                medicineUtility.UpdateMedicinePrice(id, newPrice);
                break;
            case 3:

                string inp = Console.ReadLine();
                string[] arr = input.Split(" ");

                Medicine med = new Medicine()
                {
                    Id = arr[0],
                    Name = arr[1],
                    Price = int.Parse(arr[2]),
                    ExpiryYear = int.Parse(arr[3]),

                };
                medicineUtility.AddMedicine(med);
                break;
            case 4:

                return;

        }
    }
    catch (InvalidExpiryYearException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (InvalidPriceException e) { Console.WriteLine(e.Message); }
    catch (DuplicateMedicineException e) { Console.WriteLine(e.Message); }
    catch (MedicineNotFoundException e) { Console.WriteLine(e.Message); }

}
