using Microsoft.OpenApi.Models;
using StudentDataAPI.Context;
using StudentDataAPI.Repositories.Students;
using StudentDataAPI.Services.StudentServices;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Version = "v1",
        Title = "Student Demogrphic InformationAPI",
        Description = "Api for Student Information Visualizer",
        Contact = new OpenApiContact
        {
            Name = "Github Repository",
            Url = new Uri("https://github.com/Olivein123/Rooks-Special-Problem")
        }
    });
  
});

    // Configure Services
ConfigureServices(builder.Services);

void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<DapperContext>();
    services.AddScoped<IStudentRepositories, StudentRepository>();
    services.AddScoped<IStudentService, StudentService>();
}
  

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
