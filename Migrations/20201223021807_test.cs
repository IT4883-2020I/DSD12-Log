using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class test : Migration
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
                        .Annotation("Sqlite:Autoincrement", true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true),
                    IncidentId = table.Column<string>(nullable: true)
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    EntityId = table.Column<string>(type: "varchar(255)", nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    DroneId = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    IncidentId = table.Column<string>(nullable: true)
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
                values: new object[] { 1, "3", "Drone Edit", "8", 18, 29, "Drone 7", "LUOI_DIEN", "1", "MonitorRegion 2", new DateTime(2020, 12, 2, 2, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 23, "2", "Drone Edit", "1", 40, 15, "Drone 7", "DE_DIEU", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 15, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 24, "7", "Drone Edit", "4", 48, 21, "Drone 5", "DE_DIEU", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 25, "3", "Drone Delete", "6", 24, 24, "Drone 9", "DE_DIEU", "4", "MonitorRegion 2", new DateTime(2020, 12, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Drone Edit", "4", 36, 14, "Drone 8", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 27, "5", "Drone Activity Log", "5", 49, 43, "Drone 4", "CAY_TRONG", "3", "MonitorRegion 3", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 28, "2", "Drone Activity Log", "2", 28, 45, "Drone 2", "CAY_TRONG", "1", "MonitorRegion 1", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 29, "3", "Drone Delete", "9", 12, 36, "Drone 8", "DE_DIEU", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 9, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 31, "7", "Drone Edit", "9", 13, 14, "Drone 3", "LUOI_DIEN", "4", "MonitorRegion 3", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 32, "9", "Drone Edit", "6", 14, 29, "Drone 8", "DE_DIEU", "2", "MonitorRegion 4", new DateTime(2020, 12, 1, 7, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 33, "9", "Drone Add", "3", 31, 42, "Drone 8", "CHAY_RUNG", "4", "MonitorRegion 1", new DateTime(2020, 12, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 34, "3", "Drone Activity Log", "3", 31, 45, "Drone 10", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 1, 4, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 35, "3", "Drone Delete", "10", 33, 17, "Drone 7", "CHAY_RUNG", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 36, "8", "Drone Delete", "1", 39, 31, "Drone 8", "CAY_TRONG", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 37, "4", "Drone Activity Log", "1", 46, 13, "Drone 9", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 12, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 38, "5", "Drone Activity Log", "5", 36, 15, "Drone 6", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 39, "1", "Drone Delete", "1", 48, 29, "Drone 9", "LUOI_DIEN", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 8, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 40, "9", "Drone Add", "7", 46, 22, "Drone 8", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 12, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Drone Delete", "6", 32, 35, "Drone 7", "DE_DIEU", "2", "MonitorRegion 3", new DateTime(2020, 12, 1, 1, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 21, "6", "Drone Edit", "1", 19, 25, "Drone 1", "CAY_TRONG", "1", "MonitorRegion 3", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 30, "10", "Drone Delete", "7", 36, 21, "Drone 4", "CAY_TRONG", "3", "MonitorRegion 2", new DateTime(2020, 12, 1, 9, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 19, "7", "Drone Activity Log", "1", 40, 18, "Drone 6", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 20, "9", "Drone Delete", "8", 18, 37, "Drone 4", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 2, "9", "Drone Delete", "8", 26, 49, "Drone 9", "DE_DIEU", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 3, "3", "Drone Edit", "7", 19, 46, "Drone 8", "CAY_TRONG", "2", "MonitorRegion 2", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 4, "2", "Drone Add", "10", 49, 14, "Drone 9", "CAY_TRONG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 15, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 5, "3", "Drone Delete", "8", 36, 28, "Drone 5", "CHAY_RUNG", "3", "MonitorRegion 2", new DateTime(2020, 12, 2, 6, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 6, "9", "Drone Add", "8", 19, 35, "Drone 7", "CHAY_RUNG", "1", "MonitorRegion 4", new DateTime(2020, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 8, "5", "Drone Activity Log", "8", 31, 32, "Drone 2", "CAY_TRONG", "2", "MonitorRegion 4", new DateTime(2020, 12, 2, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 9, "10", "Drone Delete", "6", 23, 44, "Drone 4", "CHAY_RUNG", "2", "MonitorRegion 1", new DateTime(2020, 12, 1, 12, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 10, "5", "Drone Delete", "4", 43, 46, "Drone 3", "DE_DIEU", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 1, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 7, "4", "Drone Edit", "7", 41, 11, "Drone 10", "LUOI_DIEN", "2", "MonitorRegion 4", new DateTime(2020, 12, 2, 16, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 18, "2", "Drone Delete", "5", 44, 33, "Drone 3", "CHAY_RUNG", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 12, "5", "Drone Edit", "3", 48, 23, "Drone 8", "DE_DIEU", "1", "MonitorRegion 3", new DateTime(2020, 12, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 13, "6", "Drone Add", "7", 18, 30, "Drone 4", "CHAY_RUNG", "3", "MonitorRegion 4", new DateTime(2020, 12, 2, 13, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 14, "1", "Drone Edit", "10", 26, 48, "Drone 1", "CHAY_RUNG", "3", "MonitorRegion 3", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 15, "2", "Drone Add", "3", 41, 18, "Drone 8", "CHAY_RUNG", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 7, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 16, "10", "Drone Activity Log", "6", 14, 28, "Drone 5", "DE_DIEU", "3", "MonitorRegion 1", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 17, "1", "Drone Edit", "10", 40, 15, "Drone 7", "LUOI_DIEN", "2", "MonitorRegion 3", new DateTime(2020, 12, 2, 10, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "RegionId", "RegionName", "Timestamp", "Type" },
                values: new object[] { 11, "9", "Drone Delete", "10", 12, 10, "Drone 1", "DE_DIEU", "4", "MonitorRegion 4", new DateTime(2020, 12, 2, 6, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "1", "Image Add", "10", "25", "7", "Image VN", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "9", "Image Delete", "6", "24", "5", "Image PO", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 2, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "8", "Image Delete", "5", "12", "7", "Image HG", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "6", "Image Delete", "10", "4", "12", "Image NZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "8", "Image Delete", "1", "25", "10", "Image YZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "6", "Image Add", "8", "18", "11", "Image KB", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "7", "Image Delete", "9", "25", "7", "Image RU", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "10", "Image Edit", "9", "37", "11", "Image QQ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "7", "Image Delete", "3", "10", "13", "Image OH", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "5", "Image Activity Log", "9", "10", "14", "Image VQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "9", "Image Add", "2", "14", "5", "Image CF", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "8", "Image Edit", "10", "14", "3", "Image CO", "DE_DIEU", "1", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "10", "Image Add", "6", "24", "13", "Image TV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "10", "Image Delete", "8", "15", "2", "Image RW", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "3", "Image Add", "10", "32", "10", "Image FQ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "6", "Image Activity Log", "6", "31", "9", "Image FP", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "6", "Image Add", "3", "6", "5", "Image CN", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "9", "Image Add", "4", "20", "14", "Image MQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "1", "Image Activity Log", "2", "35", "1", "Image JY", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "1", "Image Delete", "2", "9", "6", "Image DN", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "10", "Image Edit", "9", "3", "11", "Image UT", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "Image Activity Log", "7", "33", "9", "Image HK", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "7", "Image Edit", "1", "10", "2", "Image WM", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "3", "Image Edit", "4", "2", "13", "Image VQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "2", "Image Edit", "6", "15", "10", "Image HU", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 9, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "2", "Image Delete", "2", "4", "4", "Image ZW", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 3, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "2", "Image Add", "1", "17", "5", "Image AX", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "6", "Image Edit", "2", "7", "11", "Image FR", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "7", "Image Edit", "1", "1", "6", "Image BH", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "10", "Image Activity Log", "10", "15", "1", "Image IR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 14, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "4", "Image Activity Log", "6", "2", "12", "Image IG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "Image Add", "8", "3", "6", "Image TH", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "8", "Image Activity Log", "5", "28", "2", "Image IM", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "1", "Image Edit", "3", "32", "13", "Image BS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "3", "Image Add", "6", "25", "5", "Image EK", "DE_DIEU", "0", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "5", "Image Edit", "6", "40", "10", "Image BQ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "9", "Image Add", "10", "33", "8", "Image RH", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "1", "Image Delete", "5", "24", "4", "Image CZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "6", "Image Activity Log", "9", "1", "7", "Image FO", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "3", "Image Activity Log", "2", "10", "7", "Image VA", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "10", "Incident Add", "7", "Incident IK", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 9, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "1", "Incident Edit", "3", "Incident CM", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 3, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "10", "Incident Add", "8", "Incident WI", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "1", "Incident Edit", "5", "Incident NC", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "7", "Incident Activity Log", "12", "Incident DF", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 11, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "4", "Incident Delete", "12", "Incident FA", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 7, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "9", "Incident Activity Log", "11", "Incident JE", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "1", "Incident Edit", "12", "Incident EZ", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "7", "Incident Activity Log", "1", "Incident AI", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "1", "Incident Delete", "10", "Incident KT", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 2, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "3", "Incident Delete", "3", "Incident TX", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "6", "Incident Edit", "1", "Incident EC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 12, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "9", "Incident Edit", "1", "Incident NB", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "10", "Incident Edit", "14", "Incident DI", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 2, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "9", "Incident Activity Log", "1", "Incident PA", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "5", "Incident Activity Log", "12", "Incident VP", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 9, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "6", "Incident Activity Log", "10", "Incident WV", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 9, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "Incident Activity Log", "12", "Incident QX", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "3", "Incident Add", "8", "Incident VY", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 9, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "4", "Incident Delete", "6", "Incident VD", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "3", "Incident Activity Log", "3", "Incident VB", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 4, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "10", "Incident Add", "11", "Incident MT", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "4", "Incident Edit", "5", "Incident JJ", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "3", "Incident Add", "1", "Incident EH", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "3", "Incident Activity Log", "11", "Incident JI", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "3", "Incident Edit", "8", "Incident QA", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 15, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "10", "Incident Edit", "11", "Incident BA", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 16, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "10", "Incident Edit", "13", "Incident AJ", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 9, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "10", "Incident Activity Log", "1", "Incident LP", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "Incident Activity Log", "6", "Incident LU", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "5", "Incident Delete", "1", "Incident CV", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "7", "Incident Add", "2", "Incident CE", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "3", "Incident Edit", "4", "Incident ZR", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 7, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "Incident Edit", "10", "Incident DW", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "5", "Incident Activity Log", "8", "Incident SJ", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 15, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "4", "Incident Add", "5", "Incident XM", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "8", "Incident Activity Log", "11", "Incident FH", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "2", "Incident Edit", "10", "Incident KA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 2, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "3", "Incident Edit", "5", "Incident XV", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 5, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "1", "Incident Delete", "9", "Incident DA", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 5, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "2", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "8", "MonitorRegion Edit", "3", "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "10", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "8", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 2, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "2", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "9", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "7", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "MonitorRegion Delete", "2", "MonitorRegion 2", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "MonitorRegion Delete", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "2", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "5", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "MonitorRegion Edit", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "8", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "9", "MonitorRegion Add", "2", "MonitorRegion 2", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "10", "MonitorRegion Edit", "1", "MonitorRegion 1", "DE_DIEU", "0", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "1", "MonitorRegion Edit", "2", "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "MonitorRegion Edit", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "7", "MonitorRegion Add", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "5", "MonitorRegion Edit", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 1, "4", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 2, "10", "MonitorRegion Add", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 3, "5", "MonitorRegion Add", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 4, "8", "MonitorRegion Delete", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 5, "4", "MonitorRegion Edit", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 6, "3", "MonitorRegion Delete", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 7, "1", "MonitorRegion Add", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 8, "2", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 9, "1", "MonitorRegion Delete", "3", "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "4", "MonitorRegion Add", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "9", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "3", "MonitorRegion Delete", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 2, 16, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "8", "MonitorRegion Add", "1", "MonitorRegion 1", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "10", "MonitorRegion Edit", "3", "MonitorRegion 3", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 5, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "5", "MonitorRegion Edit", "3", "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "7", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "2", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "9", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "ObjectObserve Delete", "8", "ObjectObserve IO", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "10", "ObjectObserve Activity Log", "17", "ObjectObserve QB", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 6, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "ObjectObserve Edit", "3", "ObjectObserve HU", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 8, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "6", "ObjectObserve Delete", "9", "ObjectObserve CV", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "1", "ObjectObserve Delete", "15", "ObjectObserve XT", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "3", "ObjectObserve Edit", "8", "ObjectObserve MA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 2, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "4", "ObjectObserve Delete", "1", "ObjectObserve XE", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 12, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "5", "ObjectObserve Add", "8", "ObjectObserve GF", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 17, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "10", "ObjectObserve Activity Log", "4", "ObjectObserve XR", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "9", "ObjectObserve Activity Log", "9", "ObjectObserve QD", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "5", "ObjectObserve Edit", "9", "ObjectObserve CM", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "5", "ObjectObserve Activity Log", "12", "ObjectObserve JA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 7, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "4", "ObjectObserve Add", "10", "ObjectObserve HO", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "ObjectObserve Edit", "1", "ObjectObserve EA", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "7", "ObjectObserve Delete", "18", "ObjectObserve KN", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 8, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "ObjectObserve Add", "14", "ObjectObserve YT", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "2", "ObjectObserve Delete", "3", "ObjectObserve VF", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 4, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "6", "ObjectObserve Delete", "20", "ObjectObserve NG", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "ObjectObserve Add", "16", "ObjectObserve PG", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "6", "ObjectObserve Edit", "20", "ObjectObserve BE", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "7", "ObjectObserve Activity Log", "17", "ObjectObserve KJ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "9", "ObjectObserve Delete", "11", "ObjectObserve HQ", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 2, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "ObjectObserve Add", "18", "ObjectObserve VW", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "1", "ObjectObserve Activity Log", "1", "ObjectObserve SN", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "5", "ObjectObserve Add", "20", "ObjectObserve AX", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 1, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "10", "ObjectObserve Edit", "6", "ObjectObserve HG", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "6", "ObjectObserve Delete", "11", "ObjectObserve HC", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "6", "ObjectObserve Delete", "19", "ObjectObserve KF", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "4", "ObjectObserve Edit", "13", "ObjectObserve FV", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 9, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "ObjectObserve Add", "8", "ObjectObserve WS", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 5, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "9", "ObjectObserve Delete", "19", "ObjectObserve MJ", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "4", "ObjectObserve Activity Log", "8", "ObjectObserve BU", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "ObjectObserve Activity Log", "12", "ObjectObserve QP", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "7", "ObjectObserve Add", "15", "ObjectObserve PC", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 11, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "9", "ObjectObserve Activity Log", "4", "ObjectObserve CV", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "ObjectObserve Delete", "5", "ObjectObserve AF", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "9", "ObjectObserve Edit", "9", "ObjectObserve MK", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 14, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "6", "ObjectObserve Activity Log", "12", "ObjectObserve MA", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "10", "ObjectObserve Delete", "4", "ObjectObserve LO", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "1", "ObjectObserve Delete", "16", "ObjectObserve QZ", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 1, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "9", "Payload Activity Log", "4", "9", "Payload FR", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "7", "Payload Add", "9", "9", "Payload ES", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "Payload Delete", "2", "7", "Payload WB", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "4", "Payload Activity Log", "5", "1", "Payload HS", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "6", "Payload Activity Log", "10", "5", "Payload KQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "2", "Payload Add", "1", "4", "Payload JZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "7", "Payload Activity Log", "10", "10", "Payload WA", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "5", "Payload Delete", "3", "4", "Payload XC", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "10", "Payload Activity Log", "7", "6", "Payload IT", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "8", "Payload Edit", "3", "2", "Payload NL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "4", "Payload Activity Log", "3", "10", "Payload NP", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "4", "Payload Add", "4", "7", "Payload ML", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "Payload Activity Log", "2", "7", "Payload FJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "10", "Payload Activity Log", "2", "4", "Payload YX", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "7", "Payload Activity Log", "10", "8", "Payload GI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "5", "Payload Add", "5", "9", "Payload ZV", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "9", "Payload Activity Log", "4", "10", "Payload TQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "1", "Payload Delete", "5", "3", "Payload GK", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "7", "Payload Edit", "5", "1", "Payload MM", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "3", "Payload Delete", "2", "10", "Payload BC", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "2", "Payload Add", "8", "9", "Payload ST", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "5", "Payload Delete", "2", "10", "Payload JC", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "8", "Payload Add", "6", "4", "Payload IG", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "Payload Activity Log", "3", "1", "Payload SL", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "5", "Payload Delete", "9", "9", "Payload QA", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "2", "Payload Add", "6", "6", "Payload NL", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "8", "Payload Add", "6", "9", "Payload RC", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 13, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "Payload Edit", "8", "7", "Payload QB", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "Payload Activity Log", "3", "7", "Payload PY", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "1", "Payload Activity Log", "9", "4", "Payload PM", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "5", "Payload Add", "1", "10", "Payload FT", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "6", "Payload Add", "5", "3", "Payload XZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "10", "Payload Activity Log", "5", "10", "Payload VF", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "9", "Payload Delete", "4", "1", "Payload PH", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "3", "Payload Delete", "5", "5", "Payload XH", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "7", "Payload Delete", "10", "1", "Payload YV", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "5", "Payload Edit", "5", "3", "Payload PM", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "8", "Payload Delete", "9", "7", "Payload FV", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "8", "Payload Activity Log", "5", "3", "Payload FR", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "6", "Payload Delete", "6", "2", "Payload FP", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 1, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "ResolveProblem Edit", "1", "ResolveProblem DE", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "8", "ResolveProblem Activity Log", "13", "ResolveProblem UE", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 2, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "1", "ResolveProblem Edit", "6", "ResolveProblem EB", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "3", "ResolveProblem Activity Log", "1", "ResolveProblem RU", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "8", "ResolveProblem Activity Log", "11", "ResolveProblem DX", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "8", "ResolveProblem Delete", "8", "ResolveProblem YX", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "9", "ResolveProblem Delete", "4", "ResolveProblem TT", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "3", "ResolveProblem Edit", "10", "ResolveProblem TP", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 13, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "10", "ResolveProblem Delete", "9", "ResolveProblem GX", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 15, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "6", "ResolveProblem Add", "7", "ResolveProblem YY", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 12, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "3", "ResolveProblem Edit", "1", "ResolveProblem UL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 11, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "6", "ResolveProblem Delete", "14", "ResolveProblem WF", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "1", "ResolveProblem Activity Log", "4", "ResolveProblem BX", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "9", "ResolveProblem Delete", "4", "ResolveProblem SJ", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 15, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "8", "ResolveProblem Edit", "10", "ResolveProblem MR", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "6", "ResolveProblem Activity Log", "12", "ResolveProblem HL", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "4", "ResolveProblem Activity Log", "2", "ResolveProblem UU", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "1", "ResolveProblem Add", "13", "ResolveProblem VJ", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 1, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "2", "ResolveProblem Activity Log", "3", "ResolveProblem PV", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 15, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "10", "ResolveProblem Edit", "14", "ResolveProblem MV", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "ResolveProblem Add", "5", "ResolveProblem CL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "ResolveProblem Delete", "13", "ResolveProblem LI", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "10", "ResolveProblem Edit", "7", "ResolveProblem SA", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 2, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "7", "ResolveProblem Activity Log", "7", "ResolveProblem BA", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "1", "ResolveProblem Edit", "3", "ResolveProblem HI", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "10", "ResolveProblem Activity Log", "10", "ResolveProblem TN", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "6", "ResolveProblem Delete", "4", "ResolveProblem SC", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "9", "ResolveProblem Delete", "6", "ResolveProblem IU", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "7", "ResolveProblem Delete", "9", "ResolveProblem ZA", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "6", "ResolveProblem Add", "3", "ResolveProblem OD", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 7, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "ResolveProblem Delete", "4", "ResolveProblem MD", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "3", "ResolveProblem Activity Log", "3", "ResolveProblem MU", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "1", "ResolveProblem Activity Log", "8", "ResolveProblem SP", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 6, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "8", "ResolveProblem Add", "13", "ResolveProblem VG", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 12, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "7", "ResolveProblem Activity Log", "13", "ResolveProblem NN", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 13, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "9", "ResolveProblem Edit", "10", "ResolveProblem FD", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 12, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "1", "ResolveProblem Delete", "3", "ResolveProblem JO", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 16, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "ResolveProblem Add", "4", "ResolveProblem BV", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 3, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "8", "ResolveProblem Activity Log", "6", "ResolveProblem PF", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "2", "ResolveProblem Delete", "14", "ResolveProblem FE", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 12, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "2", "Statical Edit", "54", "Statical SX", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "3", "Statical Edit", "52", "Statical NU", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "3", "Statical Add", "50", "Statical GV", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "Statical Activity Log", "42", "Statical LJ", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "8", "Statical Activity Log", "46", "Statical JQ", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "2", "Statical Edit", "44", "Statical YO", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "6", "Statical Activity Log", "56", "Statical DO", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 14, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "1", "Statical Activity Log", "48", "Statical TQ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "7", "Statical Add", "58", "Statical JU", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "1", "Statical Delete", "66", "Statical AJ", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 14, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "3", "Statical Activity Log", "62", "Statical PB", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 1, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "1", "Statical Add", "64", "Statical AG", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "4", "Statical Delete", "68", "Statical UA", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 15, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "9", "Statical Activity Log", "70", "Statical EZ", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Statical Edit", "72", "Statical GG", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 13, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "Statical Delete", "74", "Statical KS", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "3", "Statical Delete", "76", "Statical BI", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 5, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "8", "Statical Edit", "40", "Statical BI", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "5", "Statical Activity Log", "60", "Statical MN", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "5", "Statical Delete", "78", "Statical AI", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "Statical Add", "38", "Statical FC", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "2", "Statical Add", "34", "Statical SH", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "5", "Statical Delete", "36", "Statical NC", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "4", "Statical Edit", "0", "Statical QO", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "7", "Statical Delete", "2", "Statical EI", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "Statical Edit", "4", "Statical PD", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 15, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "4", "Statical Edit", "6", "Statical QX", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "9", "Statical Activity Log", "10", "Statical KB", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "9", "Statical Activity Log", "12", "Statical TT", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 15, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "Statical Add", "14", "Statical NM", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "Statical Activity Log", "8", "Statical WZ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "1", "Statical Delete", "18", "Statical HH", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "4", "Statical Add", "16", "Statical CR", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 1, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "10", "Statical Edit", "30", "Statical HB", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 4, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "2", "Statical Activity Log", "28", "Statical SU", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 14, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "9", "Statical Delete", "26", "Statical DO", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "6", "Statical Activity Log", "32", "Statical KL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "7", "Statical Activity Log", "22", "Statical IA", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 3, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "3", "Statical Delete", "20", "Statical GI", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 12, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Statical Edit", "24", "Statical TC", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "2", "UavConnect Delete", "10", "UavConnect WO", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "9", "UavConnect Edit", "2", "UavConnect RB", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "8", "UavConnect Activity Log", "7", "UavConnect EB", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 2, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "4", "UavConnect Delete", "3", "UavConnect RZ", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "1", "UavConnect Edit", "11", "UavConnect UP", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "2", "UavConnect Activity Log", "1", "UavConnect VA", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "9", "UavConnect Delete", "4", "UavConnect XD", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 12, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "8", "UavConnect Delete", "5", "UavConnect PO", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 3, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "UavConnect Add", "11", "UavConnect KP", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 6, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "9", "UavConnect Add", "2", "UavConnect OP", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "7", "UavConnect Edit", "3", "UavConnect ED", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "8", "UavConnect Edit", "4", "UavConnect TS", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "1", "UavConnect Activity Log", "12", "UavConnect UV", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "5", "UavConnect Add", "3", "UavConnect DT", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 5, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "2", "UavConnect Add", "8", "UavConnect IC", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 11, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "UavConnect Add", "9", "UavConnect MK", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "9", "UavConnect Delete", "7", "UavConnect RY", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "3", "UavConnect Add", "14", "UavConnect KU", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "4", "UavConnect Add", "13", "UavConnect VP", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "10", "UavConnect Add", "13", "UavConnect TO", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "5", "UavConnect Activity Log", "11", "UavConnect XV", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "UavConnect Activity Log", "7", "UavConnect YK", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "10", "UavConnect Delete", "10", "UavConnect VI", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "UavConnect Edit", "6", "UavConnect SS", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "9", "UavConnect Activity Log", "9", "UavConnect PY", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "2", "UavConnect Delete", "5", "UavConnect NX", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 4, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "2", "UavConnect Activity Log", "14", "UavConnect CW", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "4", "UavConnect Delete", "3", "UavConnect KX", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 13, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "6", "UavConnect Activity Log", "6", "UavConnect DA", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "5", "UavConnect Add", "9", "UavConnect KI", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 3, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "7", "UavConnect Delete", "10", "UavConnect GK", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "7", "UavConnect Delete", "13", "UavConnect ZH", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 5, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "UavConnect Edit", "11", "UavConnect LX", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 16, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "1", "UavConnect Activity Log", "7", "UavConnect AK", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "7", "UavConnect Edit", "10", "UavConnect KI", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "6", "UavConnect Add", "6", "UavConnect OD", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "UavConnect Delete", "4", "UavConnect KZ", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "10", "UavConnect Activity Log", "5", "UavConnect AF", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 4, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "4", "UavConnect Edit", "5", "UavConnect LC", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "10", "UavConnect Edit", "8", "UavConnect DR", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 38, "2", "User Edit", "7", null, "Meta data example 28", "CAY_TRONG", "3", "7", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 37, "8", "User Edit", "1", null, "Meta data example 27", "CHAY_RUNG", "4", "13", new DateTime(2020, 12, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 36, "4", "User Add", "10", null, "Meta data example 26", "LUOI_DIEN", "4", "14", new DateTime(2020, 12, 1, 3, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 32, "6", "User Activity Log", "2", null, "Meta data example 22", "DE_DIEU", "3", "5", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 34, "9", "User Add", "5", null, "Meta data example 24", "DE_DIEU", "1", "5", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 33, "3", "User Edit", "2", null, "Meta data example 23", "CHAY_RUNG", "2", "11", new DateTime(2020, 12, 2, 5, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 39, "4", "User Edit", "8", null, "Meta data example 29", "CAY_TRONG", "3", "2", new DateTime(2020, 12, 1, 11, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 35, "7", "User Add", "1", null, "Meta data example 25", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 6, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 40, "3", "User Edit", "1", null, "Meta data example 30", "CHAY_RUNG", "2", "6", new DateTime(2020, 12, 2, 10, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 44, "1", "User Add", "2", null, "Meta data example 34", "CHAY_RUNG", "1", "3", new DateTime(2020, 12, 1, 14, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 42, "3", "User Delete", "3", null, "Meta data example 32", "CAY_TRONG", "4", "7", new DateTime(2020, 12, 2, 12, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 43, "4", "User Edit", "6", null, "Meta data example 33", "LUOI_DIEN", "2", "5", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 45, "2", "User Delete", "1", null, "Meta data example 35", "CAY_TRONG", "1", "8", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 46, "3", "User Delete", "4", null, "Meta data example 36", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 47, "7", "User Add", "5", null, "Meta data example 37", "DE_DIEU", "3", "4", new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 48, "9", "User Activity Log", "4", null, "Meta data example 38", "LUOI_DIEN", "4", "2", new DateTime(2020, 12, 1, 11, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 49, "4", "User Add", "2", null, "Meta data example 39", "DE_DIEU", "1", "4", new DateTime(2020, 12, 2, 3, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 31, "6", "User Edit", "2", null, "Meta data example 21", "CHAY_RUNG", "1", "8", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 41, "5", "User Add", "9", null, "Meta data example 31", "CAY_TRONG", "3", "9", new DateTime(2020, 12, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 30, "1", "User Activity Log", "10", null, "Meta data example 20", "LUOI_DIEN", "2", "14", new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 29, "3", "User Add", "6", null, "Meta data example 19", "CAY_TRONG", "4", "12", new DateTime(2020, 12, 2, 3, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 28, "10", "User Activity Log", "6", null, "Meta data example 18", "CAY_TRONG", "1", "2", new DateTime(2020, 12, 1, 13, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 10, "7", "User Delete", "4", null, "Meta data example 0", "CAY_TRONG", "3", "6", new DateTime(2020, 12, 2, 13, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 11, "1", "User Delete", "7", null, "Meta data example 1", "DE_DIEU", "2", "12", new DateTime(2020, 12, 1, 11, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 12, "6", "User Activity Log", "8", null, "Meta data example 2", "CHAY_RUNG", "3", "3", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 13, "8", "User Add", "9", null, "Meta data example 3", "LUOI_DIEN", "3", "14", new DateTime(2020, 12, 2, 13, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 14, "3", "User Delete", "1", null, "Meta data example 4", "CHAY_RUNG", "1", "7", new DateTime(2020, 12, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 16, "9", "User Activity Log", "4", null, "Meta data example 6", "LUOI_DIEN", "4", "4", new DateTime(2020, 12, 1, 12, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 17, "3", "User Delete", "8", null, "Meta data example 7", "LUOI_DIEN", "1", "8", new DateTime(2020, 12, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 18, "4", "User Add", "1", null, "Meta data example 8", "LUOI_DIEN", "2", "9", new DateTime(2020, 12, 1, 3, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 15, "1", "User Activity Log", "10", null, "Meta data example 5", "DE_DIEU", "3", "8", new DateTime(2020, 12, 2, 14, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 20, "6", "User Activity Log", "5", null, "Meta data example 10", "CHAY_RUNG", "3", "10", new DateTime(2020, 12, 2, 2, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 19, "3", "User Add", "3", null, "Meta data example 9", "DE_DIEU", "2", "12", new DateTime(2020, 12, 2, 12, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 26, "10", "User Activity Log", "5", null, "Meta data example 16", "CAY_TRONG", "1", "11", new DateTime(2020, 12, 2, 12, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 25, "5", "User Activity Log", "5", null, "Meta data example 15", "LUOI_DIEN", "3", "2", new DateTime(2020, 12, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 24, "1", "User Activity Log", "3", null, "Meta data example 14", "CHAY_RUNG", "3", "11", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 27, "10", "User Activity Log", "6", null, "Meta data example 17", "LUOI_DIEN", "1", "13", new DateTime(2020, 12, 1, 9, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 22, "3", "User Delete", "4", null, "Meta data example 12", "DE_DIEU", "1", "11", new DateTime(2020, 12, 1, 9, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 21, "10", "User Delete", "9", null, "Meta data example 11", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 23, "1", "User Edit", "7", null, "Meta data example 13", "CAY_TRONG", "4", "13", new DateTime(2020, 12, 1, 2, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "6", "Video Add", "5", "38", "9", "Video BC", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "9", "Video Delete", "2", "34", "6", "Video WF", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "6", "Video Add", "6", "30", "13", "Video AL", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "6", "Video Activity Log", "8", "13", "12", "Video UY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "6", "Video Activity Log", "7", "20", "11", "Video IJ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 9, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "2", "Video Edit", "8", "6", "11", "Video CE", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "8", "Video Activity Log", "2", "4", "11", "Video ID", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "9", "Video Delete", "6", "13", "8", "Video TY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "7", "Video Edit", "9", "6", "10", "Video WV", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "5", "Video Add", "4", "1", "4", "Video QS", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "8", "Video Edit", "4", "17", "12", "Video LT", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "4", "Video Edit", "5", "1", "6", "Video BL", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "3", "Video Delete", "7", "22", "1", "Video UM", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "9", "Video Add", "9", "37", "12", "Video IN", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "1", "Video Delete", "3", "22", "2", "Video SK", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "9", "Video Add", "5", "24", "6", "Video RD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "10", "Video Add", "10", "7", "13", "Video RY", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "7", "Video Delete", "3", "2", "13", "Video PI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "Video Edit", "6", "18", "8", "Video HU", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 7, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "7", "Video Edit", "8", "35", "13", "Video AR", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "5", "Video Edit", "9", "9", "7", "Video RH", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "5", "Video Edit", "7", "21", "1", "Video LN", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "3", "Video Delete", "3", "16", "8", "Video AI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Video Add", "8", "5", "14", "Video YW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "1", "Video Add", "4", "21", "8", "Video WW", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "9", "Video Edit", "10", "37", "10", "Video JO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "7", "Video Add", "7", "7", "8", "Video MO", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "9", "Video Edit", "1", "28", "9", "Video GW", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "8", "Video Activity Log", "1", "14", "10", "Video SD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "Video Edit", "6", "1", "11", "Video KL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "2", "Video Delete", "10", "8", "8", "Video TF", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "8", "Video Delete", "8", "14", "2", "Video EH", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 12, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "3", "Video Edit", "10", "27", "6", "Video OD", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Video Edit", "6", "28", "1", "Video VX", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "5", "Video Edit", "7", "17", "3", "Video FC", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "10", "Video Activity Log", "5", "3", "9", "Video TI", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "3", "Video Delete", "3", "26", "6", "Video AS", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "6", "Video Add", "5", "30", "7", "Video IL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "9", "Video Delete", "6", "14", "13", "Video NV", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "5", "Video Add", "1", "30", "6", "Video NI", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "5", "Warning Activity Log", "3", "Warning NY", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 14, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "3", "Warning Activity Log", "7", "Warning TH", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 6, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "2", "Warning Edit", "5", "Warning VC", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "4", "Warning Activity Log", "9", "Warning RL", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 3, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "Warning Delete", "6", "Warning QS", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "8", "Warning Activity Log", "2", "Warning PU", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 4, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "3", "Warning Add", "7", "Warning TJ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "2", "Warning Edit", "5", "Warning HH", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 1, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "7", "Warning Activity Log", "4", "Warning RU", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "5", "Warning Delete", "2", "Warning HK", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "2", "Warning Delete", "4", "Warning HL", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "4", "Warning Activity Log", "7", "Warning GG", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 9, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "3", "Warning Add", "5", "Warning TB", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "2", "Warning Delete", "9", "Warning GF", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 9, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "4", "Warning Delete", "9", "Warning HU", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 2, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "7", "Warning Edit", "1", "Warning PM", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 16, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "4", "Warning Activity Log", "8", "Warning HI", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 1, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "8", "Warning Add", "4", "Warning OJ", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 16, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "10", "Warning Delete", "8", "Warning HK", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "7", "Warning Edit", "7", "Warning VA", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 6, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "8", "Warning Delete", "6", "Warning NY", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "7", "Warning Delete", "1", "Warning WR", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "1", "Warning Activity Log", "7", "Warning OP", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "6", "Warning Activity Log", "4", "Warning BX", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "10", "Warning Add", "10", "Warning ZD", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "5", "Warning Edit", "5", "Warning YG", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 2, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "Warning Edit", "7", "Warning HM", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 8, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "3", "Warning Delete", "10", "Warning DX", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 10, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "8", "Warning Activity Log", "3", "Warning BY", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "5", "Warning Edit", "2", "Warning JC", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "1", "Warning Edit", "8", "Warning QB", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 5, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "3", "Warning Activity Log", "3", "Warning RO", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "9", "Warning Activity Log", "9", "Warning PM", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "6", "Warning Activity Log", "6", "Warning ST", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 14, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "1", "Warning Add", "8", "Warning SE", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 9, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "10", "Warning Activity Log", "8", "Warning CI", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 15, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "Warning Add", "6", "Warning SC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "10", "Warning Add", "6", "Warning WX", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "3", "Warning Delete", "9", "Warning GE", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "3", "Warning Edit", "7", "Warning YO", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 4 });
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
