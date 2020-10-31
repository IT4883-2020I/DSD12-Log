using System.Collections.Generic;
using aspnetcoreapp.Models;
using Microsoft.Extensions.Configuration;

namespace aspnetcoreapp.Service
{
    public class AuthenticationService
    {
        private readonly IConfiguration _configuration;

        private List<GroupAuthentication> GroupAuthentications {get;} = new List<GroupAuthentication>()
        {
            new GroupAuthentication(){GroupId = 1, Username = "G1", Password = "123"},
            new GroupAuthentication(){GroupId = 2, Username = "G2", Password = "123"},
            new GroupAuthentication(){GroupId = 3, Username = "G3", Password = "123"},
            new GroupAuthentication(){GroupId = 4, Username = "G4", Password = "123"},
            new GroupAuthentication(){GroupId = 5, Username = "G5", Password = "123"},
            new GroupAuthentication(){GroupId = 6, Username = "G6", Password = "123"},
            new GroupAuthentication(){GroupId = 7, Username = "G7", Password = "123"},
            new GroupAuthentication(){GroupId = 8, Username = "G8", Password = "123"},
            new GroupAuthentication(){GroupId = 10, Username = "G10", Password = "123"},
            new GroupAuthentication(){GroupId = 11, Username = "G11", Password = "123"},
            new GroupAuthentication(){GroupId = 12, Username = "G12", Password = "123"},
        };

        public bool IsAuthenticate(int groupId, string username, string password)
        {
            if (_configuration["TurnOnAuthentication"] == "true") {
                foreach (var group in GroupAuthentications)
                {
                    if (groupId == group.GroupId && username == group.Username && password == group.Password)
                    {
                        return true;
                    }
                }
                return false;
            } else
            {
                return true;
            }
        }

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}