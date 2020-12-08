using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DroneLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "ImageLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "IncidentLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    ImageId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncidentLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "MonitorRegionLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorRegionLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "ObjectObserves",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectObserves", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "Payloads",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payloads", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "ResolveProblemLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResolveProblemLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "StaticalLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticalLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "SystemLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UavConnectLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UavConnectLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "UserLog",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Metadata = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: false),
                    IncidentId = table.Column<int>(nullable: false),
                    ResolveProblemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLog", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "VideoLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    DroneId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "WarningLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarningLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Dev", 10m, 20 },
                    { 2, "Banana", 5m, 10 }
                });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 23, "Drone Edit", 5, 10, 21, "Drone 9", "DE_DIEU", 1, "MonitorRegion 4", new DateTime(2020, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Drone Edit", 4, 10, 34, "Drone 3", "CAY_TRONG", 3, "MonitorRegion 1", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Drone Activity Log", 4, 20, 43, "Drone 10", "LUOI_DIEN", 4, "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Drone Delete", 8, 27, 48, "Drone 5", "DE_DIEU", 4, "MonitorRegion 3", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Drone Delete", 7, 24, 36, "Drone 8", "DE_DIEU", 2, "MonitorRegion 3", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Drone Activity Log", 2, 44, 11, "Drone 8", "DE_DIEU", 2, "MonitorRegion 1", new DateTime(2020, 12, 2, 16, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Drone Activity Log", 3, 26, 29, "Drone 3", "DE_DIEU", 4, "MonitorRegion 3", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Drone Activity Log", 6, 45, 24, "Drone 5", "CAY_TRONG", 3, "MonitorRegion 2", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "Drone Edit", 8, 11, 44, "Drone 7", "CAY_TRONG", 1, "MonitorRegion 1", new DateTime(2020, 12, 1, 3, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Drone Delete", 8, 30, 13, "Drone 4", "CHAY_RUNG", 3, "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Drone Add", 6, 23, 24, "Drone 5", "CHAY_RUNG", 3, "MonitorRegion 1", new DateTime(2020, 12, 1, 3, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Drone Edit", 10, 29, 15, "Drone 8", "CAY_TRONG", 3, "MonitorRegion 3", new DateTime(2020, 12, 2, 1, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Drone Add", 2, 31, 48, "Drone 10", "CHAY_RUNG", 3, "MonitorRegion 4", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Drone Delete", 9, 28, 37, "Drone 2", "LUOI_DIEN", 1, "MonitorRegion 3", new DateTime(2020, 12, 1, 5, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "Drone Add", 3, 28, 37, "Drone 4", "DE_DIEU", 1, "MonitorRegion 2", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Drone Edit", 10, 15, 21, "Drone 4", "CHAY_RUNG", 4, "MonitorRegion 4", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Drone Activity Log", 6, 45, 42, "Drone 9", "DE_DIEU", 4, "MonitorRegion 2", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Drone Add", 2, 42, 33, "Drone 3", "DE_DIEU", 2, "MonitorRegion 1", new DateTime(2020, 12, 1, 9, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Drone Add", 1, 22, 37, "Drone 3", "LUOI_DIEN", 1, "MonitorRegion 1", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Drone Delete", 8, 29, 34, "Drone 4", "LUOI_DIEN", 4, "MonitorRegion 4", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Drone Add", 4, 26, 17, "Drone 5", "DE_DIEU", 4, "MonitorRegion 4", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Drone Edit", 8, 42, 49, "Drone 10", "CAY_TRONG", 1, "MonitorRegion 4", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, "Drone Delete", 4, 33, 15, "Drone 1", "DE_DIEU", 1, "MonitorRegion 4", new DateTime(2020, 12, 1, 15, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, "Drone Activity Log", 1, 40, 35, "Drone 3", "LUOI_DIEN", 1, "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, "Drone Edit", 6, 39, 14, "Drone 6", "CHAY_RUNG", 1, "MonitorRegion 4", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "Drone Activity Log", 1, 47, 13, "Drone 4", "CAY_TRONG", 3, "MonitorRegion 3", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 6, "Drone Delete", 8, 17, 44, "Drone 7", "CAY_TRONG", 1, "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, "Drone Delete", 5, 35, 25, "Drone 8", "LUOI_DIEN", 1, "MonitorRegion 4", new DateTime(2020, 12, 2, 6, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, "Drone Activity Log", 1, 26, 41, "Drone 10", "CHAY_RUNG", 1, "MonitorRegion 3", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, "Drone Activity Log", 8, 28, 25, "Drone 7", "DE_DIEU", 1, "MonitorRegion 3", new DateTime(2020, 12, 1, 1, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 1, "Drone Delete", 7, 10, 44, "Drone 1", "CHAY_RUNG", 2, "MonitorRegion 2", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Drone Activity Log", 9, 16, 43, "Drone 8", "CAY_TRONG", 2, "MonitorRegion 2", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Drone Delete", 9, 16, 16, "Drone 8", "LUOI_DIEN", 4, "MonitorRegion 4", new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "Drone Add", 1, 24, 34, "Drone 10", "DE_DIEU", 1, "MonitorRegion 4", new DateTime(2020, 12, 1, 3, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Drone Delete", 10, 13, 49, "Drone 10", "CHAY_RUNG", 1, "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Drone Add", 6, 49, 15, "Drone 2", "LUOI_DIEN", 1, "MonitorRegion 2", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Drone Add", 8, 16, 12, "Drone 8", "LUOI_DIEN", 1, "MonitorRegion 2", new DateTime(2020, 12, 1, 13, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Drone Add", 7, 39, 13, "Drone 3", "CAY_TRONG", 3, "MonitorRegion 2", new DateTime(2020, 12, 2, 8, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Drone Delete", 2, 33, 28, "Drone 7", "LUOI_DIEN", 4, "MonitorRegion 3", new DateTime(2020, 12, 2, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Drone Activity Log", 7, 11, 47, "Drone 5", "CAY_TRONG", 2, "MonitorRegion 2", new DateTime(2020, 12, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Image Add", 5, 6, "Image AM", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Image Edit", 4, 22, "Image JI", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 15, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Image Add", 8, 3, "Image SE", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Image Edit", 6, 8, "Image ZS", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Image Activity Log", 7, 28, "Image DQ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "Image Delete", 4, 34, "Image HT", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "Image Activity Log", 1, 24, "Image BX", "DE_DIEU", "0", new DateTime(2020, 12, 1, 3, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "Image Add", 8, 10, "Image ZY", "DE_DIEU", "0", new DateTime(2020, 12, 1, 12, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Image Activity Log", 9, 32, "Image LH", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Image Activity Log", 10, 30, "Image FZ", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Image Activity Log", 5, 10, "Image TF", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "Image Delete", 1, 11, "Image MH", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Image Add", 6, 15, "Image KD", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Image Delete", 3, 39, "Image FC", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Image Delete", 4, 12, "Image TP", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Image Add", 2, 35, "Image BR", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Image Add", 5, 33, "Image BI", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "Image Add", 4, 1, "Image IC", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Image Activity Log", 4, 10, "Image PT", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Image Edit", 10, 11, "Image YT", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Image Delete", 10, 18, "Image ZI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Image Activity Log", 8, 21, "Image BD", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Image Edit", 8, 11, "Image TT", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Image Add", 2, 1, "Image SV", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Image Add", 6, 33, "Image WW", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Image Activity Log", 7, 18, "Image WQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Image Activity Log", 10, 11, "Image LP", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Image Delete", 5, 30, "Image KS", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Image Activity Log", 3, 20, "Image WG", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "Image Activity Log", 10, 27, "Image GG", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Image Activity Log", 8, 6, "Image JU", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "Image Edit", 7, 25, "Image VR", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Image Edit", 6, 40, "Image UV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Image Activity Log", 5, 31, "Image NZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Image Activity Log", 3, 13, "Image BO", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Image Add", 8, 7, "Image SR", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Image Activity Log", 10, 5, "Image NM", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Image Delete", 8, 39, "Image IX", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Image Activity Log", 8, 4, "Image IP", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Image Add", 2, 29, "Image CS", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 42, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "ImageId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type", "VideoId" },
                values: new object[,]
                {
                    { 37, "Incident Edit", 3, 8, "Incident UA", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 4, 25 },
                    { 36, "Incident Activity Log", 4, 15, "Incident MW", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 8, 7, 0, 0, DateTimeKind.Unspecified), 20, 34 },
                    { 35, "Incident Activity Log", 8, 31, "Incident OH", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 20, 23 },
                    { 31, "Incident Add", 14, 17, "Incident OK", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 14, 42, 0, 0, DateTimeKind.Unspecified), 2, 36 },
                    { 33, "Incident Activity Log", 8, 33, "Incident PE", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 1, 3, 0, 0, DateTimeKind.Unspecified), 20, 19 },
                    { 32, "Incident Activity Log", 8, 35, "Incident XS", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 2, 16, 32, 0, 0, DateTimeKind.Unspecified), 20, 10 },
                    { 39, "Incident Add", 5, 20, "Incident MV", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 2, 29 },
                    { 34, "Incident Edit", 5, 29, "Incident TU", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 5, 22, 0, 0, DateTimeKind.Unspecified), 4, 34 },
                    { 40, "Incident Delete", 13, 33, "Incident EE", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 3, 4 },
                    { 45, "Incident Edit", 13, 5, "Incident HQ", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 4, 40 },
                    { 42, "Incident Edit", 6, 8, "Incident PD", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), 4, 34 },
                    { 43, "Incident Edit", 2, 20, "Incident DR", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 4, 24 },
                    { 44, "Incident Activity Log", 7, 33, "Incident KU", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 20, 40 },
                    { 46, "Incident Activity Log", 10, 24, "Incident PJ", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 3, 46, 0, 0, DateTimeKind.Unspecified), 20, 33 },
                    { 47, "Incident Edit", 10, 19, "Incident QH", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 8, 26, 0, 0, DateTimeKind.Unspecified), 4, 30 },
                    { 48, "Incident Edit", 7, 40, "Incident MM", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 12, 34, 0, 0, DateTimeKind.Unspecified), 4, 31 },
                    { 49, "Incident Add", 12, 4, "Incident WE", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 2, 19 },
                    { 41, "Incident Edit", 5, 24, "Incident OD", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 9, 14, 0, 0, DateTimeKind.Unspecified), 4, 28 },
                    { 30, "Incident Add", 6, 40, "Incident GA", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 2, 28 },
                    { 38, "Incident Add", 2, 23, "Incident JJ", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 2, 37 },
                    { 28, "Incident Delete", 13, 25, "Incident XB", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 3, 35 },
                    { 11, "Incident Add", 1, 10, "Incident ZC", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 2, 26 },
                    { 12, "Incident Delete", 12, 2, "Incident LX", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 9, 2, 0, 0, DateTimeKind.Unspecified), 3, 16 },
                    { 13, "Incident Activity Log", 13, 29, "Incident DM", "LUOI_DIEN", 4, "1", new DateTime(2020, 12, 1, 2, 29, 0, 0, DateTimeKind.Unspecified), 20, 30 },
                    { 14, "Incident Activity Log", 2, 26, "Incident LF", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 20, 39 },
                    { 15, "Incident Delete", 12, 17, "Incident DR", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 2, 14, 4, 0, 0, DateTimeKind.Unspecified), 3, 28 },
                    { 16, "Incident Delete", 3, 17, "Incident EL", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 11, 24, 0, 0, DateTimeKind.Unspecified), 3, 34 },
                    { 17, "Incident Add", 7, 2, "Incident ZY", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 12, 13, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 18, "Incident Delete", 5, 39, "Incident LB", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 3, 20 },
                    { 19, "Incident Add", 4, 22, "Incident KX", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 10, "Incident Add", 14, 19, "Incident AN", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 2, 32, 0, 0, DateTimeKind.Unspecified), 2, 13 },
                    { 29, "Incident Edit", 1, 25, "Incident UO", "DE_DIEU", 1, "1", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 4, 7 },
                    { 21, "Incident Activity Log", 5, 37, "Incident SI", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 12, 35, 0, 0, DateTimeKind.Unspecified), 20, 16 },
                    { 22, "Incident Edit", 9, 2, "Incident YC", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 13, 49, 0, 0, DateTimeKind.Unspecified), 4, 39 },
                    { 23, "Incident Edit", 14, 3, "Incident KP", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 4, 28 },
                    { 24, "Incident Edit", 13, 32, "Incident RB", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 4, 16, 0, 0, DateTimeKind.Unspecified), 4, 18 },
                    { 25, "Incident Activity Log", 8, 36, "Incident PN", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 13, 5, 0, 0, DateTimeKind.Unspecified), 20, 29 },
                    { 26, "Incident Delete", 1, 9, "Incident KU", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 1, 3, 48, 0, 0, DateTimeKind.Unspecified), 3, 36 },
                    { 27, "Incident Activity Log", 5, 24, "Incident KO", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 20, 25 },
                    { 20, "Incident Delete", 10, 39, "Incident TQ", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 3, 38 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, "MonitorRegion Delete", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "MonitorRegion Edit", 4, "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "MonitorRegion Add", 2, "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 1, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "MonitorRegion Add", 2, "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "MonitorRegion Add", 4, "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "MonitorRegion Delete", 1, "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "MonitorRegion Activity Log", 1, "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 14, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "MonitorRegion Delete", 1, "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "MonitorRegion Delete", 2, "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "MonitorRegion Add", 3, "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "MonitorRegion Delete", 4, "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "MonitorRegion Edit", 3, "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "MonitorRegion Delete", 1, "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "MonitorRegion Edit", 1, "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "MonitorRegion Add", 4, "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 1, "MonitorRegion Edit", 2, "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, "MonitorRegion Add", 3, "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "MonitorRegion Activity Log", 2, "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, "MonitorRegion Add", 2, "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "MonitorRegion Add", 4, "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, "MonitorRegion Delete", 3, "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 5, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 8, "MonitorRegion Edit", 1, "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, "MonitorRegion Activity Log", 3, "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 1, 4, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "MonitorRegion Activity Log", 2, "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "MonitorRegion Edit", 2, "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "MonitorRegion Delete", 3, "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "MonitorRegion Activity Log", 2, "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "MonitorRegion Delete", 1, "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "MonitorRegion Delete", 2, "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "MonitorRegion Activity Log", 4, "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "MonitorRegion Activity Log", 2, "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ObjectObserve Add", 3, "ObjectObserve YI", "DE_DIEU", 4, "1", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "ObjectObserve Edit", 14, "ObjectObserve BY", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 2, 14, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "ObjectObserve Activity Log", 18, "ObjectObserve GE", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 9, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "ObjectObserve Add", 9, "ObjectObserve YS", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "ObjectObserve Activity Log", 20, "ObjectObserve XW", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "ObjectObserve Add", 1, "ObjectObserve GQ", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 14, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "ObjectObserve Delete", 11, "ObjectObserve PU", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "ObjectObserve Edit", 14, "ObjectObserve VX", "CAY_TRONG", 1, "0", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "ObjectObserve Delete", 18, "ObjectObserve VH", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 2, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "ObjectObserve Edit", 19, "ObjectObserve EI", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 1, 11, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "ObjectObserve Edit", 1, "ObjectObserve LN", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "ObjectObserve Add", 16, "ObjectObserve IF", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "ObjectObserve Edit", 9, "ObjectObserve BP", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 6, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "ObjectObserve Activity Log", 14, "ObjectObserve LY", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 6, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "ObjectObserve Delete", 4, "ObjectObserve HC", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "ObjectObserve Add", 8, "ObjectObserve YK", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "ObjectObserve Add", 1, "ObjectObserve UD", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 12, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "ObjectObserve Activity Log", 6, "ObjectObserve CF", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 8, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "ObjectObserve Add", 11, "ObjectObserve SL", "DE_DIEU", 4, "0", new DateTime(2020, 12, 1, 5, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "ObjectObserve Activity Log", 20, "ObjectObserve VI", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 3, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "ObjectObserve Edit", 14, "ObjectObserve LC", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "ObjectObserve Add", 11, "ObjectObserve UJ", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 16, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "ObjectObserve Add", 12, "ObjectObserve IK", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "ObjectObserve Add", 20, "ObjectObserve SL", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "ObjectObserve Activity Log", 14, "ObjectObserve QL", "DE_DIEU", 1, "1", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "ObjectObserve Activity Log", 9, "ObjectObserve BF", "CAY_TRONG", 4, "0", new DateTime(2020, 12, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "ObjectObserve Edit", 4, "ObjectObserve GY", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 1, 2, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "ObjectObserve Add", 20, "ObjectObserve TK", "DE_DIEU", 4, "1", new DateTime(2020, 12, 2, 12, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "ObjectObserve Add", 2, "ObjectObserve NB", "DE_DIEU", 2, "0", new DateTime(2020, 12, 2, 11, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "ObjectObserve Edit", 15, "ObjectObserve IX", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 8, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "ObjectObserve Add", 20, "ObjectObserve GI", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 9, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "ObjectObserve Activity Log", 1, "ObjectObserve VB", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "ObjectObserve Delete", 19, "ObjectObserve NN", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 1, 11, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "ObjectObserve Delete", 15, "ObjectObserve OK", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "ObjectObserve Delete", 15, "ObjectObserve DI", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "ObjectObserve Delete", 10, "ObjectObserve QG", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "ObjectObserve Activity Log", 12, "ObjectObserve NT", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "ObjectObserve Activity Log", 14, "ObjectObserve PL", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "ObjectObserve Edit", 13, "ObjectObserve OS", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "ObjectObserve Delete", 2, "ObjectObserve XU", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 10, 34, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "Payload Edit", 4, 1, "Payload US", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Payload Activity Log", 5, 6, "Payload JL", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "Payload Activity Log", 8, 4, "Payload MQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "Payload Edit", 2, 5, "Payload NP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "Payload Delete", 8, 10, "Payload ZR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Payload Activity Log", 10, 10, "Payload YC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "Payload Edit", 2, 10, "Payload ZS", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Payload Edit", 10, 1, "Payload PH", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Payload Add", 3, 10, "Payload VR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Payload Activity Log", 5, 6, "Payload RT", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Payload Delete", 1, 10, "Payload JV", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Payload Delete", 2, 1, "Payload JT", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Payload Add", 8, 3, "Payload HX", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Payload Activity Log", 4, 10, "Payload NV", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "Payload Delete", 6, 1, "Payload JX", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Payload Add", 2, 4, "Payload IL", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Payload Edit", 8, 7, "Payload NA", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Payload Add", 8, 3, "Payload QO", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Payload Edit", 6, 2, "Payload FJ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 1, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Payload Edit", 1, 2, "Payload ZF", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Payload Edit", 1, 9, "Payload WW", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Payload Add", 6, 10, "Payload KV", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Payload Edit", 2, 4, "Payload BT", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Payload Delete", 10, 9, "Payload MF", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Payload Activity Log", 10, 6, "Payload TP", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Payload Edit", 3, 8, "Payload QX", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Payload Delete", 8, 4, "Payload PG", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Payload Edit", 1, 6, "Payload OC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Payload Edit", 7, 2, "Payload JA", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Payload Delete", 10, 3, "Payload GF", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Payload Delete", 8, 7, "Payload FG", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Payload Activity Log", 8, 5, "Payload BP", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "Payload Add", 4, 7, "Payload EA", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Payload Activity Log", 1, 5, "Payload ZP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Payload Add", 4, 7, "Payload YU", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Payload Edit", 5, 1, "Payload RD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Payload Delete", 8, 5, "Payload DQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Payload Add", 3, 10, "Payload KK", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Payload Add", 4, 9, "Payload JZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Payload Add", 6, 4, "Payload DB", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ResolveProblem Edit", 6, "ResolveProblem VX", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "ResolveProblem Edit", 6, "ResolveProblem ML", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "ResolveProblem Add", 8, "ResolveProblem FR", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 1, 5, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "ResolveProblem Activity Log", 5, "ResolveProblem GC", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 2, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "ResolveProblem Activity Log", 6, "ResolveProblem UW", "DE_DIEU", 2, "1", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "ResolveProblem Edit", 14, "ResolveProblem UN", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "ResolveProblem Activity Log", 4, "ResolveProblem VK", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 1, 15, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "ResolveProblem Activity Log", 14, "ResolveProblem RO", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 15, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "ResolveProblem Delete", 9, "ResolveProblem CB", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 3, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "ResolveProblem Edit", 10, "ResolveProblem BX", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "ResolveProblem Edit", 4, "ResolveProblem JJ", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "ResolveProblem Edit", 13, "ResolveProblem LM", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "ResolveProblem Activity Log", 5, "ResolveProblem MR", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 2, 16, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "ResolveProblem Activity Log", 11, "ResolveProblem YQ", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 11, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "ResolveProblem Activity Log", 5, "ResolveProblem NQ", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 2, 14, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "ResolveProblem Add", 9, "ResolveProblem CI", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "ResolveProblem Add", 10, "ResolveProblem EM", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "ResolveProblem Edit", 8, "ResolveProblem EK", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 9, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "ResolveProblem Edit", 7, "ResolveProblem DG", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 3, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "ResolveProblem Delete", 2, "ResolveProblem NJ", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "ResolveProblem Activity Log", 14, "ResolveProblem LI", "DE_DIEU", 3, "0", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "ResolveProblem Activity Log", 6, "ResolveProblem GB", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "ResolveProblem Delete", 7, "ResolveProblem TI", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 2, 1, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "ResolveProblem Activity Log", 10, "ResolveProblem ZV", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "ResolveProblem Delete", 1, "ResolveProblem YA", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "ResolveProblem Edit", 5, "ResolveProblem RY", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 1, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "ResolveProblem Add", 12, "ResolveProblem KZ", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "ResolveProblem Activity Log", 2, "ResolveProblem DR", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "ResolveProblem Delete", 1, "ResolveProblem YV", "DE_DIEU", 1, "1", new DateTime(2020, 12, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "ResolveProblem Add", 6, "ResolveProblem DR", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "ResolveProblem Add", 4, "ResolveProblem CQ", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 5, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "ResolveProblem Add", 1, "ResolveProblem LV", "LUOI_DIEN", 2, "0", new DateTime(2020, 12, 1, 7, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "ResolveProblem Edit", 8, "ResolveProblem AA", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "ResolveProblem Delete", 5, "ResolveProblem NF", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 1, 13, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "ResolveProblem Edit", 4, "ResolveProblem AT", "DE_DIEU", 1, "1", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "ResolveProblem Edit", 5, "ResolveProblem OD", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 1, 13, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "ResolveProblem Edit", 8, "ResolveProblem SC", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "ResolveProblem Add", 6, "ResolveProblem VW", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "ResolveProblem Delete", 1, "ResolveProblem YX", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 16, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "ResolveProblem Activity Log", 5, "ResolveProblem SP", "CAY_TRONG", 2, "1", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Statical Activity Log", 54, "Statical OA", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "Statical Add", 52, "Statical ZQ", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Statical Edit", 50, "Statical GU", "DE_DIEU", 4, "1", new DateTime(2020, 12, 2, 17, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Statical Edit", 42, "Statical YQ", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 11, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Statical Edit", 46, "Statical TA", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Statical Delete", 44, "Statical DG", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "Statical Delete", 56, "Statical EZ", "DE_DIEU", 2, "0", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Statical Edit", 48, "Statical IY", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 7, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Statical Add", 58, "Statical SP", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Statical Activity Log", 66, "Statical TC", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "Statical Add", 62, "Statical YD", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 1, 3, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Statical Add", 64, "Statical VD", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Statical Edit", 68, "Statical WT", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "Statical Delete", 70, "Statical MV", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "Statical Delete", 72, "Statical LW", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 1, 14, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Statical Add", 74, "Statical XF", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Statical Delete", 76, "Statical RU", "DE_DIEU", 1, "0", new DateTime(2020, 12, 1, 11, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Statical Delete", 40, "Statical JL", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Statical Delete", 60, "Statical AE", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Statical Delete", 78, "Statical LU", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "Statical Activity Log", 38, "Statical FA", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 13, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "Statical Add", 34, "Statical EK", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Statical Add", 36, "Statical CZ", "DE_DIEU", 4, "0", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Statical Activity Log", 0, "Statical WK", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Statical Delete", 2, "Statical WF", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 2, 9, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Statical Delete", 4, "Statical ZK", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Statical Delete", 6, "Statical UX", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 12, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Statical Edit", 10, "Statical KX", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 15, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Statical Edit", 12, "Statical KE", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 1, 5, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Statical Activity Log", 14, "Statical XN", "DE_DIEU", 1, "1", new DateTime(2020, 12, 1, 3, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Statical Activity Log", 8, "Statical YX", "DE_DIEU", 4, "0", new DateTime(2020, 12, 2, 6, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Statical Add", 18, "Statical NR", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Statical Add", 16, "Statical WT", "CAY_TRONG", 3, "0", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Statical Add", 30, "Statical FZ", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Statical Edit", 28, "Statical CN", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Statical Delete", 26, "Statical MM", "DE_DIEU", 2, "1", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Statical Delete", 32, "Statical NJ", "DE_DIEU", 1, "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Statical Activity Log", 22, "Statical SH", "CAY_TRONG", 1, "1", new DateTime(2020, 12, 1, 13, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "Statical Delete", 20, "Statical DM", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 1, 3, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Statical Activity Log", 24, "Statical JE", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 3, 24, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "UavConnect Activity Log", 10, 10, "UavConnect ZQ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "UavConnect Edit", 8, 1, "UavConnect AL", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "UavConnect Activity Log", 5, 1, "UavConnect AV", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "UavConnect Activity Log", 3, 14, "UavConnect KE", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "UavConnect Activity Log", 6, 2, "UavConnect IO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "UavConnect Add", 3, 7, "UavConnect SW", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "UavConnect Add", 6, 2, "UavConnect FE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "UavConnect Edit", 10, 9, "UavConnect HQ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "UavConnect Delete", 10, 7, "UavConnect QG", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "UavConnect Delete", 4, 3, "UavConnect NX", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "UavConnect Edit", 2, 14, "UavConnect FZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "UavConnect Delete", 1, 5, "UavConnect OW", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "UavConnect Add", 1, 14, "UavConnect TF", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "UavConnect Add", 3, 6, "UavConnect UC", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "UavConnect Edit", 1, 10, "UavConnect CV", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "UavConnect Edit", 6, 2, "UavConnect RM", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "UavConnect Edit", 3, 12, "UavConnect TL", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "UavConnect Add", 8, 6, "UavConnect CC", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "UavConnect Activity Log", 8, 9, "UavConnect QT", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "UavConnect Add", 9, 13, "UavConnect XM", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "UavConnect Add", 5, 13, "UavConnect ED", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "UavConnect Activity Log", 10, 13, "UavConnect GO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "UavConnect Add", 4, 9, "UavConnect FP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 2, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "UavConnect Delete", 3, 10, "UavConnect EF", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "UavConnect Add", 3, 13, "UavConnect KL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "UavConnect Add", 10, 10, "UavConnect CA", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "UavConnect Activity Log", 1, 1, "UavConnect DS", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "UavConnect Activity Log", 1, 9, "UavConnect TH", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "UavConnect Activity Log", 2, 8, "UavConnect DS", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "UavConnect Activity Log", 5, 10, "UavConnect UR", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "UavConnect Activity Log", 6, 6, "UavConnect FK", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "UavConnect Edit", 3, 14, "UavConnect DV", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "UavConnect Activity Log", 4, 12, "UavConnect QF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "UavConnect Activity Log", 9, 14, "UavConnect IX", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "UavConnect Delete", 10, 11, "UavConnect OI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "UavConnect Delete", 3, 7, "UavConnect PN", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "UavConnect Add", 3, 9, "UavConnect XL", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "UavConnect Edit", 4, 10, "UavConnect GZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "UavConnect Edit", 4, 13, "UavConnect MU", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "UavConnect Activity Log", 5, 1, "UavConnect KY", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type", "UserId" },
                values: new object[,]
                {
                    { 38, "User Activity Log", 5, 0, "Meta data example 28", "LUOI_DIEN", 3, 7, new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 20, 5 },
                    { 37, "User Add", 7, 0, "Meta data example 27", "CHAY_RUNG", 4, 4, new DateTime(2020, 12, 1, 4, 43, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 36, "User Add", 10, 0, "Meta data example 26", "LUOI_DIEN", 4, 12, new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 32, "User Activity Log", 9, 0, "Meta data example 22", "LUOI_DIEN", 3, 13, new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 34, "User Add", 7, 0, "Meta data example 24", "CAY_TRONG", 2, 6, new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 33, "User Delete", 4, 0, "Meta data example 23", "CAY_TRONG", 4, 7, new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 39, "User Add", 1, 0, "Meta data example 29", "CAY_TRONG", 2, 14, new DateTime(2020, 12, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), 2, 9 },
                    { 35, "User Edit", 8, 0, "Meta data example 25", "CHAY_RUNG", 4, 12, new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 4, 7 },
                    { 40, "User Add", 1, 0, "Meta data example 30", "CAY_TRONG", 1, 12, new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 2, 6 },
                    { 44, "User Add", 6, 0, "Meta data example 34", "CAY_TRONG", 1, 4, new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 42, "User Delete", 3, 0, "Meta data example 32", "CAY_TRONG", 4, 2, new DateTime(2020, 12, 1, 7, 2, 0, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 43, "User Delete", 8, 0, "Meta data example 33", "CHAY_RUNG", 3, 2, new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 45, "User Activity Log", 10, 0, "Meta data example 35", "CAY_TRONG", 3, 10, new DateTime(2020, 12, 2, 5, 42, 0, 0, DateTimeKind.Unspecified), 20, 10 },
                    { 46, "User Edit", 6, 0, "Meta data example 36", "LUOI_DIEN", 2, 4, new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 47, "User Edit", 2, 0, "Meta data example 37", "CAY_TRONG", 3, 9, new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 4, 8 },
                    { 48, "User Add", 4, 0, "Meta data example 38", "DE_DIEU", 4, 9, new DateTime(2020, 12, 2, 3, 37, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 49, "User Add", 7, 0, "Meta data example 39", "LUOI_DIEN", 1, 9, new DateTime(2020, 12, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 31, "User Delete", 2, 0, "Meta data example 21", "CAY_TRONG", 4, 3, new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 3, 7 },
                    { 41, "User Edit", 7, 0, "Meta data example 31", "LUOI_DIEN", 1, 12, new DateTime(2020, 12, 2, 3, 46, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 30, "User Delete", 7, 0, "Meta data example 20", "CHAY_RUNG", 1, 12, new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 3, 7 },
                    { 29, "User Add", 6, 0, "Meta data example 19", "CAY_TRONG", 3, 6, new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 28, "User Add", 6, 0, "Meta data example 18", "CAY_TRONG", 3, 9, new DateTime(2020, 12, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 10, "User Activity Log", 2, 0, "Meta data example 0", "DE_DIEU", 3, 7, new DateTime(2020, 12, 1, 5, 22, 0, 0, DateTimeKind.Unspecified), 20, 1 },
                    { 11, "User Activity Log", 10, 0, "Meta data example 1", "LUOI_DIEN", 4, 7, new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 12, "User Delete", 6, 0, "Meta data example 2", "DE_DIEU", 1, 7, new DateTime(2020, 12, 2, 13, 48, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 13, "User Add", 8, 0, "Meta data example 3", "CAY_TRONG", 1, 5, new DateTime(2020, 12, 1, 9, 9, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 14, "User Add", 1, 0, "Meta data example 4", "DE_DIEU", 1, 9, new DateTime(2020, 12, 2, 17, 48, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 16, "User Delete", 1, 0, "Meta data example 6", "CAY_TRONG", 2, 7, new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 17, "User Edit", 1, 0, "Meta data example 7", "DE_DIEU", 3, 3, new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 18, "User Edit", 2, 0, "Meta data example 8", "CHAY_RUNG", 1, 5, new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 15, "User Delete", 9, 0, "Meta data example 5", "DE_DIEU", 2, 9, new DateTime(2020, 12, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 20, "User Activity Log", 10, 0, "Meta data example 10", "CAY_TRONG", 1, 4, new DateTime(2020, 12, 2, 9, 21, 0, 0, DateTimeKind.Unspecified), 20, 5 },
                    { 19, "User Add", 4, 0, "Meta data example 9", "CHAY_RUNG", 1, 10, new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 26, "User Delete", 6, 0, "Meta data example 16", "LUOI_DIEN", 3, 14, new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 3, 6 },
                    { 25, "User Edit", 5, 0, "Meta data example 15", "LUOI_DIEN", 3, 9, new DateTime(2020, 12, 2, 12, 16, 0, 0, DateTimeKind.Unspecified), 4, 6 },
                    { 24, "User Activity Log", 1, 0, "Meta data example 14", "CHAY_RUNG", 3, 8, new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 20, 6 },
                    { 27, "User Delete", 4, 0, "Meta data example 17", "DE_DIEU", 1, 7, new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified), 3, 9 },
                    { 22, "User Add", 2, 0, "Meta data example 12", "CAY_TRONG", 4, 11, new DateTime(2020, 12, 2, 16, 15, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 21, "User Edit", 8, 0, "Meta data example 11", "CHAY_RUNG", 2, 1, new DateTime(2020, 12, 1, 15, 15, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 23, "User Edit", 8, 0, "Meta data example 13", "CHAY_RUNG", 4, 1, new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Video Delete", 3, 8, "Video DY", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "Video Edit", 9, 37, "Video QE", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Video Activity Log", 9, 23, "Video CW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "Video Edit", 8, 2, "Video SR", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "Video Edit", 4, 34, "Video WO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Video Delete", 8, 29, "Video NO", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "Video Delete", 6, 31, "Video TY", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "Video Activity Log", 7, 4, "Video MR", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "Video Edit", 6, 37, "Video SW", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Video Edit", 1, 30, "Video XP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Video Add", 5, 13, "Video VW", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Video Delete", 7, 21, "Video JT", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Video Activity Log", 9, 23, "Video IG", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Video Add", 5, 1, "Video CQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Video Edit", 4, 24, "Video AN", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 9, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Video Edit", 6, 7, "Video EL", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Video Delete", 1, 34, "Video ZM", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Video Edit", 5, 33, "Video IT", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Video Activity Log", 3, 37, "Video AO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Video Add", 8, 24, "Video IQ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Video Edit", 6, 34, "Video SN", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Video Edit", 1, 34, "Video IZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Video Add", 7, 12, "Video AH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Video Add", 1, 3, "Video QA", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Video Delete", 2, 5, "Video TY", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Video Add", 3, 28, "Video ID", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Video Delete", 10, 17, "Video RF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Video Delete", 9, 7, "Video LB", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Video Activity Log", 2, 6, "Video WP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "Video Activity Log", 9, 40, "Video RV", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Video Edit", 3, 26, "Video KR", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Video Add", 5, 34, "Video XR", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Video Activity Log", 1, 18, "Video GV", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Video Delete", 10, 3, "Video OM", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Video Edit", 8, 19, "Video GE", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Video Add", 1, 33, "Video FB", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Video Activity Log", 3, 4, "Video CO", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Video Activity Log", 7, 30, "Video XJ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Video Activity Log", 3, 3, "Video TQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Video Delete", 10, 30, "Video LR", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "Warning Delete", 8, "Warning HP", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 7, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Warning Activity Log", 5, "Warning SZ", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Warning Add", 10, "Warning MC", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Warning Activity Log", 9, "Warning XY", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 2, 10, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "Warning Add", 6, "Warning HV", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Warning Delete", 4, "Warning AZ", "CHAY_RUNG", 3, "1", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Warning Add", 8, "Warning GL", "CAY_TRONG", 2, "0", new DateTime(2020, 12, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Warning Edit", 1, "Warning GK", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Warning Edit", 8, "Warning TR", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 2, 2, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Warning Edit", 3, "Warning MC", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Warning Delete", 8, "Warning JP", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Warning Add", 6, "Warning HE", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Warning Edit", 5, "Warning KG", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Warning Activity Log", 3, "Warning DY", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Warning Edit", 8, "Warning ZY", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 2, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Warning Add", 8, "Warning IT", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Warning Edit", 2, "Warning XT", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Warning Activity Log", 8, "Warning HU", "DE_DIEU", 4, "1", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Warning Add", 5, "Warning YE", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Warning Delete", 7, "Warning PK", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 10, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Warning Add", 4, "Warning EN", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Warning Edit", 2, "Warning IX", "LUOI_DIEN", 3, "0", new DateTime(2020, 12, 2, 17, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Warning Edit", 4, "Warning IL", "LUOI_DIEN", 4, "0", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Warning Edit", 7, "Warning HT", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Warning Activity Log", 9, "Warning OK", "DE_DIEU", 1, "0", new DateTime(2020, 12, 2, 9, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "Warning Activity Log", 5, "Warning RK", "LUOI_DIEN", 2, "1", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Warning Edit", 5, "Warning CG", "CHAY_RUNG", 2, "0", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Warning Edit", 3, "Warning AR", "CAY_TRONG", 3, "1", new DateTime(2020, 12, 2, 7, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Warning Delete", 1, "Warning YS", "LUOI_DIEN", 1, "0", new DateTime(2020, 12, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "Warning Add", 9, "Warning QG", "CAY_TRONG", 4, "1", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Warning Edit", 1, "Warning DC", "CHAY_RUNG", 3, "0", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Warning Activity Log", 10, "Warning UG", "CHAY_RUNG", 1, "1", new DateTime(2020, 12, 1, 6, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "Warning Delete", 5, "Warning GK", "CHAY_RUNG", 2, "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Warning Edit", 4, "Warning BO", "DE_DIEU", 1, "0", new DateTime(2020, 12, 1, 12, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Warning Add", 6, "Warning MY", "LUOI_DIEN", 1, "1", new DateTime(2020, 12, 2, 3, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Warning Delete", 5, "Warning RU", "CHAY_RUNG", 4, "0", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "Warning Delete", 7, "Warning NU", "CHAY_RUNG", 4, "1", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Warning Activity Log", 2, "Warning VR", "DE_DIEU", 3, "0", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "Warning Add", 3, "Warning MS", "CHAY_RUNG", 1, "0", new DateTime(2020, 12, 2, 7, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Warning Activity Log", 4, "Warning OF", "LUOI_DIEN", 3, "1", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "DroneLogs");

            migrationBuilder.DropTable(
                name: "ImageLogs");

            migrationBuilder.DropTable(
                name: "IncidentLogs");

            migrationBuilder.DropTable(
                name: "MonitorRegionLogs");

            migrationBuilder.DropTable(
                name: "ObjectObserves");

            migrationBuilder.DropTable(
                name: "Payloads");

            migrationBuilder.DropTable(
                name: "ResolveProblemLogs");

            migrationBuilder.DropTable(
                name: "StaticalLogs");

            migrationBuilder.DropTable(
                name: "SystemLogs");

            migrationBuilder.DropTable(
                name: "UavConnectLogs");

            migrationBuilder.DropTable(
                name: "UserLog");

            migrationBuilder.DropTable(
                name: "VideoLogs");

            migrationBuilder.DropTable(
                name: "WarningLogs");
        }
    }
}
