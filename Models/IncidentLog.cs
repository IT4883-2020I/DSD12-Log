using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{

    public class IncidentLog : EntityActivityLog
    {
        public static int GroupId = 5;
        [Column(TypeName = "varchar(255)")] public string RegionId { get; set; }
        [Column(TypeName = "varchar(255)")] public string Name { get; set; }
        
        public static IncidentLog[] GetSeederData()
        {
            var droneSeeder = new List<IncidentLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                int ranDay = rand.Next(1, 3);
                int ranHour = rand.Next(1, 18);
                int ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                string projectType = Models.ProjectType.GetRandomProjectType();
                var droneLog = new IncidentLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = IncidentLog.GetRandomEntityId(),
                    AuthorId = UserLog.GetRandomEntityId(),
                    RegionId = MonitorRegionLog.GetRandomEntityId(),
                    ProjectType = projectType,
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

        public static string GetRandomEntityId()
        {
            var rand = new Random();
            return rand.Next(1, 15).ToString();
        }
    }

    public class IncidentLogResponse : EntityActivityLogDTO
    {
        
        public string Name { get; set; }
        public string RegionId { get; set; }
    }

    public class IncidentLogRequest : CommonRequest
    {
        public string RegionId { get; set; }
    }
}