using AutoMapper;
using Demo.Database.Models;
using Demo.Entities.ResponseModel;

namespace Demo_Entity.Profiles
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<DepartmentResponseModel, Department>().ReverseMap();
        }
    }
}
