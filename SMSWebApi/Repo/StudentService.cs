using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public class StudentService:StudentRepo
    {
        private readonly ApplicationDbContext db;
        public StudentService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddStudent(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
        }
    }
}
