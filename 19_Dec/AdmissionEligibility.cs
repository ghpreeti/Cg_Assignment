//Admission Eligibility: Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).

using System;

public class AdmissionEligibility
{
    public static void Run()
    {
        Console.WriteLine("Enter Maths marks: ");
        int math = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Physics marks: ");
        int phys = Int32.Parse(Console.ReadLine());     
        Console.WriteLine("Enter Chemistry marks: ");
        int chem = Int32.Parse(Console.ReadLine());
        int total = math + phys + chem;
        if (math >= 65 && phys >= 55 && chem >= 50 && (total >= 180 || (math + phys) >= 140))
        {
          Console.WriteLine("Eligible");
        }
        else
        {
          Console.WriteLine("Not eligible");
        }
    }
}