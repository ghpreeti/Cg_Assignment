// See https://aka.ms/new-console-template for more information
using System;
using StudentLINQ;

class Program
{
    public static void Easy() { 
        StudentRepo sRepo = new StudentRepo();
        List<Student> studList = sRepo.GetAllStudents();

        // 1️. Students older than 20
        Console.WriteLine("\n1. Students with age above 20:");
        var above20 = studList.Where(s => s.Age > 20).ToList();
        foreach (var std in above20)
        {
            Console.WriteLine($"Id:{std.Id}, Name:{std.Name}, Age:{std.Age}, Marks:{std.Marks}, City:{std.City}");
        }

        // 2️. Only student names
        Console.WriteLine("\n2. Student Names:");
        List<string> studNames = studList.Select(s => s.Name).ToList();
        foreach (var name in studNames)
        {
            Console.WriteLine(name);
        }

        // 3️. Count students from Mumbai
        int mumbaiCount = studList.Count(s => s.City == "Mumbai");
        Console.WriteLine("\n3. Count of students from Mumbai:");
        Console.WriteLine(mumbaiCount);   // Output: int

        // 4️. Check if any student has marks above 90
        bool hasTopper = studList.Any(s => s.Marks > 90);
        Console.WriteLine("\n4. Is there any student with marks above 90?");
        Console.WriteLine(hasTopper);     // Output: bool (true/false)

        // 5️. First student from Delhi
        Console.WriteLine("\n5. First student from Delhi:");
        Student delhiStudent = studList.FirstOrDefault(s => s.City == "Delhi");
        if (delhiStudent != null)
        {
            Console.WriteLine($"Id:{delhiStudent.Id}, Name:{delhiStudent.Name}, Age:{delhiStudent.Age}, Marks:{delhiStudent.Marks}, City:{delhiStudent.City}");
        }
        else
        {
            Console.WriteLine("No student found from Delhi");
        }

    }
    
    public static void Medium()
    {
        StudentRepo sRepo = new StudentRepo();
        List<Student> studList = sRepo.GetAllStudents();

        //1.
        Console.WriteLine("\n1.");
        var stdbymarks = studList.Where(m => m.Marks >= 85 && m.Age < 22).ToList();
        foreach(var std in stdbymarks)
        {
            Console.WriteLine($"Id:{std.Id}, Name:{std.Name}, Age:{std.Age}, Marks:{std.Marks}, City:{std.City}");
        }

        //2.
        Console.WriteLine("\n2.");
        var sorted = studList.OrderByDescending(s => s.Marks).ToList();
        foreach (var std in sorted)
        {
            Console.WriteLine($"Id:{std.Id}, Name:{std.Name}, Age:{std.Age}, Marks:{std.Marks}, City:{std.City}");
        }

        //3.
        Console.WriteLine("\n3.");
        var anymSelect = studList.Select(s => new { s.Name, s.Marks }).ToList();
        foreach (var std in anymSelect)
        {
            Console.WriteLine($"Name:{std.Name}, Marks:{std.Marks}");
        }

        //4.
        Console.WriteLine("\n4.");
        var topper = studList.Max(s=>s.Marks);
        Console.WriteLine(topper);

        //5.
        Console.WriteLine("\n5.");
        string cityToSerach = Console.ReadLine();
        var stdByCity = studList.FindAll(c => c.City == cityToSerach);
        foreach (var std in stdByCity)
        {
            Console.WriteLine($"Name:{std.Name}, City:{std.City}");
        }

    }

     public static void SlightlyTricky()
    {
        StudentRepo sObj = new StudentRepo();
        List<Student> studList = sObj.GetAllStudents();

        //1.
        Console.WriteLine("\n1.");
        Console.WriteLine("Average marks of all students");
        var avg = studList.Average(m => m.Marks);
        Console.WriteLine(avg);

        //2.
        Console.WriteLine("\n2.");
        var cityGrp = studList.GroupBy(c => c.City);
        foreach(var group in cityGrp)
        {
            Console.WriteLine($"City: {group.Key}");
            foreach(var std in group)
            {
                Console.WriteLine($"Name:{std.Name}");
            }
        }

        //3.
        Console.WriteLine("\n3.");
        var topTwo = studList
                     .OrderByDescending(s => s.Marks)
                     .Take(2).ToList();


        //4.
        Console.WriteLine("\n4.");
        var above18 = studList.All(s => s.Age > 18);
        if(above18)
        Console.WriteLine("All student are above 18");



    }

    static void Main()
    {
        //Easy();
        //Medium();
        SlightlyTricky();
    }
}
