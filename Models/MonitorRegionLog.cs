namespace aspnetcoreapp.Models
{

    public class MonitorRegionLog : EntityActivityLog
    {
        public static int GroupId = 10;
        public string Name { get; set; }
    }

    public class MonitorRegionLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}