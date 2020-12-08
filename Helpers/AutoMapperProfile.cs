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
            
            CreateMap<UserLogRequest, UserLog>();

            CreateMap<DroneLog, DroneLogResponse>();
            CreateMap<Payload, PayloadResponse>();
            CreateMap<UserLog, UserLogResponse>();
            CreateMap<ImageLog, ImageLogResponse>();
            CreateMap<VideoLog, VideoLogResponse>();
            CreateMap<IncidentLog, IncidentLogResponse>();
            CreateMap<ObjectObserve, ObjectObserveResponse>();
            CreateMap<StaticalLog, StaticalLogResponse>();
            CreateMap<WarningLog, WarningLogResponse>();
            CreateMap<MonitorRegionLog, MonitorRegionLogResponse>();
            CreateMap<ResolveProblemLog, ResolveProblemLogResponse>();
            CreateMap<UavConnectLog, UavConnectLogResponse>();

            CreateMap<DroneLogRequest, DroneLog>();
            CreateMap<PayloadRequest, Payload>();
            CreateMap<ImageLogRequest, ImageLog>();
            CreateMap<VideoLogRequest, VideoLog>();
            CreateMap<IncidentLogRequest, IncidentLog>();
            CreateMap<ObjectObserveRequest, ObjectObserve>();
            CreateMap<StaticalRequest, StaticalLog>();
            CreateMap<WarningLogRequest, WarningLog>();
            CreateMap<MonitorLogRequest, MonitorRegionLog>();
            CreateMap<ResolveProblemRequest, ResolveProblemLog>();
            CreateMap<UavConnectRequest, UavConnectLog>();
        }
    }
}