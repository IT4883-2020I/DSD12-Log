using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
        public string Link { get; set; }
        public int DroneId { get; set; }

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
                var droneLog = new ImageLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = ImageLog.GetRandomEntityId(),
                    DroneId = rand.Next(1, 11),
                    AuthorId = UserLog.GetRandomEntityId(),
                    Type = apiType,
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    Description = "Image " + apiType.GetDescription(),
                    Link = "Image " + Utility.RandomString(2),
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
            return rand.Next(1, 41);
        }
    }

    public class ImageLogResponse : EntityActivityLogDTO
    {
        public string Link { get; set; }
        public int DroneId { get; set; }
    }

    public class VideoLog : EntityActivityLog
    {
        public static int GroupId = 4;
        public int DroneId { get; set; }
        public string Link { get; set; }

        public static VideoLog[] GetSeederData()
        {
            var droneSeeder = new List<VideoLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new VideoLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    DroneId = rand.Next(1, 11),
                    AuthorId = UserLog.GetRandomEntityId(),
                    EntityId = VideoLog.GetRandomEntityId(),
                    Type = apiType,
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    Description = "Video " + apiType.GetDescription(),
                    Link = "Video " + Utility.RandomString(2),
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
            return rand.Next(1, 41);
        }
    }

    public class VideoLogResponse : EntityActivityLogDTO
    {
        public string Link { get; set; }
        public int DroneId { get; set; }
    }

    public class VideoLogRequest 
    {
        public int DroneId { get; set; }
        public int EntityId { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string State { get; set; }
        public string Link { get; set; }
    }

    public class ImageLogRequest 
    {
        public int DroneId { get; set; }
        public int EntityId { get; set; }
        public int AuthorId { get; set; }
        public string Description { get; set; }
        public string ProjectType { get; set; }
        public string State { get; set; }
        public string Link { get; set; }
    }
}