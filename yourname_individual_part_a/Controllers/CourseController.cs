using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.RepositoryService;
using yourname_individual_part_a.View.Helpers;
using yourname_individual_part_a.View.ViewAssignments;
using yourname_individual_part_a.View.ViewCourses;
using yourname_individual_part_a.View.ViewStudents;
using yourname_individual_part_a.View.ViewTrainers;

namespace yourname_individual_part_a.Controllers
{
    class CourseController
    {
        CourseRepository courseService = new CourseRepository();
        StudentRepository studentService = new StudentRepository();
        TrainerRepository trainerService = new TrainerRepository();
        AssignmentRepository assignmentService = new AssignmentRepository();
        public void ReadCourses()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintCourses(courses);
        }
        public void CreateCourse()
        {
            string input = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to create a Course? Press 'Y' for Yes or 'N' for No, to go back to main menu.");
                input = Console.ReadLine().ToUpper();
                Console.ResetColor();
                if (input == "Y")
                {
                    var course = ViewCourse.CreateCourse();
                    courseService.Create(course);
                }
                else if (input == "N")
                {
                    Console.WriteLine("You exited the Course's Creation");
                }
            } while (input != "N");
        }
        public void ReadAllStudentsPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintStudentsPerCourse(courses);

        }
        public void ReadAllTrainersPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintTrainersPerCourse(courses);
        }
        public void ReadAllAssignmentsPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintAssignmentsPerCourse(courses);

        }
        public void ReadAllAssignmentsPerStudentPerCourse()
        {
            var courses = courseService.GetAll();
            ViewCourse.PrintAssignmentsPerStudentPerCourse(courses);
        }
        public void AssignStudentToCourse()
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Assign a Student to a Course by using the ID");
            Console.WriteLine();
            Console.ResetColor();

            var students = studentService.GetAll();
            ViewStudent.PrintStudents(students);
            Console.WriteLine();

            var courses = courseService.GetAll();
            ViewCourse.PrintCourses(courses);

            Console.WriteLine();

            int studentId = HelperClassNumber.IdNumberStudents("Give Student's Id from the above table");

            Console.WriteLine();

            int courseId = HelperClassNumber.IdNumberCourses("Give Existing Courses Id from the above table");

            courseService.AttachStudentToCourse(studentId, courseId);

            
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Assignment was successfull.");
            Console.ResetColor();
            Console.WriteLine();
        }
        public void AssignTrainerToCourse()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Assign a Trainer to a Course by using the ID");
            Console.WriteLine();
            Console.ResetColor();

            var trainers = trainerService.GetAll();
            ViewTrainer.PrintTrainers(trainers);

            Console.WriteLine();

            var courses = courseService.GetAll();
            ViewCourse.PrintCourses(courses);


            Console.WriteLine();
            int trainerId = HelperClassNumber.IdNumberTrainers("Give Existing Trainer's Id from the above table");

            Console.WriteLine();

            int courseId = HelperClassNumber.IdNumberCourses("Give Existing Courses Id from the above table");

            courseService.AttachTrainerToCourse(trainerId, courseId);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Assignment was successfull.");
            Console.ResetColor();
            Console.WriteLine();
        }


    }
}
