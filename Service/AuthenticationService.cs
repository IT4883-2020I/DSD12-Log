using System.Collections.Generic;
using System.Linq;
using aspnetcoreapp.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace aspnetcoreapp.Service
{
    public class AuthenticationService
    {
        private readonly IConfiguration _configuration;

        private readonly string group = @"{
            'user': 3,
            'payload': 2,
            'drone':1,   
            'image-log': 4,
            'video-log': 4,
            'incident': 5,
            'object-observe': 6,
            'statical': 7,
            'warning': 8,
            'monitor-region': 10,
            'resolve-problem': 11,
            'uav-connect': 12,
        }";

        private List<GroupAuthentication> GroupAuthentications { get; } = new List<GroupAuthentication>()
        {
            new GroupAuthentication() {GroupId = 1, Username = "G1", Password = "123"},
            new GroupAuthentication() {GroupId = 2, Username = "G2", Password = "123"},
            new GroupAuthentication() {GroupId = 3, Username = "G3", Password = "123"},
            new GroupAuthentication() {GroupId = 4, Username = "G4", Password = "123"},
            new GroupAuthentication() {GroupId = 5, Username = "G5", Password = "123"},
            new GroupAuthentication() {GroupId = 6, Username = "G6", Password = "123"},
            new GroupAuthentication() {GroupId = 7, Username = "G7", Password = "123"},
            new GroupAuthentication() {GroupId = 8, Username = "G8", Password = "123"},
            new GroupAuthentication() {GroupId = 10, Username = "G10", Password = "123"},
            new GroupAuthentication() {GroupId = 11, Username = "G11", Password = "123"},
            new GroupAuthentication() {GroupId = 12, Username = "G12", Password = "123"},
        };

        public bool IsAuthenticate(int groupId, string username, string password)
        {
            if (_configuration["TurnOnAuthentication"] == "true")
            {
                return GroupAuthentications.Any(@group => groupId == @group.GroupId && username == @group.Username && password == @group.Password);
            }
            else
            {
                return true;
            }
        }

        public bool IsAuthenticateByEntityName(string entityName, string username, string password)
        {
            var groupName = JObject.Parse(group);
            if (groupName[entityName] == null)
            {
                return false;
            }
            else
            {
                return IsAuthenticate((int) groupName[entityName], username, password);
            }
        }

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}