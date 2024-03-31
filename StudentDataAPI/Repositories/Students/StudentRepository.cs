using AutoMapper;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentDataAPI.Context;
using StudentDataAPI.DTOS;
using StudentDataAPI.Models;

namespace StudentDataAPI.Repositories.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DapperContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(DapperContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Task<IEnumerable<Student>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            var sql = @"
        SELECT 
            PI.*, 
            FP.*, 
            SI.*, 
            CI.*
        FROM 
            Personal_Info AS PI
        JOIN 
            Family_Profile AS FP ON PI.StudentId = FP.StudentId
        JOIN 
            SHS_Information AS SI ON PI.StudentId = SI.StudentId
        JOIN 
            College_Information AS CI ON PI.StudentId = CI.StudentId
        WHERE 
            PI.StudentId = @studentId";

            using (var con = _context.CreateConnection())
            {
                // Execute the SQL query and obtain the results
                var results = await con.QueryAsync<PersonalInformationDTO, FamilyProfile, SHSInformation, CollegeInformation, Student>(
                    sql,
                    (pi, fp, si, ci) =>
                    {
                        // Construct Student object using AutoMapper
                        var student = new Student
                        {
                            PersonalInformation = pi,
                            FamilyProfile = fp,
                            SHSInformation = si,
                            CollegeInformation = ci
                        };
                        return student;
                    },
                    new { StudentId = studentId },
                    splitOn: "StudentId");

                // Return the first result or null if no results found
                return results.FirstOrDefault();
            }
        }
    }
}
