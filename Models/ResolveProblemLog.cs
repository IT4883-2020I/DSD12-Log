using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class ResolveProblemLog : EntityActivityLog
    {
        public static int GroupId = 11;
        public string RegionId { get; set; }
        
        public static ResolveProblemLog[] GetSeederData()
        {
            var droneSeeder = new List<ResolveProblemLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new ResolveProblemLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = ResolveProblemLog.GetRandomEntityId(),
                    Type = apiType,
                    AuthorId = UserLog.GetRandomEntityId(),
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    Description = "ResolveProblem " + apiType.GetDescription(),
                    Name = "ResolveProblem " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    RegionId = MonitorRegionLog.GetRandomEntityId(),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
        public string Name { get; set; }
        
        public static string GetRandomEntityId()
        {
            var rand = new Random();
            return rand.Next(1, 15).ToString();
        }
    }

    public class ResolveProblemLogResponse : EntityActivityLogDTO
    {
        public string RegionId { get; set; }
    }

    public class ResolveProblemRequest : CommonRequest
    {
        public string RegionId { get; set; }
    }
}