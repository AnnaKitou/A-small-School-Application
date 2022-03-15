using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.RepositoryService;
using yourname_individual_part_a.View.ViewAssignments;

namespace yourname_individual_part_a.Controllers
{
    class AssignmentController
    {
        AssignmentRepository assignmentService = new AssignmentRepository();
        public void ReadAssignments()
        {
            var assignments = assignmentService.GetAll();
            ViewAssignment.PrintAssignments(assignments);
        }
        public void CreateAssignment()
        {
            string input = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to create an assignment? Press 'Y' for Yes or 'N' for No, to go back to main menu.");
                input = Console.ReadLine().ToUpper();
                Console.ResetColor();
                if (input == "Y")
                {
                    var assignment = ViewAssignment.CreateAssignment();
                    assignmentService.Create(assignment);
                }
                else if (input == "N")
                {
                    Console.WriteLine("You exited the Assingment's Creation");
                }
            } while (input != "N");
            
        }
        public void PrintStudentPerAssignmentCurrentWeek()
        {
            string input = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to print all students that have to submit an assignment in this current week? \nPress 'T' to try a date OR 'R' to go back to main menu.");
                input = Console.ReadLine().ToUpper();
                Console.ResetColor();
                if (input=="T")
                {
                    var assignments = assignmentService.GetAll();
                    ViewAssignment.PrintStudentPerAssignmentCurrentWeek(assignments);
                }
                else if (input == "R")
                {
                    Console.WriteLine("You are in the main Menu");
                }
            } while (input != "R");
        }
    }
}
