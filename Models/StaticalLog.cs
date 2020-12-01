namespace aspnetcoreapp.Models
{

    public class StaticalLog : EntityActivityLog
    {
        public static int GroupId = 7;
        public string Name { get; set; }
    }

    public class StaticalLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}