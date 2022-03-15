using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;

namespace yourname_individual_part_a.Database.PairClasses
{
    class CourseStudent
    {
        public static void Pair(Course c, Student s)
        {
            c.Students.Add(s);
            s.Courses.Add(c);
        }
    }
}
