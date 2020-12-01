namespace aspnetcoreapp.Models
{
    public class UavConnectLog : EntityActivityLog
    {
        public static int GroupId = 12;
        public string Name { get; set; }
    }

    public class UavConnectLogResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}