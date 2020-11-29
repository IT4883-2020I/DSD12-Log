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

        [HttpDelete("drones/{id}")]
        [HttpPost("drones/{id}")]
        [HttpPost("drones-has-problems/{id}")]
        [HttpPut("drones/{id}")]
        public async Task<ActionResult> PostDrone([FromBody] DroneLog form, int id, string username, string password)
        {
            if (!_authService.IsAuthenticate(DroneLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var route = Request.Path.Value;
            form.EntityId = id;
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

        [HttpDelete("payload/{id}")]
        [HttpPost("payload/{id}")]
        [HttpPut("payload/{id}")]
        public async Task<ActionResult> PostPayload([FromBody] Payload form, int id, string username, string password)
        {
            if (!_authService.IsAuthenticate(Payload.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
            return await Post<Payload>(form);
        }

        [HttpGet("user")]
        public async Task<ActionResult> GetUser([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<UserLog, UserLogResponse>(UserLog.GroupId, form, username, password);

        [HttpDelete("user/{id}")]
        [HttpPost("user/{id}")]
        [HttpPost("user-role/{id}")]
        [HttpPut("user/{id}")]
        public async Task<ActionResult> PostUser([FromBody] UserLog form, int id, string username, string password)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
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

        [HttpDelete("video/{id}")]
        [HttpPost("video/{id}")]
        [HttpPut("video/{id}")]
        public async Task<ActionResult> PostVideo([FromBody] VideoLog form, int id, string username, string password)
        {
            if (!_authService.IsAuthenticate(VideoLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
            return await Post<VideoLog>(form);
        }

        [HttpGet("image")]
        public async Task<ActionResult> GetImage([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<ImageLog, ImageLogResponse>(ImageLog.GroupId, form, username, password);

        [HttpDelete("image/{id}")]
        [HttpPost("image/{id}")]
        [HttpPut("image/{id}")]
        public async Task<ActionResult> PostImage([FromBody] ImageLog form, int id, string username, string password)
        {
            if (!_authService.IsAuthenticate(ImageLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
            return await Post<ImageLog>(form);
        }

        [HttpGet("incident")]
        public async Task<ActionResult> GetIncident([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<IncidentLog, IncidentLogResponse>(IncidentLog.GroupId, form, username, password);

        [HttpDelete("incident/{id}")]
        [HttpPost("incident/{id}")]
        [HttpPost("incident-confirm/{id}")]
        [HttpPut("incident/{id}")]
        public async Task<ActionResult> PostIncident([FromBody] IncidentLog form, int id, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(IncidentLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
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

        [HttpDelete("monitor-object/{id}")]
        [HttpPost("monitor-object/{id}")]
        [HttpPut("monitor-object/{id}")]
        public async Task<ActionResult> PostObjectObserve([FromBody] ObjectObserve form, int id, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(ObjectObserve.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
            return await Post<ObjectObserve>(form);
        }

        [HttpGet("receive-statistical")]
        public async Task<ActionResult> GetStatical([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<StaticalLog, StaticalLogResponse>(StaticalLog.GroupId, form, username, password);

        [HttpPost("statistical-frequence/{id}")]
        [HttpPost("statistical-address/{id}")]
        [HttpPost("statistical-incident/{id}")]
        public async Task<ActionResult> PostStatical([FromBody] StaticalLog form, int id, string username,
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

            form.EntityId = id;
            return await Post<StaticalLog>(form, apiType);
        }

        [HttpGet("warning")]
        public async Task<ActionResult> GetWarning([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<WarningLog, WarningLogResponse>(WarningLog.GroupId, form, username, password);

        [HttpDelete("warning/{id}")]
        [HttpPost("warning/{id}")]
        [HttpPost("warning-level/{id}")]
        [HttpPost("solution-handling-warning/{id}")]
        [HttpPut("warning/{id}")]
        public async Task<ActionResult> PostWarning([FromBody] WarningLog form, int id, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(WarningLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
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

        [HttpDelete("monitor-region/{id}")]
        [HttpPost("monitor-region/{id}")]
        [HttpPut("monitor-region/{id}")]
        public async Task<ActionResult> PostMonitorRegion([FromBody] MonitorRegionLog form, int id, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(MonitorRegionLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
            return await Post<MonitorRegionLog>(form);
        }

        [HttpGet("resolve-problem")]
        public async Task<ActionResult> GetResolveProblemLog([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<ResolveProblemLog, ResolveProblemLogResponse>(ResolveProblemLog.GroupId, form, username,
                password);

        [HttpDelete("resolve-problem/{id}")]
        [HttpPost("resolve-problem/{id}")]
        [HttpPost("result-resolve-problem/{id}")]
        [HttpPut("resolve-problem/{id}")]
        public async Task<ActionResult> PostResolveProblemLog([FromBody] ResolveProblemLog form, int id,
            string username,
            string password)
        {
            if (!_authService.IsAuthenticate(ResolveProblemLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
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

        [HttpDelete("uav-connect/{id}")]
        [HttpPost("uav-connect/{id}")]
        [HttpPut("uav-connect/{id}")]
        public async Task<ActionResult> PostUavConnectLog([FromBody] UavConnectLog form, int id, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(UavConnectLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            form.EntityId = id;
            return await Post<UavConnectLog>(form);
        }
    }
}