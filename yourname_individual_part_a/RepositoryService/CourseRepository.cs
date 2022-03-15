using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yourname_individual_part_a.Core.Entities;
using yourname_individual_part_a.Database;

namespace yourname_individual_part_a.RepositoryService
{
    class CourseRepository
    {
        MyDataBase db = new MyDataBase();
        public List<Course> GetAll()
        {
            return db.Courses;
        }
        public void Create(Course c)
        {
            int lastId = db.Courses[db.Courses.Count - 1].Id;
            c.Id = lastId + 1;
            db.Courses.Add(c);
        }
        public void AttachStudentToCourse(int studentId, int courseId)
        {
            var student = db.Students.Find(x => x.Id == studentId);
            var course = db.Courses.Find(x => x.Id == courseId);

            course.Students.Add(student);
        }
        public void AttachTrainerToCourse(int trainerId, int courseId)
        {
            var trainer = db.Trainers.Find(x => x.Id == trainerId);
            var course = db.Courses.Find(x => x.Id == courseId);

            course.Trainers.Add(trainer);
        }


    }
}
