using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class UserLog : EntityLog
    {
        public static int GroupId = 3;
        public string Metadata { get; set; }
        [Column(TypeName = "varchar(255)")] public string RegionId { get; set; }
        [Column(TypeName = "varchar(255)")] public string IncidentId { get; set; }
        [Column(TypeName = "varchar(255)")] public string ResolveProblemId { get; set; }
        [Column(TypeName = "varchar(255)")] public string Name { get; set; }

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
                    EntityId = UserLog.GetRandomEntityId(),
                    Name = Utility.RandomString(5) + " " + Utility.RandomString(4),
                    Type = apiType,
                    AuthorId = UserLog.GetRandomEntityId(),
                    ResolveProblemId = ResolveProblemLog.GetRandomEntityId(),
                    Description = "User " + apiType.GetDescription(),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0)
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
        public string TargetId { get; set; }
        public string Metadata { get; set; }
        public string AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RegionId { get; set; }
        public string IncidentId { get; set; }
        public string ResolveProblemId { get; set; }
    }
}