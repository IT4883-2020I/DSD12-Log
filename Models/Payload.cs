namespace aspnetcoreapp.Models
{
    public class Payload : EntityActivityLog
    {
        public static int GroupId = 2;
        public string Name { get; set; }
    }

    public class PayloadResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}