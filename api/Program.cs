using api.Models;
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

app.MapGet("/absences", async (AppDbContext db) =>
    await db.Absences.ToListAsync())
    .WithName("GetAbsences")
    .WithOpenApi();

app.MapGet("/settings", async (AppDbContext db) =>
    await db.AppSettings.FirstOrDefaultAsync())
    .WithName("GetAppSettings")
    .WithOpenApi();

app.MapGet("/assignments", async (AppDbContext db) =>
    await db.Assignments.ToListAsync())
    .WithName("GetAssignments")
    .WithOpenApi();

app.MapGet("/students", async (AppDbContext db) =>
    await db.Students.ToListAsync())
    .WithName("GetStudents")
    .WithOpenApi();

app.MapGet("/studentClassrooms", async (AppDbContext db) =>
    await db.StudentClassrooms.ToListAsync())
    .WithName("GetStudentClassrooms")
    .WithOpenApi();

app.MapGet("/teachers", async (AppDbContext db) =>
    await db.Teachers.Select(t => new ListItem {
            Id = t.Id,
            Label = $"{t.FirstName} {t.LastName}",
            LabelEn = $"{t.FirstName} {t.LastName}"
        }).ToListAsync())
    .WithName("GetTeachers")
    .WithOpenApi();

app.MapPost("/sync", (AppDbContext db, Absence[] absences) => {
    // TODO: Implement
    return absences[0].Year;
})
    .WithName("Sync")
    .WithOpenApi();

app.Run();
