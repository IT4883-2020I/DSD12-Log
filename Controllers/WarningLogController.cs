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
        public async Task<ActionResult> GetWarning([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<WarningLog, WarningLogResponse>(WarningLog.GroupId, form, username, password);


        [HttpPost("warning/delete")]
        [HttpPost("warning/edit")]
        [HttpPost("warning/activity")]
        [HttpPost("warning/add")]
        [HttpPost("warning-level")]
        [HttpPost("solution-handling-warning")]
        public async Task<ActionResult> PostWarning([FromBody] WarningLogRequest request, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(WarningLog.GroupId, username, password))
            {
                return Unauthorized();
            }


            var form = _mapper.Map<WarningLog>(request);
            var apiType = ApiType.Empty;
            if (Request.Path.Value.Contains("warning-level"))
            {
                apiType = ApiType.WarningLevel;
            }
            else if (Request.Path.Value.Contains("solution-handling-warning"))
            {
                apiType = ApiType.SolutionHandling;
            }

            apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<WarningLog>(form, apiType);
        }
    }
}