using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;

namespace yourname_individual_part_a.Database.PairClasses
{
    class CourseTrainer
    {
        public static void Pair(Course c, Trainer t)
        {
            c.Trainers.Add(t);
            t.Courses.Add(c);
        }
    }
}
