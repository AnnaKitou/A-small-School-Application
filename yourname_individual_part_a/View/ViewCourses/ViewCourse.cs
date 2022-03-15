using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Core.Enums;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewCourses
{
    class ViewCourse:CreateCourses
    {
        public static void PrintCourses(List<Course> courses)
        {
            Console.WriteLine("All Courses are displayed in the table Below");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($" {"Id",-10}{"Title",-13}{"Stream",-12}{"CourseType",-13} {"StartDate",-17} {"EndDate",-12}");
            foreach (var cou in courses)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{new string('-', 80)}");
                Console.WriteLine($"| {cou.Id,-5}| {cou.Title,-15}| {cou.Stream,-10}| {cou.CourseType,-12}| {cou.StartDate.ToShortDateString(),-14}| {cou.EndDate.ToShortDateString(),-11}|");
            }
            Console.ResetColor();
        }
        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            foreach (var cou in courses)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Students in the Course => Id:{cou.Id} , Title:{cou.Title}, Stream:{cou.Stream}, Type:{cou.CourseType} are listed below:");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t| {"Id",-5} {"First Name",-15} {"Last Name",-15} {"Date Of Birth",-17}{"TuitionFees",-14}{"",-5}");

                Console.ResetColor();

                foreach (var stu in cou.Students)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\t{new string('-', 71)}{"",-5}");
                    Console.WriteLine($"\t| {stu.Id,-5}| {stu.Name,-15}| {stu.LastName,-15}| {stu.DateOfBirth.ToShortDateString(),-12} | {stu.TuitionFees,-13}{"",-5}");
                }
                Console.ResetColor();

            }

        }
        public static void PrintTrainersPerCourse(List<Course> courses)
        {
            foreach (var cou in courses)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Trainers in ==>Id:{cou.Id} , Title: {cou.Title}, Stream:{cou.Stream,-5}, Type:{cou.CourseType,-5} are listed below:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\t {"Id",-8}{"First Name",-15}{"Last Name",-13}   {"Subject",-10}{"",-10}");
                foreach (var tr in cou.Trainers)
                {

                    Console.WriteLine("\t" + $"{new string('-', 50)}{"",-10}");
                    Console.WriteLine("\t" + $"| {tr.Id,-5}| {tr.Name,-13}| {tr.LastName,-15}| {tr.Subject,-12}{"",-7}");
                }
            }
            Console.ResetColor();
        }
        public static void PrintAssignmentsPerCourse(List<Course> courses)
        {
            foreach (var cou in courses)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Assignments in ==> Id:{cou.Id} , Title: {cou.Title}, Stream:{cou.Stream,-5}, Type:{cou.CourseType,-5} are listed below:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\t {"Id",-5}{"Description",-26}{"Subbmission Date",-18}{"Oral Mark",-11}{"Total Mark"}{"",-5}");

                foreach (var ass in cou.Assignments)
                {
                    Console.WriteLine("\t" + $"{new string('-', 71)}{"",-5}");
                    Console.WriteLine("\t" + $"{ass.Id,-5}| {ass.Dexcription,-27}| {ass.SubDate.ToShortDateString(),-15}| {ass.OralMark,-10}| {ass.TotalMark,-5}|{"",-5}");
                }
            }
            Console.ResetColor();
        }
        public static void PrintAssignmentsPerStudentPerCourse(List<Course> courses)
        {
            foreach (var cou in courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Assignments in the course=> Id:{cou.Id} , Title: {cou.Title}, Stream: {cou.Stream}, Type: {cou.CourseType} and their students are listed below:");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine();

                foreach (var ass in cou.Assignments)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"Assignment=> Id {ass.Id}, Description:{ass.Dexcription}, Subbmission Date:{ass.SubDate.ToShortDateString()}, Oral Mark:{ass.OralMark}, Total Mark:{ass.TotalMark}");
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"\t| {"Id",-5} {"First Name",-15} {"Last Name",-15} {"Date Of Birth",-17}{"TuitionFees",-14}{"",-5}");

                    Console.ResetColor();
                    foreach (var stu in ass.Students)
                    {

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine($"\t{new string('-', 71)}{"",-5}");
                        Console.WriteLine($"\t| {stu.Id,-5}| {stu.Name,-15}| {stu.LastName,-15}| {stu.DateOfBirth.ToShortDateString(),-12} | {stu.TuitionFees,-13}{"",-5}");

                    }
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}
