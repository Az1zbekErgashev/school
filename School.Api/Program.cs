using Microsoft.EntityFrameworkCore;
using School.Api.Middlewres;
using School.Infrastructure.Contexts;
using School.Service.Interfaces.Class;
using School.Service.Interfaces.IRepositories;
using School.Service.Interfaces.Student;
using School.Service.Service.Class;
using School.Service.Service.Repositories;
using School.Service.Service.Student;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IClassService, ClassService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("PostgresConnection");
builder.Services.AddDbContext<SchoolDB>(options =>
{
    options.UseNpgsql(connectionString, b => b.MigrationsAssembly("School.Api"));
    options.EnableDetailedErrors();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<SchoolExceptionMiddlewares>();
app.UseAuthorization();

app.MapControllers();

app.Run();
