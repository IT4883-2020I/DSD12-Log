using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using aspnetcoreapp.Helpers;
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

        [HttpPost("drones/{type}")]
        [HttpPost("drones-has-problems/")]
        public async Task<ActionResult> PostDrone([FromBody] DroneLog form, string username, string password,
            string type)
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
                var apiType = Utility.GetTypeFromString(type);
                if (apiType == ApiType.Empty)
                {
                    return NotFound();
                }

                return await Post<DroneLog>(form, apiType);
            }
        }

        [HttpGet("payload")]
        public async Task<ActionResult> GetPayload([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<Payload, PayloadResponse>(Payload.GroupId, form, username, password);


        [HttpPost("payload/{type}")]
        public async Task<ActionResult> PostPayload([FromBody] Payload form, string username, string password,
            string type)
        {
            if (!_authService.IsAuthenticate(Payload.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<Payload>(form, apiType);
        }

        [HttpGet("user")]
        public async Task<ActionResult> GetUser([FromQuery] MinMaxDate form, string username,
            string password)
        {
            if (_authService.IsAuthenticate(UserLog.GroupId, username, password))
            {
                var list = await _dbContext.Set<UserLog>()
                    .Where(entity =>
                        entity.Timestamp <= form.MaxDate && entity.Timestamp >= form.MinDate &&
                        entity.Type != ApiType.ActivityLog)
                    .AsNoTracking()
                    .ToListAsync();
                var result = list.Select(entityLog => new UserLogResponse()
                    {
                        TargetId = entityLog.EntityId,
                        UserId = entityLog.UserId,
                        Metadata = entityLog.Metadata,
                        Description = entityLog.Description,
                        Type = entityLog.Type.GetDescription(),
                        Timestamp = entityLog.Timestamp.ToShortTimeString() + " " + entityLog.Timestamp.ToShortDateString(),
                    })
                    .ToList();
                return Ok(result);
            }
            else
            {
                return Unauthorized();
            }
        }


        [HttpPost("user/{type}")]
        public async Task<ActionResult> PostUser([FromBody] UserLogRequest form, string username, string password,
            string type)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (Request.Path.Value.Contains("user-role"))
            {
                apiType = ApiType.Role;
            }

            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }
            else
            {
                var userLog = new UserLog()
                {
                    EntityId = form.target_id,
                    Metadata = form.meta_data,
                    UserId = form.user_id,
                    Description = form.description,
                    Timestamp = DateTime.Now
                };
                return await Post<UserLog>(userLog, apiType);
            }
        }

        [HttpGet("video")]
        public async Task<ActionResult> GetVideo([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<VideoLog, VideoLogResponse>(VideoLog.GroupId, form, username, password);


        [HttpPost("video/{type}")]
        public async Task<ActionResult> PostVideo([FromBody] VideoLog form, string username, string password,
            string type)
        {
            if (!_authService.IsAuthenticate(VideoLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<VideoLog>(form, apiType);
        }

        [HttpGet("image")]
        public async Task<ActionResult> GetImage([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<ImageLog, ImageLogResponse>(ImageLog.GroupId, form, username, password);


        [HttpPost("image/{type}")]
        public async Task<ActionResult> PostImage([FromBody] ImageLog form, string username, string password,
            string type)
        {
            if (!_authService.IsAuthenticate(ImageLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<ImageLog>(form, apiType);
        }

        [HttpGet("incident")]
        public async Task<ActionResult> GetIncident([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<IncidentLog, IncidentLogResponse>(IncidentLog.GroupId, form, username, password);


        [HttpPost("incident/{type}")]
        [HttpPost("incident-confirm/")]
        public async Task<ActionResult> PostIncident([FromBody] IncidentLog form, string username, string password,
            string type)
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

            apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<IncidentLog>(form, apiType);
        }

        [HttpGet("monitor-object")]
        public async Task<ActionResult>
            GetObjectObserve([FromQuery] MinMaxDate form, string username, string password) =>
            await Get<ObjectObserve, ObjectObserveResponse>(ObjectObserve.GroupId, form, username, password);


        [HttpPost("monitor-object/{type}")]
        public async Task<ActionResult> PostObjectObserve([FromBody] ObjectObserve form, string username,
            string password, string type)
        {
            if (!_authService.IsAuthenticate(ObjectObserve.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<ObjectObserve>(form, apiType);
        }

        [HttpGet("receive-statistical")]
        public async Task<ActionResult> GetStatical([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<StaticalLog, StaticalLogResponse>(StaticalLog.GroupId, form, username, password);

        [HttpPost("statistical-frequence/")]
        [HttpPost("statistical-address/")]
        [HttpPost("statistical-incident/")]
        public async Task<ActionResult> PostStatical([FromBody] StaticalLog form, string username,
            string password, string type)
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


        [HttpPost("warning/{type}")]
        [HttpPost("warning-level/")]
        [HttpPost("solution-handling-warning/")]
        public async Task<ActionResult> PostWarning([FromBody] WarningLog form, string username,
            string password, string type)
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

            apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<WarningLog>(form, apiType);
        }

        [HttpGet("monitor-region")]
        public async Task<ActionResult>
            GetMonitorRegion([FromQuery] MinMaxDate form, string username, string password) =>
            await Get<MonitorRegionLog, MonitorRegionLogResponse>(MonitorRegionLog.GroupId, form, username, password);

        [HttpPost("monitor-region/{type}")]
        public async Task<ActionResult> PostMonitorRegion([FromBody] MonitorRegionLog form, string username,
            string password, string type)
        {
            if (!_authService.IsAuthenticate(MonitorRegionLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<MonitorRegionLog>(form, apiType);
        }

        [HttpGet("resolve-problem")]
        public async Task<ActionResult> GetResolveProblemLog([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<ResolveProblemLog, ResolveProblemLogResponse>(ResolveProblemLog.GroupId, form, username,
                password);


        [HttpPost("resolve-problem/{type}")]
        [HttpPost("result-resolve-problem/")]
        public async Task<ActionResult> PostResolveProblemLog([FromBody] ResolveProblemLog form,
            string username,
            string password, string type)
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

            apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<ResolveProblemLog>(form, apiType);
        }

        [HttpGet("uav-connect")]
        public async Task<ActionResult> GetUavConnectLog([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<UavConnectLog, UavConnectLogResponse>(UavConnectLog.GroupId, form, username, password);


        [HttpPost("uav-connect/{type}")]
        public async Task<ActionResult> PostUavConnectLog([FromBody] UavConnectLog form, string username,
            string password, string type)
        {
            if (!_authService.IsAuthenticate(UavConnectLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromString(type);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<UavConnectLog>(form, apiType);
        }
    }
}