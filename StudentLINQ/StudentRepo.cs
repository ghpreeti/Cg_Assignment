using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLINQ
{
    internal class StudentRepo
    {
        List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Alok", Age = 20, Marks = 85, City = "Delhi" },
    new Student { Id = 2, Name = "Riya", Age = 22, Marks = 72, City = "Mumbai" },
    new Student { Id = 3, Name = "Rajat", Age = 19, Marks = 78, City = "Delhi" },
    new Student { Id = 4, Name = "Nitya", Age = 21, Marks = 88, City = "Pune" },
    new Student { Id = 5, Name = "Raman", Age = 23, Marks = 65, City = "Bangalore" },
    new Student { Id = 6, Name = "Smita", Age = 22, Marks = 92, City = "Mumbai" },
    new Student { Id = 7, Name = "Saket", Age = 19, Marks = 58, City = "Delhi" },
    new Student { Id = 8, Name = "Prachi", Age = 21, Marks = 88, City = "Pune" },
    new Student { Id = 9, Name = "Naresh", Age = 23, Marks = 95, City = "Bangalore" },
    new Student { Id = 10, Name = "Aarti", Age = 22, Marks = 84, City = "Mumbai" },
    new Student { Id = 11, Name = "Vartika", Age = 19, Marks = 78, City = "Delhi" },
    new Student { Id = 12, Name = "Manan", Age = 21, Marks = 88, City = "Pune" },
    new Student { Id = 13, Name = "Mahesh", Age = 25, Marks = 77, City = "Chennai" },
    new Student { Id = 14, Name = "Ranjeet", Age = 22, Marks = 96, City = "Mumbai" },
    new Student { Id = 15, Name = "Kajal", Age = 19, Marks = 78, City = "Chennai" }

};

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
