using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{

    public class IncidentLog : EntityActivityLog
    {
        public static int GroupId = 5;
        public int RegionId { get; set; }
        public int ImageId { get; set; }
        public int VideoId { get; set; }
        public string Name { get; set; }
        
        public static IncidentLog[] GetSeederData()
        {
            var droneSeeder = new List<IncidentLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new IncidentLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = IncidentLog.GetRandomEntityId(),
                    RegionId = MonitorRegionLog.GetRandomEntityId(),
                    VideoId = VideoLog.GetRandomEntityId(),
                    ImageId = ImageLog.GetRandomEntityId(),
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    Type = apiType,
                    Description = "Incident " + apiType.GetDescription(),
                    Name = "Incident " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }

        public static int GetRandomEntityId()
        {
            var rand = new Random();
            return rand.Next(1, 15);
        }
    }

    public class IncidentLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
        public int RegionId { get; set; }
        public int ImageId { get; set; }
        public int VideoId { get; set; }
    }

    public class IncidentLogRequest : CommonRequest
    {
        public int RegionId { get; set; }
        public int ImageId { get; set; }
        public int VideoId { get; set; }
    }
}