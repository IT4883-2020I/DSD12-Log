using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class DroneLog : EntityLog
    {
        public static int GroupId = 1;
        public string Name { get; set; }
        public string RegionName { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        
        public static DroneLog[] GetSeederData()
        {
            var droneSeeder = new List<DroneLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new DroneLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = i * 2,
                    Latitude = rand.Next(10, 50),
                    Longitude = rand.Next(10, 50),
                    Type = apiType,
                    RegionName = Utility.RandomString(5),
                    Description = "Drone " + apiType.GetDescription(),
                    Name = "Drone " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0)
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }

    }

    public class DroneLogResponse : EntityLogDTO
    {
        public string Name { get; set; }
        public string RegionName { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
    }

    public class DroneLogRequest
    {
        public string Name { get; set; }
        public string RegionName { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public int EntityId { get; set; }
        public string Description { get; set; }
    }
}