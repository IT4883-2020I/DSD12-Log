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


        [HttpGet("video")]
        public async Task<ActionResult> GetVideo([FromQuery] MinMaxDate form) =>
            await Get<VideoLog, VideoLogResponse>(VideoLog.GroupId, form);


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
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<VideoLog>(form, apiType);
        }

        [HttpGet("image")]
        public async Task<ActionResult> GetImage([FromQuery] MinMaxDate form) =>
            await Get<ImageLog, ImageLogResponse>(ImageLog.GroupId, form);


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
            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }

            return await Post<ImageLog>(form, apiType);
        }
    }
}