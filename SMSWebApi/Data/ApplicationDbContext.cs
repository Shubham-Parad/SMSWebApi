using Microsoft.EntityFrameworkCore;
using SMSWebApi.Models;

namespace SMSWebApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
    }
}
