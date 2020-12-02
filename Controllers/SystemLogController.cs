using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public class SystemLogController : ControllerBase
    {
        private ILogger<SystemLogController> _logger;
        private readonly ApplicationDbContext _dbContext;
        private IMapper _mapper;
        private IConfiguration _configuration;
        private AuthenticationService _authService;

        private ErrorLevel GetErrorLevelByUrl(string url)
        {
            return url.Split('/')[^1] switch
            {
                "error" => ErrorLevel.Error,
                "warning" => ErrorLevel.Warning,
                "critical" => ErrorLevel.Critical,
                _ => ErrorLevel.Empty,
            };
        }

        public SystemLogController(ILogger<SystemLogController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
            _authService = new AuthenticationService(configuration);
        }


        [HttpGet("system/all-logs")]
        public async Task<ActionResult> GetAllLogs()
        {
            var list = new ArrayList();
            var payloads = await _dbContext.Payloads.AsNoTracking().ToListAsync();
            var userLogs = await _dbContext.UserLog.AsNoTracking().ToListAsync();
            var imageLogs = await _dbContext.ImageLogs.AsNoTracking().ToListAsync();
            var videoLogs = await _dbContext.VideoLogs.AsNoTracking().ToListAsync();
            var incidentLogs = await _dbContext.IncidentLogs.AsNoTracking().ToListAsync();
            var observes = await _dbContext.ObjectObserves.AsNoTracking().ToListAsync();
            var staticalLogs = await _dbContext.StaticalLogs.AsNoTracking().ToListAsync();
            var warningLogs = await _dbContext.WarningLogs.AsNoTracking().ToListAsync();
            var monitorRegionLogs = await _dbContext.MonitorRegionLogs.AsNoTracking().ToListAsync();
            var resolveProblemLogs = await _dbContext.ResolveProblemLogs.AsNoTracking().ToListAsync();
            var uavConnectLogs = await _dbContext.UavConnectLogs.AsNoTracking().ToListAsync();
            var droneLogs = await _dbContext.DroneLogs.AsNoTracking().ToListAsync();
            list.AddRange(droneLogs);
            list.AddRange(payloads);
            list.AddRange(imageLogs);
            list.AddRange(videoLogs);
            list.AddRange(incidentLogs);
            list.AddRange(observes);
            list.AddRange(staticalLogs);
            list.AddRange(monitorRegionLogs);
            list.AddRange(resolveProblemLogs);
            list.AddRange(uavConnectLogs);
            list.Sort();
            return Ok(list);
        }

        public struct ErrorLogRequest
        {
            public string Description { get; set; }
        }

        [HttpPost("system/error-log/error")]
        [HttpPost("system/error-log/warning")]
        [HttpPost("system/error-log/critical")]
        public async Task<ActionResult> PostErrorLog([FromBody] ErrorLogRequest form)
        {
            var level = GetErrorLevelByUrl(Request.Path.Value);
            if (level == ErrorLevel.Empty)
            {
                return NotFound();
            }

            var systemLog = new SystemLog()
            {
                Level = level,
                Description = form.Description,
                TimeStamp = DateTime.Now
            };
            _dbContext.SystemLogs.Add(systemLog);
            await _dbContext.SaveChangesAsync();
            return Ok(systemLog);
        }

        [HttpGet("system/error-log")]
        public async Task<ActionResult> GetErrorLog()
        {
            return Ok(await _dbContext.SystemLogs.ToListAsync());
        }
    }
}