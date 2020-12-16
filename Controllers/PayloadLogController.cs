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
    public class PayloadLogController : CustomController
    {
        public PayloadLogController(ILogger<PayloadLogController> logger, ApplicationDbContext dbContext,
            IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }


        [HttpGet("payload")]
        public async Task<ActionResult<List<PayloadResponse>>> GetPayload([FromQuery] MinMaxDate form, string? payloadId,
            string? droneId, string projectType)
        {
            var listEntity = await GetEntity<Payload, PayloadResponse>(Payload.GroupId, form, projectType);

            return (listEntity.Where(entity =>
                    (droneId == null || entity.DroneId == droneId) &&
                    (payloadId == null || entity.EntityId == payloadId))
                .ToList());
        }


        [HttpPost("payload/delete")]
        [HttpPost("payload/edit")]
        [HttpPost("payload/activity")]
        [HttpPost("payload/add")]
        public async Task<ActionResult> PostPayload([FromBody] PayloadRequest request)
        {
            if (!_authService.IsAuthenticate(Payload.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<Payload>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<Payload>(form, apiType);
        }
    }
}