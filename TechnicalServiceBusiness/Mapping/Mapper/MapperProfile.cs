using AutoMapper;
using TechnicalServiceBusiness.Mapping.GeneralMapper;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceBusiness.Mapping.Mapper
{
    public class MapperProfile :Profile
    {
      public MapperProfile()
        {
            CreateMap<InsertTechnicianModel, Technician>().ReverseMap();
        }
    }
}
