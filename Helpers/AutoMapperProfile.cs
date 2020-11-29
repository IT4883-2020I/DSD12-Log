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

            CreateMap<EntityActivityLogInput, EntityActivityLog>();
            CreateMap<EntityActivityLog, Payload>().ReverseMap();
            CreateMap<EntityActivityLog, ImageLog>().ReverseMap();
            CreateMap<EntityActivityLog, VideoLog>().ReverseMap();
            CreateMap<EntityActivityLog, IncidentLog>().ReverseMap();
            CreateMap<EntityActivityLog, ObjectObserve>().ReverseMap();
            CreateMap<EntityActivityLog, StaticalLog>().ReverseMap();
            CreateMap<EntityActivityLog, WarningLog>().ReverseMap();
            CreateMap<EntityActivityLog, MonitorRegionLog>().ReverseMap();
            CreateMap<EntityActivityLog, ResolveProblemLog>().ReverseMap();
            CreateMap<EntityActivityLog, UavConnectLog>().ReverseMap();

            CreateMap<DroneLog, ActivityLogController.DroneLogDTO>();
            CreateMap<DroneLogRequest, DroneLog>();
            CreateMap<UserLogRequest, UserLog>();

        }
    }
}
