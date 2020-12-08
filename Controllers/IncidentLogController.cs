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
    public class IncidentLogController : CustomController
    {
        public IncidentLogController(ILogger<IncidentLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }


        [HttpGet("incident")]
        public async Task<ActionResult<List<IncidentLogResponse>>> GetIncident([FromQuery] MinMaxDate form, int? videoId, int? imageId,
            int? regionId,
            string projectType)
        {
            var listEntity = await GetEntity<IncidentLog, IncidentLogResponse>(ObjectObserve.GroupId, form, projectType);
            var result = new List<IncidentLogResponse>();
            foreach (var incidentLog in listEntity)
            {
                if ((videoId == null || incidentLog.VideoId == videoId) &&
                    (imageId == null || incidentLog.ImageId == imageId) &&
                    (regionId == null || incidentLog.RegionId == regionId))
                {
                    result.Add(incidentLog);
                }
            }

            return result;
        }


        [HttpPost("incident/delete")]
        [HttpPost("incident/edit")]
        [HttpPost("incident/activity")]
        [HttpPost("incident/add")]
        [HttpPost("incident-confirm")]
        public async Task<ActionResult> PostIncident([FromBody] IncidentLogRequest request)
        {
            if (!_authService.IsAuthenticate(IncidentLog.GroupId))
            {
                return Unauthorized();
            }

            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("incident-confirm"))
            {
                apiType = ApiType.Confirm;
            }

            var form = _mapper.Map<IncidentLog>(request);
            apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<IncidentLog>(form, apiType);
        }
    }
}