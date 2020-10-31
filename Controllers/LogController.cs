using System;
using System.Collections.Generic;
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
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly AuthenticationService _authService;

        
        
        private List<Route> Routes { get; } = new List<Route>
        {
            new Route{R="drones", T=ApiType.Get, G=1},
            new Route{R="drones", T=ApiType.Add, G=1},
            new Route{R="drones", T=ApiType.Edit, G=1},
            new Route{R="drones", T=ApiType.Delete, G=1},
            new Route{R="drones-change-schedule", T=ApiType.ChangeSchedule, G=1},
            new Route{R="drones-has-problems", T=ApiType.HasProblem, G=1},

            new Route{R="payload", T=ApiType.Get, G=2},
            new Route{R="payload", T=ApiType.Add, G=2},
            new Route{R="payload", T=ApiType.Edit, G=2},
            new Route{R="payload", T=ApiType.Delete, G=2},
            new Route{R="payload-register", T=ApiType.Register, G=2},

            new Route{R="user", T=ApiType.Get, G=3},
            new Route{R="user", T=ApiType.Add, G=3},
            new Route{R="user", T=ApiType.Edit, G=3},
            new Route{R="user", T=ApiType.Delete, G=3},
            new Route{R="user-work", T=ApiType.Work, G=3},
            new Route{R="user-role", T=ApiType.Role, G=3},

            new Route{R="image", T=ApiType.Get, G=4},
            new Route{R="image", T=ApiType.Add, G=4},
            new Route{R="image", T=ApiType.Delete, G=4},
            new Route{R="image-result", T=ApiType.Result, G=4},
            new Route{R="video", T=ApiType.Get, G=4},
            new Route{R="video", T=ApiType.Add, G=4},
            new Route{R="video", T=ApiType.Delete, G=4},
            new Route{R="video-result", T=ApiType.Result, G=4},

            new Route{R="incident", T=ApiType.Get, G=5},
            new Route{R="incident", T=ApiType.Add, G=5},
            new Route{R="incident", T=ApiType.Edit, G=5},
            new Route{R="incident-confirm", T=ApiType.Confirm, G=5},
            new Route{R="incident-update-progress", T=ApiType.Confirm, G=5},

            new Route{R="monitor-object", T=ApiType.Get, G=6},
            new Route{R="monitor-object", T=ApiType.Add, G=6},
            new Route{R="monitor-object", T=ApiType.Edit, G=6},
            new Route{R="monitor-object", T=ApiType.Delete, G=6},
            new Route{R="monitor-object-change-state", T=ApiType.ChangeState, G=6},

            new Route{R="receive-statistical", T=ApiType.Get, G=7},
            new Route{R="statistical-address", T=ApiType.HasProblem, G=7},
            new Route{R="statistical-incident", T=ApiType.CommonIncident, G=7},
            new Route{R="statistical-frequence", T=ApiType.FrequenceIncident, G=7},
            new Route{R="export-report", T=ApiType.ExportReport, G=7},

            new Route{R="warning", T=ApiType.Get, G=8},
            new Route{R="warning-level", T=ApiType.WarningLevel, G=8},
            new Route{R="solution-handling-warning", T=ApiType.SolutionHandling, G=8},
            new Route{R="update-status-warning", T=ApiType.Edit, G=8},
            new Route{R="warning", T=ApiType.Delete, G=8},

            new Route{R="monitor-region", T=ApiType.Get, G=10},
            new Route{R="monitor-region", T=ApiType.Add, G=10},
            new Route{R="monitor-region", T=ApiType.Edit, G=10},
            new Route{R="monitor-region", T=ApiType.Delete, G=10},
            new Route{R="devide-monitor-region", T=ApiType.DevideRegion, G=10},

            new Route{R="resolve-problem", T=ApiType.Get, G=11},
            new Route{R="resolve-problem", T=ApiType.Add, G=11},
            new Route{R="resolve-problem", T=ApiType.Delete, G=11},
            new Route{R="update-status-resolve-problem", T=ApiType.UpdateStatusResolveProblem, G=11},
            new Route{R="staff-resolve-problem", T=ApiType.StaffResolveProblem, G=11},
            new Route{R="result-resolve-problem", T=ApiType.ResultResolveProblem, G=11},

            new Route{R="uav-connect", T=ApiType.Get, G=12},
            new Route{R="uav-connect", T=ApiType.Add, G=12},
            new Route{R="uav-connect", T=ApiType.Delete, G=12},
            new Route{R="success-connect", T=ApiType.SuccessConnect, G=12},
            new Route{R="fail-connect", T=ApiType.FailConnect, G=12}
        };

        private async Task AddLog(EntityLog entity, Route route)
        {
            switch (route.G)
            {
                case 1:
                    _dbContext.Set<DroneLog>().Add((_mapper.Map<DroneLog>(entity)));
                    break;
                case 2:
                    _dbContext.Set<Payload>().Add(_mapper.Map<Payload>(entity));
                    break;
                case 3:
                    _dbContext.Set<UserLog>().Add(_mapper.Map<UserLog>(entity));
                    break;
                case 4:
                    switch (route.R)
                    {
                        case "image":
                        case "image-result":
                            _dbContext.Set<ImageLog>().Add(_mapper.Map<ImageLog>(entity));
                            break;
                        case "video":
                        case "video-result":
                            _dbContext.Set<VideoLog>().Add(_mapper.Map<VideoLog>(entity));
                            break;
                    }
                    break;
                case 5:
                    _dbContext.Set<IncidentLog>().Add(_mapper.Map<IncidentLog>(entity));
                    break;
                case 6:
                    _dbContext.Set<ObjectObserve>().Add(_mapper.Map<ObjectObserve>(entity));
                    break;
                case 7:
                    _dbContext.Set<StaticalLog>().Add(_mapper.Map<StaticalLog>(entity));
                    break;
                case 8:
                    _dbContext.Set<WarningLog>().Add(_mapper.Map<WarningLog>(entity));
                    break;
                case 10:
                    _dbContext.Set<MonitorRegionLog>().Add(_mapper.Map<MonitorRegionLog>(entity));
                    break;
                case 11:
                    _dbContext.Set<ResolveProblemLog>().Add(_mapper.Map<ResolveProblemLog>(entity));
                    break;
                case 12:
                    _dbContext.Set<UavConnectLog>().Add(_mapper.Map<UavConnectLog>(entity));
                    break;
            }
            await _dbContext.SaveChangesAsync();
        }

        public LogController(ILogger<LogController> logger, ApplicationDbContext dbContext, IMapper mapper,IConfiguration configuration)
        {
            _logger = logger;
            this._dbContext = dbContext;
            this._mapper = mapper;
            _configuration = configuration;
            _authService = new AuthenticationService(configuration);
        }
        
        public struct GetForm    
        {
            public DateTime MinDate { get; set; }
            public DateTime MaxDate { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
        [HttpGet("{routeName}")]
        public async Task<ActionResult<List<EntityLogDTO>>> Get(string routeName, [FromBody] GetForm getForm)
        {
            _logger.LogInformation(getForm.ToJson());
            List<EntityLog> entities = new List<EntityLog>();
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T == ApiType.Get)
                {
                    if (_authService.IsAuthenticate(routeE.G, getForm.Username, getForm.Password))
                    {
                        switch (routeE.G)
                        {
                            case 1:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<DroneLog>().AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 2:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<Payload>().AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 3:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<UserLog>().AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 4:
                                switch (routeName)
                                {
                                    case "image":
                                        entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<ImageLog>()
                                            .AsNoTracking()
                                            .ToListAsync());
                                        break;
                                    case "video":
                                        entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<VideoLog>()
                                            .AsNoTracking()
                                            .ToListAsync());
                                        break;
                                }

                                break;
                            case 5:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<IncidentLog>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 6:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<ObjectObserve>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 7:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<StaticalLog>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 8:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<WarningLog>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 10:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<MonitorRegionLog>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 11:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<ResolveProblemLog>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                            case 12:
                                entities = _mapper.Map<List<EntityLog>>(await _dbContext.Set<UavConnectLog>()
                                    .AsNoTracking()
                                    .ToListAsync());
                                break;
                        }

                        var result = new List<EntityLogDTO>();
                        foreach (var entity in entities)
                        {
                            if (getForm.MinDate <= entity.Timestamp && entity.Timestamp <= getForm.MaxDate)
                            {
                                EntityLogDTO dto = new EntityLogDTO()
                                {
                                    EntityId = entity.EntityId,
                                    Type = entity.Type.GetDescription(),
                                    Description = entity.Description,
                                    Timestamp = entity.Timestamp.ToShortTimeString() + " " +
                                                entity.Timestamp.ToShortDateString()
                                };
                                result.Add(dto);
                            }
                        }

                        return result;
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }

            return Ok();
        }
        
        public struct UsernamePassword    
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
        [HttpPost("{routeName}/{id}")]
        public async Task<ActionResult> AddAddLog(string routeName, int id, string description, [FromBody] UsernamePassword form)
        {
           
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T != ApiType.Edit && routeE.T != ApiType.Delete && routeE.T != ApiType.Get)
                {
                    if (_authService.IsAuthenticate(routeE.G, form.Username, form.Password))
                    {
                        var log = new EntityLog
                        {
                            EntityId = id,
                            Type = routeE.T,
                            Description = description,
                            Timestamp = DateTime.Now
                        };
                        await AddLog(log, routeE);
                        return Ok();
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }
            return NotFound();
        }
        
        [HttpPut("{routeName}/{id}")]
        public async Task<ActionResult> AddEditLog(string routeName, int id, string description, [FromBody] UsernamePassword form)
        {
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T == ApiType.Edit)
                {
                    if (_authService.IsAuthenticate(routeE.G, form.Username, form.Password))
                    {
                        var log = new EntityLog
                        {
                            EntityId = id,
                            Type = routeE.T,
                            Description = description,
                            Timestamp = DateTime.Now
                        };
                        await AddLog(log, routeE);
                        return Ok();
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }
            return NotFound();
        }

        [HttpDelete("{routeName}/{id}")]
        public async Task<ActionResult> AddDeleteLog(string routeName, int id, string description, [FromBody] UsernamePassword form)
        {
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T == ApiType.Delete)
                {
                    if (_authService.IsAuthenticate(routeE.G, form.Username, form.Password))
                    {
                        var log = new EntityLog
                        {
                            EntityId = id,
                            Type = routeE.T,
                            Description = description,
                            Timestamp = DateTime.Now
                        };
                        await AddLog(log, routeE);
                        return Ok();
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
            }
            return NotFound();
        }
    }

    public struct Route
    {
        public string R { get; set; }
        public ApiType T { get; set; }
        public int G { get; set; }
    }
}