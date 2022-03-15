using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewAssignments
{
    abstract class CreateAssignments
    {
        public static Assignment CreateAssignment()
        {
            //perigrafi
            string description = HelperClassText.InputText("Give Assignment's Description");
            //Date of SubMission
            DateTime subDate = HelperClassDateTime.DateTimeCourseAndAssignment("Give Assignment's Date of Submission (ex. 1989-12-25) from 2015-12-31 to 2025-12-31");
            //Scores
            int oralMark = HelperClassNumber.InputNumber("Give Assignment's Oral Mark");
            int totalMark = 100;

            Assignment obj = new Assignment(0, description, subDate, oralMark, totalMark);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("This assignment has been sucessfully created.");
            Console.ResetColor();
            Console.WriteLine();
            return obj;
        }
    }
}
