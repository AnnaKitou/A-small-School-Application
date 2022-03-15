using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourname_individual_part_a.Core.Entities
{
    class Assignment
    {
        public Assignment(int id, string dexcription, DateTime subDate, int oralMark, int totalMark)
        {
            Id = id;
            Dexcription = dexcription;
            SubDate = subDate;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public int Id { get; set; }
        public string Dexcription { get; set; }
        public DateTime SubDate { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //Navigation Properties
        public Course Course { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
