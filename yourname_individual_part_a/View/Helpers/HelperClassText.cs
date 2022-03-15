using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourname_individual_part_a.View.Helpers
{
    class HelperClassText
    {
        public static string InputText(string placeholder)
        {
            do
            {
                try
                {
                    Console.WriteLine(placeholder);
                    string result = Console.ReadLine();
                    if (result.All(Char.IsLetter) && !string.IsNullOrWhiteSpace(result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("The input must contain letters from A(a) to Z(z)");
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                }
            } while (true);
        }
    }
}
