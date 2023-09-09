using api.Models;
using api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("Default")
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/absences", (AppDbContext db) => Services.GetAbsences(db))
    .WithName("GetAbsences")
    .WithOpenApi();

app.MapGet("/settings", (AppDbContext db) => Services.GetAppSettings(db))
    .WithName("GetAppSettings")
    .WithOpenApi();

app.MapGet("/assignments", (AppDbContext db) => Services.GetAssignments(db))
    .WithName("GetAssignments")
    .WithOpenApi();

app.MapGet("/classrooms", (AppDbContext db) => Services.GetClassrooms(db))
    .WithName("GetClassrooms")
    .WithOpenApi();

app.MapGet("/students", (AppDbContext db) => Services.GetStudents(db))
    .WithName("GetStudents")
    .WithOpenApi();

app.MapGet("/studentClassrooms", (AppDbContext db) => Services.GetStudentClassrooms(db))
    .WithName("GetStudentClassrooms")
    .WithOpenApi();

app.MapGet("/teachers", (AppDbContext db) => Services.GetTeachers(db))
    .WithName("GetTeachers")
    .WithOpenApi();

app.MapPost("/sync", (AppDbContext db, Absence[] absences) => {
    return absences[0].Year;
})
    .WithName("Sync")
    .WithOpenApi();

app.Run();
