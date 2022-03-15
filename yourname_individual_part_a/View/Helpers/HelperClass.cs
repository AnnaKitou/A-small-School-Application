using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Enums;
using yourname_individual_part_a.View.ViewCourses;

namespace yourname_individual_part_a.View.Helpers
{
    class HelperClass
    {
        //public static string InputText(string placeholder)
        //{
        //    do
        //    {
        //        try
        //        {

        //            Console.WriteLine(placeholder);
        //            string result = Console.ReadLine();
        //            if (result.All(Char.IsLetter) && !string.IsNullOrWhiteSpace(result)) { 
        //            return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("The input must contain letters from A(a) to Z(z)");
        //                Console.ResetColor();
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //        }
     
        //    } while (true);
        //}
        //public static int InputNumber(string placeholder)
        //{
        //    do
        //    {
        //        try
        //        {

        //            Console.WriteLine(placeholder);
        //            int result = Convert.ToInt32(Console.ReadLine());
        //            if (result > 0 && result <= 5000) 
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("Tuition Fees must be between 1 - 5000 euro");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be a number");
        //            Console.ResetColor();
        //        }
        //        catch(OverflowException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be between 0 - 5000");
        //            Console.ResetColor();
        //        }
        //    } while (true);
        //}
        //public static int InputNumberOralMark(string placeholder)
        //{
        //    do
        //    {
        //        try
        //        {

        //            Console.WriteLine(placeholder);
        //            int result = Convert.ToInt32(Console.ReadLine());
        //            if (result >= 0 && result <= 100)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("Tuition Fees must be between 0 - 100");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be a number");
        //            Console.ResetColor();
        //        }
        //        catch (OverflowException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be between 0 - 100");
        //            Console.ResetColor();
        //        }
        //    } while (true);
        //}
        //public static int IdNumberCourses(string placeholder)
        //{
        //    do
        //    {
        //        try
        //        {

        //            Console.WriteLine(placeholder);
        //            int result = Convert.ToInt32(Console.ReadLine());
        //            if (result > 0 && result <= 8)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("ID number must be between 1 - 8 ");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be a number");
        //            Console.ResetColor();
        //        }
        //        catch (OverflowException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be between 1 - 8");
        //            Console.ResetColor();
        //        }
        //    } while (true);
        //}
        //public static int IdNumberTrainers(string placeholder)
        //{
        //    do
        //    {
        //        try
        //        {

        //            Console.WriteLine(placeholder);
        //            int result = Convert.ToInt32(Console.ReadLine());
        //            if (result > 0 && result <= 8)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("ID number must be between 1 - 8 ");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be a number");
        //            Console.ResetColor();
        //        }
        //        catch (OverflowException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be between 1 - 8");
        //            Console.ResetColor();
        //        }
        //    } while (true);
        //}
        //public static int IdNumberStudents(string placeholder)
        //{
        //    do
        //    {
        //        try
        //        {

        //            Console.WriteLine(placeholder);
        //            int result = Convert.ToInt32(Console.ReadLine());
        //            if (result > 0 && result <= 40)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("ID number must be between 1 - 40 ");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be a number");
        //            Console.ResetColor();
        //        }
        //        catch (OverflowException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("The input must be between 1 - 40");
        //            Console.ResetColor();
        //        }
        //    } while (true);
        //}
        //public static DateTime DateTimeBirthday(string date)
        //{
        //    do
        //    {
        //        try
        //        {
        //            Console.WriteLine(date);
        //            DateTime result = Convert.ToDateTime(Console.ReadLine());
        //            DateTime maxValue = new DateTime(2000,12,31);
        //            DateTime minValue = new DateTime(1960, 12, 31);

        //            if (result <= maxValue && result>=minValue)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("The input must be between 1960-12-31 - 2000-12-31");
        //                Console.ResetColor();
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("You must enter a valid a Date ex. 1989-12-01 or 1989/12/01 ");
        //            Console.ResetColor();
        //        }

        //    } while (true);

        //}
        //public static DateTime DateTimeCourseAndAssignment(string date)
        //{
        //    do
        //    {
        //        try
        //        {
        //            Console.WriteLine(date);
        //            DateTime result = Convert.ToDateTime(Console.ReadLine());
        //            DateTime minDate = new DateTime(2015,12,31);
        //            DateTime maxDate = new DateTime(2025,12,31);
        //            if (result>=minDate && result<=maxDate)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("The input must be between 2015-12-31 - 2025-12-31");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("You must enter a valid a Date ex. 1989-12-01 or 1989/12/01 ");
        //            Console.ResetColor();
        //        }
        //        catch (Exception)
        //        {

        //        }

        //    } while (true);

        //}
        //public static DateTime DateTimeAssignmentPerWeek(string date)
        //{
        //    do
        //    {
        //        try
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Blue;
        //            Console.WriteLine(date);
        //            DateTime result = Convert.ToDateTime(Console.ReadLine());
        //            DateTime minDate = new DateTime(2015, 12, 31);
        //            DateTime maxDate = new DateTime(2025, 12, 31);
        //            Console.ResetColor();
        //            Console.WriteLine();
        //            if (result >= minDate && result <= maxDate)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("The input must be between 2015-12-31 - 2025-12-31");
        //                Console.ResetColor();

        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("You must enter a valid a Date ex. 1989-12-01 or 1989/12/01 ");
        //            Console.ResetColor();
        //        }
        //        catch (Exception)
        //        {

        //        }

        //    } while (true);

        //}
        //public static Subject Subject(string subject)
        //{
           
        //    do
        //    {
        //        try
        //        {
        //            Console.WriteLine(subject);
        //            string[] subjects = Enum.GetNames(typeof(Subject));
        //            for (int i = 0; i < subjects.Length; i++)
        //            {
        //                Console.WriteLine($"{i,-10}-{subjects[i]}");
        //            }
        //            int choice = Convert.ToInt32(Console.ReadLine());
        //            Subject result = (Subject)choice;
        //            if (choice>=0 && choice<=3 ) {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("Input must be between 0 - 3");
        //                Console.ResetColor();
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("Input must be a number between 0 - 3");
        //            Console.ResetColor();
        //        }

        //    } while (true);
        //}
        //public static Stream Stream(string stream)
        //{
        //    do
        //    {
        //        try
        //        {
        //            Console.WriteLine(stream);
        //            string[] streams = Enum.GetNames(typeof(Stream));
        //            for (int i = 0; i < streams.Length; i++)
        //            {
        //                Console.WriteLine($"{i,-10}-{streams[i]}");
        //            }
        //            int choice = Convert.ToInt32(Console.ReadLine());
        //            Stream result = (Stream)choice;
        //            if (choice >= 0 && choice <= 7)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("Input must be between 0 - 7");
        //                Console.ResetColor();
        //            }
        //        }
        //        catch (FormatException)
        //        {

        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("Input must be a number between 0 - 7");
        //            Console.ResetColor();
        //        }
        //    } while (true);
        //}
        //public static CourseType Type(string type)
        //{
        //    do
        //    {
        //        try
        //        {
        //            Console.WriteLine(type);
        //            string[] types = Enum.GetNames(typeof(CourseType));
        //            for (int i = 0; i < types.Length; i++)
        //            {
        //                Console.WriteLine($"{i,-10}-{types[i]}");
        //            }
        //            int choice = Convert.ToInt32(Console.ReadLine());
        //            CourseType result = (CourseType)choice;
        //            if (choice >= 0 && choice <= 1)
        //            {
        //                return result;
        //            }
        //            else
        //            {
        //                Console.WriteLine();
        //                Console.ForegroundColor = ConsoleColor.Magenta;
        //                Console.WriteLine("Input must be between 0 - 1");
        //                Console.ResetColor();
        //            }
        //        }
        //        catch (FormatException)
        //        {

        //            Console.WriteLine();
        //            Console.ForegroundColor = ConsoleColor.Magenta;
        //            Console.WriteLine("Input must be a number between 0 - 1");
        //            Console.ResetColor();
        //        }

        //    } while (true);
        //}
    }
}
