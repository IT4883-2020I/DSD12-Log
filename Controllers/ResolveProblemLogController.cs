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
    public class ResolveProblemLogController : CustomController
    {
        public ResolveProblemLogController(ILogger<ResolveProblemLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        [HttpGet("resolve-problem")]
        public async Task<ActionResult<List<ResolveProblemLogResponse>>> GetResolveProblemLog(
            [FromQuery] MinMaxDate form, string? resolveProblemId, string? regionId,
            string projectType)
        {
            var listEntity =
                await GetEntity<ResolveProblemLog, ResolveProblemLogResponse>(ObjectObserve.GroupId, form, projectType);

            return (listEntity.Where(entity =>
                (regionId == null || entity.RegionId == regionId) &&
                (resolveProblemId == null || entity.EntityId == resolveProblemId)).ToList());
        }


        [HttpPost("resolve-problem/delete")]
        [HttpPost("resolve-problem/edit")]
        [HttpPost("resolve-problem/activity")]
        [HttpPost("resolve-problem/add")]
        [HttpPost("result-resolve-problem")]
        public async Task<ActionResult> PostResolveProblemLog([FromBody] ResolveProblemRequest request)
        {
            if (!_authService.IsAuthenticate(ResolveProblemLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<ResolveProblemLog>(request);
            var apiType = LogType.Empty;
            if (Request.Path.Value.Contains("result-resolve-problem"))
            {
                apiType = LogType.ResultResolveProblem;
            }

            apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<ResolveProblemLog>(form, apiType);
        }
    }
}