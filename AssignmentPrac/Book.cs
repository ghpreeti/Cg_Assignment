using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentPrac
{
    public class Book
    {
        #region Feilds
        string title;
        string author;
        int numPages;
        DateTime dueDate;
        DateTime returnedDate;
        #endregion

        public Book() { }
        public Book(string title, string author, int numPages,DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)numPages / daysToRead;
        }

        public double CalculateLateFee(double dailyLateFeeRate)
        {
            TimeSpan days = returnedDate - dueDate;
            int NumberOfDaysLate = days.Days;

            return NumberOfDaysLate * dailyLateFeeRate;
        }
    }
}
