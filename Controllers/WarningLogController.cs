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
    public class WarningLogController : CustomController
    {
        public WarningLogController(ILogger<WarningLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        [HttpGet("warning")]
        public async Task<ActionResult<List<WarningLogResponse>>> GetWarning([FromQuery] MinMaxDate form, string? regionId,
            string? warningId,
            string projectType)
        {
            var listEntity = await GetEntity<WarningLog, WarningLogResponse>(ObjectObserve.GroupId, form, projectType);

            return (listEntity.Where(entity =>
                (regionId == null || entity.RegionId == regionId) &&
                (warningId == null || entity.EntityId == warningId)).ToList());
        }

        [HttpPost("warning/delete")]
        [HttpPost("warning/edit")]
        [HttpPost("warning/activity")]
        [HttpPost("warning/add")]
        [HttpPost("warning-level")]
        [HttpPost("solution-handling-warning")]
        public async Task<ActionResult> PostWarning([FromBody] WarningLogRequest request)
        {
            if (!_authService.IsAuthenticate(WarningLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<WarningLog>(request);
            var apiType = LogType.Empty;
            if (Request.Path.Value.Contains("warning-level"))
            {
                apiType = LogType.WarningLevel;
            }
            else if (Request.Path.Value.Contains("solution-handling-warning"))
            {
                apiType = LogType.SolutionHandling;
            }

            apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<WarningLog>(form, apiType);
        }
    }
}