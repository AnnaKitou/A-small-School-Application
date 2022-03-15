using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Controllers;

namespace yourname_individual_part_a.Application
{
    class App
    {
        public static void Run()
        {
            AssignmentController assignmentController = new AssignmentController();
            CourseController courseController = new CourseController();
            StudentView studentController = new StudentView();
            TrainerController trainerController = new TrainerController();

            const int first = -40;
            const int second = -70;
            const int third = -40;
            const int fourth = -10;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*! Welcome To Our School !*");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Choose an Option");
            Console.WriteLine();
            Console.ResetColor();

            string input = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{"------View All DATA-----",first}{"------View Data By Course/By Assignment------",second}{"------Create DATA------",third}{"------EXIT------",fourth}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{ "1 - View All Students",first}{"5 - View All Students Per Course",second}{"12 - Create a Student",third}{"        E",fourth}");
                Console.WriteLine($"{"2 - View All Courses",first}{"6 - View All Trainers Per Course",second}{"13 - Create a Trainer",third}");
                Console.WriteLine($"{"3 - View All Trainers",first}{"7 - View All Assignments Per Course",second}{"14 - Create an Assignment",third}");
                Console.WriteLine($"{"4 - View All Assignments",first}{"8 - View All Assignments Per Student",second}{"15 - Create a Course",third}");
                Console.WriteLine($"{"   ",first}{"9 - View All Assignments Per Student Per Course",second}{"16 - Assign a Student To a Course",third}");
                Console.WriteLine($"{"  ",first}{"10 - View All Students That Belong to More than One Courses",second}{"17 - Assing a Trainer To a Course",third}");
                Console.WriteLine($"{" ",first}{"11 - View Students that need to submit assignments this week",second}");
                Console.WriteLine($"{" ",first}{" ",second}");

                input = Console.ReadLine().ToUpper();
                Console.ResetColor();
                Console.Clear();
                switch (input)
                {
                    case "1": studentController.ReadStudents(); break;
                    case "2": courseController.ReadCourses(); break;
                    case "3": trainerController.ReadTrainers(); break;
                    case "4": assignmentController.ReadAssignments(); break;
                    case "5": courseController.ReadAllStudentsPerCourse(); break;
                    case "6": courseController.ReadAllTrainersPerCourse(); break;
                    case "7": courseController.ReadAllAssignmentsPerCourse(); break;
                    case "8": studentController.ReadAllAssignmentsPerStudent(); break;
                    case "9": courseController.ReadAllAssignmentsPerStudentPerCourse(); break;
                    case "10": studentController.ReadStudentsToMoreThanOneCourse(); break;
                    case "11": assignmentController.PrintStudentPerAssignmentCurrentWeek(); break;
                    case "12": studentController.CreateStudent(); break;
                    case "13": trainerController.CreateTrainer(); break;
                    case "14": assignmentController.CreateAssignment(); break;
                    case "15": courseController.CreateCourse(); break;
                    case "16": courseController.AssignStudentToCourse(); break;
                    case "17": courseController.AssignTrainerToCourse(); break;
                    case "E": Console.WriteLine("You Pressed Exit"); break;
                    default: Console.WriteLine("Wrong Choice! Give: 1 to 19 or E"); break;
                }

            } while (input != "E");
        }
    }
}
