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
    public class UavConnectLogController : CustomController
    {
        public UavConnectLogController(ILogger<UavConnectLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        [HttpGet("uav-connect")]
        public async Task<ActionResult<List<UavConnectLogResponse>>> GetUavConnectLog([FromQuery] MinMaxDate form,
            int? droneId, string projectType)
        {
            var listEntity = await GetEntity<UavConnectLog, UavConnectLogResponse>(Payload.GroupId, form, projectType);
            if (droneId != null)
            {
                return (listEntity.Where(entity => entity.DroneId == droneId).ToList());
            }
            else
            {
                return (listEntity);
            }
        }

        [HttpPost("uav-connect/delete")]
        [HttpPost("uav-connect/edit")]
        [HttpPost("uav-connect/activity")]
        [HttpPost("uav-connect/add")]
        public async Task<ActionResult> PostUavConnectLog([FromBody] UavConnectRequest request)
        {
            if (!_authService.IsAuthenticate(UavConnectLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<UavConnectLog>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<UavConnectLog>(form, apiType);
        }
    }
}