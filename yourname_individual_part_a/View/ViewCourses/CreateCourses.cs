using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Core.Enums;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewCourses
{
    abstract class CreateCourses
    {
        public static Course CreateCourse()
        {
            //Title
            string title = HelperClassText.InputText("Give Course's  Title");
            //Stream
            Core.Enums.Stream stream = HelperClassEnum.Stream("Give Course's Stream");
            //Course Type
            CourseType courseType = HelperClassEnum.Type("Give Course's Type");
            //StartDate

            DateTime startDate = HelperClassDateTime.DateTimeCourseAndAssignment("Give Course's Start Date (ex. 1989-12-25) from 2015-12-31 to 2025-12-31");
            do
            {
                //EndDate
                DateTime endDate = HelperClassDateTime.DateTimeCourseAndAssignment("Give Course's End Date (ex. 1989-12-25) from 2015-12-31 to 2025-12-31 \nEnd Date must e greater than start date at least 30 days in total.");
                TimeSpan timeSpan = endDate.Subtract(startDate);
                if (startDate < endDate && startDate != endDate && timeSpan.TotalDays >= 30)
                {
                    Course obj = new Course(0, title, stream, courseType, startDate, endDate);
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("This course has been sucessfully created.");
                    Console.ResetColor();
                    Console.WriteLine();
                    return obj;
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("End date must be greater than start date at least 30 days in total");
                    Console.ResetColor();
                }

            } while (true);
        }
    }
}
