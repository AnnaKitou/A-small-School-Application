using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;

namespace yourname_individual_part_a.Database.PairClasses
{
    class AssignmentStudent
    {
        public static void Pair(Assignment a, Student s)
        {
            a.Students.Add(s);
            s.Assignments.Add(a);
        }
    }
}
