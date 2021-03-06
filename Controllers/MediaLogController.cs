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
    public class MediaLogController : CustomController
    {
        public MediaLogController(ILogger<MediaLogController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        public class MediaQuery
        {
            [FromQuery] public int DroneId { get; set; } = int.MinValue;
        }

        [HttpGet("video")]
        public async Task<ActionResult<List<VideoLogResponse>>> GetVideo(
            [FromQuery] MinMaxDate form, string videoId, string incidentId, string? droneId, string projectType)
        {
            var listEntity = await GetEntity<VideoLog, VideoLogResponse>(VideoLog.GroupId, form, projectType);


            return (listEntity.Where(entity =>
                    (incidentId == null || entity.IncidentId == incidentId) &&
                    (droneId == null || entity.DroneId == droneId) &&
                    (videoId == null || entity.EntityId == videoId))
                .ToList());
        }

        [HttpPost("video/delete")]
        [HttpPost("video/edit")]
        [HttpPost("video/activity")]
        [HttpPost("video/add")]
        public async Task<ActionResult> PostVideo([FromBody] VideoLogRequest request)
        {
            if (!_authService.IsAuthenticate(VideoLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<VideoLog>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<VideoLog>(form, apiType);
        }

        [HttpGet("image")]
        public async Task<ActionResult<List<ImageLogResponse>>> GetImage([FromQuery] MinMaxDate form, string? droneId,
            string incidentId,
            string imageId,
            string projectType)
        {
            var listEntity = await GetEntity<ImageLog, ImageLogResponse>(ImageLog.GroupId, form, projectType);

            return (listEntity.Where(entity =>
                (incidentId == null || entity.IncidentId == incidentId) &&
                (droneId == null || entity.DroneId == droneId) &&
                (imageId == null || entity.EntityId == imageId)).ToList());
        }


        [HttpPost("image/delete")]
        [HttpPost("image/edit")]
        [HttpPost("image/activity")]
        [HttpPost("image/add")]
        public async Task<ActionResult> PostImage([FromBody] ImageLogRequest request)
        {
            if (!_authService.IsAuthenticate(ImageLog.GroupId))
            {
                return Unauthorized();
            }

            var form = _mapper.Map<ImageLog>(request);
            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }

            return await Post<ImageLog>(form, apiType);
        }
    }
}