// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using aspnetcoreapp.Models;
// using aspnetcoreapp.Service;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// namespace aspnetcoreapp.Controllers
// {
//     [Route("drones")]
//     [ApiController]
//     public class DroneLogController : CustomController
//     {

//         public DroneLogController(ApplicationDbContext dbContext) : base(dbContext)
//         {

//         }

//         [HttpGet("")]
//         public async Task<ActionResult<List<DroneLog>>> Get()
//         {
//             var logs = await dbContext.DroneLogs.AsNoTracking().ToListAsync();
//             return logs;
//         }

//         [HttpPost("{id}")]
//         public async Task<ActionResult> PostDroneLog(int id)
//         {
//             return await AddLog<DroneLog>(id, (int)Models.Type.Add, new DescriptionForm { Description = "" });
//         }

//         [HttpPut("{id}")]
//         public async Task<ActionResult> PutDroneLog(int id, DroneLog model)
//         {
//             return await AddLog<DroneLog>(id, (int)Models.Type.Edit, "");
//         }

//         [HttpDelete("{id}")]
//         public async Task<ActionResult> DeleteDroneLogById(int id)
//         {
//             return await AddLog<DroneLog>(id, (int)Models.Type.Delete, "");
//         }

//         [HttpPost("has-problems/{id}")]
//         public async Task<ActionResult> HasProblems(int id)
//         {
//             return await AddLog<DroneLog>(id, (int)Models.Type.HasProblem, "");
//         }

//         [HttpPost("change-schedule/{id}")]
//         public async Task<ActionResult> ChangeSchedule(int id, DroneLog log)
//         {
//             return await AddLog<DroneLog>(id, (int)Models.Type.ChangeSchedule, "");
//         }
//     }
// }