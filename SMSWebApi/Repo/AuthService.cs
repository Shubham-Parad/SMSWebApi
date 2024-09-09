using SMSWebApi.Data;
using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public class AuthService : AuthRepo
    {
        private readonly ApplicationDbContext db;
        public AuthService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void SignUp(Users u)
        {
            var existingUser = db.Users.FirstOrDefault(x => x.Email == u.Email);
            if (existingUser != null)
            {
                throw new Exception("User with this email already exists.");
            }
            u.Password = BCrypt.Net.BCrypt.HashPassword(u.Password);
            db.Users.Add(u);
            db.SaveChanges();
        }

        public bool SignIn(Users u)
        {
            var user = db.Users.FirstOrDefault(x => x.Email == u.Email);
            if (user == null)
            {
                throw new Exception("Invalid email or password.");
            }

            // Verify the password
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(u.Password, user.Password);
            if (!isPasswordValid)
            {
                throw new Exception("Invalid email or password.");
            }
            return true;
        }
    }
}
