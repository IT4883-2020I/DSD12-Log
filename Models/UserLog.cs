using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class UserLog : EntityLog
    {
        public static int GroupId = 3;
        public string Metadata { get; set; }
        public int UserId { get; set; }
        public int RegionId { get; set; }
        public int IncidentId { get; set; }
        public int ResolveProblemId { get; set; }

        public static UserLog[] GetSeederData()
        {
            var droneSeeder = new List<UserLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new UserLog()
                {
                    Metadata = "Meta data example " + i,
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    EntityLogPrimaryKeyId = i + 10,
                    RegionId = MonitorRegionLog.GetRandomEntityId(),
                    EntityId = i * 2,
                    Type = apiType,
                    UserId = i * 3 - 1,
                    Description = "User " + apiType.GetDescription(),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0)
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
    }

    public struct UserLogRequest
    {
        public int user_id { get; set; }
        public int target_id { get; set; }
        public string description { get; set; }
        public string meta_data { get; set; }
        public string project_type { get; set; }
        public int region_id { get; set; }
        public int incident_id { get; set; }
        public int resolve_problem_id { get; set; }
    }

    public class UserLogResponse : TypeAndTimeStamp
    {
        public int TargetId { get; set; }
        public string Metadata { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public int RegionId { get; set; }
        public int IncidentId { get; set; }
        public int ResolveProblemId { get; set; }
    }
}