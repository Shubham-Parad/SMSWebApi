using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SMSWebApi.Data;
using SMSWebApi.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn"));
});

builder.Services.AddScoped<ClassRepo, ClassService>();
builder.Services.AddScoped<ParentRepo, ParentService>();
builder.Services.AddScoped<StudentRepo, StudentService>();
builder.Services.AddScoped<SubjectRepo, SubjectService>();
builder.Services.AddScoped<TeacherRepo, TeacherService>();
builder.Services.AddScoped<TimetableRepo, TimetableService>();
builder.Services.AddScoped<AuthRepo, AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
