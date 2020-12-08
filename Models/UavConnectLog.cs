using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class UavConnectLog : EntityActivityLog
    {
        public static int GroupId = 12;
        public string Name { get; set; }
        public int DroneId { get; set; }

        public static UavConnectLog[] GetSeederData()
        {
            var droneSeeder = new List<UavConnectLog>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new UavConnectLog()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    DroneId = rand.Next(1, 11),
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    EntityId = UavConnectLog.GetRandomEntityId(),
                    Type = apiType,
                    Description = "UavConnect " + apiType.GetDescription(),
                    Name = "UavConnect " + Utility.RandomString(2),
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
            return rand.Next(1, 15);
        }
    }

    public class UavConnectLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
        public int DroneId { get; set; }
    }

    public class UavConnectRequest : CommonRequest
    {
        public int DroneId { get; set; }
    }
}