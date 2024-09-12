using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{

    public class ParentService:ParentRepo
    {
        private readonly ApplicationDbContext db;
        public ParentService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddParent(Parent p)
        {
            db.Parents.Add(p);
            db.SaveChanges();
        }
    }
}
