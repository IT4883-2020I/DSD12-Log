using System;
using aspnetcoreapp.Controllers;
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

            CreateMap<EntityStateLogInput, EntityStateLog>();
            CreateMap<EntityStateLog, Payload>().ReverseMap();
            CreateMap<EntityStateLog, ImageLog>().ReverseMap();
            CreateMap<EntityStateLog, VideoLog>().ReverseMap();
            CreateMap<EntityStateLog, IncidentLog>().ReverseMap();
            CreateMap<EntityStateLog, ObjectObserve>().ReverseMap();
            CreateMap<EntityStateLog, StaticalLog>().ReverseMap();
            CreateMap<EntityStateLog, WarningLog>().ReverseMap();
            CreateMap<EntityStateLog, MonitorRegionLog>().ReverseMap();
            CreateMap<EntityStateLog, ResolveProblemLog>().ReverseMap();
            CreateMap<EntityStateLog, UavConnectLog>().ReverseMap();

            CreateMap<DroneLog, ActivityLogController.DroneLogDTO>();
            CreateMap<DroneLogRequest, DroneLog>();
            CreateMap<UserLogRequest, UserLog>();

        }
    }
}
