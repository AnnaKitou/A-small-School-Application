using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourname_individual_part_a.View.Helpers
{
    class HelperClassNumber
    {
        public static int InputNumber(string placeholder)
        {
            do
            {
                try
                {

                    Console.WriteLine(placeholder);
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result > 0 && result <= 5000)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Tuition Fees must be between 1 - 5000 euro");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be a number");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be between 0 - 5000");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static int InputNumberOralMark(string placeholder)
        {
            do
            {
                try
                {

                    Console.WriteLine(placeholder);
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result >= 0 && result <= 100)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Tuition Fees must be between 0 - 100");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be a number");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be between 0 - 100");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static int IdNumberCourses(string placeholder)
        {
            do
            {
                try
                {

                    Console.WriteLine(placeholder);
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result > 0 && result <= 12)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("ID number must be between 1 - 12 ");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be a number");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be between 1 - 12");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static int IdNumberTrainers(string placeholder)
        {
            do
            {
                try
                {

                    Console.WriteLine(placeholder);
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result > 0 && result <= 12)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("ID number must be between 1 - 12 ");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be a number");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be between 1 - 12");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static int IdNumberStudents(string placeholder)
        {
            do
            {
                try
                {
                    Console.WriteLine(placeholder);
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result > 0 && result <= 45)
                    {
                    return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("ID number must be between 1 - 45 ");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be a number");
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The input must be between 1 - 45");
                    Console.ResetColor();
                }
              
            } while (true);
        }
    }
}
