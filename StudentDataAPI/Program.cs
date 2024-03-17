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
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});



    // Configure Services
ConfigureServices(builder.Services);

void ConfigureServices(IServiceCollection services)
{
    
    services.AddTransient<DapperContext>();

    //Repository injections
    services.AddScoped<IPersonalInformationRepository, PersonalInformationRepository>();
    services.AddScoped<IFamilyProfileRepository, FamilyProfileRepository>();
    services.AddScoped<ISHSInformationRepository, SHSInformationRepository>();
    services.AddScoped<ICollegeInformationRepository, CollegeInformationRepository>();


    //Service injections
    services.AddScoped<IPersonalInformationService, PersonalInformationService>();
    services.AddScoped<IFamilyProfileService, FamilyProfileService>();
    services.AddScoped<ISHSInformationService, SHSInformationService>();
    services.AddScoped<ICollegeInformationService, CollegeInformationService>();
}

var app = builder.Build();

app.UseCors(builder => builder
    .WithOrigins("http://localhost:3000") // Specify your allowed origins here
    .AllowAnyMethod()
    .AllowAnyHeader());

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
