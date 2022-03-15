using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.View.Helpers;

namespace yourname_individual_part_a.View.ViewStudents
{
   abstract class CreateStudents
    {
        public static Student CreateStudent()
        {
            //onoma
            string firstName = HelperClassText.InputText("Give Student's First Name");
            //epitheto
            string lastName = HelperClassText.InputText("Give Student's Last Name");
            //Date of Birth
            DateTime birthday = HelperClassDateTime.DateTimeBirthday("Give Student's Date of Birth (ex. 1989-12-25) from 1960-12-31 to 2000-12-31");
            //Tuition Fees
            int tuitionFees = HelperClassNumber.InputNumber("Give Student's Tuition Fees");

            Student obj = new Student(0, firstName, lastName, birthday, tuitionFees);

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("This student has been sucessfully created.");
            Console.ResetColor();
            Console.WriteLine();
            return obj;

         
        }
    }
}
