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
    public class MonitorRegionLogController : CustomController
    {
        public MonitorRegionLogController(ILogger<MonitorRegionLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }


        [HttpGet("monitor-region")]
        public async Task<ActionResult<List<MonitorRegionLogResponse>>>
            GetMonitorRegion([FromQuery] MinMaxDate form, string? regionId, string projectType)         {
            var listEntity =
                await GetEntity<MonitorRegionLog, MonitorRegionLogResponse>(MonitorRegionLog.GroupId, form, projectType);
            return (listEntity.Where(entity =>
                (regionId == null || entity.EntityId == regionId)).ToList());
        }

        [HttpPost("monitor-region/delete")]
        [HttpPost("monitor-region/edit")]
        [HttpPost("monitor-region/activity")]
        [HttpPost("monitor-region/add")]
        public async Task<ActionResult> PostMonitorRegion([FromBody] MonitorLogRequest request)
        {
            if (!_authService.IsAuthenticate(MonitorRegionLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<MonitorRegionLog>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<MonitorRegionLog>(form, apiType);
        }
    }
}