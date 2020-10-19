
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoreapp.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp.Controllers
{
    [Route("api")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> logger;
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

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
        };

        private async Task AddLog(EntityLog entity, Route route)
        {
            switch (route.G)
            {
                case 1:
                    dbContext.Set<DroneLog>().Add((mapper.Map<DroneLog>(entity)));
                    break;
                case 2:
                    dbContext.Set<Payload>().Add(mapper.Map<Payload>(entity));
                    break;
                case 3:
                    dbContext.Set<UserLog>().Add(mapper.Map<UserLog>(entity));
                    break;
                case 4:
                    if (route.R == "image" || route.R == "image-result")
                    {
                        dbContext.Set<ImageLog>().Add(mapper.Map<ImageLog>(entity));
                    }
                    else if (route.R == "video" || route.R == "video-result")
                    {
                        dbContext.Set<VideoLog>().Add(mapper.Map<VideoLog>(entity));
                    }
                    break;
                case 5:
                    dbContext.Set<IncidentLog>().Add(mapper.Map<IncidentLog>(entity));
                    break;
                case 6:
                    dbContext.Set<ObjectObserve>().Add(mapper.Map<ObjectObserve>(entity));
                    break;
            }
            await dbContext.SaveChangesAsync();
        }

        public LogController(ILogger<LogController> logger, ApplicationDbContext dbContext, IMapper mapper)
        {
            this.logger = logger;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        [HttpGet("{routeName}")]
        public async Task<ActionResult<List<EntityLogDTO>>> Get(string routeName)
        {
            List<EntityLog> entities = new List<EntityLog>();
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T == ApiType.Get)
                {
                    switch (routeE.G)
                    {
                        case 1:
                            entities = mapper.Map<List<EntityLog>>(await dbContext.Set<DroneLog>().AsNoTracking().ToListAsync());
                            break;
                        case 2:
                            entities = mapper.Map<List<EntityLog>>(await dbContext.Set<Payload>().AsNoTracking().ToListAsync());
                            break;
                        case 3:
                            entities = mapper.Map<List<EntityLog>>(await dbContext.Set<UserLog>().AsNoTracking().ToListAsync());
                            break;
                        case 4:
                            if (routeName == "image")
                            {
                                entities = mapper.Map<List<EntityLog>>(await dbContext.Set<ImageLog>().AsNoTracking().ToListAsync());
                            }
                            else if (routeName == "video")
                            {
                                entities = mapper.Map<List<EntityLog>>(await dbContext.Set<VideoLog>().AsNoTracking().ToListAsync());
                            }
                            break;
                        case 5:
                            entities = mapper.Map<List<EntityLog>>(await dbContext.Set<IncidentLog>().AsNoTracking().ToListAsync());
                            break;
                        case 6:
                            entities = mapper.Map<List<EntityLog>>(await dbContext.Set<ObjectObserve>().AsNoTracking().ToListAsync());
                            break;
                    }
                    var result = new List<EntityLogDTO>();
                    foreach (var entity in entities)
                    {
                        EntityLogDTO dto = new EntityLogDTO()
                        {
                            EntityId = entity.EntityId,
                            Type = entity.Type.getDescription(),
                            Description = entity.Description,
                            Timestamp = entity.Timestamp.ToShortTimeString() + " " + entity.Timestamp.ToShortDateString()
                        };
                        result.Add(dto);
                    }
                    return result;
                }
            }
            return Ok();
        }


        [HttpPost("{routeName}/{id}")]
        public async Task<ActionResult> AddAddLog(string routeName, int id, string description)
        {
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T != ApiType.Edit && routeE.T != ApiType.Delete && routeE.T != ApiType.Get)
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
            }
            return NotFound();
        }

        [HttpPut("{routeName}/{id}")]
        public async Task<ActionResult> AddEditLog(string routeName, int id, string description)
        {
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T == ApiType.Edit)
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
            }
            return NotFound();
        }

        [HttpDelete("{routeName}/{id}")]
        public async Task<ActionResult> AddDeleteLog(string routeName, int id, string description)
        {
            foreach (var routeE in Routes)
            {
                if (routeE.R == routeName && routeE.T == ApiType.Delete)
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