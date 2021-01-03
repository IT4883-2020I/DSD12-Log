using System;

namespace aspnetcoreapp.Helpers
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class StartPoint
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class EndPoint
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Root
    {
        public StartPoint StartPoint { get; set; }
        public EndPoint EndPoint { get; set; }
        public string Id { get; set; }
        public string Area { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string IncidentType { get; set; }
        public int Times { get; set; }
        public int Level { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int V { get; set; }
    }
}