using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Enums;

namespace yourname_individual_part_a.Core.Entities
{
    class Course
    {
        public Course(int id, string title, Stream stream, CourseType coursetype, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Title = title;
            Stream = stream;
            CourseType = coursetype;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Title { get; set; }
        public Stream Stream { get; set; }
        public CourseType CourseType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Id { get; set; }

        //Navigation Properties
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
    }
}
