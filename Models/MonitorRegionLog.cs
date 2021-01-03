using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class MonitorRegionLog : EntityActivityLog
    {
        public static int GroupId = 10;
        [Column(TypeName = "varchar(255)")] public string Name { get; set; }

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

        public static string GetRandomEntityId()
        {
            var list = new List<string>
            {
                "5fef34d32024870017139e51",
                "5fec86a1f139ff00177a252e",
                "5fec0951eeec7500179c9bbd",
                "5fec08eeeeec7500179c9bbc",
                "5fec08a6eeec7500179c9bbb",
                "5fe1a1ade40ec00017660154"
            };
            var rand = new Random();
            return list[rand.Next(1, 6)];
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