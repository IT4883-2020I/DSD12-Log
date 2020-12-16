using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class Payload : EntityActivityLog
    {
        public static int GroupId = 2;
        public string Name { get; set; }
        public string DroneId { get; set; }

        public static Payload[] GetSeederData()
        {
            var droneSeeder = new List<Payload>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new Payload()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    DroneId = DroneLog.GetRandomEntityId(),
                    EntityId = Payload.GetRandomEntityId(),
                    AuthorId = UserLog.GetRandomEntityId(),
                    ProjectType = Models.ProjectType.GetRandomProjectType(),
                    Type = apiType,
                    Description = "Payload " + apiType.GetDescription(),
                    Name = "Payload " + Utility.RandomString(2),
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
            return rand.Next(1, 11).ToString();
        }
    }

    public class PayloadResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
        public string DroneId { get; set; }
    }

    public class PayloadRequest : CommonRequest
    {
        public string DroneId { get; set; }
    }
}