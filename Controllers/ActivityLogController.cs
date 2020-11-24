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

namespace aspnetcoreapp.Controllers
{
    [Route("api")]
    public class ActivityLogController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly AuthenticationService _authService;
        private readonly IMapper _autoMapper;

        public ActivityLogController(ApplicationDbContext dbContext, IMapper autoMapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _authService = new AuthenticationService(configuration);
            _autoMapper = autoMapper;
        }

        public struct GetForm
        {
            public DateTime MinDate { get; set; }
            public DateTime MaxDate { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost("activity/drone")]
        public async Task<ActionResult> PostDroneLog([FromBody] DroneLogRequest form)
        {
            if (!_authService.IsAuthenticateByEntityName("drone", form.Username, form.Password))
            {
                return Unauthorized();
            }

            var log = _autoMapper.Map<DroneLog>(form);
            log.Type = ApiType.ActivityLog;
            log.Timestamp = DateTime.Now;
            _dbContext.DroneLogs.Add(log);
            await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                id = log.EntityId,
                type = ApiType.ActivityLog.GetDescription()
            });
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
        public async Task<ActionResult> GetDroneLog([FromBody] GetForm form)
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
        public async Task<ActionResult> PostUserLog([FromBody] UserLogRequest form)
        {
            if (!_authService.IsAuthenticateByEntityName("user", form.Username, form.Password))
            {
                return Unauthorized();
            }

            var log = _autoMapper.Map<UserLog>(form);
            log.Type = ApiType.ActivityLog;
            log.Timestamp = DateTime.Now;
            _dbContext.UserLog.Add(log);
            await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                id = log.EntityId,
                type = ApiType.ActivityLog.GetDescription()
            });
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
        public async Task<ActionResult> GetUserLog([FromBody] GetForm form)
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
                            Name = log.Name,
                            Type = log.Type.GetDescription(),
                            Description = log.Description,
                            Timestamp = log.Timestamp.ToShortTimeString() + " " + log.Timestamp.ToShortDateString(),
                            Role = log.Role,
                            WorkName = log.WorkName
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
        public async Task<ActionResult> PostActivityLog(string groupName, [FromBody] EntityStateLogInput form)
        {
            if (!_authService.IsAuthenticateByEntityName(groupName, form.UserName, form.Password))
            {
                return Unauthorized();
            }

            var log = _autoMapper.Map<EntityStateLog>(form);
            log.Type = ApiType.ActivityLog;
            log.Timestamp = DateTime.Now;
            switch (groupName)
            {
                case "payload":
                    _dbContext.Payload.Add(_autoMapper.Map<Payload>(log));
                    break;
                case "image-log":
                    _dbContext.ImageLog.Add(_autoMapper.Map<ImageLog>(log));
                    break;
                case "video-log":
                    _dbContext.VideoLog.Add(_autoMapper.Map<VideoLog>(log));
                    break;
                case "incident":
                    _dbContext.IncidentLog.Add(_autoMapper.Map<IncidentLog>(log));
                    break;
                case "object-observe":
                    _dbContext.ObjectObserve.Add(_autoMapper.Map<ObjectObserve>(log));
                    break;
                case "statical":
                    _dbContext.StaticalLog.Add(_autoMapper.Map<StaticalLog>(log));
                    break;
                case "warning":
                    _dbContext.WarningLog.Add(_autoMapper.Map<WarningLog>(log));
                    break;
                case "monitor-region":
                    _dbContext.MonitorRegionLog.Add(_autoMapper.Map<MonitorRegionLog>(log));
                    break;
                case "resolve-problem":
                    _dbContext.ResolveProblemLog.Add(_autoMapper.Map<ResolveProblemLog>(log));
                    break;
                case "uav-connect":
                    _dbContext.UavConnectLog.Add(_autoMapper.Map<UavConnectLog>(log));
                    break;
            }

            await _dbContext.SaveChangesAsync();
            return Ok(new
            {
                id = log.EntityId,
                type = ApiType.ActivityLog.GetDescription()
            });
        }

        [HttpGet("activity/{groupName}")]
        public async Task<ActionResult> GetActivityLog(string groupName, [FromBody] GetForm form)
        {
            if (_authService.IsAuthenticateByEntityName(groupName, form.Username, form.Password))
            {
                List<EntityStateLog> list = null;
                switch (groupName)
                {
                    case "payload":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.Payload.ToListAsync());
                        break;
                    case "image-log":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.ImageLog.ToListAsync());
                        break;
                    case "video-log":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.VideoLog.ToListAsync());
                        break;
                    case "incident":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.IncidentLog.ToListAsync());
                        break;
                    case "object-observe":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.ObjectObserve.ToListAsync());
                        break;
                    case "statical":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.StaticalLog.ToListAsync());
                        break;
                    case "warning":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.WarningLog.ToListAsync());
                        break;
                    case "monitor-region":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.MonitorRegionLog.ToListAsync());
                        break;
                    case "resolve-problem":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.ResolveProblemLog.ToListAsync());
                        break;
                    case "uav-connect":
                        list = _autoMapper.Map<List<EntityStateLog>>(await _dbContext.UavConnectLog.ToListAsync());
                        break;
                }

                if (list != null)
                {
                    var logs = from log in list
                        where log.Type == ApiType.ActivityLog
                        where log.Timestamp >= form.MinDate
                        where log.Timestamp <= form.MaxDate
                        select log;
                    var result = new List<EntityStateLogDTO>();
                    foreach (var log in logs)
                    {
                        result.Add(new EntityStateLogDTO
                        {
                            EntityId = log.EntityId,
                            Type = log.Type.GetDescription(),
                            State = log.State,
                            Name = log.Name,
                            Description = log.Description,
                            Timestamp = log.Timestamp.ToShortTimeString() + " " + log.Timestamp.ToShortDateString()
                        });
                    }

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