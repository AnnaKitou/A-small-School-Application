using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Core.Enums;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewTrainers
{
    class ViewTrainer:CreateTrainers
    {
        public static void PrintTrainers(List<Trainer> trainers)
        {
            Console.WriteLine();
            Console.WriteLine("All Trainers are displayed in the table Below");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($" {"Id",-8}{"First Name",-15}{"Last Name",-13}   {"Subject",-10}");
            Console.ResetColor();
            foreach (var tra in trainers)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.BackgroundColor = ConsoleColor.White;

                Console.WriteLine($"{new string('-', 50)}");
                Console.WriteLine($"| {tra.Id,-5} | {tra.Name,-10} | {tra.LastName,-15}| {tra.Subject,-10}");
                Console.WriteLine($"{new string('-', 50)}");
            }
            Console.ResetColor();
        }
       
    }
}
