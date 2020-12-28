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
                name: "DroneLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionName = table.Column<string>(type: "varchar(255)", nullable: true),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    Link = table.Column<string>(type: "varchar(255)", nullable: true),
                    DroneId = table.Column<string>(type: "varchar(255)", nullable: true),
                    IncidentId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    DroneId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    WorkName = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    Metadata = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true),
                    IncidentId = table.Column<string>(type: "varchar(255)", nullable: true),
                    ResolveProblemId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    DroneId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Link = table.Column<string>(type: "varchar(255)", nullable: true),
                    IncidentId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(type: "varchar(255)", nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(type: "varchar(255)", nullable: true),
                    State = table.Column<string>(type: "varchar(255)", nullable: true),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    RegionId = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarningLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 1, "2", "Drone Add", "1", 45, 18, "Drone 2", "DE_DIEU", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "6", "Drone Activity Log", "7", 25, 45, "Drone 9", "CAY_TRONG", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 15, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "4", "Drone Delete", "2", 24, 17, "Drone 6", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 15, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "5", "Drone Add", "6", 47, 35, "Drone 4", "LUOI_DIEN", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 11, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "2", "Drone Add", "7", 41, 44, "Drone 5", "DE_DIEU", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 10, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "8", "Drone Activity Log", "6", 32, 12, "Drone 6", "CAY_TRONG", "2", "MonitorRegion 4", new DateTime(2020, 12, 2, 13, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "3", "Drone Add", "7", 42, 40, "Drone 4", "DE_DIEU", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 3, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "7", "Drone Delete", "8", 14, 44, "Drone 7", "LUOI_DIEN", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 1, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "4", "Drone Add", "10", 19, 49, "Drone 1", "CAY_TRONG", "4", "MonitorRegion 1", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "9", "Drone Add", "10", 42, 34, "Drone 1", "DE_DIEU", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "1", "Drone Add", "5", 22, 18, "Drone 9", "DE_DIEU", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "4", "Drone Edit", "6", 27, 45, "Drone 2", "CHAY_RUNG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "6", "Drone Activity Log", "6", 16, 39, "Drone 2", "DE_DIEU", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "10", "Drone Add", "7", 43, 37, "Drone 4", "LUOI_DIEN", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 3, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "7", "Drone Edit", "7", 20, 36, "Drone 6", "CAY_TRONG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 3, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "5", "Drone Activity Log", "10", 46, 44, "Drone 7", "CAY_TRONG", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 15, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "7", "Drone Add", "5", 18, 10, "Drone 1", "DE_DIEU", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "8", "Drone Edit", "4", 37, 16, "Drone 1", "CAY_TRONG", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "10", "Drone Edit", "10", 32, 13, "Drone 10", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "10", "Drone Edit", "8", 28, 35, "Drone 8", "CAY_TRONG", "2", "MonitorRegion 4", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "8", "Drone Edit", "8", 38, 43, "Drone 9", "CHAY_RUNG", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 1, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "6", "Drone Edit", "6", 34, 42, "Drone 5", "DE_DIEU", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 3, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "4", "Drone Edit", "6", 38, 19, "Drone 9", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, "2", "Drone Edit", "8", 15, 47, "Drone 5", "LUOI_DIEN", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 3, "3", "Drone Edit", "2", 37, 11, "Drone 6", "DE_DIEU", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 4, "5", "Drone Activity Log", "3", 16, 26, "Drone 9", "DE_DIEU", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 5, "8", "Drone Delete", "6", 20, 41, "Drone 7", "CAY_TRONG", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 4, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, "8", "Drone Add", "6", 40, 44, "Drone 5", "LUOI_DIEN", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, "5", "Drone Add", "2", 25, 40, "Drone 6", "CAY_TRONG", "4", "MonitorRegion 3", new DateTime(2020, 12, 1, 14, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, "2", "Drone Activity Log", "4", 43, 23, "Drone 6", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "5", "Drone Add", "8", 17, 36, "Drone 8", "LUOI_DIEN", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "10", "Drone Edit", "1", 23, 16, "Drone 9", "CHAY_RUNG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 6, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "2", "Drone Edit", "10", 47, 45, "Drone 8", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "4", "Drone Edit", "1", 18, 24, "Drone 6", "LUOI_DIEN", "4", "MonitorRegion 3", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "6", "Drone Edit", "8", 42, 24, "Drone 10", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "8", "Drone Edit", "10", 30, 45, "Drone 10", "LUOI_DIEN", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "6", "Drone Activity Log", "6", 22, 29, "Drone 5", "DE_DIEU", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "2", "Drone Activity Log", "3", 20, 20, "Drone 8", "LUOI_DIEN", "2", "MonitorRegion 3", new DateTime(2020, 12, 1, 10, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "4", "Drone Add", "9", 29, 10, "Drone 4", "LUOI_DIEN", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 13, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "8", "Drone Add", "8", 13, 46, "Drone 4", "DE_DIEU", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "1", "Hình ảnh theo dõi LUOI_DIEN EPIDD", "10", "17", "8", "Image OX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 13, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "2", "Hình ảnh theo dõi DE_DIEU AATJQ", "9", "38", "12", "Image ZT", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "3", "Hình ảnh theo dõi CAY_TRONG NDOBR", "5", "30", "2", "Image HX", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "5", "Hình ảnh theo dõi DE_DIEU BPVHX", "6", "27", "14", "Image DD", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "8", "Hình ảnh theo dõi CAY_TRONG SGCSK", "3", "16", "2", "Image HG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "1", "Hình ảnh theo dõi CAY_TRONG JUZWK", "1", "25", "10", "Image HB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "8", "Hình ảnh theo dõi DE_DIEU JXDDI", "10", "4", "4", "Image ZS", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "1", "Hình ảnh theo dõi CHAY_RUNG DTVEG", "4", "11", "12", "Image RB", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "9", "Hình ảnh theo dõi CHAY_RUNG SVIHT", "9", "32", "7", "Image AT", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "9", "Hình ảnh theo dõi DE_DIEU WVVLE", "7", "31", "1", "Image AC", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "1", "Hình ảnh theo dõi LUOI_DIEN AZARI", "4", "15", "12", "Image YB", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "2", "Hình ảnh theo dõi DE_DIEU GURTE", "1", "39", "8", "Image TR", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "10", "Hình ảnh theo dõi DE_DIEU HBQVR", "7", "20", "8", "Image MC", "DE_DIEU", "0", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "10", "Hình ảnh theo dõi LUOI_DIEN VXUAW", "1", "8", "9", "Image NG", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 4, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "5", "Hình ảnh theo dõi DE_DIEU QZDIZ", "4", "4", "13", "Image BJ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "5", "Hình ảnh theo dõi CAY_TRONG TJBYI", "3", "24", "10", "Image ZG", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "3", "Hình ảnh theo dõi DE_DIEU LQCMG", "7", "37", "10", "Image LM", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "1", "Hình ảnh theo dõi CAY_TRONG DFBBJ", "7", "2", "9", "Image FG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "10", "Hình ảnh theo dõi DE_DIEU JCRKN", "8", "32", "9", "Image XH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "3", "Hình ảnh theo dõi LUOI_DIEN DEADD", "8", "15", "7", "Image QV", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "1", "Hình ảnh theo dõi DE_DIEU WODBF", "2", "3", "8", "Image NC", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "10", "Hình ảnh theo dõi DE_DIEU OZXZK", "7", "39", "14", "Image HS", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "9", "Hình ảnh theo dõi CHAY_RUNG KUMPQ", "2", "6", "3", "Image NP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "10", "Hình ảnh theo dõi CAY_TRONG RWZZW", "2", "15", "12", "Image SF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "4", "Hình ảnh theo dõi DE_DIEU CKRSY", "6", "32", "9", "Image WD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "5", "Hình ảnh theo dõi LUOI_DIEN BQRUZ", "3", "19", "14", "Image UD", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "6", "Hình ảnh theo dõi LUOI_DIEN XDTLC", "1", "30", "9", "Image ZN", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "7", "Hình ảnh theo dõi DE_DIEU PWRPQ", "8", "16", "12", "Image DI", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "9", "Hình ảnh theo dõi CAY_TRONG PJJOW", "6", "35", "14", "Image IL", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "4", "Hình ảnh theo dõi LUOI_DIEN ZDZFV", "10", "32", "13", "Image OA", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "3", "Hình ảnh theo dõi DE_DIEU SLBSY", "4", "25", "8", "Image TU", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "9", "Hình ảnh theo dõi CHAY_RUNG CDWBW", "4", "31", "7", "Image MI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "Hình ảnh theo dõi LUOI_DIEN IVEPL", "3", "38", "10", "Image PS", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "10", "Hình ảnh theo dõi CHAY_RUNG SOLZA", "6", "19", "1", "Image IH", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "9", "Hình ảnh theo dõi CHAY_RUNG WVXFB", "3", "13", "2", "Image QX", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "1", "Hình ảnh theo dõi DE_DIEU PGSHF", "5", "39", "7", "Image JA", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "3", "Hình ảnh theo dõi LUOI_DIEN BAXZJ", "7", "10", "9", "Image KL", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "8", "Hình ảnh theo dõi LUOI_DIEN TLZJH", "6", "7", "4", "Image VC", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "9", "Hình ảnh theo dõi LUOI_DIEN HBFJQ", "5", "40", "8", "Image WX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 4, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "9", "Hình ảnh theo dõi DE_DIEU YIAFW", "4", "15", "1", "Image KK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 32, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "6", "Incident Activity Log", "2", "Incident WK", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "7", "Incident Add", "13", "Incident PX", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "8", "Incident Add", "11", "Incident CL", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "5", "Incident Add", "11", "Incident KU", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 16, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "7", "Incident Edit", "9", "Incident RU", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "10", "Incident Edit", "2", "Incident XJ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "9", "Incident Edit", "11", "Incident GP", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 6, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "5", "Incident Edit", "1", "Incident FQ", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 4, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "3", "Incident Edit", "4", "Incident KZ", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "4", "Incident Delete", "9", "Incident AX", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "6", "Incident Delete", "4", "Incident YB", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 12, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "5", "Incident Edit", "2", "Incident YZ", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "3", "Incident Activity Log", "6", "Incident KK", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "4", "Incident Activity Log", "7", "Incident EQ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "4", "Incident Edit", "2", "Incident NH", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 15, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "5", "Incident Add", "3", "Incident JE", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "7", "Incident Delete", "5", "Incident AS", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 10, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "5", "Incident Add", "10", "Incident PC", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "7", "Incident Add", "7", "Incident CQ", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "2", "Incident Delete", "6", "Incident UN", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "3", "Incident Delete", "1", "Incident BI", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 12, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "2", "Incident Delete", "1", "Incident NU", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 7, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "1", "Incident Edit", "3", "Incident PZ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "1", "Incident Activity Log", "4", "Incident CO", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "3", "Incident Add", "7", "Incident ZD", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "9", "Incident Add", "10", "Incident NF", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "8", "Incident Activity Log", "1", "Incident QH", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "2", "Incident Activity Log", "14", "Incident QB", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "8", "Incident Delete", "7", "Incident SR", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "4", "Incident Edit", "11", "Incident YK", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 3, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "5", "Incident Add", "1", "Incident YH", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 3, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "3", "Incident Activity Log", "6", "Incident CS", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "8", "Incident Add", "3", "Incident OY", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "10", "Incident Delete", "12", "Incident PZ", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 3, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "3", "Incident Edit", "5", "Incident EC", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "2", "Incident Edit", "1", "Incident WJ", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "10", "Incident Activity Log", "10", "Incident YY", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "6", "Incident Edit", "14", "Incident OW", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 2, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "8", "Incident Edit", "14", "Incident NI", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 7, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "6", "Incident Add", "12", "Incident YV", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 10, 36, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, "4", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "7", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "2", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "10", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "3", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "7", "MonitorRegion Add", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "7", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "8", "MonitorRegion Add", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 15, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "3", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "9", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "6", "MonitorRegion Edit", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "7", "MonitorRegion Add", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "7", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "1", "MonitorRegion Add", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "9", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "3", "MonitorRegion Edit", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "3", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "7", "MonitorRegion Add", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "1", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "6", "MonitorRegion Edit", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "7", "MonitorRegion Delete", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 1, "4", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 2, "2", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, "3", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, "4", "MonitorRegion Edit", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "1", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, "8", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 7, "9", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 8, "8", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, "8", "MonitorRegion Delete", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "1", "MonitorRegion Delete", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "10", "MonitorRegion Edit", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "7", "MonitorRegion Add", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "3", "MonitorRegion Delete", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "9", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "10", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "9", "MonitorRegion Edit", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "6", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "10", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "3", "MonitorRegion Delete", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 26, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "8", "ObjectObserve Delete", "17", "ObjectObserve TV", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 15, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "7", "ObjectObserve Add", "5", "ObjectObserve QI", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 17, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "4", "ObjectObserve Edit", "17", "ObjectObserve IZ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "2", "ObjectObserve Delete", "11", "ObjectObserve KP", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "1", "ObjectObserve Delete", "20", "ObjectObserve SN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 2, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "3", "ObjectObserve Delete", "6", "ObjectObserve RK", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "4", "ObjectObserve Add", "9", "ObjectObserve GI", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 13, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "6", "ObjectObserve Edit", "17", "ObjectObserve UX", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "2", "ObjectObserve Edit", "12", "ObjectObserve JS", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 5, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "9", "ObjectObserve Activity Log", "16", "ObjectObserve WA", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "4", "ObjectObserve Add", "20", "ObjectObserve XR", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 5, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "10", "ObjectObserve Delete", "18", "ObjectObserve OD", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 4, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "7", "ObjectObserve Activity Log", "15", "ObjectObserve HP", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 1, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "4", "ObjectObserve Edit", "19", "ObjectObserve ZB", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "3", "ObjectObserve Edit", "20", "ObjectObserve IY", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "10", "ObjectObserve Activity Log", "20", "ObjectObserve FK", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "4", "ObjectObserve Add", "7", "ObjectObserve FF", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 15, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "7", "ObjectObserve Edit", "3", "ObjectObserve ZX", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 8, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "10", "ObjectObserve Edit", "15", "ObjectObserve OQ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "3", "ObjectObserve Add", "5", "ObjectObserve HE", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 1, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "10", "ObjectObserve Delete", "20", "ObjectObserve AP", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "3", "ObjectObserve Edit", "13", "ObjectObserve WL", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 8, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "4", "ObjectObserve Activity Log", "15", "ObjectObserve GY", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 14, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "10", "ObjectObserve Delete", "7", "ObjectObserve LB", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 5, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "7", "ObjectObserve Activity Log", "16", "ObjectObserve QJ", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 13, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "3", "ObjectObserve Delete", "5", "ObjectObserve BN", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "7", "ObjectObserve Delete", "18", "ObjectObserve TK", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "ObjectObserve Edit", "15", "ObjectObserve EM", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "4", "ObjectObserve Delete", "10", "ObjectObserve PW", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "2", "ObjectObserve Add", "14", "ObjectObserve NQ", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 13, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "5", "ObjectObserve Activity Log", "15", "ObjectObserve IT", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "1", "ObjectObserve Delete", "17", "ObjectObserve DF", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "3", "ObjectObserve Activity Log", "15", "ObjectObserve AR", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "5", "ObjectObserve Add", "19", "ObjectObserve SF", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 14, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "6", "ObjectObserve Activity Log", "15", "ObjectObserve NK", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 9, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "7", "ObjectObserve Edit", "10", "ObjectObserve RI", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "5", "ObjectObserve Edit", "14", "ObjectObserve IF", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 8, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "1", "ObjectObserve Add", "9", "ObjectObserve YM", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "8", "ObjectObserve Activity Log", "2", "ObjectObserve EZ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "1", "ObjectObserve Activity Log", "6", "ObjectObserve QU", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 11, 24, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "2", "Payload Delete", "1", "10", "ID-JWV-W", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "7", "Payload Activity Log", "4", "8", "IX-TCF-P", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "10", "Payload Edit", "8", "8", "NW-QCA-N", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "1", "Payload Delete", "9", "5", "FB-VRE-M", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "5", "Payload Activity Log", "8", "3", "AB-QVV-Y", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "7", "Payload Edit", "1", "5", "ZT-BZK-U", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "10", "Payload Edit", "1", "1", "NX-NZZ-G", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "5", "Payload Edit", "2", "7", "QE-HDG-A", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "3", "Payload Add", "7", "8", "WR-ZZH-S", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "6", "Payload Edit", "1", "1", "DO-DPT-U", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "3", "Payload Edit", "9", "10", "DI-SEF-Q", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "8", "Payload Edit", "1", "7", "XG-YZB-Y", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "9", "Payload Delete", "1", "1", "OU-WDU-G", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "1", "Payload Edit", "9", "5", "UF-OIE-U", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "1", "Payload Add", "6", "8", "PG-GCC-Y", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "2", "Payload Edit", "3", "1", "WP-YAJ-P", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "7", "Payload Activity Log", "7", "10", "WJ-LPC-E", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 14, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "6", "Payload Delete", "7", "8", "WD-HKR-B", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "9", "Payload Activity Log", "7", "9", "VE-TMX-J", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 4, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "3", "Payload Edit", "5", "10", "UH-MYN-A", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 2, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "9", "Payload Add", "7", "1", "MR-TAG-D", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "9", "Payload Add", "2", "3", "EA-QZO-U", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "6", "Payload Delete", "10", "1", "XS-BOC-K", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "8", "Payload Add", "10", "8", "MU-JRK-F", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "4", "Payload Delete", "8", "10", "UD-ZDI-Z", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "2", "Payload Activity Log", "8", "10", "UG-HOX-M", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "8", "Payload Delete", "9", "6", "PD-JQG-J", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "2", "Payload Add", "6", "7", "OO-OZU-O", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "6", "Payload Delete", "6", "3", "KE-GTM-Q", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "4", "Payload Delete", "10", "3", "WR-VFV-N", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "5", "Payload Activity Log", "1", "4", "WL-RPF-P", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "3", "Payload Activity Log", "2", "3", "QA-BEW-H", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "7", "Payload Add", "10", "5", "OL-ENK-P", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "3", "Payload Delete", "8", "2", "BA-UKV-B", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "7", "Payload Edit", "9", "3", "MN-KKW-B", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "10", "Payload Add", "3", "9", "UO-TWU-K", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "2", "Payload Activity Log", "7", "4", "EE-PQJ-D", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "5", "Payload Delete", "9", "2", "GQ-SLX-T", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "8", "Payload Delete", "3", "10", "UF-VCS-E", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "1", "Payload Add", "6", "10", "LU-AFY-T", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "2", "ResolveProblem Add", "13", "ResolveProblem VI", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "9", "ResolveProblem Edit", "4", "ResolveProblem FM", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "3", "ResolveProblem Delete", "8", "ResolveProblem ZB", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 9, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "10", "ResolveProblem Edit", "2", "ResolveProblem JC", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "7", "ResolveProblem Activity Log", "9", "ResolveProblem LM", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 12, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "1", "ResolveProblem Edit", "11", "ResolveProblem RD", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "3", "ResolveProblem Delete", "7", "ResolveProblem ZV", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "7", "ResolveProblem Edit", "7", "ResolveProblem NR", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "1", "ResolveProblem Delete", "14", "ResolveProblem SC", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "10", "ResolveProblem Delete", "3", "ResolveProblem YW", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 6, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "1", "ResolveProblem Add", "5", "ResolveProblem PT", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 11, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "2", "ResolveProblem Edit", "4", "ResolveProblem SG", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 5, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "2", "ResolveProblem Edit", "10", "ResolveProblem GA", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 8, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "9", "ResolveProblem Add", "5", "ResolveProblem RL", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 3, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "1", "ResolveProblem Activity Log", "14", "ResolveProblem DI", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "6", "ResolveProblem Activity Log", "7", "ResolveProblem HM", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 7, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "8", "ResolveProblem Add", "5", "ResolveProblem JY", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "1", "ResolveProblem Activity Log", "14", "ResolveProblem XT", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 6, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "2", "ResolveProblem Delete", "12", "ResolveProblem IB", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "3", "ResolveProblem Edit", "13", "ResolveProblem PS", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 3, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "6", "ResolveProblem Add", "7", "ResolveProblem KS", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "ResolveProblem Delete", "12", "ResolveProblem RX", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 13, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "10", "ResolveProblem Activity Log", "5", "ResolveProblem AT", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "9", "ResolveProblem Activity Log", "14", "ResolveProblem YD", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "8", "ResolveProblem Activity Log", "2", "ResolveProblem MH", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 11, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "2", "ResolveProblem Edit", "12", "ResolveProblem DJ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "5", "ResolveProblem Add", "10", "ResolveProblem UJ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 4, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "6", "ResolveProblem Edit", "13", "ResolveProblem HO", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 14, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "9", "ResolveProblem Activity Log", "4", "ResolveProblem ZF", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "10", "ResolveProblem Add", "13", "ResolveProblem SM", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "3", "ResolveProblem Edit", "3", "ResolveProblem OH", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "7", "ResolveProblem Edit", "4", "ResolveProblem OA", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "4", "ResolveProblem Edit", "9", "ResolveProblem CM", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 13, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "7", "ResolveProblem Edit", "1", "ResolveProblem HU", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "4", "ResolveProblem Add", "14", "ResolveProblem EC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "10", "ResolveProblem Activity Log", "8", "ResolveProblem DR", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "2", "ResolveProblem Activity Log", "3", "ResolveProblem GM", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 3, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "8", "ResolveProblem Edit", "14", "ResolveProblem OF", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 3, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "7", "ResolveProblem Activity Log", "13", "ResolveProblem KI", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "4", "ResolveProblem Delete", "2", "ResolveProblem WW", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "4", "Statical Delete", "54", "Statical QB", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "6", "Statical Activity Log", "52", "Statical PN", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "9", "Statical Activity Log", "50", "Statical BS", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "7", "Statical Add", "42", "Statical TU", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 10, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "4", "Statical Activity Log", "46", "Statical PO", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "6", "Statical Edit", "44", "Statical XV", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "5", "Statical Add", "56", "Statical TK", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "1", "Statical Activity Log", "48", "Statical TO", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 7, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "9", "Statical Delete", "58", "Statical BN", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "10", "Statical Delete", "66", "Statical RE", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 11, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "10", "Statical Delete", "62", "Statical PD", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 8, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "4", "Statical Activity Log", "64", "Statical AO", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 14, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "9", "Statical Activity Log", "68", "Statical VI", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "3", "Statical Activity Log", "70", "Statical WD", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "8", "Statical Delete", "72", "Statical DY", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "3", "Statical Add", "74", "Statical KH", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "1", "Statical Edit", "76", "Statical JA", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 8, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "8", "Statical Activity Log", "40", "Statical RN", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "5", "Statical Add", "60", "Statical MF", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "7", "Statical Delete", "78", "Statical ZA", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "8", "Statical Delete", "38", "Statical XD", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 9, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "6", "Statical Edit", "34", "Statical XY", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 1, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "6", "Statical Activity Log", "36", "Statical AV", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "3", "Statical Delete", "0", "Statical WH", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "6", "Statical Edit", "2", "Statical SE", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "5", "Statical Activity Log", "4", "Statical MX", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "10", "Statical Add", "6", "Statical CT", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 9, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "Statical Delete", "10", "Statical RM", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "Statical Add", "12", "Statical JG", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 11, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "6", "Statical Add", "14", "Statical AB", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 3, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "1", "Statical Activity Log", "8", "Statical KU", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 14, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "2", "Statical Add", "18", "Statical ZS", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "2", "Statical Activity Log", "16", "Statical PI", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 4, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "6", "Statical Add", "30", "Statical CV", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "10", "Statical Add", "28", "Statical HF", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 10, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "1", "Statical Delete", "26", "Statical UM", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 7, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "10", "Statical Edit", "32", "Statical YN", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "10", "Statical Activity Log", "22", "Statical OZ", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 13, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "1", "Statical Delete", "20", "Statical IG", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "4", "Statical Edit", "24", "Statical DP", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "6", "Giám sát Edit", "2", "Đợi giám sát quý 2", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", "Giám sát Delete", "10", "Đợi giám sát quý 2", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "5", "Giám sát Activity Log", "1", "Đợi giám sát quý 2", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "6", "Giám sát Add", "6", "Đợi giám sát quý 1", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 10, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "2", "Giám sát Activity Log", "10", "Đợi giám sát quý 1", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 5, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "4", "Giám sát Activity Log", "1", "Đợi giám sát quý 2", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "7", "Giám sát Delete", "1", "Đợi giám sát quý 2", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "7", "Giám sát Edit", "11", "Đợi giám sát quý 2", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 5, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "5", "Giám sát Add", "8", "Đợi giám sát quý 2", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 3, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "2", "Giám sát Delete", "13", "Đợi giám sát quý 2", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 14, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "8", "Giám sát Add", "3", "Đợi giám sát quý 2", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "10", "Giám sát Add", "8", "Đợi giám sát quý 2", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "1", "Giám sát Activity Log", "10", "Đợi giám sát quý 2", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "8", "Giám sát Add", "3", "Đợi giám sát quý 1", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 2, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "9", "Giám sát Activity Log", "3", "Đợi giám sát quý 1", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "9", "Giám sát Add", "12", "Đợi giám sát quý 2", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "2", "Giám sát Edit", "4", "Đợi giám sát quý 1", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 1, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "5", "Giám sát Delete", "6", "Đợi giám sát quý 1", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 11, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "6", "Giám sát Delete", "13", "Đợi giám sát quý 1", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 13, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "5", "Giám sát Edit", "4", "Đợi giám sát quý 2", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "8", "Giám sát Add", "7", "Đợi giám sát quý 1", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 5, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "5", "Giám sát Activity Log", "9", "Đợi giám sát quý 1", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "4", "Giám sát Edit", "5", "Đợi giám sát quý 2", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "6", "Giám sát Delete", "3", "Đợi giám sát quý 1", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "8", "Giám sát Delete", "9", "Đợi giám sát quý 2", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 15, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "10", "Giám sát Add", "1", "Đợi giám sát quý 1", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 11, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "7", "Giám sát Edit", "14", "Đợi giám sát quý 2", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 6, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "6", "Giám sát Edit", "7", "Đợi giám sát quý 2", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 15, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "2", "Giám sát Add", "7", "Đợi giám sát quý 2", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 13, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "3", "Giám sát Delete", "5", "Đợi giám sát quý 1", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 10, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "3", "Giám sát Activity Log", "11", "Đợi giám sát quý 1", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "4", "Giám sát Delete", "13", "Đợi giám sát quý 1", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 14, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "3", "Giám sát Delete", "6", "Đợi giám sát quý 1", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "2", "Giám sát Add", "13", "Đợi giám sát quý 2", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "5", "Giám sát Activity Log", "4", "Đợi giám sát quý 2", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 1, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "10", "Giám sát Edit", "4", "Đợi giám sát quý 2", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "5", "Giám sát Delete", "1", "Đợi giám sát quý 1", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "9", "Giám sát Edit", "10", "Đợi giám sát quý 2", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "1", "Giám sát Add", "4", "Đợi giám sát quý 2", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "2", "Giám sát Add", "10", "Đợi giám sát quý 1", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "3", "User Add", "8", null, "Meta data example 28", "SJFEH PAVJ", "CAY_TRONG", "1", "2", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "7", "User Edit", "3", null, "Meta data example 27", "ODUXM GLQC", "CAY_TRONG", "4", "13", new DateTime(2020, 12, 2, 3, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "7", "User Activity Log", "1", null, "Meta data example 26", "UXNOP WKJO", "LUOI_DIEN", "1", "6", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "4", "User Edit", "9", null, "Meta data example 22", "ZZRVX FRII", "CAY_TRONG", "2", "8", new DateTime(2020, 12, 2, 1, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "8", "User Add", "3", null, "Meta data example 24", "DTNBT SMIC", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "4", "User Delete", "9", null, "Meta data example 23", "JWWMP AWNA", "CHAY_RUNG", "3", "3", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "3", "User Delete", "7", null, "Meta data example 29", "SAFDI GFZL", "CAY_TRONG", "2", "12", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "8", "User Add", "7", null, "Meta data example 25", "BUWAC IHVI", "DE_DIEU", "1", "12", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "6", "User Activity Log", "5", null, "Meta data example 30", "ICTOP YZYN", "DE_DIEU", "4", "10", new DateTime(2020, 12, 1, 6, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "2", "User Delete", "9", null, "Meta data example 34", "QBHNL BGCZ", "CAY_TRONG", "1", "7", new DateTime(2020, 12, 2, 11, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "10", "User Activity Log", "2", null, "Meta data example 32", "WOZGV NXQP", "DE_DIEU", "3", "6", new DateTime(2020, 12, 2, 15, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "7", "User Delete", "9", null, "Meta data example 33", "BMEFW PPRP", "LUOI_DIEN", "4", "12", new DateTime(2020, 12, 2, 5, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "4", "User Activity Log", "8", null, "Meta data example 35", "OVSLA UDMT", "CAY_TRONG", "3", "5", new DateTime(2020, 12, 1, 9, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "7", "User Add", "3", null, "Meta data example 36", "AJIHU JMOG", "CHAY_RUNG", "1", "6", new DateTime(2020, 12, 2, 16, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "8", "User Edit", "3", null, "Meta data example 37", "WAUYJ UGLV", "CHAY_RUNG", "2", "12", new DateTime(2020, 12, 2, 10, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "3", "User Activity Log", "2", null, "Meta data example 38", "GUQTR FUSF", "LUOI_DIEN", "3", "6", new DateTime(2020, 12, 2, 15, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "6", "User Add", "6", null, "Meta data example 39", "MCXNH GSAT", "CHAY_RUNG", "3", "2", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "1", "User Activity Log", "2", null, "Meta data example 21", "SGWEO KRUA", "CHAY_RUNG", "3", "9", new DateTime(2020, 12, 1, 15, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "9", "User Activity Log", "2", null, "Meta data example 31", "WRTDD LRJH", "CAY_TRONG", "2", "2", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "1", "User Add", "2", null, "Meta data example 20", "HYRFB MFWX", "DE_DIEU", "4", "9", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "10", "User Delete", "2", null, "Meta data example 19", "ZINQO TOWR", "DE_DIEU", "1", "8", new DateTime(2020, 12, 1, 4, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "User Activity Log", "3", null, "Meta data example 18", "ZNTCO JPLA", "LUOI_DIEN", "2", "9", new DateTime(2020, 12, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "9", "User Add", "8", null, "Meta data example 0", "YATGP AGUX", "DE_DIEU", "3", "2", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "4", "User Add", "5", null, "Meta data example 1", "QDATD ZJWN", "DE_DIEU", "2", "5", new DateTime(2020, 12, 1, 8, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "2", "User Add", "6", null, "Meta data example 2", "SQOXO EDEI", "CAY_TRONG", "4", "10", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "10", "User Edit", "8", null, "Meta data example 3", "LGTQX ZCVF", "CAY_TRONG", "4", "8", new DateTime(2020, 12, 2, 7, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "9", "User Activity Log", "6", null, "Meta data example 4", "NVGYR AKPW", "CHAY_RUNG", "4", "4", new DateTime(2020, 12, 1, 4, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "7", "User Delete", "9", null, "Meta data example 6", "XBMES JKKW", "CAY_TRONG", "4", "2", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "6", "User Add", "9", null, "Meta data example 7", "WORRR WKQF", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 10, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "10", "User Edit", "9", null, "Meta data example 8", "TNHIV MAGF", "DE_DIEU", "1", "2", new DateTime(2020, 12, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "6", "User Add", "6", null, "Meta data example 5", "XZGML ILWS", "CHAY_RUNG", "4", "10", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "6", "User Delete", "1", null, "Meta data example 10", "PZTSD JIOV", "CHAY_RUNG", "4", "4", new DateTime(2020, 12, 2, 7, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "7", "User Edit", "2", null, "Meta data example 9", "OGCUZ LIBF", "DE_DIEU", "4", "10", new DateTime(2020, 12, 2, 2, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "6", "User Edit", "7", null, "Meta data example 16", "XLWPZ PKRH", "CAY_TRONG", "2", "12", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "6", "User Edit", "4", null, "Meta data example 15", "RETZX LULC", "CAY_TRONG", "3", "11", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "7", "User Delete", "10", null, "Meta data example 14", "ELLRR SQYD", "LUOI_DIEN", "3", "4", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "User Activity Log", "1", null, "Meta data example 17", "OEZWC YSNP", "DE_DIEU", "2", "10", new DateTime(2020, 12, 2, 14, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "5", "User Add", "7", null, "Meta data example 12", "JEFHQ PLXS", "DE_DIEU", "3", "10", new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "4", "User Edit", "7", null, "Meta data example 11", "XVQER JUDI", "DE_DIEU", "4", "4", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "8", "User Add", "7", null, "Meta data example 13", "OIKYX UUPE", "CAY_TRONG", "4", "4", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "6", "Video theo dõi CHAY_RUNG KKNCC", "10", "19", "14", "Video YR", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 2, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "10", "Video theo dõi CHAY_RUNG OTIVK", "9", "13", "10", "Video CP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "6", "Video theo dõi CHAY_RUNG HPODR", "5", "35", "13", "Video XQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "2", "Video theo dõi CHAY_RUNG KJSAT", "1", "29", "4", "Video BI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "1", "Video theo dõi CHAY_RUNG HHZQO", "8", "24", "9", "Video ZQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "5", "Video theo dõi CHAY_RUNG PMUEP", "8", "20", "10", "Video SN", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "5", "Video theo dõi CHAY_RUNG DLVKI", "8", "23", "12", "Video LU", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "9", "Video theo dõi CHAY_RUNG GRKCD", "6", "12", "6", "Video XW", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "6", "Video theo dõi CHAY_RUNG UQJVH", "4", "24", "7", "Video YR", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "5", "Video theo dõi CHAY_RUNG USORL", "5", "25", "4", "Video JZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "10", "Video theo dõi CHAY_RUNG WSWIF", "8", "5", "13", "Video XP", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "1", "Video theo dõi CHAY_RUNG MVKWO", "4", "4", "11", "Video OK", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "2", "Video theo dõi CHAY_RUNG PGTFE", "5", "37", "9", "Video KX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "7", "Video theo dõi CHAY_RUNG TOMGX", "10", "25", "11", "Video OA", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "1", "Video theo dõi CHAY_RUNG MSGLA", "4", "33", "2", "Video OH", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "3", "Video theo dõi CHAY_RUNG URPHO", "1", "33", "5", "Video US", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "3", "Video theo dõi CHAY_RUNG RWPXS", "10", "26", "3", "Video ZN", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "2", "Video theo dõi CHAY_RUNG CXMVM", "5", "40", "12", "Video VX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "3", "Video theo dõi CHAY_RUNG YBOFD", "4", "19", "12", "Video ME", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "9", "Video theo dõi CHAY_RUNG CSRCZ", "10", "22", "9", "Video XO", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "8", "Video theo dõi CHAY_RUNG DMROZ", "5", "11", "9", "Video UU", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "5", "Video theo dõi CHAY_RUNG UWSBO", "7", "9", "6", "Video BV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 6, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "5", "Video theo dõi CHAY_RUNG JNBJX", "3", "26", "14", "Video XN", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "10", "Video theo dõi CHAY_RUNG OFDEP", "6", "32", "13", "Video IC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "7", "Video theo dõi CHAY_RUNG RWBIL", "9", "4", "7", "Video DW", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "5", "Video theo dõi CHAY_RUNG QEPGL", "8", "21", "1", "Video TF", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "6", "Video theo dõi CHAY_RUNG NPLDG", "1", "30", "9", "Video XP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "Video theo dõi CHAY_RUNG OWUKJ", "4", "5", "1", "Video EC", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "2", "Video theo dõi CHAY_RUNG ZZVAL", "6", "38", "1", "Video WH", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "3", "Video theo dõi CHAY_RUNG AZRZW", "8", "35", "10", "Video YZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "2", "Video theo dõi CHAY_RUNG GIKCW", "9", "15", "6", "Video CA", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "8", "Video theo dõi CHAY_RUNG NSEGC", "10", "27", "6", "Video PI", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "4", "Video theo dõi CHAY_RUNG BQCXK", "2", "37", "13", "Video AF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "9", "Video theo dõi CHAY_RUNG WAEBC", "3", "22", "6", "Video ZA", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "4", "Video theo dõi CHAY_RUNG SYGVT", "1", "36", "12", "Video KE", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "3", "Video theo dõi CHAY_RUNG ZGWYF", "4", "4", "2", "Video SV", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "5", "Video theo dõi CHAY_RUNG EIMEU", "6", "2", "7", "Video TR", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "8", "Video theo dõi CHAY_RUNG ZTBCR", "5", "18", "3", "Video CE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "6", "Video theo dõi CHAY_RUNG HCSYQ", "4", "14", "9", "Video TG", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "3", "Video theo dõi CHAY_RUNG GICCS", "4", "11", "2", "Video TZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 41, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "8", "Warning Edit", "6", "Warning SB", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "10", "Warning Delete", "2", "Warning GA", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "8", "Warning Activity Log", "2", "Warning JH", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "8", "Warning Delete", "10", "Warning ZU", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 14, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "1", "Warning Add", "8", "Warning PL", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 7, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "1", "Warning Add", "10", "Warning NP", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 13, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "5", "Warning Edit", "2", "Warning MP", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "10", "Warning Delete", "2", "Warning VT", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "4", "Warning Add", "2", "Warning JA", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 1, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "8", "Warning Add", "6", "Warning KZ", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "3", "Warning Edit", "3", "Warning DE", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "1", "Warning Activity Log", "5", "Warning DO", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 8, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "2", "Warning Add", "4", "Warning VJ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 16, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "8", "Warning Edit", "5", "Warning XG", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "7", "Warning Add", "8", "Warning RG", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 11, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "6", "Warning Add", "3", "Warning QX", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "6", "Warning Add", "2", "Warning LO", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 1, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "10", "Warning Add", "7", "Warning LW", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 5, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "9", "Warning Activity Log", "3", "Warning SP", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "10", "Warning Add", "9", "Warning NA", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "5", "Warning Delete", "4", "Warning TU", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 12, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "2", "Warning Edit", "2", "Warning ZX", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 2, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "6", "Warning Delete", "4", "Warning FV", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "3", "Warning Delete", "2", "Warning QD", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "2", "Warning Delete", "2", "Warning LD", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 4, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "2", "Warning Delete", "3", "Warning UB", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 10, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "8", "Warning Add", "3", "Warning LY", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 13, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "1", "Warning Delete", "10", "Warning MU", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "7", "Warning Edit", "2", "Warning FX", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "8", "Warning Delete", "2", "Warning YX", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 4, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "5", "Warning Edit", "3", "Warning AB", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "9", "Warning Activity Log", "6", "Warning WG", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "2", "Warning Edit", "9", "Warning AM", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 1, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "1", "Warning Delete", "8", "Warning SF", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "2", "Warning Add", "3", "Warning QL", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "4", "Warning Add", "10", "Warning XJ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 7, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "8", "Warning Activity Log", "1", "Warning ZZ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 14, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "9", "Warning Delete", "10", "Warning GW", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 16, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "Warning Add", "8", "Warning DG", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "5", "Warning Activity Log", "2", "Warning MO", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
