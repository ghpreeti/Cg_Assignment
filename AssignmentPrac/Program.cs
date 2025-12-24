// See https://aka.ms/new-console-template for more information
using AssignmentPrac;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {


        //Console.Write("Enter the title: ");
        //string title = Console.ReadLine();


        //Console.Write("Enter the author: ");
        //string author = Console.ReadLine();


        //Console.Write("Enter the number of pages: ");
        //int numPages = int.Parse(Console.ReadLine());


        //Console.Write("Enter the due date: ");
        //DateTime dueDate = DateTime.Parse(Console.ReadLine());


        //Console.Write("Enter the return date: ");
        //DateTime returnedDate = DateTime.Parse(Console.ReadLine());


        //Console.Write("Enter the days to read: ");
        //int daysToRead = int.Parse(Console.ReadLine());


        //Console.Write("Enter the daily late feeRate: ");
        //int dailyLateFeeRate = int.Parse(Console.ReadLine());

        //Book bookObj = new Book(title,author,numPages,dueDate,returnedDate);

        //Console.WriteLine($"Average Pages Read Per Day : {bookObj.AveragePagesReadPerDay(daysToRead)}");
        //Console.WriteLine($"Late Fee : {bookObj.CalculateLateFee(dailyLateFeeRate)}");



        //CabDetails cabDetailObj = new CabDetails();

        //Console.Write("Enter the booking id(AC@123): ");
        //cabDetailObj.BookingID = Console.ReadLine();

        //Console.Write("Enter the cab type: ");
        //cabDetailObj.CabType = Console.ReadLine().ToLower();

        //Console.Write("Enter the distance in km: ");
        //cabDetailObj.Distance = double.Parse(Console.ReadLine());

        //Console.Write("Enter the waiting time in minutes: ");
        //cabDetailObj.WaitingTime = int.Parse(Console.ReadLine());


        //if (cabDetailObj.ValidateBookingID())
        //{
        //    Console.WriteLine($"The fare amount is : {cabDetailObj.CalculateFareAmount()}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Booking Id");
        //}


        //Console.Write("Enter the radius aof circle: ");
        //double radius = double.Parse(Console.ReadLine());
        //Console.WriteLine($"Area: {Area.CalArea(radius)}");

        Console.WriteLine("Feet: ");
        int feet = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Feet : {FeetToCm.ConvertFeetToCm(feet)}");






    }
}