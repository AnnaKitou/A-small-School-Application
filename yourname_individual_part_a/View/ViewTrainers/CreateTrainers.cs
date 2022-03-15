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
    abstract class CreateTrainers
    {
        public static Trainer CreateTrainer()
        {
            //onoma
            string firstName = HelperClassText.InputText("Give Trainer's  First Name");
            //epitheto
            string lastName = HelperClassText.InputText("Give Trainer's  Last Name");
            //Subject
            Subject subject = HelperClassEnum.Subject("Give Trainer's Subject");

            Trainer obj = new Trainer(0, firstName, lastName, subject);
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("This trainer has been sucessfully created.");
            Console.ResetColor();
            Console.WriteLine();
            return obj;
        }
    }
}
