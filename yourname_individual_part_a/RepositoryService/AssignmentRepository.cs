using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Database;

namespace yourname_individual_part_a.RepositoryService
{
    class AssignmentRepository
    {
        MyDataBase db = new MyDataBase();
        public List<Assignment> GetAll()  
        {
            return db.Assignments;
        }
        public void Create(Assignment a)
        {
            int lastId = db.Assignments[db.Assignments.Count - 1].Id;
            a.Id = lastId + 1;
            db.Assignments.Add(a);
        }
    }
}
