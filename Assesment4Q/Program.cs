// See https://aka.ms/new-console-template for more information
using System;

namespace FactoryRobotHazardAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RobotHazardAuditor auditor = new RobotHazardAuditor();

                Console.WriteLine("Enter arm precision (0.0 - 1.0): ");
                double armPrecision = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter worker density (1 - 20): ");
                int workerDensity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter machinery state (Worn / Faulty / Critical): ");
                string machineryState = Console.ReadLine();

                double risk = auditor.CalculateHazardRisk(
                                    armPrecision,
                                    workerDensity,
                                    machineryState);

                Console.WriteLine("\n=== Hazard Analysis Result ===");
                Console.WriteLine($"Hazard Risk Score: {risk}");
            }
            catch (RobotSafetyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }

            Console.ReadLine(); // keep console open
        }
    }
}

