using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using aspnetcoreapp.Models;
using aspnetcoreapp.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp.Controllers
{
    [Route("api")]
    [ApiController]
    public class NewLogController : CustomController
    {
        public NewLogController(ILogger<NewLogController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }


        [HttpGet("drones")]
        public async Task<ActionResult> GetDrone([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<DroneLog>(DroneLog.GroupId, form, username, password);

        [HttpDelete("drones")]
        [HttpPost("drones")]
        [HttpPut("drones")]
        public async Task<ActionResult> PostDrone([FromBody] DroneLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(DroneLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<DroneLog>(form);
        }

        [HttpGet("payload")]
        public async Task<ActionResult> GetPayload([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<Payload>(Payload.GroupId, form, username, password);

        [HttpDelete("payload")]
        [HttpPost("payload")]
        [HttpPut("payload")]
        public async Task<ActionResult> PostPayload([FromBody] Payload form, string username, string password)
        {
            if (!_authService.IsAuthenticate(Payload.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<Payload>(form);
        }

        [HttpGet("user")]
        public async Task<ActionResult> GetUser([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<UserLog>(UserLog.GroupId, form, username, password);

        [HttpDelete("user")]
        [HttpPost("user")]
        [HttpPut("user")]
        public async Task<ActionResult> PostUser([FromBody] UserLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<UserLog>(form);
        }

        [HttpGet("video")]
        public async Task<ActionResult> GetVideo([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<VideoLog>(VideoLog.GroupId, form, username, password);

        [HttpDelete("video")]
        [HttpPost("video")]
        [HttpPut("video")]
        public async Task<ActionResult> PostVideo([FromBody] VideoLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(VideoLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<VideoLog>(form);
        }

        [HttpGet("image")]
        public async Task<ActionResult> GetImage([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<ImageLog>(ImageLog.GroupId, form, username, password);

        [HttpDelete("image")]
        [HttpPost("image")]
        [HttpPut("image")]
        public async Task<ActionResult> PostImage([FromBody] ImageLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(ImageLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<ImageLog>(form);
        }

        [HttpGet("incident")]
        public async Task<ActionResult> GetIncident([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<IncidentLog>(IncidentLog.GroupId, form, username, password);

        [HttpDelete("incident")]
        [HttpPost("incident")]
        [HttpPut("incident")]
        public async Task<ActionResult> PostIncident([FromBody] IncidentLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(IncidentLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<IncidentLog>(form);
        }

        [HttpGet("monitor-object")]
        public async Task<ActionResult>
            GetObjectObserve([FromBody] MinMaxDate form, string username, string password) =>
            await Get<ObjectObserve>(ObjectObserve.GroupId, form, username, password);

        [HttpDelete("monitor-object")]
        [HttpPost("monitor-object")]
        [HttpPut("monitor-object")]
        public async Task<ActionResult> PostObjectObserve([FromBody] ObjectObserve form, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(ObjectObserve.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<ObjectObserve>(form);
        }

        [HttpGet("receive-statistical")]
        public async Task<ActionResult> GetStatical([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<StaticalLog>(StaticalLog.GroupId, form, username, password);

        [HttpPost("statistical-frequence")]
        [HttpPost("statistical-address")]
        [HttpPost("statistical-incident")]
        public async Task<ActionResult> PostStatical([FromBody] StaticalLog form, string username, string password)
        {
            var route = Request.Path.Value;
            _logger.LogInformation("PostStatical " + route);
            if (!_authService.IsAuthenticate(StaticalLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = ApiType.CommonIncident;
            if (route.Contains("statistical-frequence"))
            {
                apiType = ApiType.FrequenceIncident;
            }
            else if (route.Contains("statistical-address"))
            {
                apiType = ApiType.HasProblem;
            }

            return await Post<StaticalLog>(form, apiType);
        }

        [HttpGet("warning")]
        public async Task<ActionResult> GetWarning([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<WarningLog>(WarningLog.GroupId, form, username, password);

        [HttpDelete("warning")]
        [HttpPost("warning")]
        [HttpPut("warning")]
        public async Task<ActionResult> PostWarning([FromBody] WarningLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(WarningLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<WarningLog>(form);
        }

        [HttpGet("monitor-region")]
        public async Task<ActionResult>
            GetMonitorRegion([FromBody] MinMaxDate form, string username, string password) =>
            await Get<MonitorRegionLog>(MonitorRegionLog.GroupId, form, username, password);

        [HttpDelete("monitor-region")]
        [HttpPost("monitor-region")]
        [HttpPut("monitor-region")]
        public async Task<ActionResult> PostMonitorRegion([FromBody] MonitorRegionLog form, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(MonitorRegionLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<MonitorRegionLog>(form);
        }

        [HttpGet("resolve-problem")]
        public async Task<ActionResult> GetResolveProblemLog([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<ResolveProblemLog>(ResolveProblemLog.GroupId, form, username, password);

        [HttpDelete("resolve-problem")]
        [HttpPost("resolve-problem")]
        [HttpPut("resolve-problem")]
        public async Task<ActionResult> PostResolveProblemLog([FromBody] ResolveProblemLog form, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(ResolveProblemLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<ResolveProblemLog>(form);
        }

        [HttpGet("uav-connect")]
        public async Task<ActionResult> GetUavConnectLog([FromBody] MinMaxDate form, string username,
            string password) =>
            await Get<UavConnectLog>(UavConnectLog.GroupId, form, username, password);

        [HttpDelete("uav-connect")]
        [HttpPost("uav-connect")]
        [HttpPut("uav-connect")]
        public async Task<ActionResult> PostUavConnectLog([FromBody] UavConnectLog form, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(UavConnectLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            return await Post<UavConnectLog>(form);
        }
    }
}