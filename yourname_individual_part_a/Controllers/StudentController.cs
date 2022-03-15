using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.RepositoryService;
using yourname_individual_part_a.View.ViewAssignments;
using yourname_individual_part_a.View.ViewStudents;

namespace yourname_individual_part_a.Controllers
{
    class StudentView
    {
        StudentRepository studentService = new StudentRepository();
        AssignmentRepository assignmentService = new AssignmentRepository();
        public void ReadStudents()
        {
            var students = studentService.GetAll();
            ViewStudent.PrintStudents(students);
        }
        public void CreateStudent()
        {
            string input = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to create a Student? Press 'Y' for Yes or 'N' for No, to go back to main menu.");
                input = Console.ReadLine().ToUpper();
                Console.ResetColor();
                if (input=="Y")
                {
                    var student = ViewStudent.CreateStudent();
                    studentService.Create(student);
                }
                else if (input == "N")
                {
                    Console.WriteLine("You exited the Student's Creation");
                }
            } while (input != "N");
        }
        public void ReadAllAssignmentsPerStudent()
        {
            var students = studentService.GetAll();
            ViewStudent.PrintAssignmentsPerStudent(students);
        }
        public void ReadStudentsToMoreThanOneCourse()
        {
            var students = studentService.GetAll();
            ViewStudent.PrintCoursesPerStudent(students);
        }

        

    }
}
