using System;
using System.Diagnostics.CodeAnalysis;
using aspnetcoreapp.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var books = new Book[]
            {
                new Book {Id = 1, Name = "Dev", Price = 10, Quantity = 20},
                new Book {Id = 2, Name = "Banana", Price = 5, Quantity = 10}
            };
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<DroneLog>().HasData(DroneLog.GetSeederData());
            modelBuilder.Entity<Payload>().HasData(Payload.GetSeederData());
            modelBuilder.Entity<ImageLog>().HasData(ImageLog.GetSeederData());
            modelBuilder.Entity<VideoLog>().HasData(VideoLog.GetSeederData());
            modelBuilder.Entity<IncidentLog>().HasData(IncidentLog.GetSeederData());
            modelBuilder.Entity<ObjectObserve>().HasData(ObjectObserve.GetSeederData());
            modelBuilder.Entity<StaticalLog>().HasData(StaticalLog.GetSeederData());
            modelBuilder.Entity<WarningLog>().HasData(WarningLog.GetSeederData());
            modelBuilder.Entity<MonitorRegionLog>().HasData(MonitorRegionLog.GetSeederData());
            modelBuilder.Entity<ResolveProblemLog>().HasData(ResolveProblemLog.GetSeederData());
            modelBuilder.Entity<UavConnectLog>().HasData(UavConnectLog.GetSeederData());
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<DroneLog> DroneLogs { get; set; }
        public DbSet<Payload> Payloads { get; set; }
        public DbSet<UserLog> UserLog { get; set; }
        public DbSet<ImageLog> ImageLogs { get; set; }
        public DbSet<VideoLog> VideoLogs { get; set; }
        public DbSet<IncidentLog> IncidentLogs { get; set; }
        public DbSet<ObjectObserve> ObjectObserves { get; set; }
        public DbSet<StaticalLog> StaticalLogs { get; set; }
        public DbSet<WarningLog> WarningLogs { get; set; }
        public DbSet<MonitorRegionLog> MonitorRegionLogs { get; set; }
        public DbSet<ResolveProblemLog> ResolveProblemLogs { get; set; }
        public DbSet<UavConnectLog> UavConnectLogs { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
    }
}