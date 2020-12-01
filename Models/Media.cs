using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class ImageLog : EntityActivityLog
    {
        public static int GroupId = 4;
        
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
                    EntityId = i * 2,
                    Type = apiType,
                    Description = "Drone " + apiType.GetDescription(),
                    Name = "Drone " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
    }

    public class ImageLogResponse : EntityActivityLogDTO
    {
    }

    public class VideoLog : EntityActivityLog
    {
        public static int GroupId = 4;
        
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
                    EntityId = i * 2,
                    Type = apiType,
                    Description = "Drone " + apiType.GetDescription(),
                    Name = "Drone " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
    }

    public class VideoLogResponse : EntityActivityLogDTO
    {
    }
}