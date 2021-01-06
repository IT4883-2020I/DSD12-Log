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
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    UavConnectId = table.Column<string>(type: "varchar(255)", nullable: true)
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
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[,]
                {
                    { 1, "6", "Drone Edit", "9", 27, 21, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 2, 1, 5, 0, 0, DateTimeKind.Unspecified), 4, "8" },
                    { 73, "5", "Drone Add", "9", 24, 18, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 4, 22, 0, 0, DateTimeKind.Unspecified), 2, "8" },
                    { 72, "4", "Drone Add", "5", 11, 24, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 2, 10, 42, 0, 0, DateTimeKind.Unspecified), 2, "12" },
                    { 71, "8", "Drone Activity Log", "7", 31, 40, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 20, "11" },
                    { 70, "6", "Drone Activity Log", "7", 37, 34, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 1, 2, 9, 0, 0, DateTimeKind.Unspecified), 20, "8" },
                    { 69, "7", "Drone Delete", "1", 18, 44, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 1, 13, 21, 0, 0, DateTimeKind.Unspecified), 3, "2" },
                    { 68, "10", "Drone Edit", "8", 34, 41, "Drone 8", "CAY_TRONG", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 4, "6" },
                    { 67, "3", "Drone Edit", "4", 37, 25, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), 4, "5" },
                    { 66, "5", "Drone Edit", "2", 29, 26, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), 4, "12" },
                    { 65, "10", "Drone Delete", "5", 39, 44, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 2, 13, 6, 0, 0, DateTimeKind.Unspecified), 3, "14" },
                    { 64, "4", "Drone Edit", "2", 40, 45, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 4, "8" },
                    { 63, "1", "Drone Edit", "1", 40, 23, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 4, "4" },
                    { 62, "2", "Drone Activity Log", "8", 40, 26, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 20, "5" },
                    { 61, "3", "Drone Add", "6", 46, 23, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 2, "14" },
                    { 60, "5", "Drone Delete", "10", 26, 35, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified), 3, "5" },
                    { 59, "3", "Drone Edit", "10", 11, 29, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 2, 3, 46, 0, 0, DateTimeKind.Unspecified), 4, "13" },
                    { 58, "3", "Drone Delete", "2", 34, 10, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 1, 12, 10, 0, 0, DateTimeKind.Unspecified), 3, "7" },
                    { 57, "1", "Drone Delete", "7", 47, 44, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 5, 44, 0, 0, DateTimeKind.Unspecified), 3, "9" },
                    { 56, "7", "Drone Edit", "4", 23, 10, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 4, "4" },
                    { 55, "10", "Drone Add", "8", 49, 34, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 2, "1" },
                    { 54, "7", "Drone Delete", "1", 40, 30, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 3, "12" },
                    { 53, "6", "Drone Delete", "7", 35, 48, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 3, "6" },
                    { 74, "1", "Drone Edit", "4", 24, 25, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 1, 13, 18, 0, 0, DateTimeKind.Unspecified), 4, "1" },
                    { 75, "7", "Drone Delete", "4", 48, 31, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified), 3, "9" },
                    { 76, "6", "Drone Edit", "2", 44, 41, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 1, 6, 44, 0, 0, DateTimeKind.Unspecified), 4, "3" },
                    { 77, "6", "Drone Activity Log", "4", 44, 27, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 2, 12, 42, 0, 0, DateTimeKind.Unspecified), 20, "10" },
                    { 100, "4", "Drone Add", "5", 26, 30, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 6, 32, 0, 0, DateTimeKind.Unspecified), 2, "8" },
                    { 99, "2", "Drone Add", "9", 30, 17, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 2, 16, 14, 0, 0, DateTimeKind.Unspecified), 2, "4" },
                    { 98, "8", "Drone Edit", "8", 16, 35, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 1, 2, 37, 0, 0, DateTimeKind.Unspecified), 4, "12" },
                    { 97, "2", "Drone Edit", "9", 29, 31, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 4, "8" },
                    { 96, "7", "Drone Add", "7", 48, 22, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 2, "9" },
                    { 95, "4", "Drone Delete", "5", 19, 27, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 3, "5" },
                    { 94, "5", "Drone Activity Log", "4", 42, 20, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 14, 39, 0, 0, DateTimeKind.Unspecified), 20, "7" },
                    { 93, "1", "Drone Edit", "7", 35, 44, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 4, "10" },
                    { 92, "5", "Drone Delete", "3", 21, 48, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified), 3, "4" },
                    { 91, "10", "Drone Add", "6", 16, 11, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 2, 13, 8, 0, 0, DateTimeKind.Unspecified), 2, "4" },
                    { 52, "3", "Drone Delete", "5", 41, 48, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 1, 14, 19, 0, 0, DateTimeKind.Unspecified), 3, "8" },
                    { 90, "5", "Drone Edit", "5", 41, 48, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 14, 34, 0, 0, DateTimeKind.Unspecified), 4, "12" },
                    { 88, "4", "Drone Activity Log", "9", 29, 37, "Drone 9", "DE_DIEU", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 20, "9" },
                    { 87, "1", "Drone Add", "7", 18, 28, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 2, 4, 45, 0, 0, DateTimeKind.Unspecified), 2, "12" },
                    { 86, "10", "Drone Delete", "2", 27, 24, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 1, 5, 26, 0, 0, DateTimeKind.Unspecified), 3, "1" },
                    { 85, "1", "Drone Edit", "8", 44, 10, "Drone 8", "LUOI_DIEN", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 4, "2" },
                    { 84, "6", "Drone Add", "10", 46, 42, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 2, 6, 29, 0, 0, DateTimeKind.Unspecified), 2, "3" },
                    { 83, "2", "Drone Edit", "1", 20, 28, "Drone 1", "CHAY_RUNG", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 4, "1" },
                    { 82, "7", "Drone Add", "5", 10, 36, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 2, "4" },
                    { 81, "2", "Drone Add", "8", 21, 25, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 2, "2" },
                    { 79, "7", "Drone Delete", "4", 19, 31, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 3, "1" },
                    { 78, "5", "Drone Edit", "10", 47, 29, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 4, "6" },
                    { 89, "2", "Drone Edit", "3", 20, 45, "Drone 3", "CAY_TRONG", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified), 4, "9" },
                    { 51, "9", "Drone Add", "6", 24, 39, "Drone 6", "DE_DIEU", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 2, "1" },
                    { 80, "9", "Drone Add", "3", 49, 36, "Drone 3", "CHAY_RUNG", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 2, "11" },
                    { 49, "4", "Drone Delete", "3", 25, 17, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 3, "14" },
                    { 22, "2", "Drone Add", "3", 44, 26, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 2, "9" },
                    { 21, "9", "Drone Activity Log", "8", 30, 31, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified), 20, "10" },
                    { 20, "9", "Drone Add", "6", 21, 27, "Drone 6", "LUOI_DIEN", new DateTime(2020, 12, 2, 1, 43, 0, 0, DateTimeKind.Unspecified), 2, "7" },
                    { 19, "1", "Drone Activity Log", "6", 36, 20, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 20, "9" },
                    { 18, "6", "Drone Delete", "9", 21, 47, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 3, "7" },
                    { 17, "2", "Drone Delete", "7", 41, 24, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 3, "9" },
                    { 15, "10", "Drone Delete", "3", 35, 29, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 1, 5, 27, 0, 0, DateTimeKind.Unspecified), 3, "4" },
                    { 14, "8", "Drone Edit", "9", 23, 25, "Drone 9", "LUOI_DIEN", new DateTime(2020, 12, 1, 15, 49, 0, 0, DateTimeKind.Unspecified), 4, "3" },
                    { 13, "3", "Drone Delete", "8", 10, 14, "Drone 8", "DE_DIEU", new DateTime(2020, 12, 2, 12, 35, 0, 0, DateTimeKind.Unspecified), 3, "7" },
                    { 12, "2", "Drone Activity Log", "6", 34, 12, "Drone 6", "LUOI_DIEN", new DateTime(2020, 12, 2, 16, 34, 0, 0, DateTimeKind.Unspecified), 20, "8" },
                    { 11, "10", "Drone Delete", "9", 23, 19, "Drone 9", "DE_DIEU", new DateTime(2020, 12, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), 3, "14" },
                    { 10, "9", "Drone Add", "1", 45, 44, "Drone 1", "CHAY_RUNG", new DateTime(2020, 12, 2, 17, 34, 0, 0, DateTimeKind.Unspecified), 2, "1" },
                    { 9, "9", "Drone Delete", "5", 25, 31, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 1, 13, 44, 0, 0, DateTimeKind.Unspecified), 3, "4" },
                    { 8, "8", "Drone Add", "2", 38, 45, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 2, "10" },
                    { 7, "8", "Drone Activity Log", "1", 31, 36, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), 20, "1" },
                    { 6, "4", "Drone Edit", "5", 35, 42, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 4, "2" },
                    { 5, "7", "Drone Edit", "5", 26, 42, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 4, 6, 0, 0, DateTimeKind.Unspecified), 4, "7" },
                    { 4, "8", "Drone Edit", "4", 30, 40, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 4, "8" },
                    { 3, "3", "Drone Delete", "8", 10, 14, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 9, 26, 0, 0, DateTimeKind.Unspecified), 3, "14" },
                    { 2, "6", "Drone Edit", "8", 42, 21, "Drone 8", "DE_DIEU", new DateTime(2020, 12, 1, 5, 17, 0, 0, DateTimeKind.Unspecified), 4, "12" },
                    { 50, "2", "Drone Delete", "10", 26, 28, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 2, 7, 17, 0, 0, DateTimeKind.Unspecified), 3, "8" },
                    { 23, "9", "Drone Add", "5", 24, 41, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 1, 4, 40, 0, 0, DateTimeKind.Unspecified), 2, "4" },
                    { 24, "7", "Drone Add", "2", 35, 45, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 1, 46, 0, 0, DateTimeKind.Unspecified), 2, "13" },
                    { 16, "6", "Drone Delete", "8", 44, 20, "Drone 8", "LUOI_DIEN", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 3, "2" },
                    { 26, "1", "Drone Add", "2", 24, 46, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 2, "1" },
                    { 48, "7", "Drone Delete", "6", 49, 35, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 3, "8" },
                    { 47, "10", "Drone Activity Log", "9", 23, 16, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 10, 28, 0, 0, DateTimeKind.Unspecified), 20, "13" },
                    { 46, "10", "Drone Activity Log", "7", 26, 38, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 11, 16, 0, 0, DateTimeKind.Unspecified), 20, "10" },
                    { 25, "4", "Drone Add", "8", 26, 33, "Drone 8", "DE_DIEU", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 2, "14" },
                    { 44, "7", "Drone Edit", "6", 34, 46, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 4, "9" },
                    { 43, "3", "Drone Add", "4", 46, 48, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 2, "3" },
                    { 42, "1", "Drone Delete", "6", 23, 24, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 3, "2" },
                    { 41, "2", "Drone Activity Log", "2", 23, 48, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 20, "13" },
                    { 40, "8", "Drone Delete", "6", 20, 31, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), 3, "12" },
                    { 39, "7", "Drone Delete", "9", 25, 13, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 3, "1" },
                    { 38, "4", "Drone Delete", "6", 40, 22, "Drone 6", "LUOI_DIEN", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 3, "8" },
                    { 37, "8", "Drone Edit", "1", 48, 23, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 4, "6" },
                    { 45, "8", "Drone Edit", "10", 30, 31, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 2, 12, 31, 0, 0, DateTimeKind.Unspecified), 4, "1" },
                    { 35, "4", "Drone Add", "4", 30, 11, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 2, "4" },
                    { 27, "3", "Drone Edit", "4", 27, 30, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 4, "7" },
                    { 36, "4", "Drone Delete", "4", 45, 10, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 1, 2, 41, 0, 0, DateTimeKind.Unspecified), 3, "13" },
                    { 29, "8", "Drone Delete", "2", 45, 30, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 3, "14" },
                    { 30, "3", "Drone Activity Log", "9", 44, 26, "Drone 9", "DE_DIEU", new DateTime(2020, 12, 2, 14, 37, 0, 0, DateTimeKind.Unspecified), 20, "1" },
                    { 28, "1", "Drone Activity Log", "1", 19, 15, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 1, 7, 9, 0, 0, DateTimeKind.Unspecified), 20, "13" },
                    { 32, "5", "Drone Edit", "10", 46, 44, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 1, 5, 47, 0, 0, DateTimeKind.Unspecified), 4, "4" },
                    { 33, "1", "Drone Delete", "2", 48, 34, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 3, "1" },
                    { 34, "4", "Drone Edit", "7", 43, 31, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 4, "7" },
                    { 31, "4", "Drone Activity Log", "1", 25, 37, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 2, 12, 0, 0, DateTimeKind.Unspecified), 20, "5" }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 33, "10", "Hình ảnh theo dõi DE_DIEU BIRMA", "3", "12", "10", "Image OJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "7", "Hình ảnh theo dõi CHAY_RUNG GVRDD", "4", "25", "7", "Image NZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "2", "Hình ảnh theo dõi DE_DIEU RVRXB", "10", "7", "3", "Image SU", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "7", "Hình ảnh theo dõi DE_DIEU BFTYH", "10", "28", "5", "Image AS", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "2", "Hình ảnh theo dõi CAY_TRONG REOZY", "3", "2", "11", "Image LC", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "2", "Hình ảnh theo dõi CAY_TRONG EIYNF", "4", "5", "11", "Image CI", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "7", "Hình ảnh theo dõi CAY_TRONG WAPSI", "9", "5", "1", "Image WM", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "9", "Hình ảnh theo dõi CAY_TRONG YELPI", "4", "12", "14", "Image GL", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "4", "Hình ảnh theo dõi DE_DIEU QHVWA", "4", "3", "8", "Image JC", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "10", "Hình ảnh theo dõi CHAY_RUNG IXWXH", "8", "25", "1", "Image MI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "5", "Hình ảnh theo dõi CHAY_RUNG XKACO", "4", "6", "11", "Image CB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "7", "Hình ảnh theo dõi DE_DIEU TKTCU", "5", "23", "7", "Image ZQ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "9", "Hình ảnh theo dõi CAY_TRONG CFXLO", "9", "22", "4", "Image RK", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "10", "Hình ảnh theo dõi DE_DIEU HTGTM", "1", "1", "12", "Image XM", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "4", "Hình ảnh theo dõi LUOI_DIEN GLCQQ", "7", "19", "8", "Image ZL", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "5", "Hình ảnh theo dõi CAY_TRONG HBKWK", "9", "39", "12", "Image QQ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "8", "Hình ảnh theo dõi LUOI_DIEN CMZIF", "7", "28", "10", "Image QW", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "10", "Hình ảnh theo dõi CHAY_RUNG XHFCL", "3", "16", "5", "Image ZE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "3", "Hình ảnh theo dõi LUOI_DIEN SXSTT", "9", "32", "7", "Image HO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "8", "Hình ảnh theo dõi CAY_TRONG QROAV", "3", "1", "12", "Image WP", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "7", "Hình ảnh theo dõi LUOI_DIEN HCKJW", "2", "22", "1", "Image MG", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "Hình ảnh theo dõi DE_DIEU PQOQG", "4", "28", "13", "Image MD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "4", "Hình ảnh theo dõi LUOI_DIEN JVRKA", "6", "22", "12", "Image ND", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "10", "Hình ảnh theo dõi CHAY_RUNG UDWGB", "2", "10", "1", "Image SY", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "2", "Hình ảnh theo dõi LUOI_DIEN IVKVB", "8", "13", "6", "Image XH", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 2, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "7", "Hình ảnh theo dõi CHAY_RUNG HHHOJ", "3", "34", "5", "Image DH", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "3", "Hình ảnh theo dõi CHAY_RUNG LISSI", "6", "17", "9", "Image PB", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "4", "Hình ảnh theo dõi DE_DIEU KTDBI", "6", "15", "5", "Image LO", "DE_DIEU", "0", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "2", "Hình ảnh theo dõi CHAY_RUNG VNVSA", "9", "10", "4", "Image GH", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "6", "Hình ảnh theo dõi LUOI_DIEN UCMOS", "7", "23", "3", "Image XL", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "7", "Hình ảnh theo dõi LUOI_DIEN JMEKC", "7", "33", "6", "Image HQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "7", "Hình ảnh theo dõi DE_DIEU BGIOL", "3", "35", "10", "Image AZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "3", "Hình ảnh theo dõi CAY_TRONG XNOPM", "3", "11", "14", "Image XG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "9", "Hình ảnh theo dõi DE_DIEU VRPUZ", "8", "38", "14", "Image RS", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "1", "Hình ảnh theo dõi DE_DIEU IDKIF", "7", "3", "7", "Image HY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "8", "Hình ảnh theo dõi DE_DIEU AWRTY", "2", "11", "5", "Image SH", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "2", "Hình ảnh theo dõi DE_DIEU DORFI", "9", "35", "6", "Image WN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "3", "Hình ảnh theo dõi CHAY_RUNG TELBI", "4", "28", "9", "Image RZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "5", "Hình ảnh theo dõi CHAY_RUNG QAGHS", "6", "37", "3", "Image XM", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "5", "Hình ảnh theo dõi DE_DIEU OVGHP", "7", "32", "9", "Image QS", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "7", "Incident Activity Log", "8", "Incident LM", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 6, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "6", "Incident Delete", "2", "Incident CO", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 2, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "7", "Incident Activity Log", "14", "Incident HV", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 15, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "6", "Incident Add", "7", "Incident AQ", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "7", "Incident Delete", "2", "Incident FQ", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "9", "Incident Activity Log", "12", "Incident ML", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "4", "Incident Activity Log", "2", "Incident EJ", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "10", "Incident Activity Log", "7", "Incident CM", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 15, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "5", "Incident Add", "13", "Incident LZ", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "3", "Incident Edit", "4", "Incident HK", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "2", "Incident Edit", "5", "Incident XQ", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "3", "Incident Edit", "12", "Incident GA", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "8", "Incident Edit", "6", "Incident MG", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "6", "Incident Activity Log", "8", "Incident PY", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "7", "Incident Activity Log", "1", "Incident FS", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "6", "Incident Delete", "10", "Incident BQ", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "6", "Incident Add", "14", "Incident ZZ", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 3, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "2", "Incident Add", "7", "Incident VA", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "9", "Incident Edit", "14", "Incident ZI", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 1, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "1", "Incident Delete", "9", "Incident BH", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 15, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "5", "Incident Activity Log", "1", "Incident YB", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 12, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "8", "Incident Add", "6", "Incident UY", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 6, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "8", "Incident Edit", "5", "Incident XE", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 4, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "5", "Incident Edit", "10", "Incident QB", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 10, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "5", "Incident Add", "12", "Incident RS", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "5", "Incident Add", "3", "Incident UZ", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "5", "Incident Edit", "14", "Incident JC", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 12, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "4", "Incident Edit", "8", "Incident AT", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "3", "Incident Add", "5", "Incident YI", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "4", "Incident Edit", "2", "Incident VS", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 2, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "5", "Incident Activity Log", "5", "Incident XD", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "9", "Incident Delete", "2", "Incident QO", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 9, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "10", "Incident Add", "8", "Incident EC", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "1", "Incident Add", "7", "Incident YU", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 13, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "4", "Incident Delete", "12", "Incident KY", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "10", "Incident Activity Log", "14", "Incident LO", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "3", "Incident Delete", "11", "Incident AG", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "8", "Incident Delete", "13", "Incident TF", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "4", "Incident Activity Log", "11", "Incident EQ", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 1, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "4", "Incident Delete", "14", "Incident IZ", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 1, 20, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 29, "2", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "5", "MonitorRegion Activity Log", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "7", "MonitorRegion Activity Log", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "1", "MonitorRegion Delete", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "7", "MonitorRegion Edit", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "3", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "1", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "6", "MonitorRegion Add", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "2", "MonitorRegion Delete", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "7", "MonitorRegion Delete", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "10", "MonitorRegion Delete", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "1", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "7", "MonitorRegion Activity Log", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "3", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "1", "MonitorRegion Add", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "1", "MonitorRegion Add", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 10, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "5", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "8", "MonitorRegion Add", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "DE_DIEU", "1", new DateTime(2020, 12, 2, 7, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "9", "MonitorRegion Activity Log", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "1", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 1, "6", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "MonitorRegion Delete", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, "10", "MonitorRegion Delete", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, "9", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, "4", "MonitorRegion Edit", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "2", "MonitorRegion Delete", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, "10", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "DE_DIEU", "0", new DateTime(2020, 12, 1, 4, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "4", "MonitorRegion Activity Log", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, "8", "MonitorRegion Delete", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "9", "MonitorRegion Delete", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, "3", "MonitorRegion Edit", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "10", "MonitorRegion Add", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "5", "MonitorRegion Activity Log", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "7", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "3", "MonitorRegion Delete", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "8", "MonitorRegion Activity Log", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "8", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "6", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "5", "MonitorRegion Add", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "8", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 21, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "9", "ObjectObserve Delete", "12", "ObjectObserve RX", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "1", "ObjectObserve Edit", "14", "ObjectObserve QG", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 7, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "10", "ObjectObserve Activity Log", "9", "ObjectObserve RM", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "1", "ObjectObserve Activity Log", "9", "ObjectObserve DR", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "7", "ObjectObserve Activity Log", "3", "ObjectObserve UG", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "5", "ObjectObserve Activity Log", "7", "ObjectObserve DC", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 13, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "8", "ObjectObserve Edit", "2", "ObjectObserve SD", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 2, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "1", "ObjectObserve Activity Log", "18", "ObjectObserve AM", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "10", "ObjectObserve Activity Log", "9", "ObjectObserve GT", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "2", "ObjectObserve Add", "5", "ObjectObserve YH", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "1", "ObjectObserve Activity Log", "19", "ObjectObserve MT", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "9", "ObjectObserve Edit", "18", "ObjectObserve XZ", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 14, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "9", "ObjectObserve Edit", "5", "ObjectObserve RS", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "5", "ObjectObserve Edit", "3", "ObjectObserve NH", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 6, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "9", "ObjectObserve Edit", "13", "ObjectObserve TH", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 4, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "5", "ObjectObserve Add", "19", "ObjectObserve AL", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "2", "ObjectObserve Activity Log", "5", "ObjectObserve CK", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 1, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "8", "ObjectObserve Activity Log", "6", "ObjectObserve KX", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 17, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "5", "ObjectObserve Edit", "1", "ObjectObserve NG", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 17, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "1", "ObjectObserve Edit", "13", "ObjectObserve CC", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 12, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "8", "ObjectObserve Activity Log", "15", "ObjectObserve PA", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "5", "ObjectObserve Edit", "9", "ObjectObserve BH", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "2", "ObjectObserve Edit", "15", "ObjectObserve FV", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "1", "ObjectObserve Delete", "18", "ObjectObserve SB", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "8", "ObjectObserve Delete", "4", "ObjectObserve PG", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "7", "ObjectObserve Delete", "14", "ObjectObserve EF", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "6", "ObjectObserve Activity Log", "11", "ObjectObserve FA", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "10", "ObjectObserve Delete", "14", "ObjectObserve AV", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "10", "ObjectObserve Edit", "11", "ObjectObserve YY", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "4", "ObjectObserve Edit", "12", "ObjectObserve SK", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "3", "ObjectObserve Activity Log", "7", "ObjectObserve VP", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 12, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "8", "ObjectObserve Delete", "14", "ObjectObserve XP", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "6", "ObjectObserve Delete", "2", "ObjectObserve NZ", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 9, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "1", "ObjectObserve Edit", "13", "ObjectObserve JD", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 15, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "2", "ObjectObserve Edit", "17", "ObjectObserve PV", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "9", "ObjectObserve Edit", "8", "ObjectObserve SB", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 5, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "8", "ObjectObserve Delete", "17", "ObjectObserve KH", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 7, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "4", "ObjectObserve Add", "2", "ObjectObserve JT", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "9", "ObjectObserve Add", "16", "ObjectObserve ZA", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "10", "ObjectObserve Add", "6", "ObjectObserve IA", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 11, 28, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "1", "Payload Add", "4", "10", "JP-ELO-J", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "9", "Payload Delete", "5", "2", "VY-QQJ-R", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "9", "Payload Activity Log", "9", "4", "NS-OSR-Q", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 12, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "10", "Payload Activity Log", "7", "9", "FZ-OOS-F", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "1", "Payload Add", "9", "3", "BI-RPX-C", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 12, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "7", "Payload Delete", "9", "1", "UM-ZYK-I", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "5", "Payload Add", "8", "8", "LA-XYF-F", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "9", "Payload Delete", "10", "6", "HY-LHR-U", "DE_DIEU", "0", new DateTime(2020, 12, 1, 4, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "3", "Payload Activity Log", "6", "8", "QY-BLP-M", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "5", "Payload Delete", "8", "9", "SH-KIP-Z", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "5", "Payload Activity Log", "1", "6", "ZQ-QMZ-R", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "2", "Payload Activity Log", "5", "10", "JG-IFH-E", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "5", "Payload Delete", "5", "3", "WV-MWY-G", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "2", "Payload Activity Log", "1", "7", "BW-MQT-Q", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "6", "Payload Add", "5", "6", "KQ-AKX-J", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "9", "Payload Delete", "3", "2", "YN-YOR-Z", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "1", "Payload Delete", "5", "1", "SS-FHH-H", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "5", "Payload Edit", "5", "1", "JJ-DSE-U", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "2", "Payload Edit", "5", "8", "FO-UHH-W", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "8", "Payload Add", "8", "9", "WZ-NDY-H", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "1", "Payload Edit", "5", "7", "WK-QOH-X", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "3", "Payload Activity Log", "8", "2", "SD-PSC-E", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "8", "Payload Activity Log", "8", "7", "EQ-UUX-M", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "2", "Payload Delete", "5", "4", "WH-NUA-N", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "9", "Payload Edit", "6", "3", "DU-ZPI-I", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "2", "Payload Add", "9", "5", "EU-ILI-R", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "2", "Payload Activity Log", "4", "7", "AA-URD-G", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "9", "Payload Activity Log", "10", "7", "XT-FKG-O", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "1", "Payload Delete", "8", "4", "UF-UEO-S", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "6", "Payload Add", "8", "3", "JN-VSW-R", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "Payload Delete", "2", "4", "GD-MKA-F", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "10", "Payload Activity Log", "2", "8", "HS-DWH-W", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "7", "Payload Add", "4", "4", "AT-ECT-V", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "7", "Payload Delete", "1", "9", "ON-HTZ-V", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "5", "Payload Edit", "10", "4", "MZ-ZGO-U", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "1", "Payload Add", "10", "3", "HW-ULF-O", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "8", "Payload Delete", "6", "5", "NR-HGV-W", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "2", "Payload Delete", "10", "3", "UQ-QCV-P", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "8", "Payload Delete", "4", "6", "XB-VVO-F", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "5", "Payload Add", "3", "3", "WL-IPU-J", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 2, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "3", "ResolveProblem Add", "7", "ResolveProblem XD", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "4", "ResolveProblem Activity Log", "9", "ResolveProblem KF", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "3", "ResolveProblem Activity Log", "10", "ResolveProblem UB", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "5", "ResolveProblem Delete", "9", "ResolveProblem DO", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "4", "ResolveProblem Edit", "5", "ResolveProblem LU", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "5", "ResolveProblem Activity Log", "2", "ResolveProblem CN", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "10", "ResolveProblem Activity Log", "4", "ResolveProblem TZ", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 2, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "9", "ResolveProblem Delete", "1", "ResolveProblem KF", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "2", "ResolveProblem Edit", "14", "ResolveProblem NF", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 7, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "5", "ResolveProblem Add", "11", "ResolveProblem PI", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "4", "ResolveProblem Delete", "13", "ResolveProblem XY", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "4", "ResolveProblem Delete", "8", "ResolveProblem EP", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "8", "ResolveProblem Delete", "14", "ResolveProblem YT", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "4", "ResolveProblem Edit", "2", "ResolveProblem WP", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "3", "ResolveProblem Add", "9", "ResolveProblem WC", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 8, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "9", "ResolveProblem Add", "6", "ResolveProblem OP", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "10", "ResolveProblem Edit", "10", "ResolveProblem SR", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 8, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "3", "ResolveProblem Add", "2", "ResolveProblem XP", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "8", "ResolveProblem Add", "5", "ResolveProblem AD", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 12, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "9", "ResolveProblem Delete", "11", "ResolveProblem OL", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 2, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "10", "ResolveProblem Activity Log", "3", "ResolveProblem MR", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 13, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "10", "ResolveProblem Add", "12", "ResolveProblem KP", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 1, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "5", "ResolveProblem Edit", "9", "ResolveProblem IU", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "9", "ResolveProblem Activity Log", "8", "ResolveProblem NG", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "7", "ResolveProblem Delete", "3", "ResolveProblem AP", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 16, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "2", "ResolveProblem Edit", "8", "ResolveProblem ZZ", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "1", "ResolveProblem Add", "8", "ResolveProblem EE", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "8", "ResolveProblem Activity Log", "7", "ResolveProblem AX", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "1", "ResolveProblem Add", "13", "ResolveProblem ZO", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "8", "ResolveProblem Edit", "9", "ResolveProblem EG", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "10", "ResolveProblem Delete", "5", "ResolveProblem SQ", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "8", "ResolveProblem Add", "9", "ResolveProblem WI", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 17, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "8", "ResolveProblem Delete", "1", "ResolveProblem YA", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 7, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "4", "ResolveProblem Add", "4", "ResolveProblem FO", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "6", "ResolveProblem Activity Log", "14", "ResolveProblem PE", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 2, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "4", "ResolveProblem Add", "6", "ResolveProblem BA", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 7, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "3", "ResolveProblem Activity Log", "4", "ResolveProblem TL", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 13, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "5", "ResolveProblem Activity Log", "10", "ResolveProblem BH", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "5", "ResolveProblem Activity Log", "4", "ResolveProblem JA", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "2", "ResolveProblem Edit", "8", "ResolveProblem ZL", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "5", "Statical Delete", "54", "Statical BA", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 6, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "7", "Statical Add", "52", "Statical RD", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "4", "Statical Add", "44", "Statical QF", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "6", "Statical Edit", "48", "Statical DG", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "10", "Statical Edit", "46", "Statical DV", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "7", "Statical Delete", "56", "Statical NM", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "3", "Statical Add", "50", "Statical NN", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "9", "Statical Activity Log", "58", "Statical LJ", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 8, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "4", "Statical Delete", "70", "Statical SJ", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "5", "Statical Activity Log", "62", "Statical DN", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "10", "Statical Add", "64", "Statical NQ", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "5", "Statical Activity Log", "66", "Statical TY", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 11, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "1", "Statical Activity Log", "72", "Statical HB", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 10, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "1", "Statical Add", "74", "Statical YC", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 12, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "4", "Statical Delete", "76", "Statical TJ", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 5, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "6", "Statical Delete", "78", "Statical VA", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "4", "Statical Add", "42", "Statical OX", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "2", "Statical Add", "60", "Statical ZL", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "3", "Statical Add", "40", "Statical LH", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "6", "Statical Edit", "68", "Statical QR", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 7, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "10", "Statical Delete", "36", "Statical PO", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "9", "Statical Add", "38", "Statical TN", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 6, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "2", "Statical Activity Log", "0", "Statical HZ", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "7", "Statical Delete", "2", "Statical FK", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "3", "Statical Edit", "4", "Statical CP", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "8", "Statical Delete", "6", "Statical XI", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 11, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "4", "Statical Delete", "8", "Statical DG", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "7", "Statical Add", "10", "Statical AB", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 11, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "6", "Statical Delete", "12", "Statical EN", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 16, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "5", "Statical Edit", "16", "Statical SG", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "7", "Statical Add", "14", "Statical SY", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 5, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "2", "Statical Activity Log", "20", "Statical ZC", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "4", "Statical Activity Log", "22", "Statical YQ", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "9", "Statical Add", "24", "Statical EL", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 13, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "9", "Statical Delete", "26", "Statical YK", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "3", "Statical Edit", "28", "Statical EV", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 13, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "8", "Statical Activity Log", "30", "Statical OW", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 15, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "2", "Statical Add", "32", "Statical UC", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "8", "Statical Delete", "34", "Statical NF", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "4", "Statical Delete", "18", "Statical VL", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 15, 18, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 77, "1", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 16, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 76, "6", "Giám sát Add", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 78, "1", "Giám sát Delete", "3", "Đợi giám sát 3", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 83, "1", "Giám sát Activity Log", "14", "Đợi giám sát 14", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 13, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 80, "3", "Giám sát Edit", "2", "Đợi giám sát 2", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 81, "2", "Giám sát Add", "5", "Đợi giám sát 5", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 82, "5", "Giám sát Activity Log", "8", "Đợi giám sát 8", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 75, "3", "Giám sát Activity Log", "14", "Đợi giám sát 14", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 79, "2", "Giám sát Add", "8", "Đợi giám sát 8", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 14, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, "1", "Giám sát Delete", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 64, "6", "Giám sát Add", "4", "Đợi giám sát 4", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, "9", "Giám sát Delete", "5", "Đợi giám sát 5", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 71, "3", "Giám sát Activity Log", "3", "Đợi giám sát 3", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 70, "6", "Giám sát Delete", "3", "Đợi giám sát 3", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 11, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 69, "10", "Giám sát Edit", "1", "Đợi giám sát 1", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 68, "6", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 67, "2", "Giám sát Edit", "12", "Đợi giám sát 12", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 4, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 66, "6", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 65, "9", "Giám sát Activity Log", "3", "Đợi giám sát 3", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 13, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 84, "5", "Giám sát Edit", "7", "Đợi giám sát 7", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 14, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 63, "3", "Giám sát Add", "4", "Đợi giám sát 4", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 10, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, "1", "Giám sát Delete", "9", "Đợi giám sát 9", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 1, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 73, "10", "Giám sát Add", "3", "Đợi giám sát 3", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 85, "3", "Giám sát Delete", "13", "Đợi giám sát 13", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 95, "10", "Giám sát Add", "12", "Đợi giám sát 12", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 87, "3", "Giám sát Delete", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 61, "4", "Giám sát Delete", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 109, "8", "Giám sát Add", "2", "Đợi giám sát 2", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 108, "6", "Giám sát Add", "5", "Đợi giám sát 5", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 6, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 107, "9", "Giám sát Activity Log", "3", "Đợi giám sát 3", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 106, "7", "Giám sát Edit", "13", "Đợi giám sát 13", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 105, "7", "Giám sát Add", "4", "Đợi giám sát 4", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 15, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 104, "10", "Giám sát Add", "6", "Đợi giám sát 6", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 103, "10", "Giám sát Delete", "13", "Đợi giám sát 13", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 102, "6", "Giám sát Activity Log", "4", "Đợi giám sát 4", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 101, "4", "Giám sát Add", "6", "Đợi giám sát 6", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 1, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 86, "7", "Giám sát Delete", "2", "Đợi giám sát 2", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 100, "8", "Giám sát Delete", "4", "Đợi giám sát 4", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 98, "8", "Giám sát Edit", "13", "Đợi giám sát 13", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 13, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 97, "9", "Giám sát Activity Log", "7", "Đợi giám sát 7", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 96, "7", "Giám sát Edit", "12", "Đợi giám sát 12", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 16, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 94, "7", "Giám sát Activity Log", "10", "Đợi giám sát 10", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 9, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 93, "6", "Giám sát Activity Log", "13", "Đợi giám sát 13", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 92, "2", "Giám sát Edit", "12", "Đợi giám sát 12", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 91, "5", "Giám sát Add", "14", "Đợi giám sát 14", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 13, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 90, "5", "Giám sát Edit", "11", "Đợi giám sát 11", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 17, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 89, "3", "Giám sát Add", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 7, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 88, "8", "Giám sát Edit", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 7, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 99, "1", "Giám sát Delete", "14", "Đợi giám sát 14", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 60, "1", "Giám sát Add", "8", "Đợi giám sát 8", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "6", "Giám sát Add", "7", "Đợi giám sát 7", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, "1", "Giám sát Add", "13", "Đợi giám sát 13", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 15, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "10", "Giám sát Delete", "14", "Đợi giám sát 14", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "6", "Giám sát Edit", "6", "Đợi giám sát 6", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 3, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "10", "Giám sát Delete", "4", "Đợi giám sát 4", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "3", "Giám sát Edit", "1", "Đợi giám sát 1", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 2, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "2", "Giám sát Activity Log", "4", "Đợi giám sát 4", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "6", "Giám sát Activity Log", "1", "Đợi giám sát 1", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "1", "Giám sát Delete", "2", "Đợi giám sát 2", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 15, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 59, "5", "Giám sát Activity Log", "11", "Đợi giám sát 11", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 4, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "5", "Giám sát Delete", "6", "Đợi giám sát 6", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 12, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "2", "Giám sát Edit", "10", "Đợi giám sát 10", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 15, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "9", "Giám sát Activity Log", "14", "Đợi giám sát 14", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 5, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "8", "Giám sát Add", "9", "Đợi giám sát 9", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 6, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "8", "Giám sát Activity Log", "7", "Đợi giám sát 7", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "2", "Giám sát Add", "6", "Đợi giám sát 6", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "9", "Giám sát Delete", "5", "Đợi giám sát 5", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "2", "Giám sát Edit", "14", "Đợi giám sát 14", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 15, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "2", "Giám sát Add", "3", "Đợi giám sát 3", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 6, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "4", "Giám sát Delete", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 12, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "2", "Giám sát Edit", "3", "Đợi giám sát 3", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 6, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "6", "Giám sát Add", "7", "Đợi giám sát 7", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "2", "Giám sát Edit", "12", "Đợi giám sát 12", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 5, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "4", "Giám sát Add", "10", "Đợi giám sát 10", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "7", "Giám sát Activity Log", "3", "Đợi giám sát 3", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 9, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "5", "Giám sát Edit", "12", "Đợi giám sát 12", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 16, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "7", "Giám sát Delete", "5", "Đợi giám sát 5", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 6, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "6", "Giám sát Edit", "4", "Đợi giám sát 4", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 14, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 57, "5", "Giám sát Delete", "10", "Đợi giám sát 10", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "4", "Giám sát Edit", "12", "Đợi giám sát 12", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 10, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 55, "6", "Giám sát Edit", "2", "Đợi giám sát 2", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 12, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 54, "4", "Giám sát Activity Log", "13", "Đợi giám sát 13", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 9, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 53, "2", "Giám sát Edit", "14", "Đợi giám sát 14", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 1, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 52, "8", "Giám sát Add", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 2, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, "10", "Giám sát Add", "8", "Đợi giám sát 8", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 10, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 50, "9", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "3", "Giám sát Edit", "2", "Đợi giám sát 2", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "1", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "9", "Giám sát Edit", "9", "Đợi giám sát 9", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 56, "6", "Giám sát Add", "5", "Đợi giám sát 5", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "5", "Giám sát Delete", "10", "Đợi giám sát 10", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "7", "Giám sát Edit", "10", "Đợi giám sát 10", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 14, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "8", "Giám sát Edit", "13", "Đợi giám sát 13", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 4, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "5", "Giám sát Activity Log", "1", "Đợi giám sát 1", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "10", "Giám sát Delete", "6", "Đợi giám sát 6", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "7", "Giám sát Edit", "12", "Đợi giám sát 12", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 8, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "7", "Giám sát Add", "9", "Đợi giám sát 9", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "2", "Giám sát Edit", "9", "Đợi giám sát 9", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 17, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "8", "Giám sát Add", "1", "Đợi giám sát 1", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "3", "Giám sát Add", "7", "Đợi giám sát 7", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 6, 24, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "9", "User Add", "3", null, "Meta data example 22", "RIZPW DJCJ", "DE_DIEU", "5fec0951eeec7500179c9bbd", "11", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "3", "User Delete", "2", null, "Meta data example 29", "VRPEA ZYGJ", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "11", new DateTime(2020, 12, 1, 3, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "4", "User Activity Log", "4", null, "Meta data example 23", "GGMYQ WPWU", "DE_DIEU", "5fec0951eeec7500179c9bbd", "14", new DateTime(2020, 12, 1, 4, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "10", "User Edit", "7", null, "Meta data example 24", "VQFFW OQQO", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "4", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "6", "User Add", "4", null, "Meta data example 25", "RCSSQ IBXH", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "4", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "9", "User Edit", "5", null, "Meta data example 26", "PVSZV EEVH", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "6", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "10", "User Delete", "2", null, "Meta data example 27", "EBABK ACUT", "DE_DIEU", "5fe1a1ade40ec00017660154", "7", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "8", "User Delete", "9", null, "Meta data example 28", "MSNFF ENTH", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "2", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "6", "User Activity Log", "4", null, "Meta data example 39", "JYXUK VFPD", "DE_DIEU", "5fec0951eeec7500179c9bbd", "13", new DateTime(2020, 12, 2, 12, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "6", "User Edit", "1", null, "Meta data example 34", "CWMRB NNPA", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "7", new DateTime(2020, 12, 2, 3, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "8", "User Edit", "2", null, "Meta data example 31", "GHEZD XHMT", "CAY_TRONG", "5fe1a1ade40ec00017660154", "14", new DateTime(2020, 12, 1, 9, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "2", "User Edit", "3", null, "Meta data example 32", "QLNZQ NMVA", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "14", new DateTime(2020, 12, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "3", "User Delete", "2", null, "Meta data example 33", "BWKBY RIKG", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "7", new DateTime(2020, 12, 1, 13, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "6", "User Add", "7", null, "Meta data example 35", "SLMSB YHKN", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "2", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "5", "User Delete", "9", null, "Meta data example 36", "EGQWO KXDA", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "1", "User Delete", "10", null, "Meta data example 37", "OXGEP UYWX", "DE_DIEU", "5fe1a1ade40ec00017660154", "12", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "8", "User Add", "2", null, "Meta data example 38", "ZWUWS PJRA", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "9", new DateTime(2020, 12, 1, 3, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "7", "User Add", "1", null, "Meta data example 21", "KRUYI UXUR", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "3", "User Edit", "7", null, "Meta data example 30", "JVJDZ QCRH", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "8", new DateTime(2020, 12, 1, 13, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "3", "User Delete", "4", null, "Meta data example 20", "RANET YXBX", "DE_DIEU", "5fe1a1ade40ec00017660154", "2", new DateTime(2020, 12, 1, 4, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "7", "User Add", "3", null, "Meta data example 9", "BBSSF QYPJ", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "4", new DateTime(2020, 12, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "3", "User Delete", "4", null, "Meta data example 18", "XDANO SSDH", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "3", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "6", "User Delete", "4", null, "Meta data example 19", "GKPWY PXKY", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "4", new DateTime(2020, 12, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "10", "User Add", "2", null, "Meta data example 0", "FTDNT QWUW", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "13", new DateTime(2020, 12, 2, 8, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "2", "User Edit", "1", null, "Meta data example 1", "ENGNI CXTN", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "8", new DateTime(2020, 12, 1, 12, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "4", "User Activity Log", "2", null, "Meta data example 2", "CZYIO SIPE", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "10", "User Delete", "7", null, "Meta data example 4", "WNGBG WBAD", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "12", new DateTime(2020, 12, 2, 15, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "User Edit", "7", null, "Meta data example 5", "UFDSC GVVY", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "6", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "8", "User Add", "10", null, "Meta data example 6", "HGPQS SOSC", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "7", new DateTime(2020, 12, 1, 6, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "6", "User Delete", "5", null, "Meta data example 7", "GHZAB OTWB", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "6", new DateTime(2020, 12, 1, 15, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "7", "User Add", "7", null, "Meta data example 3", "XMZNL WWQT", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "7", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "10", "User Edit", "3", null, "Meta data example 10", "IIXRL NFDQ", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "6", new DateTime(2020, 12, 2, 10, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "9", "User Edit", "10", null, "Meta data example 11", "NYTGK YTBF", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "2", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "5", "User Activity Log", "10", null, "Meta data example 12", "JGHXK FPHU", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "5", new DateTime(2020, 12, 2, 4, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "7", "User Delete", "1", null, "Meta data example 13", "PDNMJ HKVC", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 14, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "2", "User Add", "8", null, "Meta data example 17", "NYZIM DQKG", "DE_DIEU", "5fec86a1f139ff00177a252e", "6", new DateTime(2020, 12, 1, 10, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "10", "User Activity Log", "9", null, "Meta data example 14", "MFQWR CHLH", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 8, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "4", "User Delete", "3", null, "Meta data example 15", "WWKJF BBAG", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "10", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "4", "User Add", "8", null, "Meta data example 16", "YXIFY KLGX", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "13", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "2", "User Edit", "1", null, "Meta data example 8", "QIMNK SIHL", "DE_DIEU", "5fec86a1f139ff00177a252e", "5", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 76, "10", "Video theo dõi CHAY_RUNG DNKOC", "8", "21", "8", "Video YE", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, "6", "Video theo dõi LUOI_DIEN FWWSM", "5", "7", "11", "Video TT", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 78, "4", "Video theo dõi DE_DIEU RYFWK", "9", "15", "14", "Video EH", "DE_DIEU", "0", new DateTime(2020, 12, 1, 3, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 82, "8", "Video theo dõi DE_DIEU AWALF", "1", "4", "8", "Video KS", "DE_DIEU", "0", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 80, "7", "Video theo dõi CAY_TRONG QZPNS", "5", "32", "13", "Video AK", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 81, "8", "Video theo dõi LUOI_DIEN ARSFY", "10", "36", "14", "Video PC", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 83, "3", "Video theo dõi DE_DIEU FMKAR", "3", "25", "12", "Video BP", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 75, "1", "Video theo dõi LUOI_DIEN RTTSJ", "5", "6", "12", "Video KG", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 79, "4", "Video theo dõi CAY_TRONG EBHDE", "3", "23", "3", "Video UG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 74, "3", "Video theo dõi LUOI_DIEN AELYB", "7", "3", "7", "Video UH", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 64, "1", "Video theo dõi CHAY_RUNG RFXSD", "9", "19", "13", "Video IA", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 72, "10", "Video theo dõi DE_DIEU SLQYW", "6", "18", "13", "Video XN", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 71, "2", "Video theo dõi LUOI_DIEN ZHLFB", "5", "7", "6", "Video WC", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 69, "5", "Video theo dõi LUOI_DIEN YGWDA", "10", "28", "14", "Video TX", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 68, "1", "Video theo dõi DE_DIEU DDNSZ", "6", "29", "1", "Video VQ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 67, "9", "Video theo dõi LUOI_DIEN HXGDR", "3", "2", "5", "Video OZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 66, "5", "Video theo dõi CAY_TRONG MYGBZ", "8", "23", "12", "Video XG", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 65, "10", "Video theo dõi LUOI_DIEN XSJUC", "6", "30", "10", "Video KQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 84, "9", "Video theo dõi LUOI_DIEN PYBND", "4", "20", "3", "Video GE", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 63, "6", "Video theo dõi CAY_TRONG MIFZE", "8", "28", "14", "Video WP", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, "2", "Video theo dõi CHAY_RUNG QZATW", "9", "25", "11", "Video JN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 73, "3", "Video theo dõi CHAY_RUNG IXCTA", "2", "20", "9", "Video CP", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 7, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 85, "6", "Video theo dõi CHAY_RUNG NEWSL", "10", "34", "12", "Video CZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 94, "6", "Video theo dõi LUOI_DIEN BETTI", "1", "40", "13", "Video AZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 87, "10", "Video theo dõi LUOI_DIEN HQHFP", "9", "14", "5", "Video JJ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 109, "10", "Video theo dõi LUOI_DIEN JMOBV", "5", "26", "6", "Video QU", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 108, "10", "Video theo dõi DE_DIEU XOBQG", "5", "23", "2", "Video DF", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 107, "5", "Video theo dõi CAY_TRONG FZBAJ", "3", "10", "1", "Video OR", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 106, "1", "Video theo dõi CAY_TRONG VBUVU", "1", "18", "9", "Video OK", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 105, "3", "Video theo dõi DE_DIEU XUGYH", "5", "13", "6", "Video DO", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 104, "2", "Video theo dõi CHAY_RUNG QODXF", "8", "6", "9", "Video WA", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 103, "5", "Video theo dõi LUOI_DIEN AMSLY", "1", "30", "10", "Video YI", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 102, "9", "Video theo dõi LUOI_DIEN XJOMV", "4", "4", "3", "Video BP", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 101, "3", "Video theo dõi CAY_TRONG OGZRF", "10", "12", "8", "Video JB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 100, "2", "Video theo dõi DE_DIEU MUBBM", "8", "1", "6", "Video BZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 86, "3", "Video theo dõi CAY_TRONG ZICHU", "9", "27", "3", "Video VT", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 99, "4", "Video theo dõi CAY_TRONG YWMRE", "6", "15", "2", "Video JA", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 97, "5", "Video theo dõi CAY_TRONG UQVQS", "1", "15", "3", "Video GX", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 96, "8", "Video theo dõi CHAY_RUNG IVGQI", "7", "37", "11", "Video KQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 95, "7", "Video theo dõi DE_DIEU RVVSJ", "7", "34", "1", "Video HV", "DE_DIEU", "1", new DateTime(2020, 12, 2, 7, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 61, "1", "Video theo dõi LUOI_DIEN TTPFY", "8", "16", "9", "Video XO", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 93, "8", "Video theo dõi LUOI_DIEN NIPKW", "6", "25", "5", "Video SR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 92, "7", "Video theo dõi CHAY_RUNG UXQDM", "1", "32", "5", "Video ZB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 91, "10", "Video theo dõi CHAY_RUNG EVFNY", "3", "15", "14", "Video YA", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 90, "6", "Video theo dõi LUOI_DIEN MVBIY", "8", "20", "1", "Video HQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 89, "1", "Video theo dõi LUOI_DIEN SJYAO", "9", "24", "9", "Video ZO", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 88, "4", "Video theo dõi CHAY_RUNG BHPAN", "5", "37", "6", "Video PU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 98, "4", "Video theo dõi CAY_TRONG DXLUE", "7", "5", "6", "Video GU", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 60, "9", "Video theo dõi LUOI_DIEN ZUYTM", "8", "13", "9", "Video WN", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 12, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, "1", "Video theo dõi LUOI_DIEN SSMFQ", "5", "26", "2", "Video OM", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, "4", "Video theo dõi LUOI_DIEN QKWCN", "4", "30", "9", "Video SQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "1", "Video theo dõi CAY_TRONG XBDPK", "10", "2", "7", "Video JH", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "3", "Video theo dõi DE_DIEU IRBYS", "3", "6", "1", "Video KK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 1, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "10", "Video theo dõi LUOI_DIEN LIZNN", "10", "26", "6", "Video NW", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "3", "Video theo dõi CHAY_RUNG WTRVW", "10", "18", "10", "Video DC", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "5", "Video theo dõi CAY_TRONG WBCJL", "6", "3", "14", "Video ML", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "4", "Video theo dõi CAY_TRONG QVVYK", "6", "26", "13", "Video VT", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "5", "Video theo dõi DE_DIEU XAEVO", "4", "14", "5", "Video WW", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "9", "Video theo dõi CHAY_RUNG KQEAR", "7", "27", "13", "Video NS", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "3", "Video theo dõi CHAY_RUNG YFWRU", "7", "27", "12", "Video OI", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "1", "Video theo dõi CHAY_RUNG LEBXO", "10", "2", "4", "Video RJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "2", "Video theo dõi DE_DIEU PNZUE", "8", "3", "12", "Video AI", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "8", "Video theo dõi LUOI_DIEN FFOCM", "5", "27", "8", "Video AD", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 15, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "2", "Video theo dõi LUOI_DIEN FTPHC", "9", "9", "13", "Video LS", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "3", "Video theo dõi DE_DIEU ABGJB", "3", "6", "5", "Video CY", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "2", "Video theo dõi DE_DIEU GDYYG", "10", "10", "9", "Video DO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "9", "Video theo dõi CHAY_RUNG OWOBL", "8", "9", "1", "Video JV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "9", "Video theo dõi CHAY_RUNG XZLBY", "1", "33", "7", "Video UA", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 59, "1", "Video theo dõi LUOI_DIEN KASWA", "3", "35", "2", "Video ZR", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 1, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "4", "Video theo dõi LUOI_DIEN CVQAX", "2", "23", "4", "Video DI", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "8", "Video theo dõi CHAY_RUNG UEEMG", "8", "39", "5", "Video ON", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "1", "Video theo dõi DE_DIEU KIRVJ", "1", "32", "2", "Video RY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "10", "Video theo dõi LUOI_DIEN ZUUAT", "5", "18", "5", "Video WE", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "10", "Video theo dõi CAY_TRONG UGMAO", "1", "7", "13", "Video HE", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "2", "Video theo dõi LUOI_DIEN SXMBW", "4", "34", "10", "Video GP", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "9", "Video theo dõi CHAY_RUNG PAQVF", "9", "37", "8", "Video KZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "2", "Video theo dõi CAY_TRONG IDYVA", "2", "28", "10", "Video NN", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "10", "Video theo dõi LUOI_DIEN EAATK", "10", "16", "14", "Video NY", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 7, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 57, "8", "Video theo dõi CAY_TRONG LJIXN", "8", "26", "13", "Video BB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 55, "7", "Video theo dõi LUOI_DIEN VSLQE", "1", "37", "1", "Video SM", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, "10", "Video theo dõi CHAY_RUNG AMJBO", "2", "24", "12", "Video HU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 53, "10", "Video theo dõi CHAY_RUNG VMWQW", "9", "27", "2", "Video JM", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 52, "8", "Video theo dõi DE_DIEU WEDOO", "5", "20", "8", "Video MQ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, "4", "Video theo dõi LUOI_DIEN WDXXP", "8", "38", "14", "Video XT", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 7, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 50, "9", "Video theo dõi CAY_TRONG CBEEJ", "1", "19", "13", "Video KS", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "9", "Video theo dõi DE_DIEU YMITU", "10", "27", "6", "Video DL", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "8", "Video theo dõi CHAY_RUNG NORHT", "3", "27", "2", "Video BQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "6", "Video theo dõi LUOI_DIEN QLULD", "10", "39", "13", "Video TL", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 56, "5", "Video theo dõi LUOI_DIEN SDXPZ", "5", "37", "8", "Video WS", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "4", "Video theo dõi DE_DIEU YIIQC", "6", "25", "2", "Video FU", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "5", "Video theo dõi CHAY_RUNG XLOUD", "10", "32", "2", "Video FD", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "2", "Video theo dõi LUOI_DIEN LTKKI", "4", "12", "8", "Video NA", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "10", "Video theo dõi CHAY_RUNG OMLAC", "6", "15", "9", "Video ML", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "9", "Video theo dõi CAY_TRONG KJZHI", "6", "27", "6", "Video PV", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "10", "Video theo dõi LUOI_DIEN JPFUX", "1", "13", "5", "Video JR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "1", "Video theo dõi LUOI_DIEN LHJGC", "7", "3", "5", "Video DT", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "3", "Video theo dõi LUOI_DIEN NWLBQ", "10", "31", "9", "Video XF", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "6", "Video theo dõi CAY_TRONG DZKNJ", "2", "11", "7", "Video JI", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "6", "Video theo dõi LUOI_DIEN BSKUH", "1", "36", "6", "Video EP", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "5", "Video theo dõi LUOI_DIEN BOYAO", "1", "26", "1", "Video CY", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 36, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 31, "1", "Warning Edit", "3", "Warning OG", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "8", "Warning Delete", "2", "Warning GW", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 9, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "6", "Warning Delete", "10", "Warning IS", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "10", "Warning Delete", "2", "Warning KY", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 1, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "9", "Warning Delete", "8", "Warning WF", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 2, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "1", "Warning Activity Log", "6", "Warning TR", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 3, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "10", "Warning Activity Log", "8", "Warning GV", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 7, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "7", "Warning Delete", "2", "Warning FI", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 6, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "8", "Warning Add", "8", "Warning SW", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "10", "Warning Add", "5", "Warning SF", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "7", "Warning Edit", "8", "Warning JX", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 11, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "10", "Warning Activity Log", "5", "Warning SR", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "5", "Warning Add", "3", "Warning RU", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "8", "Warning Add", "2", "Warning OC", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "2", "Warning Edit", "4", "Warning KP", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "8", "Warning Edit", "6", "Warning EI", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "7", "Warning Add", "9", "Warning ZE", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 9, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "10", "Warning Activity Log", "10", "Warning JD", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "10", "Warning Add", "8", "Warning OO", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 14, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "9", "Warning Add", "10", "Warning YD", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 7, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "3", "Warning Activity Log", "7", "Warning YT", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "10", "Warning Edit", "3", "Warning VU", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "5", "Warning Delete", "3", "Warning IE", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 3, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "8", "Warning Activity Log", "4", "Warning OE", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "2", "Warning Delete", "10", "Warning SA", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "6", "Warning Edit", "1", "Warning AA", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 5, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "9", "Warning Activity Log", "6", "Warning EX", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "5", "Warning Add", "6", "Warning TL", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "9", "Warning Delete", "6", "Warning CV", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 2, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "2", "Warning Delete", "10", "Warning ZB", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "8", "Warning Delete", "2", "Warning OJ", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "3", "Warning Add", "2", "Warning UR", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 17, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "10", "Warning Edit", "7", "Warning MK", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 8, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "8", "Warning Activity Log", "7", "Warning UC", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 3, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "4", "Warning Edit", "9", "Warning WA", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 1, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "8", "Warning Delete", "9", "Warning GG", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "3", "Warning Add", "8", "Warning ET", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "8", "Warning Add", "2", "Warning FA", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 6, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "1", "Warning Add", "10", "Warning IK", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "8", "Warning Activity Log", "4", "Warning HI", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 12, 24, 0, 0, DateTimeKind.Unspecified), 20 }
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
