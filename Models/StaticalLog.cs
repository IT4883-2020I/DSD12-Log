using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{

    public class StaticalLog : EntityActivityLog
    {
        public static int GroupId = 7;
        public string RegionId { get; set; }
        
        public static StaticalLog[] GetSeederData()
        {
            var droneSeeder = new List<StaticalLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new StaticalLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    AuthorId = UserLog.GetRandomEntityId(),
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    EntityId = (i * 2).ToString(),
                    RegionId = MonitorRegionLog.GetRandomEntityId(),
                    Type = apiType,
                    Description = "Statical " + apiType.GetDescription(),
                    Name = "Statical " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
        public string Name { get; set; }
    }

    public class StaticalLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
        public string RegionId { get; set; }
    }

    public class StaticalRequest : CommonRequest
    {
        public string RegionId { get; set; }
    }
}