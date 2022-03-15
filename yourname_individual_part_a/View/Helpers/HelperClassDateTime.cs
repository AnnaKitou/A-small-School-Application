using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourname_individual_part_a.View.Helpers
{
    class HelperClassDateTime
    {
        public static DateTime DateTimeBirthday(string date)
        {
            do
            {
                try
                {
                    Console.WriteLine(date);
                    DateTime result = Convert.ToDateTime(Console.ReadLine());
                    DateTime maxValue = new DateTime(2000, 12, 31);
                    DateTime minValue = new DateTime(1960, 12, 31);
                    if (result <= maxValue && result >= minValue)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The input must be between 1960-12-31 - 2000-12-31");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You must enter a valid a Date ex. 1989-12-01 or 1989/12/01 ");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static DateTime DateTimeCourseAndAssignment(string date)
        {
            do
            {
                try
                {
                    Console.WriteLine(date);
                    DateTime result = Convert.ToDateTime(Console.ReadLine());
                    DateTime minDate = new DateTime(2015, 12, 31);
                    DateTime maxDate = new DateTime(2025, 12, 31);
                    if (result >= minDate && result <= maxDate)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The input must be between 2015-12-31 - 2025-12-31");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You must enter a valid a Date ex. 1989-12-01 or 1989/12/01 ");
                    Console.ResetColor();
                }
                catch (Exception)
                {
                }
            } while (true);
        }
        public static DateTime DateTimeAssignmentPerWeek(string date)
        {
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(date);
                    DateTime result = Convert.ToDateTime(Console.ReadLine());
                    DateTime minDate = new DateTime(2015, 12, 31);
                    DateTime maxDate = new DateTime(2025, 12, 31);
                    Console.ResetColor();
                    Console.WriteLine();
                    if (result >= minDate && result <= maxDate)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The input must be between 2015-12-31 - 2025-12-31");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You must enter a valid a Date ex. 1989-12-01 or 1989/12/01 ");
                    Console.ResetColor();
                }
                catch (Exception)
                {
                }
            } while (true);
        }
    }
}
