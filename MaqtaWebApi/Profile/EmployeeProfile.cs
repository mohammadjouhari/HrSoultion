using AutoMapper;
namespace API.Profiles
{ 

    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {

            //CreateMap<Entity.Employee, DTO.Employee>()
            //// Ignore the indexer property explicitly if AutoMapper is scanning it
            //.ForMember("Item", opt => opt.Ignore());


            //CreateMap<DTO.Employee, Entity.Employee>()
            //// Ignore the indexer property explicitly if AutoMapper is scanning it
            //.ForMember("Item", opt => opt.Ignore());


            ////CreateMap<Entity.Employee, DTO.Employee>();
            ////CreateMap<DTO.Employee, Entity.Employee>();
            ////CreateMap<List<DTO.Employee>, List<Entity.Employee>>();
        }
    }
}
