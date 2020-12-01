using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ActivityLogController : CustomController
    {
        public ActivityLogController(ILogger<ActivityLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        public class GetForm
        {
            public DateTime MinDate { get; set; } = DateTime.MinValue;
            public DateTime MaxDate { get; set; } = DateTime.MaxValue;
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost("activity/drone")]
        public async Task<ActionResult> PostDroneLog([FromBody] DroneLog form, string username, string password)
        {
            if (!_authService.IsAuthenticateByEntityName("drone", username, password))
            {
                return Unauthorized();
            }

            var log = _mapper.Map<DroneLog>(form);
            log.Type = ApiType.ActivityLog;
            log.Timestamp = DateTime.Now;
            _dbContext.DroneLogs.Add(log);
            await _dbContext.SaveChangesAsync();
            return Ok(form);
        }

        public class DroneLogDTO
        {
            public int EntityId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public string Timestamp { get; set; }
            public string RegionName { get; set; }
            public int Longitude { get; set; }
            public int Latitude { get; set; }
        }

        [HttpGet("activity/drone")]
        public async Task<ActionResult> GetDroneLog([FromQuery] GetForm form)
        {
            if (_authService.IsAuthenticate(1, form.Username, form.Password))
            {
                return Ok(await _dbContext.DroneLogs
                    .Where(log => log.Type == ApiType.ActivityLog)
                    .Where(log => log.Timestamp >= form.MinDate)
                    .Where(log => log.Timestamp <= form.MaxDate)
                    .Select(log => new DroneLogDTO
                    {
                        EntityId = log.EntityId,
                        Name = log.Name,
                        Type = log.Type.GetDescription(),
                        Description = log.Description,
                        Timestamp = log.Timestamp.ToShortTimeString() + " " + log.Timestamp.ToShortDateString(),
                        RegionName = log.RegionName,
                        Longitude = log.Longitude,
                        Latitude = log.Latitude
                    })
                    .AsNoTracking()
                    .ToListAsync());
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost("activity/user")]
        public async Task<ActionResult> PostUserLog([FromBody] UserLog log, string username, string password)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            log.Type = ApiType.ActivityLog;
            log.Timestamp = DateTime.Now;
            _dbContext.UserLog.Add(log);
            await _dbContext.SaveChangesAsync();
            return Ok(log);
        }


        public class UserLogDTO
        {
            public int EntityId { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
            public string Timestamp { get; set; }
            public string Role { get; set; }
            public string WorkName { get; set; }
        }

        [HttpGet("activity/user")]
        public async Task<ActionResult> GetUserLog([FromQuery] GetForm form)
        {
            if (_authService.IsAuthenticate(3, form.Username, form.Password))
            {
                return Ok(await _dbContext.UserLog
                    .Where(log => log.Type == ApiType.ActivityLog)
                    .Where(log => log.Timestamp >= form.MinDate)
                    .Where(log => log.Timestamp <= form.MaxDate).Select(log =>
                        new UserLogDTO
                        {
                            EntityId = log.EntityId,
                            Type = log.Type.GetDescription(),
                            Description = log.Description,
                            Timestamp = log.Timestamp.ToShortTimeString() + " " + log.Timestamp.ToShortDateString(),
                        }
                    )
                    .AsNoTracking()
                    .ToListAsync());
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost("activity/{groupName}")]
        public async Task<ActionResult> PostActivityLog(string groupName, [FromBody] EntityActivityLog form,
            string username, string password)
        {
            if (!_authService.IsAuthenticateByEntityName(groupName, username, password))
            {
                return Unauthorized();
            }

            var log = _mapper.Map<EntityActivityLog>(form);
            log.Type = ApiType.ActivityLog;
            log.Timestamp = DateTime.Now;
            switch (groupName)
            {
                case "payload":
                    _dbContext.Payloads.Add(_mapper.Map<Payload>(log));
                    break;
                case "image-log":
                    _dbContext.ImageLogs.Add(_mapper.Map<ImageLog>(log));
                    break;
                case "video-log":
                    _dbContext.VideoLogs.Add(_mapper.Map<VideoLog>(log));
                    break;
                case "incident":
                    _dbContext.IncidentLogs.Add(_mapper.Map<IncidentLog>(log));
                    break;
                case "object-observe":
                    _dbContext.ObjectObserves.Add(_mapper.Map<ObjectObserve>(log));
                    break;
                case "statical":
                    _dbContext.StaticalLogs.Add(_mapper.Map<StaticalLog>(log));
                    break;
                case "warning":
                    _dbContext.WarningLogs.Add(_mapper.Map<WarningLog>(log));
                    break;
                case "monitor-region":
                    _dbContext.MonitorRegionLogs.Add(_mapper.Map<MonitorRegionLog>(log));
                    break;
                case "resolve-problem":
                    _dbContext.ResolveProblemLogs.Add(_mapper.Map<ResolveProblemLog>(log));
                    break;
                case "uav-connect":
                    _dbContext.UavConnectLogs.Add(_mapper.Map<UavConnectLog>(log));
                    break;
            }

            await _dbContext.SaveChangesAsync();
            return Ok(form);
        }

        [HttpGet("activity/{groupName}")]
        public async Task<ActionResult> GetActivityLog(string groupName, [FromQuery] GetForm form)
        {
            if (_authService.IsAuthenticateByEntityName(groupName, form.Username, form.Password))
            {
                List<EntityActivityLog> list = groupName switch
                {
                    "payload" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.Payloads.ToListAsync()),
                    "image-log" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.ImageLogs.ToListAsync()),
                    "video-log" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.VideoLogs.ToListAsync()),
                    "incident" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.IncidentLogs.ToListAsync()),
                    "object-observe" => _mapper.Map<List<EntityActivityLog>>(
                        await _dbContext.ObjectObserves.ToListAsync()),
                    "statical" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.StaticalLogs.ToListAsync()),
                    "warning" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.WarningLogs.ToListAsync()),
                    "monitor-region" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.MonitorRegionLogs
                        .ToListAsync()),
                    "resolve-problem" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.ResolveProblemLogs
                        .ToListAsync()),
                    "uav-connect" => _mapper.Map<List<EntityActivityLog>>(await _dbContext.UavConnectLogs.ToListAsync()),
                    _ => null
                };

                if (list != null)
                {
                    var logs = from log in list
                        where log.Type == ApiType.ActivityLog
                        where log.Timestamp >= form.MinDate
                        where log.Timestamp <= form.MaxDate
                        select log;
                    var result = logs.Select(log => new EntityActivityLogDTO
                        {
                            EntityId = log.EntityId,
                            Type = log.Type.GetDescription(),
                            State = log.State,
                            Description = log.Description,
                            Timestamp = log.Timestamp.ToShortTimeString() + " " + log.Timestamp.ToShortDateString()
                        })
                        .ToList();

                    return Ok(result);
                }
                else
                {
                    return Ok();
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        // [HttpPost("activity/payload")]
        // public async Task<ActionResult> PostPayLoadLog([FromBody] Payload log)
        // {
        //     
        //     log.Type = ApiType.ActivityLog;
        //     log.Timestamp = DateTime.Now;
        //     _dbContext.Payload.Add(log);
        //     await _dbContext.SaveChangesAsync();
        //     return Ok(new
        //     {
        //         id = log.EntityId,
        //         type = ApiType.ActivityLog.GetDescription()
        //     });
        // }
        //
        // [HttpGet("activity/payload")]
        // public async Task<ActionResult> GetPayloadLog([FromBody] GetForm form)
        // {
        //     if (_authService.IsAuthenticate(2, form.Username, form.Password))
        //     {
        //         return Ok(await _dbContext.Payload
        //             .Where(log => log.Type == ApiType.ActivityLog)
        //             .Where(log => log.Timestamp >= form.MinDate)
        //             .Where(log => log.Timestamp <= form.MaxDate)
        //             .AsNoTracking()
        //             .ToListAsync());
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
        //
        // [HttpPost("activity/incident")]
        // public async Task<ActionResult> PostIncidentLog([FromBody] IncidentLog log)
        // {
        //     log.Type = ApiType.ActivityLog;
        //     log.Timestamp = DateTime.Now;
        //     _dbContext.IncidentLog.Add(log);
        //     await _dbContext.SaveChangesAsync();
        //     return Ok(new
        //     {
        //         id = log.EntityId,
        //         type = ApiType.ActivityLog.GetDescription()
        //     });
        // }
        //
        // [HttpGet("activity/incident")]
        // public async Task<ActionResult> GetIncidentLog([FromBody] GetForm form)
        // {
        //     if (_authService.IsAuthenticate(5, form.Username, form.Password))
        //     {
        //         return Ok(await _dbContext.IncidentLog
        //             .Where(log => log.Type == ApiType.ActivityLog)
        //             .Where(log => log.Timestamp >= form.MinDate)
        //             .Where(log => log.Timestamp <= form.MaxDate)
        //             .AsNoTracking()
        //             .ToListAsync());
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
        //
        // [HttpPost("activity/object-observe")]
        // public async Task<ActionResult> PostObjectObserve([FromBody] ObjectObserve log)
        // {
        //     log.Type = ApiType.ActivityLog;
        //     log.Timestamp = DateTime.Now;
        //     _dbContext.ObjectObserve.Add(log);
        //     await _dbContext.SaveChangesAsync();
        //     return Ok(new
        //     {
        //         id = log.EntityId,
        //         type = ApiType.ActivityLog.GetDescription()
        //     });
        // }
        //
        // [HttpGet("activity/object-observe")]
        // public async Task<ActionResult> GetObjectObserve([FromBody] GetForm form)
        // {
        //     if (_authService.IsAuthenticate(6, form.Username, form.Password))
        //     {
        //         return Ok(await _dbContext.ObjectObserve
        //             .Where(log => log.Type == ApiType.ActivityLog)
        //             .Where(log => log.Timestamp >= form.MinDate)
        //             .Where(log => log.Timestamp <= form.MaxDate)
        //             .AsNoTracking()
        //             .ToListAsync());
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
        //
        // [HttpPost("activity/warning")]
        // public async Task<ActionResult> PostWarningLog([FromBody] WarningLog log)
        // {
        //     log.Type = ApiType.ActivityLog;
        //     log.Timestamp = DateTime.Now;
        //     _dbContext.WarningLog.Add(log);
        //     await _dbContext.SaveChangesAsync();
        //     return Ok(new
        //     {
        //         id = log.EntityId,
        //         type = ApiType.ActivityLog.GetDescription()
        //     });
        // }
        //
        // [HttpGet("activity/warning")]
        // public async Task<ActionResult> GetWarningLog([FromBody] GetForm form)
        // {
        //     if (_authService.IsAuthenticate(8, form.Username, form.Password))
        //     {
        //         return Ok(await _dbContext.WarningLog
        //             .Where(log => log.Type == ApiType.ActivityLog)
        //             .Where(log => log.Timestamp >= form.MinDate)
        //             .Where(log => log.Timestamp <= form.MaxDate)
        //             .AsNoTracking()
        //             .ToListAsync());
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
        //
        // [HttpPost("activity/resolve-problem")]
        // public async Task<ActionResult> PostResolveProblemLog([FromBody] ResolveProblemLog log)
        // {
        //     log.Type = ApiType.ActivityLog;
        //     log.Timestamp = DateTime.Now;
        //     _dbContext.ResolveProblemLog.Add(log);
        //     await _dbContext.SaveChangesAsync();
        //     return Ok(new
        //     {
        //         id = log.EntityId,
        //         type = ApiType.ActivityLog.GetDescription()
        //     });
        // }
        //
        // [HttpGet("activity/resolve-problem")]
        // public async Task<ActionResult> GetResolveProblemLog([FromBody] GetForm form)
        // {
        //     if (_authService.IsAuthenticate(11, form.Username, form.Password))
        //     {
        //         return Ok(await _dbContext.ResolveProblemLog
        //             .Where(log => log.Type == ApiType.ActivityLog)
        //             .Where(log => log.Timestamp >= form.MinDate)
        //             .Where(log => log.Timestamp <= form.MaxDate)
        //             .AsNoTracking()
        //             .ToListAsync());
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
        //
        // [HttpPost("activity/uav-connect")]
        // public async Task<ActionResult> PostUavConnectLog([FromBody] UavConnectLog log)
        // {
        //     log.Type = ApiType.ActivityLog;
        //     log.Timestamp = DateTime.Now;
        //     _dbContext.UavConnectLog.Add(log);
        //     await _dbContext.SaveChangesAsync();
        //     return Ok(new
        //     {
        //         id = log.EntityId,
        //         type = ApiType.ActivityLog.GetDescription()
        //     });
        // }
        //
        // [HttpGet("activity/uav-connect")]
        // public async Task<ActionResult> GetUavConnectLog([FromBody] GetForm form)
        // {
        //     if (_authService.IsAuthenticate(12, form.Username, form.Password))
        //     {
        //         return Ok(await _dbContext.UavConnectLog
        //             .Where(log => log.Type == ApiType.ActivityLog)
        //             .Where(log => log.Timestamp >= form.MinDate)
        //             .Where(log => log.Timestamp <= form.MaxDate)
        //             .AsNoTracking()
        //             .ToListAsync());
        //     }
        //     else
        //     {
        //         return Unauthorized();
        //     }
        // }
    }
}