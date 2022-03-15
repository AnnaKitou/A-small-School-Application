using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Database;

namespace yourname_individual_part_a.RepositoryService
{
    class TrainerRepository
    {
        MyDataBase db = new MyDataBase();
        public List<Trainer> GetAll()
        {
            return db.Trainers;
        }
        public void Create(Trainer t)
        {
            int lastId = db.Trainers[db.Trainers.Count - 1].Id;
            t.Id = lastId + 1;
            db.Trainers.Add(t);
        }
    }
}
