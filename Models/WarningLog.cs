using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{

    public class WarningLog : EntityActivityLog
    {
        public static int GroupId = 8;
        public string Name { get; set; }
        public string RegionId { get; set; }
        
        public static WarningLog[] GetSeederData()
        {
            var droneSeeder = new List<WarningLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new WarningLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    EntityId = WarningLog.GetRandomEntityId(),
                    RegionId = MonitorRegionLog.GetRandomEntityId(),
                    Type = apiType,
                    AuthorId = UserLog.GetRandomEntityId(),
                    Description = "Warning " + apiType.GetDescription(),
                    Name = "Warning " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
        
        public static string GetRandomEntityId()
        {
            var rand = new Random();
            return rand.Next(1, 11).ToString();
        }
    }

    public class WarningLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
        public string RegionId { get; set; }
    }
    public class WarningLogRequest : CommonRequest
    {
        public string RegionId { get; set; }
    }
}