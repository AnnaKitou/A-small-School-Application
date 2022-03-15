using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Enums;

namespace yourname_individual_part_a.Core.Entities
{
    class Trainer : Person
    {
        public Trainer(int id, string name, string lastName, Subject subject) : base(id, name, lastName)
        {
            Subject = subject;
        }
        public Subject Subject { get; set; }

        //Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
