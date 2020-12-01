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
        public async Task<ActionResult>
            GetObjectObserve([FromQuery] MinMaxDate form, string username, string password) =>
            await Get<ObjectObserve, ObjectObserveResponse>(ObjectObserve.GroupId, form, username, password);


        [HttpPost("monitor-object/delete")]
        [HttpPost("monitor-object/edit")]
        [HttpPost("monitor-object/activity")]
        [HttpPost("monitor-object/add")]
        public async Task<ActionResult> PostObjectObserve([FromBody] ObjectObserveRequest request, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(ObjectObserve.GroupId, username, password))
            {
                return Unauthorized();
            }
            
            var form = _mapper.Map<ObjectObserve>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<ObjectObserve>(form, apiType);
        }
    }
}