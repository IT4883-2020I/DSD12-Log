using System;
using System.Collections.Generic;
using aspnetcoreapp.Helpers;

namespace aspnetcoreapp.Models
{
    public class ObjectObserve : EntityActivityLog
    {
        public static int GroupId = 6;
        public string Name { get; set; }
        
        public static ObjectObserve[] GetSeederData()
        {
            var droneSeeder = new List<ObjectObserve>();
            var rand = new Random();
            for (var i = 0; i < 40; i++)
            {
                var ranDay = rand.Next(1, 3);
                var ranHour = rand.Next(1, 18);
                var ranMinute = rand.Next(1, 50);
                var apiType = Utility.GetRandomApiType();
                var droneLog = new ObjectObserve()
                {
                    EntityLogPrimaryKeyId = i + 10,
                    EntityId = i * 2,
                    Type = apiType,
                    Description = "ObjectObserve " + apiType.GetDescription(),
                    Name = "ObjectObserve " + Utility.RandomString(2),
                    Timestamp = new DateTime(2020, 12, ranDay, ranHour, ranMinute, 0),
                    State = i % 2 + ""
                };
                droneSeeder.Add(droneLog);
            }

            return droneSeeder.ToArray();
        }
    }

    public class ObjectObserveResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}