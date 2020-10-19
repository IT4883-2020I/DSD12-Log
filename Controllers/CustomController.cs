using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcoreapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreapp.Controllers
{
    public class CustomController : ControllerBase
    {
        protected readonly ApplicationDbContext dbContext;

        public CustomController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ActionResult> AddLog<TEntity>(int id, int type, string description) where TEntity : EntityLog
        {
            var entity = new EntityLog
            {
                EntityId = id,

                Description = description,
                Timestamp = DateTime.Now
            };
            dbContext.Add(entity);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}