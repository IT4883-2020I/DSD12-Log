using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using aspnetcoreapp.Models;
using aspnetcoreapp.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp.Controllers
{
    public class CustomController : ControllerBase
    {
        protected readonly ILogger<CustomController> _logger;
        protected readonly ApplicationDbContext _dbContext;
        protected IMapper _mapper;
        protected IConfiguration _configuration;
        protected readonly AuthenticationService _authService;

        public CustomController(ILogger<CustomController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
        {
            _logger = logger;
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration = configuration;
            _authService = new AuthenticationService(configuration);
        }

        public async Task<ActionResult> AddLog<TEntity>(int id, int type, string description) where TEntity : EntityLog
        {
            var entity = new EntityLog
            {
                EntityId = id,

                Description = description,
                Timestamp = DateTime.Now
            };
            _dbContext.Add(entity);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        public class MinMaxDate
        {
            public DateTime MinDate { get; set; } = DateTime.MinValue;
            public DateTime MaxDate { get; set; } = DateTime.MaxValue;
        }

        public async Task<ActionResult> Post<TEntity>(TEntity entity, ApiType apiType = ApiType.Empty)
            where TEntity : EntityLog
        {
            entity.Timestamp = DateTime.Now;
            if (apiType == ApiType.Empty)
            {
                apiType = ApiType.Add;
                if (HttpContext.Request.Method == HttpMethod.Put.Method)
                {
                    apiType = ApiType.Edit;
                }
                else if (HttpContext.Request.Method == HttpMethod.Delete.Method)
                {
                    apiType = ApiType.Delete;
                }

                entity.Type = apiType;
                _dbContext.Set<TEntity>().Add(entity);
                await _dbContext.SaveChangesAsync();
                return Ok(entity);
            }
            else
            {
                entity.Type = apiType;
                _dbContext.Set<TEntity>().Add(entity);
                await _dbContext.SaveChangesAsync();
                return Ok(entity);
            }
        }

        public async Task<ActionResult> Get<TEntity>(int group, MinMaxDate form, string username, string password)
            where TEntity : EntityLog
        {
            _logger.LogInformation(form.ToJson());
            if (_authService.IsAuthenticate(group, username, password))
            {
                var list = await _dbContext.Set<TEntity>()
                    .Where(entity =>
                        entity.Timestamp <= form.MaxDate && entity.Timestamp >= form.MinDate &&
                        entity.Type != ApiType.ActivityLog)
                    .AsNoTracking()
                    .ToListAsync();
                return Ok(list);
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}