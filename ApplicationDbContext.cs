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
            modelBuilder.Entity<Book>()
            .HasData(
                new Book { Id = 1, Name = "Dev", Price = 10, Quantity = 20 },
                new Book { Id = 2, Name = "Banana", Price = 5, Quantity = 10 }
            );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<DroneLog> DroneLogs { get; set; }
        public DbSet<Payload> Payload { get; set; }
        public DbSet<UserLog> UserLog { get; set; }
        public DbSet<ImageLog> ImageLog { get; set; }
        public DbSet<VideoLog> VideoLog { get; set; }
        public DbSet<IncidentLog> IncidentLog { get; set; }
        public DbSet<ObjectObserve> ObjectObserve { get; set; }
        public DbSet<StaticalLog> StaticalLog { get; set; }
        public DbSet<WarningLog> WarningLog { get; set; }
        public DbSet<MonitorRegionLog> MonitorRegionLog { get; set; }
        public DbSet<ResolveProblemLog> ResolveProblemLog { get; set; }
        public DbSet<UavConnectLog> UavConnectLog { get; set; }
    }
}