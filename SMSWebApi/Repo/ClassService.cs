using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public class ClassService:ClassRepo
    {
        private readonly ApplicationDbContext db;
        public ClassService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddClass(Classes c)
        {
            db.Classes.Add(c);
            db.SaveChanges();
        }
    }
}
