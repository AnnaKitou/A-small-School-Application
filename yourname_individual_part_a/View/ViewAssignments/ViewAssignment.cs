using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewAssignments
{
    class ViewAssignment:CreateAssignments
    {
        public static void PrintAssignments(List<Assignment> assignments)
        {
            Console.WriteLine("All Assignments are dislpayed in the table Below");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine($" {"Id",-8}{"Description",-27}{"Subbmission Date",-20}{"Oral Mark",-15}{"Total Mark",-10}");
            foreach (var ass in assignments)
            {
                Console.WriteLine($"{new string('-', 81)}");
                Console.WriteLine($"| {ass.Id,-5}| {ass.Dexcription,-30}| {ass.SubDate.ToShortDateString(),-15}| {ass.OralMark,-15}| {ass.TotalMark,-5}|");
            }
            Console.ResetColor();

        }
        public static void PrintStudentPerAssignmentCurrentWeek(List<Assignment> assignments)
        {
            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            DateTime inputDate = HelperClassDateTime.DateTimeAssignmentPerWeek("Give Assignments's Date that you wish To Print Students' List from 2019-01-13 to 2019-06-28. \nIf no data is displayed Please try another Date.");
            int a = calendar.GetWeekOfYear(inputDate, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
       
            foreach (var ass in assignments)
            {
                if (a == calendar.GetWeekOfYear(ass.SubDate, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday) && inputDate.Year == ass.SubDate.Year)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"The students that have to submit the Assignment, with Id: {ass.Id}, this Week are listed Below:");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine($" {"Id",-5} {"First Name",-15} {"Last Name",-15} {"Assignment's Description",-25} {"Submission date",-15}");

                    foreach (var stu in ass.Students)
                    {
                        Console.WriteLine($"{new string('-', 80)}");
                        Console.WriteLine($" {stu.Id,-5}| {stu.Name,-15}| {stu.LastName,-15}| {ass.Dexcription,-25}| {ass.SubDate.ToShortDateString(),-11}");
                    }
                    Console.ResetColor();
                }
            }
        }
    }
}
