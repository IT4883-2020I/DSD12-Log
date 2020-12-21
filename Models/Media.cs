using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
        public string Link { get; set; }
        public string DroneId { get; set; }
        public string ProjectId { get; set; }
        public string IncidentId { get; set; }

        public static ImageLog[] GetSeederData()
        {
            var droneSeeder = new List<ImageLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                string projectType = Models.ProjectType.GetRandomProjectType();
                var droneLog = new ImageLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = ImageLog.GetRandomEntityId(),
                    DroneId = DroneLog.GetRandomEntityId(),
                    AuthorId = UserLog.GetRandomEntityId(),
                    IncidentId = IncidentLog.GetRandomEntityId(),
                    Type = apiType,
                    ProjectType = projectType,
                    ProjectId = Models.ProjectType.GetRandomProjectId(projectType),
                    Description = "Image " + apiType.GetDescription(),
                    Link = "Image " + Utility.RandomString(2),
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
            return rand.Next(1, 41).ToString();
        }
    }

    public class ImageLogResponse : EntityActivityLogDTO
    {
        public string Link { get; set; }
        public string DroneId { get; set; }
        public string IncidentId { get; set; }
    }

    public class VideoLog : EntityActivityLog
    {
        public static int GroupId = 4;
        public string DroneId { get; set; }
        public string Link { get; set; }
        public string ProjectId { get; set; }
        public string IncidentId { get; set; }

        public static VideoLog[] GetSeederData()
        {
            var droneSeeder = new List<VideoLog>();
            var rand = new Random();
            string projectType = Models.ProjectType.GetRandomProjectType();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new VideoLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    DroneId = DroneLog.GetRandomEntityId(),
                    AuthorId = UserLog.GetRandomEntityId(),
                    EntityId = VideoLog.GetRandomEntityId(),
                    IncidentId = IncidentLog.GetRandomEntityId(),
                    Type = apiType,
                    ProjectType = projectType,
                    ProjectId = Models.ProjectType.GetRandomProjectId(projectType),
                    Description = "Video " + apiType.GetDescription(),
                    Link = "Video " + Utility.RandomString(2),
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
            return rand.Next(1, 41).ToString();
        }
    }

    public class VideoLogResponse : EntityActivityLogDTO
    {
        public string Link { get; set; }
        public string DroneId { get; set; }
        public string IncidentId { get; set; }
    }

    public class VideoLogRequest 
    {
        public string DroneId { get; set; }
        public string EntityId { get; set; }
        public string AuthorId { get; set; }
        public string IncidentId { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string State { get; set; }
        public string Link { get; set; }
        public string ProjectId { get; set; }
    }

    public class ImageLogRequest 
    {
        public string DroneId { get; set; }
        public string EntityId { get; set; }
        public string AuthorId { get; set; }
        public string IncidentId { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string State { get; set; }
        public string Link { get; set; }
        public string ProjectId { get; set; }
    }
}