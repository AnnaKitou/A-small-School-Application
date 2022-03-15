using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Enums;

namespace yourname_individual_part_a.View.Helpers
{
    class HelperClassEnum
    {
        public static Subject Subject(string subject)
        {
            do
            {
                try
                {
                    Console.WriteLine(subject);
                    string[] subjects = Enum.GetNames(typeof(Subject));
                    for (int i = 0; i < subjects.Length; i++)
                    {
                        Console.WriteLine($"{i,-10}-{subjects[i]}");
                    }
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Subject result = (Subject)choice;
                    if (choice >= 0 && choice <= 3)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Input must be between 0 - 3");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Input must be a number between 0 - 3");
                    Console.ResetColor();
                }

            } while (true);
        }
        public static Stream Stream(string stream)
        {
            do
            {
                try
                {
                    Console.WriteLine(stream);
                    string[] streams = Enum.GetNames(typeof(Stream));
                    for (int i = 0; i < streams.Length; i++)
                    {
                        Console.WriteLine($"{i,-10}-{streams[i]}");
                    }
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Stream result = (Stream)choice;
                    if (choice >= 0 && choice <= 7)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Input must be between 0 - 7");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Input must be a number between 0 - 7");
                    Console.ResetColor();
                }
            } while (true);
        }
        public static CourseType Type(string type)
        {
            do
            {
                try
                {
                    Console.WriteLine(type);
                    string[] types = Enum.GetNames(typeof(CourseType));
                    for (int i = 0; i < types.Length; i++)
                    {
                        Console.WriteLine($"{i,-10}-{types[i]}");
                    }
                    int choice = Convert.ToInt32(Console.ReadLine());
                    CourseType result = (CourseType)choice;
                    if (choice >= 0 && choice <= 1)
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Input must be between 0 - 1");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Input must be a number between 0 - 1");
                    Console.ResetColor();
                }

            } while (true);
        }
    }
}
