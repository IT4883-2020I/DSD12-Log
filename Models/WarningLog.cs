namespace aspnetcoreapp.Models
{

    public class WarningLog : EntityActivityLog
    {
        public static int GroupId = 8;
    }

    public class WarningLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}