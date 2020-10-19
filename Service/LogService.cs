// using System;
// using System.Threading.Tasks;
// using aspnetcoreapp.Models;

// namespace aspnetcoreapp.Service
// {
//     public class LogService
//     {
//         private readonly ApplicationDbContext dbContext;

//         public LogService(ApplicationDbContext dbContext)
//         {
//             this.dbContext = dbContext;
//         }

//         public async Task AddLog<TEntity>(int id, int type, string description) where TEntity : EntityLog
//         {
//             var entity = new EntityLog
//             {
//                 EntityId = id,
//                 Type = type,
//                 Description = description,
//                 Timestamp = DateTime.Now
//             };
//             dbContext.Add(entity);
//             await dbContext.SaveChangesAsync();
//         }
//     }
// }