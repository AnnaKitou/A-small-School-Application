using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewStudents
{
    class ViewStudent:CreateStudents
    {
        public static void PrintStudents(List<Student> students)
        {
            Console.WriteLine("All Students are displayed in the table Below");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  {"Id",-5} {"First Name",-15} {"Last Name",-15} {"Date Of Birth",-15}{"TuitionFees",-6}");
            Console.ResetColor();
            foreach (var stu in students)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{new string('-', 66)}");
                Console.WriteLine($"| {stu.Id,-5}| {stu.Name,-15}| {stu.LastName,-15}| {stu.DateOfBirth.ToShortDateString(),-12} | {stu.TuitionFees,-8}");
            }
            Console.ResetColor();
        }
        public static void PrintAssignmentsPerStudent(List<Student> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"Assignments for the student with ID: {stu.Id} , First Name: {stu.Name} , Last Name: {stu.LastName} are listed below:");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\t {"Id",-5}{"Description",-26}{"Subbmission Date",-18}{"Oral Mark",-11}{"Total Mark"}{"",-5}");
                foreach (var ass in stu.Assignments)
                {
                    Console.WriteLine("\t" + $"{new string('-', 71)}{"",-5}");
                    Console.WriteLine("\t" + $"{ass.Id,-5}| {ass.Dexcription,-27}| {ass.SubDate.ToShortDateString(),-15}| {ass.OralMark,-10}| {ass.TotalMark,-5}|{"",-5}");
                }
            }
            Console.ResetColor();
        }
        public static void PrintCoursesPerStudent(List<Student> students)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\tThe students that belong to more than one courses are Listed Below: ");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\t  {"Id",-5} {"First Name",-15} {"Last Name",-15} {"Date Of Birth",-15}{"TuitionFees",-6}{"",-5}");
            foreach (var stu in students)
            {
                if (stu.Courses.Count > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                    Console.WriteLine($"{new string('-', 79)}");
                    Console.WriteLine($"\t| {stu.Id,-5}| {stu.Name,-15}| {stu.LastName,-15}| {stu.DateOfBirth.ToShortDateString(),-12} | {stu.TuitionFees,-7}|{"",-5}");
                }
                Console.ResetColor();
            }
        }
    }
}
