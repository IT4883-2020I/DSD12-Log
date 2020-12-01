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
        public async Task<ActionResult> GetDrone([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<DroneLog, DroneLogResponse>(DroneLog.GroupId, form, username, password);

        [HttpDelete("drones/")]
        [HttpPost("drones/")]
        [HttpPost("drones-has-problems/")]
        [HttpPut("drones/")]
        public async Task<ActionResult> PostDrone([FromBody] DroneLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(DroneLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var route = Request.Path.Value;
            if (route.Contains("drones-has-problems"))
            {
                return await Post<DroneLog>(form, ApiType.HasProblem);
            }
            else
            {
                return await Post<DroneLog>(form);
            }
        }

        [HttpGet("payload")]
        public async Task<ActionResult> GetPayload([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<Payload, PayloadResponse>(Payload.GroupId, form, username, password);

        [HttpDelete("payload/")]
        [HttpPost("payload/")]
        [HttpPut("payload/")]
        public async Task<ActionResult> PostPayload([FromBody] Payload form, string username, string password)
        {
            if (!_authService.IsAuthenticate(Payload.GroupId, username, password))
            {
                return Unauthorized();
            }
            
            return await Post<Payload>(form);
        }

        [HttpGet("user")]
        public async Task<ActionResult> GetUser([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<UserLog, UserLogResponse>(UserLog.GroupId, form, username, password);

        [HttpDelete("user/")]
        [HttpPost("user/")]
        [HttpPost("user-role/")]
        [HttpPut("user/")]
        public async Task<ActionResult> PostUser([FromBody] UserLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("user-role"))
            {
                apiType = ApiType.Role;
            }

            return await Post<UserLog>(form, apiType);
        }

        [HttpGet("video")]
        public async Task<ActionResult> GetVideo([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<VideoLog, VideoLogResponse>(VideoLog.GroupId, form, username, password);

        [HttpDelete("video/")]
        [HttpPost("video/")]
        [HttpPut("video/")]
        public async Task<ActionResult> PostVideo([FromBody] VideoLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(VideoLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            return await Post<VideoLog>(form);
        }

        [HttpGet("image")]
        public async Task<ActionResult> GetImage([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<ImageLog, ImageLogResponse>(ImageLog.GroupId, form, username, password);

        [HttpDelete("image/")]
        [HttpPost("image/")]
        [HttpPut("image/")]
        public async Task<ActionResult> PostImage([FromBody] ImageLog form, string username, string password)
        {
            if (!_authService.IsAuthenticate(ImageLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            return await Post<ImageLog>(form);
        }

        [HttpGet("incident")]
        public async Task<ActionResult> GetIncident([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<IncidentLog, IncidentLogResponse>(IncidentLog.GroupId, form, username, password);

        [HttpDelete("incident/")]
        [HttpPost("incident/")]
        [HttpPost("incident-confirm/")]
        [HttpPut("incident/")]
        public async Task<ActionResult> PostIncident([FromBody] IncidentLog form, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(IncidentLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("incident-confirm"))
            {
                apiType = ApiType.Confirm;
            }

            return await Post<IncidentLog>(form, apiType);
        }

        [HttpGet("monitor-object")]
        public async Task<ActionResult>
            GetObjectObserve([FromQuery] MinMaxDate form, string username, string password) =>
            await Get<ObjectObserve, ObjectObserveResponse>(ObjectObserve.GroupId, form, username, password);

        [HttpDelete("monitor-object/")]
        [HttpPost("monitor-object/")]
        [HttpPut("monitor-object/")]
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
        public async Task<ActionResult> GetStatical([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<StaticalLog, StaticalLogResponse>(StaticalLog.GroupId, form, username, password);

        [HttpPost("statistical-frequence/")]
        [HttpPost("statistical-address/")]
        [HttpPost("statistical-incident/")]
        public async Task<ActionResult> PostStatical([FromBody] StaticalLog form, string username,
            string password)
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
        public async Task<ActionResult> GetWarning([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<WarningLog, WarningLogResponse>(WarningLog.GroupId, form, username, password);

        [HttpDelete("warning/")]
        [HttpPost("warning/")]
        [HttpPost("warning-level/")]
        [HttpPost("solution-handling-warning/")]
        [HttpPut("warning/")]
        public async Task<ActionResult> PostWarning([FromBody] WarningLog form, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(WarningLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("warning-level"))
            {
                apiType = ApiType.WarningLevel;
            }
            else if (Request.Path.Value.Contains("solution-handling-warning"))
            {
                apiType = ApiType.SolutionHandling;
            }

            return await Post<WarningLog>(form, apiType);
        }

        [HttpGet("monitor-region")]
        public async Task<ActionResult>
            GetMonitorRegion([FromQuery] MinMaxDate form, string username, string password) =>
            await Get<MonitorRegionLog, MonitorRegionLogResponse>(MonitorRegionLog.GroupId, form, username, password);

        [HttpDelete("monitor-region/")]
        [HttpPost("monitor-region/")]
        [HttpPut("monitor-region/")]
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
        public async Task<ActionResult> GetResolveProblemLog([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<ResolveProblemLog, ResolveProblemLogResponse>(ResolveProblemLog.GroupId, form, username,
                password);

        [HttpDelete("resolve-problem/")]
        [HttpPost("resolve-problem/")]
        [HttpPost("result-resolve-problem/")]
        [HttpPut("resolve-problem/")]
        public async Task<ActionResult> PostResolveProblemLog([FromBody] ResolveProblemLog form,
            string username,
            string password)
        {
            if (!_authService.IsAuthenticate(ResolveProblemLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("result-resolve-problem"))
            {
                apiType = ApiType.ResultResolveProblem;
            }

            return await Post<ResolveProblemLog>(form, apiType);
        }

        [HttpGet("uav-connect")]
        public async Task<ActionResult> GetUavConnectLog([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<UavConnectLog, UavConnectLogResponse>(UavConnectLog.GroupId, form, username, password);

        [HttpDelete("uav-connect/")]
        [HttpPost("uav-connect/")]
        [HttpPut("uav-connect/")]
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