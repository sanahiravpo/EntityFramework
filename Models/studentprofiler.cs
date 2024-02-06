using AutoMapper;

namespace EntityFramework.Models
{
    public class studentprofiler:Profile
    {

      public studentprofiler() { 
        
        CreateMap<Student,StudentDTO>().ReverseMap();
            CreateMap<Department, DepartmentDTO>().ReverseMap();


        }
    }
}
