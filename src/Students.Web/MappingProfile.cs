using AutoMapper;
using Students.Domain.Models;
using Students.Web.ViewModels;
using System.Globalization;

namespace Students.Web
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, ListStudentVM>()
                .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(y => y.DateOfBirth.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)))
                .ForMember(dto => dto.Gender, options => options.MapFrom(src => src.Gender.ToString()));

            CreateMap<CreateStudentVM, Student>()
            .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(y => y.DateOfBirth.Value))
            .ForMember(dto => dto.Gender, options => options.MapFrom(src => (Gender)Enum.Parse(typeof(Gender), src.Gender)));

            CreateMap<UpdateOrDeleteStudentVM, Student>()
            .ForMember(x => x.DateOfBirth, opt => opt.MapFrom(y => y.DateOfBirth.Value))
            .ForMember(dto => dto.Gender, options => options.MapFrom(src => (Gender)Enum.Parse(typeof(Gender), src.Gender)));


            CreateMap<Student, UpdateOrDeleteStudentVM>()
            .ForMember(dto => dto.Gender, options => options.MapFrom(src => src.Gender.ToString()));
        }
    }
}
