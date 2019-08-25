using System;
using System.Collections.Generic;

namespace GradeBook
{

   

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Max's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.GetStatistics();

            var stats = book.GetStatistics();

            // Writing to screen!
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Average}");
           
        }
    }
}
