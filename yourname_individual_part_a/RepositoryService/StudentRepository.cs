using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Database;

namespace yourname_individual_part_a.RepositoryService
{
    class StudentRepository
    {
        MyDataBase db = new MyDataBase();
        public List<Student> GetAll()
        {
            return db.Students;
        }
        public void Create(Student s)   
        {
            int lastId = db.Students[db.Students.Count - 1].Id;
            s.Id = lastId + 1;
            db.Students.Add(s);
        }
        
    }
}
