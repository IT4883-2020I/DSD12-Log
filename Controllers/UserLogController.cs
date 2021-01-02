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
    public class UserLogController : CustomController
    {
        public UserLogController(ILogger<UserLogController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

        [HttpGet("user")]
        public async Task<ActionResult<List<UserLogResponse>>> GetUser([FromQuery] MinMaxDate form,string? userId, string? regionId, string? problemId,
            string projectType)
        {
            if (_authService.IsAuthenticate(UserLog.GroupId))
            {
                var list = await _dbContext.Set<UserLog>()
                    .Where(entity =>
                        entity.Timestamp <= form.MaxDate && entity.Timestamp >= form.MinDate)
                    .AsNoTracking()
                    .ToListAsync();
                var result = new List<UserLogResponse>();
                foreach (var userLog in list)
                {
                    if (userLog.ProjectType.ToLower() == projectType.ToLower() && (regionId == null || userLog.RegionId == regionId) &&
                        (problemId == null || userLog.ResolveProblemId == problemId)
                        &&(userId ==null || userLog.EntityId == userId))
                    {
                        var userLogResponse = _mapper.Map<UserLogResponse>(userLog);
                        userLogResponse.Type = userLog.Type.GetDescription();
                        userLogResponse.Timestamp = userLog.Timestamp.ToDescriptionString();
                        userLogResponse.TargetId = userLog.EntityId; 
                        result.Add(userLogResponse);
                    }
                }

                return (result);
            }
            else
            {
                return Unauthorized();
            }
        }


        [HttpPost("user/delete")]
        [HttpPost("user/edit")]
        [HttpPost("user/activity")]
        [HttpPost("user/add")]
        public async Task<ActionResult> PostUser([FromBody] UserLogRequest form)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (apiType == LogType.Empty)
            {
                return NotFound();
            }
            else
            {
                var userLog = new UserLog()
                {
                    EntityId = form.target_id.ToString(),
                    Metadata = form.meta_data,
                    AuthorId = form.user_id.ToString(),
                    ProjectType = form.project_type,
                    Description = form.description,
                    RegionId = form.region_id.ToString(),
                    IncidentId = form.incident_id.ToString(),
                    ResolveProblemId = form.resolve_problem_id.ToString(),
                    Timestamp = Utility.GetTimeNow()
                };
                return await Post<UserLog>(userLog, apiType);
            }
        }
    }
}