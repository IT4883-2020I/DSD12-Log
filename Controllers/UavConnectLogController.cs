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
        public async Task<ActionResult> GetUavConnectLog([FromQuery] MinMaxDate form, string username,
            string password) =>
            await Get<UavConnectLog, UavConnectLogResponse>(UavConnectLog.GroupId, form, username, password);


        [HttpPost("uav-connect/delete")]
        [HttpPost("uav-connect/edit")]
        [HttpPost("uav-connect/activity")]
        [HttpPost("uav-connect/add")]
        public async Task<ActionResult> PostUavConnectLog([FromBody] UavConnectRequest request, string username,
            string password)
        {
            if (!_authService.IsAuthenticate(UavConnectLog.GroupId, username, password))
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