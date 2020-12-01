namespace aspnetcoreapp.Models
{

    public class IncidentLog : EntityActivityLog
    {
        public static int GroupId = 5;
        public string Name { get; set; }
    }

    public class IncidentLogResponse : EntityActivityLogDTO
    {
    }
}