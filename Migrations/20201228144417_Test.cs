using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                values: new object[] { 1, "10", "Drone Activity Log", "6", 49, 35, "Drone 7", "LUOI_DIEN", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 23, "5", "Drone Edit", "6", 11, 16, "Drone 7", "LUOI_DIEN", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 7, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 24, "3", "Drone Delete", "5", 11, 40, "Drone 1", "CAY_TRONG", "2", "MonitorRegion 4", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 25, "1", "Drone Edit", "3", 13, 32, "Drone 8", "LUOI_DIEN", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 15, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 26, "8", "Drone Add", "1", 46, 18, "Drone 9", "DE_DIEU", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 27, "6", "Drone Activity Log", "7", 39, 26, "Drone 2", "LUOI_DIEN", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 28, "3", "Drone Activity Log", "2", 15, 27, "Drone 5", "CAY_TRONG", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 29, "10", "Drone Activity Log", "4", 27, 20, "Drone 8", "LUOI_DIEN", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 31, "6", "Drone Add", "5", 18, 27, "Drone 1", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 1, 8, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 32, "4", "Drone Edit", "6", 35, 29, "Drone 8", "CAY_TRONG", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 2, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 33, "9", "Drone Add", "5", 25, 45, "Drone 4", "DE_DIEU", "4", "MonitorRegion 3", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 34, "5", "Drone Activity Log", "8", 22, 27, "Drone 1", "CAY_TRONG", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 7, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 35, "6", "Drone Delete", "10", 31, 28, "Drone 9", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 13, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 36, "7", "Drone Add", "1", 37, 22, "Drone 9", "LUOI_DIEN", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 37, "7", "Drone Activity Log", "5", 25, 12, "Drone 7", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 38, "5", "Drone Activity Log", "9", 23, 49, "Drone 7", "LUOI_DIEN", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 12, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 39, "5", "Drone Edit", "6", 16, 14, "Drone 1", "LUOI_DIEN", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 1, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 40, "1", "Drone Add", "3", 37, 29, "Drone 4", "CHAY_RUNG", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 22, "6", "Drone Delete", "5", 49, 13, "Drone 7", "CAY_TRONG", "1", "MonitorRegion 4", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 21, "10", "Drone Activity Log", "9", 41, 48, "Drone 4", "CHAY_RUNG", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 30, "4", "Drone Activity Log", "9", 30, 48, "Drone 9", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 8, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 19, "9", "Drone Delete", "6", 42, 27, "Drone 2", "DE_DIEU", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 20, "8", "Drone Add", "10", 35, 12, "Drone 1", "DE_DIEU", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 4, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 2, "3", "Drone Edit", "5", 36, 25, "Drone 8", "CAY_TRONG", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 3, "9", "Drone Delete", "2", 17, 21, "Drone 2", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 4, "3", "Drone Edit", "6", 48, 46, "Drone 5", "CHAY_RUNG", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 5, "5", "Drone Edit", "5", 14, 35, "Drone 1", "CAY_TRONG", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 6, "10", "Drone Activity Log", "6", 36, 49, "Drone 6", "DE_DIEU", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 8, "10", "Drone Edit", "2", 12, 32, "Drone 10", "LUOI_DIEN", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 9, "5", "Drone Edit", "7", 35, 40, "Drone 6", "CHAY_RUNG", "1", "MonitorRegion 1", new DateTime(2020, 12, 1, 7, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 10, "9", "Drone Activity Log", "8", 32, 34, "Drone 6", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 7, "4", "Drone Activity Log", "1", 45, 26, "Drone 9", "DE_DIEU", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 14, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 18, "1", "Drone Edit", "2", 22, 20, "Drone 10", "DE_DIEU", "2", "MonitorRegion 2", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 12, "4", "Drone Add", "9", 20, 26, "Drone 8", "CAY_TRONG", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 13, "5", "Drone Add", "3", 41, 46, "Drone 6", "CAY_TRONG", "1", "MonitorRegion 2", new DateTime(2020, 12, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 14, "7", "Drone Edit", "6", 38, 39, "Drone 10", "CHAY_RUNG", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 15, "7", "Drone Delete", "3", 44, 24, "Drone 9", "LUOI_DIEN", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 1, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 16, "10", "Drone Delete", "7", 40, 21, "Drone 4", "LUOI_DIEN", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 17, "6", "Drone Activity Log", "4", 15, 35, "Drone 4", "CAY_TRONG", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 11, "7", "Drone Delete", "4", 13, 39, "Drone 10", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "6", "Hình ảnh theo dõi CAY_TRONG TKNWS", "1", "33", "11", "Image YW", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "Hình ảnh theo dõi CHAY_RUNG SJNBI", "3", "4", "7", "Image FY", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "3", "Hình ảnh theo dõi DE_DIEU BOXSF", "2", "32", "3", "Image OJ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "1", "Hình ảnh theo dõi DE_DIEU WOMRE", "4", "25", "10", "Image RP", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "9", "Hình ảnh theo dõi DE_DIEU YOKFC", "10", "10", "8", "Image MS", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "10", "Hình ảnh theo dõi CHAY_RUNG EDEXW", "3", "35", "13", "Image QM", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "7", "Hình ảnh theo dõi LUOI_DIEN VENNI", "8", "25", "12", "Image YH", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "6", "Hình ảnh theo dõi CAY_TRONG ERJRJ", "5", "21", "11", "Image IT", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "5", "Hình ảnh theo dõi LUOI_DIEN KJWHS", "8", "22", "8", "Image TI", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "7", "Hình ảnh theo dõi CHAY_RUNG OYWRF", "9", "30", "6", "Image UR", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "10", "Hình ảnh theo dõi DE_DIEU SCXYV", "8", "20", "10", "Image WC", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "7", "Hình ảnh theo dõi DE_DIEU SNXAB", "9", "8", "12", "Image VQ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "2", "Hình ảnh theo dõi CAY_TRONG BRQZJ", "10", "15", "6", "Image RN", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "8", "Hình ảnh theo dõi DE_DIEU CDRHL", "1", "37", "5", "Image DK", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "4", "Hình ảnh theo dõi CAY_TRONG FOUGA", "5", "21", "8", "Image JA", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "5", "Hình ảnh theo dõi CAY_TRONG HSOEW", "5", "31", "2", "Image HH", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "Hình ảnh theo dõi CHAY_RUNG TRRHB", "2", "14", "2", "Image AO", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "10", "Hình ảnh theo dõi LUOI_DIEN XGYLL", "6", "7", "2", "Image CD", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "9", "Hình ảnh theo dõi LUOI_DIEN FKMSZ", "5", "26", "6", "Image RZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "7", "Hình ảnh theo dõi CAY_TRONG RIARE", "6", "33", "14", "Image ND", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "6", "Hình ảnh theo dõi CAY_TRONG NLIZC", "2", "8", "2", "Image AX", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "7", "Hình ảnh theo dõi LUOI_DIEN VILGY", "1", "12", "12", "Image HT", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "Hình ảnh theo dõi DE_DIEU WFNUH", "10", "2", "1", "Image SG", "DE_DIEU", "1", new DateTime(2020, 12, 2, 2, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "1", "Hình ảnh theo dõi CHAY_RUNG OYRNQ", "7", "18", "12", "Image TJ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "4", "Hình ảnh theo dõi LUOI_DIEN PAKTM", "6", "37", "13", "Image YZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "9", "Hình ảnh theo dõi LUOI_DIEN XBZES", "1", "17", "13", "Image TV", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "5", "Hình ảnh theo dõi LUOI_DIEN SVAVR", "10", "12", "5", "Image DM", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "7", "Hình ảnh theo dõi DE_DIEU KMWZR", "10", "14", "13", "Image QO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "2", "Hình ảnh theo dõi CHAY_RUNG TLCKL", "9", "16", "12", "Image XL", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "6", "Hình ảnh theo dõi LUOI_DIEN GBONL", "4", "35", "1", "Image AU", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "8", "Hình ảnh theo dõi CHAY_RUNG CDVVS", "1", "2", "8", "Image OG", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "Hình ảnh theo dõi LUOI_DIEN PGQMP", "10", "6", "1", "Image LF", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "4", "Hình ảnh theo dõi LUOI_DIEN NGKHR", "5", "29", "14", "Image LC", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "1", "Hình ảnh theo dõi CAY_TRONG JKOPO", "3", "36", "9", "Image YM", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 1, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "9", "Hình ảnh theo dõi LUOI_DIEN RAWOV", "8", "10", "13", "Image TA", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "3", "Hình ảnh theo dõi DE_DIEU EPXZP", "2", "32", "9", "Image MO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "7", "Hình ảnh theo dõi LUOI_DIEN DIAEQ", "3", "34", "1", "Image ND", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "7", "Hình ảnh theo dõi CHAY_RUNG BBLIZ", "10", "40", "10", "Image QY", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "3", "Hình ảnh theo dõi CHAY_RUNG ZYHBD", "2", "38", "10", "Image JL", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "10", "Hình ảnh theo dõi CHAY_RUNG GECBO", "3", "27", "3", "Image CE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "6", "Incident Add", "7", "Incident YD", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "4", "Incident Activity Log", "6", "Incident LC", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 14, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "10", "Incident Delete", "6", "Incident VW", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 5, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "8", "Incident Activity Log", "6", "Incident PC", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "Incident Add", "5", "Incident TD", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "3", "Incident Delete", "5", "Incident DK", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 12, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "6", "Incident Delete", "10", "Incident HT", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 13, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "3", "Incident Delete", "1", "Incident PL", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "Incident Delete", "11", "Incident PS", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "3", "Incident Activity Log", "12", "Incident WQ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 6, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "1", "Incident Edit", "14", "Incident OT", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "Incident Edit", "8", "Incident CC", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 16, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "5", "Incident Activity Log", "5", "Incident ED", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Incident Add", "1", "Incident QI", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 1, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "4", "Incident Activity Log", "1", "Incident BP", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 7, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "1", "Incident Activity Log", "6", "Incident NA", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "2", "Incident Add", "1", "Incident HU", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 15, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "2", "Incident Edit", "14", "Incident HO", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "3", "Incident Activity Log", "3", "Incident DP", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 3, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "2", "Incident Add", "11", "Incident KB", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "10", "Incident Delete", "2", "Incident XB", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 1, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "8", "Incident Activity Log", "8", "Incident WW", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "Incident Edit", "9", "Incident DX", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "6", "Incident Activity Log", "6", "Incident UF", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "5", "Incident Activity Log", "2", "Incident DI", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 15, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "2", "Incident Delete", "9", "Incident XD", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "8", "Incident Add", "8", "Incident OG", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "2", "Incident Add", "9", "Incident VV", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "9", "Incident Delete", "8", "Incident WY", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 4, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "Incident Edit", "14", "Incident OJ", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 7, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Incident Activity Log", "4", "Incident XA", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "7", "Incident Activity Log", "11", "Incident RD", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 13, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "9", "Incident Activity Log", "1", "Incident ZM", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 1, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "8", "Incident Activity Log", "2", "Incident UT", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 10, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "Incident Add", "4", "Incident SK", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 4, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "10", "Incident Delete", "3", "Incident TQ", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 9, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "1", "Incident Edit", "11", "Incident SN", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Incident Delete", "1", "Incident DC", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 9, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "7", "Incident Edit", "10", "Incident YC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "3", "Incident Add", "6", "Incident JZ", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "2", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "10", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "1", "MonitorRegion Edit", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "9", "MonitorRegion Delete", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "5", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "4", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "5", "MonitorRegion Edit", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "10", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "1", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "9", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "2", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "6", "MonitorRegion Delete", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "4", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "2", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "5", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "3", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "3", "MonitorRegion Add", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "MonitorRegion Delete", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 1, "6", "MonitorRegion Edit", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 2, "8", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 1, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 3, "8", "MonitorRegion Add", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 4, "3", "MonitorRegion Delete", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 5, "3", "MonitorRegion Add", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 6, "3", "MonitorRegion Add", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 7, "2", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 8, "10", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 9, "1", "MonitorRegion Add", "2", "MonitorRegion 2", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "6", "MonitorRegion Edit", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "1", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "4", "MonitorRegion Add", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "3", "MonitorRegion Edit", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "MonitorRegion Edit", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 10, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "8", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "5", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "MonitorRegion Add", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "5", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "3", "ObjectObserve Add", "12", "ObjectObserve LL", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "ObjectObserve Add", "3", "ObjectObserve EZ", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "10", "ObjectObserve Edit", "12", "ObjectObserve AY", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "9", "ObjectObserve Edit", "2", "ObjectObserve UI", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 2, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "7", "ObjectObserve Edit", "15", "ObjectObserve ET", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "ObjectObserve Add", "10", "ObjectObserve QL", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "7", "ObjectObserve Delete", "8", "ObjectObserve BE", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 14, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "6", "ObjectObserve Delete", "18", "ObjectObserve WY", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "10", "ObjectObserve Edit", "5", "ObjectObserve EM", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 15, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "5", "ObjectObserve Delete", "10", "ObjectObserve MW", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "2", "ObjectObserve Add", "3", "ObjectObserve NL", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 1, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "5", "ObjectObserve Activity Log", "18", "ObjectObserve XC", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 5, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "3", "ObjectObserve Activity Log", "13", "ObjectObserve SH", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "3", "ObjectObserve Edit", "20", "ObjectObserve BP", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 1, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "8", "ObjectObserve Add", "2", "ObjectObserve CS", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "4", "ObjectObserve Add", "11", "ObjectObserve QE", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "5", "ObjectObserve Add", "4", "ObjectObserve EL", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "8", "ObjectObserve Delete", "20", "ObjectObserve WT", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "7", "ObjectObserve Delete", "11", "ObjectObserve KZ", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "1", "ObjectObserve Delete", "7", "ObjectObserve JS", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "9", "ObjectObserve Activity Log", "14", "ObjectObserve IA", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 6, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "9", "ObjectObserve Delete", "11", "ObjectObserve MA", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 2, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "2", "ObjectObserve Edit", "8", "ObjectObserve SF", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 8, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "10", "ObjectObserve Delete", "15", "ObjectObserve AO", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 1, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "5", "ObjectObserve Add", "17", "ObjectObserve LW", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 1, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "2", "ObjectObserve Edit", "12", "ObjectObserve QN", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "1", "ObjectObserve Delete", "17", "ObjectObserve ZS", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 12, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "2", "ObjectObserve Delete", "9", "ObjectObserve BO", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "5", "ObjectObserve Edit", "17", "ObjectObserve GD", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "ObjectObserve Edit", "11", "ObjectObserve VU", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "6", "ObjectObserve Delete", "5", "ObjectObserve QF", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "ObjectObserve Activity Log", "3", "ObjectObserve XU", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "6", "ObjectObserve Activity Log", "16", "ObjectObserve LO", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "8", "ObjectObserve Edit", "10", "ObjectObserve MK", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 15, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "9", "ObjectObserve Edit", "11", "ObjectObserve XQ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "ObjectObserve Activity Log", "10", "ObjectObserve HO", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 2, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "4", "ObjectObserve Delete", "11", "ObjectObserve ML", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "8", "ObjectObserve Activity Log", "4", "ObjectObserve FN", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 3, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "9", "ObjectObserve Edit", "2", "ObjectObserve QP", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 14, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "9", "ObjectObserve Add", "17", "ObjectObserve HD", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "2", "Payload Activity Log", "2", "2", "HY-RJT-Z", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "2", "Payload Edit", "9", "3", "KP-XVB-L", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "Payload Delete", "8", "3", "CT-KTH-O", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "5", "Payload Edit", "6", "8", "MO-UHY-R", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "9", "Payload Edit", "9", "6", "EL-GJX-A", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "5", "Payload Add", "4", "1", "NX-UEJ-B", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "2", "Payload Add", "1", "8", "MD-VBJ-C", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "7", "Payload Delete", "9", "3", "EO-HXE-Y", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "10", "Payload Edit", "4", "2", "WS-IOW-V", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "9", "Payload Edit", "5", "1", "VQ-PXN-P", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "5", "Payload Add", "3", "2", "LY-FPO-W", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "9", "Payload Activity Log", "9", "3", "NP-AEB-W", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "5", "Payload Delete", "3", "7", "JM-GFC-T", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "3", "Payload Delete", "4", "2", "MJ-YYB-G", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "10", "Payload Delete", "8", "3", "IB-LGJ-J", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "6", "Payload Edit", "9", "7", "QC-IPC-J", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "Payload Edit", "8", "7", "AL-YJE-E", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "Payload Delete", "4", "10", "DQ-LDK-A", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "2", "Payload Delete", "9", "5", "XA-JKQ-H", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "5", "Payload Delete", "1", "7", "DJ-RKV-R", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "Payload Edit", "6", "9", "CG-GJA-F", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "9", "Payload Delete", "2", "4", "FX-ZWE-J", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "4", "Payload Add", "8", "7", "TJ-XGF-O", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "7", "Payload Activity Log", "6", "9", "HY-YXR-A", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "1", "Payload Activity Log", "1", "2", "RV-WWB-M", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "Payload Delete", "8", "6", "DP-CBG-R", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "6", "Payload Edit", "1", "1", "OS-LKR-S", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "3", "Payload Add", "3", "3", "PZ-VJM-Z", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "7", "Payload Activity Log", "7", "10", "HW-WAC-M", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "4", "Payload Edit", "3", "5", "BC-ADX-T", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "Payload Edit", "4", "7", "LB-AQC-U", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "4", "Payload Edit", "2", "6", "GN-NAI-R", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "Payload Add", "9", "10", "VB-MPM-J", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "3", "Payload Activity Log", "5", "3", "SG-ADF-D", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "3", "Payload Edit", "7", "5", "QK-GTY-Q", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "5", "Payload Activity Log", "5", "10", "EP-KOV-G", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "7", "Payload Add", "1", "3", "JI-AUU-M", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "8", "Payload Add", "10", "6", "BO-OKJ-T", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "7", "Payload Add", "5", "9", "OF-VRA-F", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "8", "Payload Edit", "6", "6", "TV-FZX-D", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 1, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "1", "ResolveProblem Edit", "10", "ResolveProblem PU", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 15, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "ResolveProblem Edit", "1", "ResolveProblem ZL", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "9", "ResolveProblem Add", "10", "ResolveProblem MK", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 2, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "2", "ResolveProblem Activity Log", "4", "ResolveProblem GV", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "6", "ResolveProblem Add", "2", "ResolveProblem JL", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "1", "ResolveProblem Delete", "6", "ResolveProblem DO", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "6", "ResolveProblem Add", "5", "ResolveProblem VE", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "6", "ResolveProblem Activity Log", "1", "ResolveProblem YO", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "2", "ResolveProblem Edit", "1", "ResolveProblem YE", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "6", "ResolveProblem Activity Log", "10", "ResolveProblem ZH", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "6", "ResolveProblem Edit", "6", "ResolveProblem AA", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 8, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "8", "ResolveProblem Edit", "6", "ResolveProblem EU", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 4, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "ResolveProblem Delete", "8", "ResolveProblem KM", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 1, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "10", "ResolveProblem Add", "6", "ResolveProblem IZ", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 13, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "3", "ResolveProblem Add", "9", "ResolveProblem KI", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "ResolveProblem Delete", "14", "ResolveProblem GT", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "4", "ResolveProblem Edit", "2", "ResolveProblem CG", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "6", "ResolveProblem Edit", "1", "ResolveProblem IX", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "2", "ResolveProblem Activity Log", "2", "ResolveProblem JF", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "4", "ResolveProblem Delete", "10", "ResolveProblem IY", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "ResolveProblem Delete", "9", "ResolveProblem UJ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "5", "ResolveProblem Delete", "12", "ResolveProblem RO", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "1", "ResolveProblem Delete", "2", "ResolveProblem OM", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "4", "ResolveProblem Activity Log", "10", "ResolveProblem PT", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 9, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "7", "ResolveProblem Edit", "8", "ResolveProblem OR", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "ResolveProblem Activity Log", "14", "ResolveProblem TC", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "6", "ResolveProblem Edit", "4", "ResolveProblem QV", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 8, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "9", "ResolveProblem Add", "1", "ResolveProblem NT", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 13, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "1", "ResolveProblem Edit", "10", "ResolveProblem IO", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "ResolveProblem Add", "13", "ResolveProblem RO", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "7", "ResolveProblem Activity Log", "8", "ResolveProblem HW", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "6", "ResolveProblem Edit", "6", "ResolveProblem HQ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "ResolveProblem Delete", "10", "ResolveProblem JB", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 9, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "2", "ResolveProblem Delete", "11", "ResolveProblem FW", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "10", "ResolveProblem Activity Log", "8", "ResolveProblem RT", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 7, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "4", "ResolveProblem Edit", "13", "ResolveProblem DZ", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "10", "ResolveProblem Add", "14", "ResolveProblem GX", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "8", "ResolveProblem Activity Log", "1", "ResolveProblem OS", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 1, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "3", "ResolveProblem Delete", "5", "ResolveProblem TW", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 9, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "4", "ResolveProblem Edit", "9", "ResolveProblem JB", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "4", "Statical Add", "54", "Statical JE", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "6", "Statical Activity Log", "52", "Statical GR", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "10", "Statical Add", "50", "Statical IX", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "10", "Statical Add", "42", "Statical MG", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "10", "Statical Activity Log", "46", "Statical SC", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "Statical Edit", "44", "Statical MU", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "10", "Statical Delete", "56", "Statical IJ", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 10, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "9", "Statical Delete", "48", "Statical QS", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "5", "Statical Activity Log", "58", "Statical RM", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "2", "Statical Add", "66", "Statical YY", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 3, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "Statical Add", "62", "Statical OZ", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "1", "Statical Edit", "64", "Statical FB", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "Statical Activity Log", "68", "Statical QF", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 12, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "6", "Statical Activity Log", "70", "Statical IN", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "8", "Statical Add", "72", "Statical MH", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "6", "Statical Add", "74", "Statical PX", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "8", "Statical Edit", "76", "Statical WP", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 12, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "5", "Statical Activity Log", "40", "Statical YE", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 9, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "9", "Statical Activity Log", "60", "Statical AY", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "10", "Statical Add", "78", "Statical RE", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "4", "Statical Delete", "38", "Statical DH", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "1", "Statical Edit", "34", "Statical ES", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 13, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "Statical Edit", "36", "Statical PD", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 13, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "Statical Add", "0", "Statical PL", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "9", "Statical Activity Log", "2", "Statical JT", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "7", "Statical Activity Log", "4", "Statical HJ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 3, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "8", "Statical Edit", "6", "Statical TD", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 15, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "1", "Statical Add", "10", "Statical ES", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "2", "Statical Add", "12", "Statical QA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "1", "Statical Edit", "14", "Statical MC", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 12, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "Statical Activity Log", "8", "Statical XS", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 14, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "8", "Statical Activity Log", "18", "Statical CI", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "8", "Statical Activity Log", "16", "Statical CU", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "6", "Statical Edit", "30", "Statical KT", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 9, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "2", "Statical Add", "28", "Statical OI", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 11, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "Statical Edit", "26", "Statical YU", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 1, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Statical Delete", "32", "Statical YA", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 14, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "Statical Delete", "22", "Statical CW", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "2", "Statical Add", "20", "Statical NN", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 3, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "1", "Statical Delete", "24", "Statical BJ", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 4, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "1", "Giám sát Edit", "8", "Đợi giám sát quý 2", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 10, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "10", "Giám sát Activity Log", "7", "Đợi giám sát quý 1", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "6", "Giám sát Edit", "12", "Đợi giám sát quý 2", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 12, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "10", "Giám sát Edit", "12", "Đợi giám sát quý 2", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "3", "Giám sát Edit", "12", "Đợi giám sát quý 1", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "6", "Giám sát Activity Log", "4", "Đợi giám sát quý 2", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "7", "Giám sát Edit", "7", "Đợi giám sát quý 2", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "2", "Giám sát Add", "6", "Đợi giám sát quý 2", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 4, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "2", "Giám sát Add", "10", "Đợi giám sát quý 1", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 2, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "Giám sát Add", "9", "Đợi giám sát quý 1", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 14, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "9", "Giám sát Edit", "5", "Đợi giám sát quý 2", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "2", "Giám sát Add", "1", "Đợi giám sát quý 2", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 9, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "7", "Giám sát Add", "1", "Đợi giám sát quý 2", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 13, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "9", "Giám sát Activity Log", "14", "Đợi giám sát quý 2", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 13, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Giám sát Delete", "12", "Đợi giám sát quý 2", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 8, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "2", "Giám sát Edit", "9", "Đợi giám sát quý 2", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 6, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "3", "Giám sát Edit", "13", "Đợi giám sát quý 1", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 5, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "Giám sát Edit", "1", "Đợi giám sát quý 2", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "2", "Giám sát Edit", "14", "Đợi giám sát quý 2", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 3, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "8", "Giám sát Edit", "10", "Đợi giám sát quý 1", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 6, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "9", "Giám sát Edit", "13", "Đợi giám sát quý 2", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "9", "Giám sát Edit", "13", "Đợi giám sát quý 2", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "8", "Giám sát Add", "5", "Đợi giám sát quý 1", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 3, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "4", "Giám sát Edit", "9", "Đợi giám sát quý 2", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 15, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "6", "Giám sát Activity Log", "3", "Đợi giám sát quý 2", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "9", "Giám sát Delete", "6", "Đợi giám sát quý 1", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 7, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "4", "Giám sát Add", "12", "Đợi giám sát quý 2", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 12, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "2", "Giám sát Edit", "11", "Đợi giám sát quý 1", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "6", "Giám sát Activity Log", "6", "Đợi giám sát quý 1", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "6", "Giám sát Delete", "13", "Đợi giám sát quý 1", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "2", "Giám sát Add", "2", "Đợi giám sát quý 2", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "8", "Giám sát Edit", "3", "Đợi giám sát quý 1", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "6", "Giám sát Activity Log", "11", "Đợi giám sát quý 2", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "6", "Giám sát Add", "6", "Đợi giám sát quý 1", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "2", "Giám sát Activity Log", "10", "Đợi giám sát quý 1", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "7", "Giám sát Activity Log", "6", "Đợi giám sát quý 2", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 12, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "6", "Giám sát Edit", "4", "Đợi giám sát quý 2", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Giám sát Add", "10", "Đợi giám sát quý 2", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "5", "Giám sát Edit", "10", "Đợi giám sát quý 2", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "4", "Giám sát Edit", "5", "Đợi giám sát quý 1", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 38, "7", "User Delete", "10", null, "Meta data example 28", "UAVWS BSSH", "LUOI_DIEN", "4", "7", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 37, "5", "User Add", "2", null, "Meta data example 27", "NTEUZ RAIV", "CAY_TRONG", "4", "11", new DateTime(2020, 12, 2, 3, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 36, "5", "User Activity Log", "4", null, "Meta data example 26", "AJYHH WHBX", "LUOI_DIEN", "4", "2", new DateTime(2020, 12, 2, 9, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 32, "8", "User Activity Log", "4", null, "Meta data example 22", "CIXNW INGY", "LUOI_DIEN", "1", "13", new DateTime(2020, 12, 2, 16, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 34, "7", "User Delete", "3", null, "Meta data example 24", "AKHPS POML", "CHAY_RUNG", "1", "5", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 33, "8", "User Add", "8", null, "Meta data example 23", "DFKXD XYDC", "DE_DIEU", "3", "6", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 39, "10", "User Activity Log", "9", null, "Meta data example 29", "XNDJK QMZH", "CHAY_RUNG", "4", "5", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 35, "1", "User Add", "7", null, "Meta data example 25", "NCNSP DZLA", "DE_DIEU", "3", "8", new DateTime(2020, 12, 1, 3, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 40, "1", "User Activity Log", "10", null, "Meta data example 30", "HMPKO UYSS", "LUOI_DIEN", "3", "14", new DateTime(2020, 12, 1, 2, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 44, "8", "User Activity Log", "10", null, "Meta data example 34", "DZZJW GXIK", "DE_DIEU", "2", "5", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 42, "3", "User Add", "9", null, "Meta data example 32", "EPUXD AQUJ", "CHAY_RUNG", "2", "8", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 43, "4", "User Delete", "7", null, "Meta data example 33", "FAAZY HLKI", "CHAY_RUNG", "3", "3", new DateTime(2020, 12, 2, 1, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 45, "9", "User Delete", "3", null, "Meta data example 35", "BKKCR SRRH", "CAY_TRONG", "4", "6", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 46, "5", "User Edit", "4", null, "Meta data example 36", "DDJJS CQQV", "DE_DIEU", "2", "7", new DateTime(2020, 12, 2, 6, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 47, "2", "User Edit", "10", null, "Meta data example 37", "ODTRC FQLB", "DE_DIEU", "3", "10", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 48, "10", "User Activity Log", "10", null, "Meta data example 38", "CHKZH VQYI", "CHAY_RUNG", "3", "14", new DateTime(2020, 12, 2, 11, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 49, "9", "User Add", "5", null, "Meta data example 39", "QTDUU ZPPR", "DE_DIEU", "3", "8", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 31, "1", "User Delete", "2", null, "Meta data example 21", "BSZAY MXHF", "CAY_TRONG", "2", "11", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 41, "9", "User Activity Log", "1", null, "Meta data example 31", "DRQUZ ZOCP", "DE_DIEU", "3", "4", new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 30, "5", "User Edit", "9", null, "Meta data example 20", "LXYXC OQXN", "CHAY_RUNG", "1", "11", new DateTime(2020, 12, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 29, "8", "User Activity Log", "10", null, "Meta data example 19", "INNJO KJSS", "LUOI_DIEN", "3", "13", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 28, "2", "User Edit", "10", null, "Meta data example 18", "VXBFZ QHVA", "DE_DIEU", "2", "12", new DateTime(2020, 12, 1, 3, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 10, "1", "User Activity Log", "5", null, "Meta data example 0", "XNHVB ZQPY", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 11, "10", "User Delete", "4", null, "Meta data example 1", "SCUVP DTXD", "CHAY_RUNG", "3", "7", new DateTime(2020, 12, 2, 5, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 12, "10", "User Delete", "5", null, "Meta data example 2", "HGLFM EROH", "CHAY_RUNG", "2", "4", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 13, "1", "User Add", "9", null, "Meta data example 3", "BYTKW TUNI", "LUOI_DIEN", "1", "10", new DateTime(2020, 12, 2, 13, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 14, "1", "User Add", "7", null, "Meta data example 4", "WISLA BRGQ", "CHAY_RUNG", "2", "12", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 16, "10", "User Activity Log", "4", null, "Meta data example 6", "ICHWJ TJJZ", "DE_DIEU", "1", "4", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 17, "5", "User Activity Log", "2", null, "Meta data example 7", "JFPZJ YOAF", "DE_DIEU", "4", "9", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 18, "1", "User Delete", "8", null, "Meta data example 8", "MKXNK KKQX", "LUOI_DIEN", "2", "4", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 15, "7", "User Activity Log", "6", null, "Meta data example 5", "RRODN QCBJ", "CHAY_RUNG", "4", "3", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 20, "9", "User Delete", "6", null, "Meta data example 10", "SIHUK LBPT", "CAY_TRONG", "3", "14", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 19, "5", "User Add", "7", null, "Meta data example 9", "RSDLW UAWB", "CHAY_RUNG", "3", "12", new DateTime(2020, 12, 2, 14, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 26, "6", "User Edit", "9", null, "Meta data example 16", "JYMEQ KDYG", "LUOI_DIEN", "4", "7", new DateTime(2020, 12, 2, 12, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 25, "6", "User Activity Log", "4", null, "Meta data example 15", "PHKDY YVOP", "LUOI_DIEN", "1", "14", new DateTime(2020, 12, 2, 12, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 24, "2", "User Activity Log", "1", null, "Meta data example 14", "IVWJD PVEC", "LUOI_DIEN", "4", "8", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 27, "8", "User Add", "3", null, "Meta data example 17", "VBQNP NXDP", "CAY_TRONG", "2", "9", new DateTime(2020, 12, 1, 6, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 22, "6", "User Activity Log", "5", null, "Meta data example 12", "ITMTE QCDD", "CAY_TRONG", "4", "14", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 21, "10", "User Edit", "2", null, "Meta data example 11", "CBWYJ YETL", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 23, "5", "User Edit", "3", null, "Meta data example 13", "XSYYS ECDD", "DE_DIEU", "3", "11", new DateTime(2020, 12, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "10", "Video theo dõi CHAY_RUNG BEHIX", "9", "2", "13", "Video OV", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "Video theo dõi CHAY_RUNG MFORL", "2", "37", "6", "Video AK", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "9", "Video theo dõi CHAY_RUNG WSTCQ", "7", "25", "4", "Video CK", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "5", "Video theo dõi CHAY_RUNG IKPJT", "1", "6", "6", "Video SD", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "Video theo dõi CHAY_RUNG JCCVM", "1", "24", "7", "Video YW", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "2", "Video theo dõi CHAY_RUNG AJGHE", "2", "6", "4", "Video NV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "2", "Video theo dõi CHAY_RUNG RDMHN", "8", "13", "11", "Video LJ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "8", "Video theo dõi CHAY_RUNG GANSP", "2", "25", "1", "Video MA", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "8", "Video theo dõi CHAY_RUNG ULARZ", "5", "24", "9", "Video RS", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "10", "Video theo dõi CHAY_RUNG LOJSK", "2", "3", "3", "Video WN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "3", "Video theo dõi CHAY_RUNG PORQF", "6", "40", "12", "Video WX", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "3", "Video theo dõi CHAY_RUNG TNPLK", "8", "16", "1", "Video DR", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "2", "Video theo dõi CHAY_RUNG ILGAG", "10", "32", "6", "Video MD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "1", "Video theo dõi CHAY_RUNG HNLAJ", "2", "4", "11", "Video BT", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "2", "Video theo dõi CHAY_RUNG LSDAV", "2", "19", "11", "Video KO", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "9", "Video theo dõi CHAY_RUNG GKPJZ", "2", "38", "10", "Video JO", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "4", "Video theo dõi CHAY_RUNG UOYKW", "10", "5", "13", "Video OP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "7", "Video theo dõi CHAY_RUNG RQUWD", "2", "29", "8", "Video FW", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "6", "Video theo dõi CHAY_RUNG VMCHW", "1", "18", "9", "Video CP", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "10", "Video theo dõi CHAY_RUNG BCLJZ", "8", "32", "8", "Video GO", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "10", "Video theo dõi CHAY_RUNG YFWMN", "9", "32", "3", "Video DW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "6", "Video theo dõi CHAY_RUNG QYBUM", "10", "29", "11", "Video HU", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "4", "Video theo dõi CHAY_RUNG MWDSN", "8", "31", "1", "Video TE", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "6", "Video theo dõi CHAY_RUNG CTVNA", "9", "10", "4", "Video KU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 13, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "4", "Video theo dõi CHAY_RUNG RCRRC", "4", "31", "2", "Video JD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "3", "Video theo dõi CHAY_RUNG VHOUL", "6", "16", "3", "Video DC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "4", "Video theo dõi CHAY_RUNG ZSRCM", "8", "29", "2", "Video II", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "3", "Video theo dõi CHAY_RUNG XZQYI", "1", "34", "11", "Video XZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "4", "Video theo dõi CHAY_RUNG UCWXG", "10", "32", "9", "Video XD", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 15, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "Video theo dõi CHAY_RUNG RQOHT", "2", "9", "2", "Video SF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "10", "Video theo dõi CHAY_RUNG AYBCM", "2", "2", "7", "Video UJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "1", "Video theo dõi CHAY_RUNG TLHKM", "5", "10", "3", "Video LG", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "7", "Video theo dõi CHAY_RUNG VCLVG", "7", "12", "8", "Video BP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Video theo dõi CHAY_RUNG UHECG", "6", "15", "5", "Video VY", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 15, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "8", "Video theo dõi CHAY_RUNG NNRQL", "7", "39", "13", "Video EB", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "8", "Video theo dõi CHAY_RUNG TVZBA", "2", "7", "5", "Video RL", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 3, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "3", "Video theo dõi CHAY_RUNG TMOHK", "5", "2", "10", "Video UV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "10", "Video theo dõi CHAY_RUNG ZOIEP", "3", "29", "7", "Video MU", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Video theo dõi CHAY_RUNG PRRFZ", "8", "15", "13", "Video UU", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "6", "Video theo dõi CHAY_RUNG TFQDH", "6", "16", "10", "Video AI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "4", "Warning Delete", "6", "Warning ZE", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 8, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "7", "Warning Activity Log", "7", "Warning JN", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 14, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "Warning Delete", "2", "Warning JB", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "2", "Warning Add", "5", "Warning QM", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "7", "Warning Edit", "6", "Warning YO", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 12, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "7", "Warning Edit", "1", "Warning LQ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 3, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "5", "Warning Add", "7", "Warning KR", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "4", "Warning Activity Log", "10", "Warning NN", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 12, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "Warning Edit", "3", "Warning FC", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 9, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "10", "Warning Add", "9", "Warning NN", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "2", "Warning Add", "6", "Warning HP", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 1, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "6", "Warning Add", "8", "Warning CX", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 3, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "1", "Warning Activity Log", "7", "Warning QL", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "5", "Warning Delete", "6", "Warning LF", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 12, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "Warning Delete", "9", "Warning TR", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 7, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "8", "Warning Edit", "4", "Warning HS", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 15, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "3", "Warning Delete", "4", "Warning DV", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 5, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "1", "Warning Delete", "8", "Warning RB", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "3", "Warning Edit", "4", "Warning CN", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 4, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "7", "Warning Delete", "7", "Warning PN", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 9, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "5", "Warning Activity Log", "7", "Warning BH", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 14, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "10", "Warning Delete", "6", "Warning TS", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 17, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "9", "Warning Activity Log", "10", "Warning VU", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "2", "Warning Delete", "1", "Warning BR", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 15, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "9", "Warning Add", "7", "Warning HB", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 11, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "6", "Warning Edit", "2", "Warning QC", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "Warning Activity Log", "2", "Warning SH", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "5", "Warning Activity Log", "5", "Warning DS", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "3", "Warning Activity Log", "6", "Warning KZ", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "1", "Warning Activity Log", "8", "Warning UF", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 14, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "10", "Warning Add", "5", "Warning OK", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "2", "Warning Add", "7", "Warning MR", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 10, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "3", "Warning Activity Log", "5", "Warning DD", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "Warning Add", "2", "Warning QP", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 16, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "4", "Warning Edit", "2", "Warning TB", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "3", "Warning Delete", "9", "Warning GV", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 5, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "8", "Warning Add", "8", "Warning JX", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "4", "Warning Edit", "1", "Warning VT", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 7, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "10", "Warning Add", "7", "Warning CA", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "5", "Warning Add", "1", "Warning LW", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 2 });
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
