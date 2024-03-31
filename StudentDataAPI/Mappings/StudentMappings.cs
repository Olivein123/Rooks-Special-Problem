using AutoMapper;
using StudentDataAPI.DTOS;
using StudentDataAPI.Models;

namespace StudentDataAPI.Mappings
{
    public class StudentMappings : Profile
    {
        public StudentMappings()
        {
            CreateMap<PersonalInformation, PersonalInformationDto>();
            CreateMap<FamilyProfile, FamilyProfileDto>();
            CreateMap<SHSInformation, SHSInformationDto>();
            CreateMap<CollegeInformation, CollegeInformationDto>();

            CreateMap<Student, StudentDto>()
           .ForMember(dest => dest.PersonalInformation, opt => opt.MapFrom(src => src.PersonalInformation))
           .ForMember(dest => dest.FamilyProfile, opt => opt.MapFrom(src => src.FamilyProfile))
           .ForMember(dest => dest.SHSInformation, opt => opt.MapFrom(src => src.SHSInformation))
           .ForMember(dest => dest.CollegeInformation, opt => opt.MapFrom(src => src.CollegeInformation));
        }
    }
}
