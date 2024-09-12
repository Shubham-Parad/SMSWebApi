using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public class TimetableService:TimetableRepo
    {
        private readonly ApplicationDbContext db;
        public TimetableService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddTimetable(Timetable t)
        {
            db.Timetables.Add(t);
            db.SaveChanges();
        }
    }
}
