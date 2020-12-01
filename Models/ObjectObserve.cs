namespace aspnetcoreapp.Models
{
    public class ObjectObserve : EntityActivityLog
    {
        public static int GroupId = 6;
        public string Name { get; set; }
    }

    public class ObjectObserveResponse : EntityActivityLogDTO
    {
        public string Name { get; set; }
    }
}