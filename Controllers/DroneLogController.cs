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
    public class DroneLogController : CustomController
    {
        public DroneLogController(ILogger<DroneLogController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }
        

        [HttpGet("drones")]
        public async Task<ActionResult> GetDrone([FromQuery] MinMaxDate form,[FromQuery] UserPassword up) =>
            await Get<DroneLog, DroneLogResponse>(DroneLog.GroupId, form, up.UserName, up.Password);

        [HttpPost("drones/delete")]
        [HttpPost("drones/edit")]
        [HttpPost("drones/activity")]
        [HttpPost("drones/add")]
        [HttpPost("drones-has-problems")]
        public async Task<ActionResult> PostDrone([FromBody] DroneLogRequest request, string username, string password)
        {
            if (!_authService.IsAuthenticate(DroneLog.GroupId, username, password))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<DroneLog>(request);
            var route = Request.Path.Value;
            if (route.Contains("drones-has-problems"))
            {
                return await Post<DroneLog>(form, ApiType.HasProblem);
            }
            else
            {
                var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
                if (apiType == ApiType.Empty)
                {
                    return NotFound();
                }

                return await Post<DroneLog>(form, apiType);
            }
        }
    }
}