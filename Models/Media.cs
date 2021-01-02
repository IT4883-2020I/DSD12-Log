using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
        [Column(TypeName = "varchar(255)")] public string Link { get; set; }
        [Column(TypeName = "varchar(255)")] public string DroneId { get; set; }
        [Column(TypeName = "varchar(255)")] public string IncidentId { get; set; }

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
                    Description = "Hình ảnh theo dõi " + projectType + " " + Utility.RandomString(5),
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
        [Column(TypeName = "varchar(255)")] public string DroneId { get; set; }
        [Column(TypeName = "varchar(255)")] public string Link { get; set; }
        [Column(TypeName = "varchar(255)")] public string IncidentId { get; set; }

        public static VideoLog[] GetSeederData()
        {
            var droneSeeder = new List<VideoLog>();
            var rand = new Random();
            for (var i = 0; i < 100; i++)
            {
                string projectType = Models.ProjectType.GetRandomProjectType();
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
                    Description = "Video theo dõi " + projectType + " " + Utility.RandomString(5),
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
    }
}