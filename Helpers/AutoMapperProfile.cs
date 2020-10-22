using System;
using aspnetcoreapp.Models;
using AutoMapper;

namespace aspnetcoreapp.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EntityLog, DroneLog>().ReverseMap();
            CreateMap<EntityLog, Payload>().ReverseMap();
            CreateMap<EntityLog, UserLog>().ReverseMap();
            CreateMap<EntityLog, ImageLog>().ReverseMap();
            CreateMap<EntityLog, VideoLog>().ReverseMap();
            CreateMap<EntityLog, IncidentLog>().ReverseMap();
            CreateMap<EntityLog, ObjectObserve>().ReverseMap();
            CreateMap<EntityLog, StaticalLog>().ReverseMap();
            CreateMap<EntityLog, WarningLog>().ReverseMap();
            CreateMap<EntityLog, MonitorRegionLog>().ReverseMap();
            CreateMap<EntityLog, ResolveProblemLog>().ReverseMap();
            CreateMap<EntityLog, UavConnectLog>().ReverseMap();
            
        }
    }
}
