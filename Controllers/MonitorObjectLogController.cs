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
    public class MonitorObjectLogController : CustomController
    {
        public MonitorObjectLogController(ILogger<MonitorObjectLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        [HttpGet("monitor-object")]
        public async Task<ActionResult<List<ObjectObserveResponse>>>
            GetObjectObserve([FromQuery] MinMaxDate form, string? monitorObjectId, string? regionId, string projectType)
        {
            var listEntity =
                await GetEntity<ObjectObserve, ObjectObserveResponse>(ObjectObserve.GroupId, form, projectType);
            return (listEntity.Where(entity =>
                (regionId == null || entity.RegionId == regionId) &&
                (monitorObjectId == null || entity.EntityId == monitorObjectId)).ToList());
        }

        [HttpPost("monitor-object/delete")]
        [HttpPost("monitor-object/edit")]
        [HttpPost("monitor-object/activity")]
        [HttpPost("monitor-object/add")]
        public async Task<ActionResult> PostObjectObserve([FromBody] ObjectObserveRequest request)
        {
            if (!_authService.IsAuthenticate(ObjectObserve.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<ObjectObserve>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<ObjectObserve>(form, apiType);
        }
    }
}