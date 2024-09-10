using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SMSWebApi.Data;
using SMSWebApi.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

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

        public Users SignIn(Users u)
        {
            var data = db.Users.FromSqlRaw($"exec sp_SignIn '{u.UserName}','{u.Password}'").SingleOrDefault();
            return data;
        }
    }
}
