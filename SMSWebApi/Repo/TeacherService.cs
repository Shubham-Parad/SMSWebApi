using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public class TeacherService : TeacherRepo
    {
        private readonly ApplicationDbContext db;

        public TeacherService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddTeacher(Teacher t)
        {
            db.Teachers.Add(t);
            db.SaveChanges();
        }
    }
}
