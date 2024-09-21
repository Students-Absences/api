using api.Models;
using api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
    builder.Configuration.GetConnectionString("Default"),
    opts =>
    {
        opts.CommandTimeout(300);
        opts.EnableRetryOnFailure(
            maxRetryCount: 10,
            maxRetryDelay: TimeSpan.FromSeconds(3),
            errorCodesToAdd: null
        );
    }
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

app.MapDelete("/clear", (AppDbContext db) => Services.ClearAbsences(db))
    .WithName("ClearAbsences")
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

app.MapPost("/sync", IResult (AppDbContext db, SyncIn syncIn) => {
        try {
            return Results.Ok(Services.Sync(db, syncIn));
        } catch (Exception e) {
            return Results.Text(e.Message, statusCode: 401);
        }
    })
    .WithName("Sync")
    .WithOpenApi();

app.Run();
