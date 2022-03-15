using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourname_individual_part_a.Core.Entities
{
    class Student : Person
    {
        public Student(int id, string name, string lastName, DateTime dateTime, int tuitionfees) : base(id, name, lastName)
        {
            DateOfBirth= dateTime;
            TuitionFees = tuitionfees;
        }

        public int TuitionFees { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Navigation Properties

        public List<Course> Courses { get; set; } = new List<Course>();

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

    }
}
