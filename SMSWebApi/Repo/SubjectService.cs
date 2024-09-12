using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public class SubjectService:SubjectRepo
    {
        private readonly ApplicationDbContext db;
        public SubjectService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddSubject(Subject s)
        {
            db.Subjects.Add(s);
            db.SaveChanges();
        }
    }
}
