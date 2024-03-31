using AutoMapper;
using StudentDataAPI.DTOS;
using StudentDataAPI.Models;

namespace StudentDataAPI.Mappings
{
    public class StudentMappings : Profile
    {
        public StudentMappings()
        {
            CreateMap<PersonalInformationDTO, Student>();
            CreateMap<FamilyProfile, Student>();
            CreateMap<SHSInformation, Student>();
            CreateMap<CollegeInformation, Student>();
        }
    }
}
