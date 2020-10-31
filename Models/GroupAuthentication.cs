namespace aspnetcoreapp.Models
{
    public class GroupAuthentication
    {
        public int GroupId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsValid(GroupAuthentication groupAuthentication)
        {
            return (groupAuthentication.GroupId == GroupId &&
                    groupAuthentication.Username == Username &&
                    groupAuthentication.Password == Password);
        }
    }
}