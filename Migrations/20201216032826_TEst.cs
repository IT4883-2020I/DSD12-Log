using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class TEst : Migration
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    RegionId = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
                    ImageId = table.Column<string>(nullable: true),
                    VideoId = table.Column<string>(nullable: true),
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
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
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
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
                    AuthorId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    WorkName = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    Metadata = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true),
                    IncidentId = table.Column<string>(nullable: true),
                    ResolveProblemId = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
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
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegionId = table.Column<string>(nullable: true)
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
                    { 1, "4", "Drone Add", "3", 33, 37, "Drone 10", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "6", "Drone Delete", "10", 30, 18, "Drone 5", "LUOI_DIEN", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 16, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "4", "Drone Delete", "8", 18, 18, "Drone 1", "LUOI_DIEN", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 1, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "9", "Drone Add", "7", 17, 47, "Drone 10", "DE_DIEU", "2", "MonitorRegion 2", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "3", "Drone Delete", "9", 21, 29, "Drone 4", "LUOI_DIEN", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "9", "Drone Edit", "6", 31, 12, "Drone 7", "CAY_TRONG", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "3", "Drone Add", "1", 15, 43, "Drone 3", "LUOI_DIEN", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "9", "Drone Delete", "10", 40, 23, "Drone 7", "CHAY_RUNG", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 3, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "10", "Drone Delete", "1", 14, 30, "Drone 7", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "2", "Drone Add", "3", 23, 46, "Drone 5", "CHAY_RUNG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "6", "Drone Add", "6", 49, 49, "Drone 9", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "9", "Drone Edit", "9", 31, 10, "Drone 9", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "3", "Drone Add", "2", 15, 11, "Drone 4", "DE_DIEU", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "10", "Drone Edit", "5", 44, 49, "Drone 7", "CAY_TRONG", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "7", "Drone Delete", "4", 11, 37, "Drone 3", "DE_DIEU", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "2", "Drone Activity Log", "4", 33, 34, "Drone 10", "DE_DIEU", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "5", "Drone Delete", "7", 49, 34, "Drone 1", "CHAY_RUNG", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 7, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "5", "Drone Edit", "2", 34, 41, "Drone 4", "CAY_TRONG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 17, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "7", "Drone Add", "1", 21, 44, "Drone 1", "CHAY_RUNG", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "6", "Drone Activity Log", "4", 38, 28, "Drone 7", "CAY_TRONG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "3", "Drone Add", "10", 10, 32, "Drone 5", "CAY_TRONG", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 5, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "4", "Drone Add", "9", 38, 23, "Drone 10", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "1", "Drone Delete", "7", 25, 17, "Drone 6", "CHAY_RUNG", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, "10", "Drone Add", "3", 34, 21, "Drone 3", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 9, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "6", "Drone Edit", "3", 11, 42, "Drone 5", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 5, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 4, "7", "Drone Add", "8", 38, 20, "Drone 6", "CAY_TRONG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "9", "Drone Edit", "4", 47, 10, "Drone 9", "LUOI_DIEN", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 15, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 6, "1", "Drone Add", "1", 42, 31, "Drone 10", "LUOI_DIEN", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, "10", "Drone Activity Log", "4", 36, 39, "Drone 5", "CAY_TRONG", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 6, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, "1", "Drone Edit", "9", 35, 13, "Drone 10", "LUOI_DIEN", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "9", "Drone Delete", "4", 47, 39, "Drone 3", "LUOI_DIEN", "4", "MonitorRegion 2", new DateTime(2020, 12, 2, 1, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, "3", "Drone Add", "9", 36, 46, "Drone 5", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "8", "Drone Add", "9", 34, 39, "Drone 1", "CHAY_RUNG", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "2", "Drone Delete", "1", 43, 42, "Drone 9", "CAY_TRONG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 16, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "10", "Drone Activity Log", "9", 47, 26, "Drone 7", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "8", "Drone Delete", "7", 14, 48, "Drone 8", "LUOI_DIEN", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "Drone Edit", "6", 20, 40, "Drone 5", "LUOI_DIEN", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "9", "Drone Add", "10", 21, 39, "Drone 8", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "9", "Drone Edit", "10", 38, 39, "Drone 7", "CAY_TRONG", "4", "MonitorRegion 3", new DateTime(2020, 12, 1, 2, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "8", "Drone Delete", "3", 39, 16, "Drone 6", "DE_DIEU", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "2", "Image Delete", "6", "34", "Image BR", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "5", "Image Activity Log", "9", "23", "Image MX", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "6", "Image Add", "4", "22", "Image KG", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "8", "Image Edit", "6", "32", "Image ES", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "1", "Image Activity Log", "5", "29", "Image IY", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "1", "Image Edit", "9", "19", "Image LY", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "1", "Image Activity Log", "2", "33", "Image GO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "3", "Image Delete", "3", "25", "Image BO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "8", "Image Add", "2", "26", "Image SC", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "2", "Image Activity Log", "7", "12", "Image RV", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "10", "Image Edit", "4", "4", "Image QQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "6", "Image Add", "4", "36", "Image GA", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "6", "Image Add", "1", "22", "Image TP", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "8", "Image Activity Log", "3", "27", "Image OP", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "1", "Image Activity Log", "4", "34", "Image FQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "2", "Image Activity Log", "8", "18", "Image ZX", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "3", "Image Delete", "1", "6", "Image UP", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "2", "Image Add", "5", "3", "Image XT", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "4", "Image Add", "7", "15", "Image XB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "2", "Image Edit", "1", "40", "Image BW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "6", "Image Activity Log", "10", "15", "Image XG", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "8", "Image Delete", "5", "19", "Image RM", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 4, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "8", "Image Add", "3", "15", "Image IQ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "4", "Image Edit", "9", "13", "Image CM", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "1", "Image Add", "9", "26", "Image TI", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "5", "Image Delete", "5", "11", "Image JN", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "5", "Image Activity Log", "4", "9", "Image YH", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "4", "Image Delete", "8", "2", "Image JS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "2", "Image Activity Log", "7", "25", "Image BV", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "1", "Image Activity Log", "1", "21", "Image CC", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "10", "Image Delete", "2", "22", "Image LT", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "8", "Image Delete", "4", "4", "Image OH", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "1", "Image Delete", "8", "27", "Image QU", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 2, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "4", "Image Edit", "10", "20", "Image GO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "7", "Image Activity Log", "10", "20", "Image KW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "2", "Image Edit", "7", "13", "Image DO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "2", "Image Edit", "10", "30", "Image OX", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "8", "Image Activity Log", "2", "17", "Image FW", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "1", "Image Delete", "1", "21", "Image AV", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "Image Delete", "5", "10", "Image YW", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "ImageId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type", "VideoId" },
                values: new object[,]
                {
                    { 32, "5", "Incident Delete", "2", "21", "Incident FJ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 3, "12" },
                    { 33, "8", "Incident Edit", "4", "19", "Incident ZO", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 1, 21, 0, 0, DateTimeKind.Unspecified), 4, "22" },
                    { 34, "1", "Incident Delete", "4", "8", "Incident JH", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 3, "2" },
                    { 35, "5", "Incident Delete", "9", "10", "Incident HW", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), 3, "3" },
                    { 36, "5", "Incident Delete", "6", "18", "Incident CW", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 3, "6" },
                    { 37, "8", "Incident Activity Log", "8", "33", "Incident WY", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 20, "21" },
                    { 38, "10", "Incident Add", "12", "10", "Incident AG", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 13, 14, 0, 0, DateTimeKind.Unspecified), 2, "33" },
                    { 40, "10", "Incident Activity Log", "14", "5", "Incident GN", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 9, 47, 0, 0, DateTimeKind.Unspecified), 20, "11" },
                    { 44, "6", "Incident Edit", "3", "2", "Incident VG", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 4, "5" },
                    { 42, "9", "Incident Add", "8", "30", "Incident QB", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 2, "5" },
                    { 43, "5", "Incident Edit", "14", "39", "Incident PO", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 4, "25" },
                    { 31, "2", "Incident Activity Log", "3", "20", "Incident HO", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), 20, "1" },
                    { 45, "2", "Incident Activity Log", "14", "36", "Incident NH", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 20, "38" },
                    { 46, "10", "Incident Add", "11", "15", "Incident AM", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 2, "38" },
                    { 47, "10", "Incident Edit", "11", "2", "Incident OQ", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 16, 14, 0, 0, DateTimeKind.Unspecified), 4, "19" },
                    { 48, "4", "Incident Edit", "14", "30", "Incident HP", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 4, "17" },
                    { 49, "2", "Incident Activity Log", "8", "33", "Incident TH", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 9, 11, 0, 0, DateTimeKind.Unspecified), 20, "19" },
                    { 41, "8", "Incident Delete", "13", "25", "Incident BA", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 14, 19, 0, 0, DateTimeKind.Unspecified), 3, "25" },
                    { 30, "9", "Incident Add", "10", "5", "Incident LX", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 11, 42, 0, 0, DateTimeKind.Unspecified), 2, "36" },
                    { 39, "9", "Incident Add", "11", "14", "Incident RK", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 2, "40" },
                    { 28, "8", "Incident Delete", "1", "32", "Incident UJ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), 3, "7" },
                    { 11, "2", "Incident Activity Log", "3", "39", "Incident DX", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 20, "31" },
                    { 12, "2", "Incident Activity Log", "5", "5", "Incident BP", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 20, "40" },
                    { 13, "1", "Incident Delete", "10", "31", "Incident LB", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 12, 13, 0, 0, DateTimeKind.Unspecified), 3, "35" },
                    { 14, "8", "Incident Add", "3", "29", "Incident OX", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 7, 4, 0, 0, DateTimeKind.Unspecified), 2, "13" },
                    { 15, "6", "Incident Add", "9", "26", "Incident UJ", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 2, "35" },
                    { 16, "7", "Incident Edit", "4", "27", "Incident TL", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 7, 46, 0, 0, DateTimeKind.Unspecified), 4, "37" },
                    { 17, "7", "Incident Activity Log", "3", "27", "Incident FS", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 20, "31" },
                    { 18, "4", "Incident Add", "8", "5", "Incident PT", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 1, 44, 0, 0, DateTimeKind.Unspecified), 2, "33" },
                    { 19, "3", "Incident Delete", "4", "31", "Incident DQ", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 7, 40, 0, 0, DateTimeKind.Unspecified), 3, "1" },
                    { 10, "4", "Incident Edit", "6", "25", "Incident PR", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 4, "8" },
                    { 20, "7", "Incident Activity Log", "1", "37", "Incident XQ", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 3, 29, 0, 0, DateTimeKind.Unspecified), 20, "26" },
                    { 21, "2", "Incident Activity Log", "13", "18", "Incident EF", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 5, 23, 0, 0, DateTimeKind.Unspecified), 20, "36" },
                    { 22, "5", "Incident Add", "6", "16", "Incident FX", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 2, 49, 0, 0, DateTimeKind.Unspecified), 2, "8" },
                    { 23, "2", "Incident Add", "14", "19", "Incident LD", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 1, 41, 0, 0, DateTimeKind.Unspecified), 2, "16" },
                    { 24, "5", "Incident Edit", "14", "14", "Incident JH", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 4, "31" },
                    { 25, "10", "Incident Add", "7", "26", "Incident TX", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 2, "1" },
                    { 26, "3", "Incident Edit", "7", "23", "Incident FL", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 6, 15, 0, 0, DateTimeKind.Unspecified), 4, "8" },
                    { 27, "5", "Incident Activity Log", "9", "5", "Incident RM", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 15, 25, 0, 0, DateTimeKind.Unspecified), 20, "37" },
                    { 29, "4", "Incident Activity Log", "8", "15", "Incident SN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 2, 14, 0, 0, DateTimeKind.Unspecified), 20, "31" }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 28, "7", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "8", "MonitorRegion Edit", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "1", "MonitorRegion Add", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "6", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "2", "MonitorRegion Delete", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "3", "MonitorRegion Add", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "9", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "10", "MonitorRegion Edit", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "8", "MonitorRegion Delete", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "7", "MonitorRegion Edit", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "6", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "5", "MonitorRegion Edit", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "10", "MonitorRegion Delete", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "8", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "8", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "10", "MonitorRegion Delete", "3", "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "4", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "10", "MonitorRegion Add", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "1", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "8", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "2", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 1, "1", "MonitorRegion Add", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 2, "6", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 3, "9", "MonitorRegion Add", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 4, "2", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "4", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 6, "6", "MonitorRegion Add", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "1", "MonitorRegion Delete", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, "10", "MonitorRegion Edit", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, "10", "MonitorRegion Edit", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "1", "MonitorRegion Add", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "6", "MonitorRegion Add", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 12, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "7", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "7", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "4", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "8", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "3", "MonitorRegion Edit", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "10", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "5", "MonitorRegion Add", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 1, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "1", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 48, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "6", "ObjectObserve Activity Log", "13", "ObjectObserve TH", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 1, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "7", "ObjectObserve Edit", "4", "ObjectObserve BP", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 13, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "3", "ObjectObserve Add", "19", "ObjectObserve AB", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "6", "ObjectObserve Edit", "3", "ObjectObserve WU", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "8", "ObjectObserve Add", "10", "ObjectObserve IT", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 13, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "2", "ObjectObserve Edit", "1", "ObjectObserve AF", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "5", "ObjectObserve Activity Log", "17", "ObjectObserve VA", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 10, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "10", "ObjectObserve Add", "18", "ObjectObserve EN", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 14, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "4", "ObjectObserve Delete", "13", "ObjectObserve ZD", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "3", "ObjectObserve Add", "13", "ObjectObserve CR", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "8", "ObjectObserve Delete", "2", "ObjectObserve OQ", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 15, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "8", "ObjectObserve Activity Log", "18", "ObjectObserve LA", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "2", "ObjectObserve Edit", "10", "ObjectObserve YB", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 12, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "3", "ObjectObserve Add", "4", "ObjectObserve NB", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "1", "ObjectObserve Activity Log", "11", "ObjectObserve RH", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "9", "ObjectObserve Add", "11", "ObjectObserve GB", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "9", "ObjectObserve Activity Log", "6", "ObjectObserve DL", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "5", "ObjectObserve Activity Log", "5", "ObjectObserve EK", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "4", "ObjectObserve Add", "18", "ObjectObserve BL", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 9, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "4", "ObjectObserve Add", "7", "ObjectObserve SB", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 9, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "5", "ObjectObserve Activity Log", "3", "ObjectObserve CO", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 1, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "5", "ObjectObserve Edit", "10", "ObjectObserve GK", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "5", "ObjectObserve Activity Log", "14", "ObjectObserve IH", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 10, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "7", "ObjectObserve Delete", "9", "ObjectObserve GO", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "3", "ObjectObserve Activity Log", "15", "ObjectObserve WS", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 11, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "5", "ObjectObserve Add", "2", "ObjectObserve CI", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "9", "ObjectObserve Delete", "17", "ObjectObserve BQ", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 15, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "5", "ObjectObserve Delete", "18", "ObjectObserve IA", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "10", "ObjectObserve Edit", "3", "ObjectObserve IN", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "1", "ObjectObserve Activity Log", "7", "ObjectObserve ZQ", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "5", "ObjectObserve Activity Log", "12", "ObjectObserve RM", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 4, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "6", "ObjectObserve Activity Log", "6", "ObjectObserve RU", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 1, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "7", "ObjectObserve Activity Log", "1", "ObjectObserve IS", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 14, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "9", "ObjectObserve Activity Log", "18", "ObjectObserve SW", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 7, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "9", "ObjectObserve Activity Log", "10", "ObjectObserve XZ", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "9", "ObjectObserve Edit", "17", "ObjectObserve VK", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "9", "ObjectObserve Add", "6", "ObjectObserve JY", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 3, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "7", "ObjectObserve Activity Log", "7", "ObjectObserve LI", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "2", "ObjectObserve Delete", "4", "ObjectObserve GX", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "7", "ObjectObserve Activity Log", "6", "ObjectObserve OZ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 17, 15, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "4", "Payload Add", "10", "6", "Payload EW", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "2", "Payload Edit", "8", "8", "Payload RR", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "5", "Payload Edit", "5", "7", "Payload AT", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "9", "Payload Add", "10", "7", "Payload UZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "9", "Payload Activity Log", "7", "2", "Payload FX", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "4", "Payload Edit", "2", "7", "Payload LN", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "4", "Payload Edit", "7", "3", "Payload RB", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "5", "Payload Add", "5", "7", "Payload JX", "DE_DIEU", "1", new DateTime(2020, 12, 1, 2, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "1", "Payload Add", "9", "10", "Payload MI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "10", "Payload Delete", "6", "3", "Payload LP", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "10", "Payload Edit", "7", "7", "Payload RA", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "8", "Payload Edit", "10", "4", "Payload DE", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "5", "Payload Add", "2", "1", "Payload YC", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "4", "Payload Add", "4", "5", "Payload IC", "DE_DIEU", "1", new DateTime(2020, 12, 2, 16, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "3", "Payload Activity Log", "2", "9", "Payload GN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "9", "Payload Add", "10", "10", "Payload UU", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "3", "Payload Delete", "9", "6", "Payload FD", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "8", "Payload Edit", "3", "5", "Payload OT", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "2", "Payload Edit", "10", "3", "Payload UZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "1", "Payload Activity Log", "2", "9", "Payload XH", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "5", "Payload Add", "10", "4", "Payload SZ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "10", "Payload Edit", "9", "3", "Payload IB", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "6", "Payload Delete", "4", "6", "Payload GA", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "1", "Payload Activity Log", "6", "2", "Payload EF", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "1", "Payload Activity Log", "9", "4", "Payload BN", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "3", "Payload Add", "3", "7", "Payload HB", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "7", "Payload Add", "5", "4", "Payload TD", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "5", "Payload Activity Log", "9", "5", "Payload JK", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "8", "Payload Activity Log", "8", "8", "Payload JQ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 1, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "4", "Payload Add", "1", "8", "Payload JI", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "4", "Payload Delete", "7", "1", "Payload GW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 10, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "5", "Payload Edit", "6", "1", "Payload TY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "3", "Payload Edit", "5", "10", "Payload PM", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 5, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "7", "Payload Activity Log", "1", "5", "Payload ZD", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "8", "Payload Add", "10", "5", "Payload JN", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "5", "Payload Activity Log", "4", "6", "Payload MA", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "9", "Payload Edit", "9", "8", "Payload WV", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "1", "Payload Edit", "3", "5", "Payload DX", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "1", "Payload Delete", "8", "10", "Payload WX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "6", "Payload Add", "4", "3", "Payload FC", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "1", "ResolveProblem Edit", "1", "ResolveProblem WC", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "4", "ResolveProblem Delete", "8", "ResolveProblem DW", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 5, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "3", "ResolveProblem Edit", "6", "ResolveProblem RK", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "5", "ResolveProblem Activity Log", "10", "ResolveProblem WV", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 12, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "5", "ResolveProblem Delete", "13", "ResolveProblem JG", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "2", "ResolveProblem Activity Log", "7", "ResolveProblem KP", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "9", "ResolveProblem Activity Log", "2", "ResolveProblem PB", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "10", "ResolveProblem Activity Log", "1", "ResolveProblem DT", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "10", "ResolveProblem Delete", "1", "ResolveProblem WC", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 4, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "2", "ResolveProblem Activity Log", "1", "ResolveProblem UD", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "2", "ResolveProblem Add", "14", "ResolveProblem OA", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 13, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "7", "ResolveProblem Delete", "5", "ResolveProblem RZ", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "6", "ResolveProblem Delete", "13", "ResolveProblem XS", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "10", "ResolveProblem Add", "13", "ResolveProblem EJ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "1", "ResolveProblem Activity Log", "11", "ResolveProblem EV", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "5", "ResolveProblem Add", "6", "ResolveProblem YK", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "7", "ResolveProblem Delete", "2", "ResolveProblem MB", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "10", "ResolveProblem Add", "3", "ResolveProblem XN", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "10", "ResolveProblem Edit", "13", "ResolveProblem GK", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 6, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "1", "ResolveProblem Delete", "8", "ResolveProblem KB", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "1", "ResolveProblem Add", "6", "ResolveProblem ZA", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "9", "ResolveProblem Delete", "7", "ResolveProblem PP", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 13, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "1", "ResolveProblem Edit", "12", "ResolveProblem LZ", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 10, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "7", "ResolveProblem Delete", "1", "ResolveProblem YZ", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 5, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "10", "ResolveProblem Edit", "10", "ResolveProblem FQ", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "1", "ResolveProblem Activity Log", "9", "ResolveProblem CO", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "10", "ResolveProblem Activity Log", "12", "ResolveProblem TU", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 2, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "10", "ResolveProblem Add", "2", "ResolveProblem GO", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 5, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "7", "ResolveProblem Delete", "6", "ResolveProblem OZ", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "8", "ResolveProblem Edit", "14", "ResolveProblem NK", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 15, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "8", "ResolveProblem Edit", "12", "ResolveProblem ZY", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "9", "ResolveProblem Add", "7", "ResolveProblem DX", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "8", "ResolveProblem Delete", "10", "ResolveProblem SG", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 9, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "5", "ResolveProblem Edit", "4", "ResolveProblem MX", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 17, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "6", "ResolveProblem Delete", "5", "ResolveProblem KO", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "8", "ResolveProblem Activity Log", "10", "ResolveProblem MN", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "4", "ResolveProblem Delete", "11", "ResolveProblem RT", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 6, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "4", "ResolveProblem Add", "5", "ResolveProblem LR", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 13, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "2", "ResolveProblem Activity Log", "13", "ResolveProblem OA", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 14, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "7", "ResolveProblem Add", "4", "ResolveProblem NQ", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "1", "Statical Add", "54", "Statical HN", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "4", "Statical Edit", "52", "Statical DQ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "7", "Statical Delete", "50", "Statical NP", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "6", "Statical Add", "42", "Statical RF", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "10", "Statical Add", "46", "Statical HQ", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 12, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "2", "Statical Activity Log", "44", "Statical CC", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "2", "Statical Edit", "56", "Statical OA", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "10", "Statical Activity Log", "48", "Statical MU", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "3", "Statical Edit", "58", "Statical GO", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 5, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "6", "Statical Delete", "66", "Statical VB", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 4, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "9", "Statical Delete", "62", "Statical IZ", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "1", "Statical Activity Log", "64", "Statical FI", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "6", "Statical Edit", "68", "Statical AR", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "10", "Statical Add", "70", "Statical RK", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "5", "Statical Delete", "72", "Statical II", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 6, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "4", "Statical Add", "74", "Statical ZD", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 7, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "10", "Statical Edit", "76", "Statical KP", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "6", "Statical Delete", "40", "Statical XD", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 13, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "5", "Statical Add", "60", "Statical XI", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "7", "Statical Edit", "78", "Statical SD", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 6, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "10", "Statical Edit", "38", "Statical GI", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "9", "Statical Edit", "34", "Statical WB", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "5", "Statical Edit", "36", "Statical VQ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 15, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "5", "Statical Activity Log", "0", "Statical GA", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 5, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "7", "Statical Add", "2", "Statical DG", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 13, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "9", "Statical Delete", "4", "Statical PQ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "1", "Statical Activity Log", "6", "Statical CP", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "4", "Statical Activity Log", "10", "Statical FU", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "4", "Statical Add", "12", "Statical QI", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "9", "Statical Activity Log", "14", "Statical PI", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "1", "Statical Add", "8", "Statical MY", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 9, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "6", "Statical Delete", "18", "Statical ML", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "4", "Statical Activity Log", "16", "Statical VV", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "7", "Statical Edit", "30", "Statical ET", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "4", "Statical Delete", "28", "Statical AP", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "1", "Statical Activity Log", "26", "Statical WX", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "6", "Statical Add", "32", "Statical ZX", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 5, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "6", "Statical Activity Log", "22", "Statical KW", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "1", "Statical Add", "20", "Statical XS", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "1", "Statical Edit", "24", "Statical OV", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 5, 8, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "7", "UavConnect Add", "1", "7", "UavConnect IN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "7", "UavConnect Activity Log", "6", "7", "UavConnect DZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "8", "UavConnect Edit", "9", "2", "UavConnect KO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "8", "UavConnect Delete", "7", "1", "UavConnect JV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "4", "UavConnect Delete", "9", "11", "UavConnect GF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "2", "UavConnect Edit", "6", "6", "UavConnect BI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "7", "UavConnect Edit", "6", "5", "UavConnect KR", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "5", "UavConnect Delete", "9", "5", "UavConnect CR", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "9", "UavConnect Add", "2", "8", "UavConnect ZZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "9", "UavConnect Activity Log", "8", "9", "UavConnect ZR", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "3", "UavConnect Add", "6", "5", "UavConnect JM", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "4", "UavConnect Delete", "7", "7", "UavConnect KT", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "3", "UavConnect Add", "3", "13", "UavConnect QV", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "2", "UavConnect Add", "3", "1", "UavConnect DY", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "9", "UavConnect Add", "5", "6", "UavConnect DI", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "3", "UavConnect Activity Log", "1", "8", "UavConnect ZG", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "7", "UavConnect Edit", "6", "14", "UavConnect DQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "7", "UavConnect Edit", "6", "6", "UavConnect XK", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "8", "UavConnect Edit", "2", "6", "UavConnect AZ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "1", "UavConnect Delete", "10", "12", "UavConnect IK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "3", "UavConnect Edit", "10", "8", "UavConnect PE", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "1", "UavConnect Delete", "6", "9", "UavConnect WN", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "2", "UavConnect Edit", "7", "9", "UavConnect DL", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "9", "UavConnect Edit", "4", "12", "UavConnect WB", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "10", "UavConnect Edit", "1", "5", "UavConnect VB", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "5", "UavConnect Add", "8", "13", "UavConnect ZM", "DE_DIEU", "0", new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "4", "UavConnect Activity Log", "7", "10", "UavConnect GA", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "8", "UavConnect Add", "2", "8", "UavConnect NM", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "2", "UavConnect Activity Log", "7", "11", "UavConnect RZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "6", "UavConnect Delete", "6", "1", "UavConnect GT", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "7", "UavConnect Edit", "2", "10", "UavConnect HX", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "6", "UavConnect Edit", "7", "2", "UavConnect VD", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "10", "UavConnect Activity Log", "5", "1", "UavConnect ZU", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "6", "UavConnect Delete", "1", "8", "UavConnect SS", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "8", "UavConnect Edit", "4", "10", "UavConnect RB", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "10", "UavConnect Edit", "9", "9", "UavConnect MJ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "2", "UavConnect Delete", "3", "3", "UavConnect XF", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "3", "UavConnect Delete", "3", "2", "UavConnect FR", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "7", "UavConnect Delete", "10", "11", "UavConnect IW", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "7", "UavConnect Edit", "9", "14", "UavConnect XV", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "5", "User Activity Log", "9", null, "Meta data example 28", "LUOI_DIEN", "1", "6", new DateTime(2020, 12, 2, 16, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "9", "User Activity Log", "8", null, "Meta data example 27", "LUOI_DIEN", "3", "6", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "6", "User Add", "7", null, "Meta data example 26", "CHAY_RUNG", "3", "9", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "3", "User Activity Log", "4", null, "Meta data example 22", "DE_DIEU", "4", "7", new DateTime(2020, 12, 1, 4, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "2", "User Edit", "4", null, "Meta data example 24", "LUOI_DIEN", "3", "8", new DateTime(2020, 12, 2, 13, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "3", "User Activity Log", "8", null, "Meta data example 23", "CHAY_RUNG", "1", "5", new DateTime(2020, 12, 2, 7, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "10", "User Edit", "9", null, "Meta data example 29", "LUOI_DIEN", "2", "11", new DateTime(2020, 12, 1, 1, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "1", "User Edit", "2", null, "Meta data example 25", "CHAY_RUNG", "4", "11", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "4", "User Delete", "1", null, "Meta data example 30", "DE_DIEU", "2", "6", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "6", "User Activity Log", "6", null, "Meta data example 34", "LUOI_DIEN", "1", "2", new DateTime(2020, 12, 1, 1, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "4", "User Edit", "1", null, "Meta data example 32", "LUOI_DIEN", "3", "11", new DateTime(2020, 12, 2, 16, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "4", "User Activity Log", "6", null, "Meta data example 33", "DE_DIEU", "1", "5", new DateTime(2020, 12, 2, 12, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "5", "User Edit", "7", null, "Meta data example 35", "CHAY_RUNG", "3", "6", new DateTime(2020, 12, 2, 6, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "10", "User Edit", "10", null, "Meta data example 36", "LUOI_DIEN", "3", "7", new DateTime(2020, 12, 1, 8, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "10", "User Delete", "1", null, "Meta data example 37", "DE_DIEU", "2", "4", new DateTime(2020, 12, 2, 14, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "3", "User Edit", "3", null, "Meta data example 38", "DE_DIEU", "2", "3", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "5", "User Activity Log", "2", null, "Meta data example 39", "DE_DIEU", "3", "14", new DateTime(2020, 12, 1, 9, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "4", "User Activity Log", "4", null, "Meta data example 21", "DE_DIEU", "1", "10", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "3", "User Activity Log", "10", null, "Meta data example 31", "DE_DIEU", "2", "5", new DateTime(2020, 12, 1, 2, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "1", "User Activity Log", "5", null, "Meta data example 20", "DE_DIEU", "1", "4", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "10", "User Add", "6", null, "Meta data example 19", "CAY_TRONG", "2", "7", new DateTime(2020, 12, 2, 2, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "8", "User Edit", "5", null, "Meta data example 18", "DE_DIEU", "1", "9", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "7", "User Activity Log", "2", null, "Meta data example 0", "LUOI_DIEN", "3", "7", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "2", "User Delete", "9", null, "Meta data example 1", "LUOI_DIEN", "1", "5", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "7", "User Add", "3", null, "Meta data example 2", "CAY_TRONG", "3", "10", new DateTime(2020, 12, 1, 1, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "3", "User Edit", "5", null, "Meta data example 3", "CHAY_RUNG", "4", "8", new DateTime(2020, 12, 1, 10, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "10", "User Add", "3", null, "Meta data example 4", "CHAY_RUNG", "3", "14", new DateTime(2020, 12, 1, 9, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "9", "User Activity Log", "8", null, "Meta data example 6", "DE_DIEU", "2", "2", new DateTime(2020, 12, 2, 2, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "1", "User Add", "2", null, "Meta data example 7", "CHAY_RUNG", "2", "14", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "2", "User Add", "10", null, "Meta data example 8", "LUOI_DIEN", "4", "6", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "User Activity Log", "6", null, "Meta data example 5", "DE_DIEU", "3", "11", new DateTime(2020, 12, 2, 7, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "10", "User Add", "6", null, "Meta data example 10", "LUOI_DIEN", "3", "3", new DateTime(2020, 12, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "3", "User Edit", "1", null, "Meta data example 9", "LUOI_DIEN", "3", "8", new DateTime(2020, 12, 2, 10, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "4", "User Delete", "1", null, "Meta data example 16", "CAY_TRONG", "1", "10", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "3", "User Activity Log", "9", null, "Meta data example 15", "CAY_TRONG", "3", "13", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "10", "User Edit", "2", null, "Meta data example 14", "DE_DIEU", "3", "5", new DateTime(2020, 12, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "5", "User Edit", "6", null, "Meta data example 17", "CAY_TRONG", "3", "12", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "2", "User Activity Log", "4", null, "Meta data example 12", "DE_DIEU", "2", "14", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "5", "User Add", "9", null, "Meta data example 11", "LUOI_DIEN", "1", "2", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "4", "User Delete", "1", null, "Meta data example 13", "CHAY_RUNG", "2", "13", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "2", "Video Activity Log", "2", "25", "Video LD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "2", "Video Delete", "10", "24", "Video DY", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "7", "Video Edit", "6", "21", "Video DS", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "2", "Video Edit", "1", "26", "Video LO", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "6", "Video Edit", "8", "24", "Video XX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "2", "Video Delete", "4", "30", "Video SC", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "5", "Video Activity Log", "4", "5", "Video KQ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "10", "Video Add", "2", "16", "Video QC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "7", "Video Add", "8", "3", "Video FT", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "7", "Video Delete", "3", "3", "Video FI", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "5", "Video Edit", "3", "39", "Video WH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "10", "Video Add", "8", "2", "Video WS", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "7", "Video Activity Log", "7", "23", "Video VX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "9", "Video Add", "6", "13", "Video BB", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "7", "Video Delete", "3", "28", "Video FF", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "3", "Video Edit", "8", "6", "Video TB", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "7", "Video Activity Log", "10", "34", "Video LL", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "4", "Video Delete", "5", "10", "Video JU", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "10", "Video Edit", "2", "22", "Video FW", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "4", "Video Add", "5", "28", "Video SV", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "8", "Video Add", "6", "40", "Video VD", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "6", "Video Delete", "1", "18", "Video ZW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "6", "Video Activity Log", "7", "14", "Video EN", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "3", "Video Add", "10", "39", "Video VY", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "1", "Video Add", "6", "9", "Video RS", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "3", "Video Activity Log", "5", "20", "Video QL", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "9", "Video Activity Log", "4", "4", "Video OK", "DE_DIEU", "1", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "7", "Video Add", "4", "4", "Video TS", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 12, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "3", "Video Delete", "5", "24", "Video NN", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "9", "Video Add", "1", "26", "Video ZB", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "3", "Video Activity Log", "9", "31", "Video BD", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "8", "Video Delete", "6", "29", "Video TZ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 4, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "6", "Video Activity Log", "4", "22", "Video CL", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "9", "Video Add", "9", "8", "Video AC", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "1", "Video Activity Log", "1", "10", "Video RD", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "1", "Video Activity Log", "2", "7", "Video ZY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "8", "Video Add", "9", "36", "Video BQ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "1", "Video Add", "2", "15", "Video AY", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "7", "Video Activity Log", "4", "21", "Video FB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "4", "Video Activity Log", "7", "19", "Video DS", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "1", "Warning Add", "4", "Warning GJ", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "8", "Warning Edit", "1", "Warning IV", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "3", "Warning Add", "2", "Warning KK", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "4", "Warning Edit", "6", "Warning JF", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 6, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "2", "Warning Activity Log", "3", "Warning CF", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "10", "Warning Delete", "7", "Warning JS", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "4", "Warning Add", "5", "Warning NJ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 15, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "10", "Warning Activity Log", "5", "Warning BK", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "1", "Warning Add", "5", "Warning UA", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "10", "Warning Edit", "6", "Warning HX", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 11, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "7", "Warning Delete", "4", "Warning VU", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "10", "Warning Edit", "6", "Warning CC", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "2", "Warning Delete", "2", "Warning ER", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "8", "Warning Delete", "6", "Warning FT", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "1", "Warning Activity Log", "5", "Warning GG", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "7", "Warning Add", "5", "Warning OG", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 15, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "9", "Warning Delete", "9", "Warning DR", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "6", "Warning Add", "1", "Warning YP", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "5", "Warning Activity Log", "7", "Warning HS", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "10", "Warning Delete", "9", "Warning EM", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 16, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "Warning Delete", "8", "Warning UL", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 1, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "1", "Warning Delete", "10", "Warning DU", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "3", "Warning Add", "2", "Warning FV", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "4", "Warning Edit", "7", "Warning WK", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 7, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "9", "Warning Delete", "4", "Warning MD", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "3", "Warning Activity Log", "10", "Warning PI", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 15, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "1", "Warning Delete", "8", "Warning JH", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 1, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "10", "Warning Edit", "6", "Warning JG", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "7", "Warning Activity Log", "4", "Warning HW", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "1", "Warning Edit", "4", "Warning JX", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "10", "Warning Add", "2", "Warning DY", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "1", "Warning Add", "8", "Warning VY", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 3, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "1", "Warning Add", "2", "Warning EP", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "7", "Warning Add", "7", "Warning EE", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 6, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "8", "Warning Delete", "1", "Warning XF", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 9, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "3", "Warning Delete", "9", "Warning NT", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "10", "Warning Add", "9", "Warning UP", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 1, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "2", "Warning Activity Log", "3", "Warning CA", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "9", "Warning Add", "7", "Warning OW", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "2", "Warning Activity Log", "2", "Warning GJ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 12, 22, 0, 0, DateTimeKind.Unspecified), 20 }
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
