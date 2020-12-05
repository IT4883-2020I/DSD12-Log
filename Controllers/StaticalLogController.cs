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
    public class StaticalLogController : CustomController
    {
        public StaticalLogController(ILogger<StaticalLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        [HttpGet("receive-statistical")]
        public async Task<ActionResult> GetStatical([FromQuery] MinMaxDate form) =>
            await Get<StaticalLog, StaticalLogResponse>(StaticalLog.GroupId, form);

        [HttpPost("statistical-frequence")]
        [HttpPost("statistical-address")]
        [HttpPost("statistical-incident")]
        public async Task<ActionResult> PostStatical([FromBody] StaticalRequest request)
        {
            var route = Request.Path.Value;
            _logger.LogInformation("PostStatical " + route);
            if (!_authService.IsAuthenticate(StaticalLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<StaticalLog>(request);
            var apiType = ApiType.CommonIncident;
            if (route.Contains("statistical-frequence"))
            {
                apiType = ApiType.FrequenceIncident;
            }
            else if (route.Contains("statistical-address"))
            {
                apiType = ApiType.HasProblem;
            }


            return await Post<StaticalLog>(form, apiType);
        }
    }
}