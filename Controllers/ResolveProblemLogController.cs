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
        public async Task<ActionResult> GetResolveProblemLog([FromQuery] MinMaxDate form) =>
            await Get<ResolveProblemLog, ResolveProblemLogResponse>(ResolveProblemLog.GroupId, form);


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
            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("result-resolve-problem"))
            {
                apiType = ApiType.ResultResolveProblem;
            }

            apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<ResolveProblemLog>(form, apiType);
        }
    }
}