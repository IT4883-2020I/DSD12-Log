using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class MonitorRegionLog : EntityActivityLog
    {
        public static int GroupId = 10;
        public string Name { get; set; }

        public static MonitorRegionLog[] GetSeederData()
        {
            var droneSeeder = new List<MonitorRegionLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var entityId = GetRandomEntityId();
                var droneLog = new MonitorRegionLog()
                {
                    EntityLogPrimaryKeyId = i + 1,
                    EntityId = entityId,
                    AuthorId = UserLog.GetRandomEntityId(),
                    Type = apiType,
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    Description = "MonitorRegion " + apiType.GetDescription(),
                    Name = "MonitorRegion " + entityId,
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
            return rand.Next(1, 5);
        }
    }

    public class MonitorRegionLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }

    public class MonitorLogRequest : CommonRequest
    {
    }
}