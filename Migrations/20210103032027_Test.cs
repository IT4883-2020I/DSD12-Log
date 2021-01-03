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
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 1, "5", "Drone Edit", "4", 10, 39, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 2, 2, 7, 0, 0, DateTimeKind.Unspecified), 4, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 73, "1", "Drone Delete", "1", 18, 13, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 3, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 72, "3", "Drone Activity Log", "6", 40, 13, "Drone 6", "LUOI_DIEN", new DateTime(2020, 12, 1, 6, 26, 0, 0, DateTimeKind.Unspecified), 20, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 71, "6", "Drone Activity Log", "9", 42, 25, "Drone 9", "LUOI_DIEN", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 70, "5", "Drone Delete", "6", 46, 32, "Drone 6", "DE_DIEU", new DateTime(2020, 12, 1, 13, 17, 0, 0, DateTimeKind.Unspecified), 3, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 69, "6", "Drone Activity Log", "10", 16, 27, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 20, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 68, "5", "Drone Delete", "10", 18, 15, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 2, 2, 11, 0, 0, DateTimeKind.Unspecified), 3, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 67, "5", "Drone Edit", "9", 28, 12, "Drone 9", "LUOI_DIEN", new DateTime(2020, 12, 2, 13, 40, 0, 0, DateTimeKind.Unspecified), 4, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 66, "6", "Drone Delete", "9", 19, 39, "Drone 9", "DE_DIEU", new DateTime(2020, 12, 1, 14, 2, 0, 0, DateTimeKind.Unspecified), 3, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 65, "10", "Drone Edit", "6", 35, 25, "Drone 6", "LUOI_DIEN", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 64, "3", "Drone Activity Log", "6", 17, 48, "Drone 6", "DE_DIEU", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 63, "2", "Drone Add", "5", 15, 18, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 2, 1, 32, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 62, "1", "Drone Delete", "6", 47, 38, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 2, 3, 37, 0, 0, DateTimeKind.Unspecified), 3, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 61, "1", "Drone Edit", "9", 16, 16, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 12, 8, 0, 0, DateTimeKind.Unspecified), 4, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 60, "3", "Drone Edit", "1", 41, 25, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 4, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 59, "4", "Drone Add", "6", 15, 35, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 1, 7, 24, 0, 0, DateTimeKind.Unspecified), 2, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 58, "5", "Drone Add", "1", 44, 24, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 17, 1, 0, 0, DateTimeKind.Unspecified), 2, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 57, "10", "Drone Add", "4", 25, 45, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 56, "5", "Drone Activity Log", "1", 44, 31, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 2, 15, 29, 0, 0, DateTimeKind.Unspecified), 20, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 55, "9", "Drone Delete", "1", 45, 41, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 1, 5, 9, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 54, "8", "Drone Edit", "4", 49, 35, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 4, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 53, "10", "Drone Add", "9", 12, 29, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 12, 23, 0, 0, DateTimeKind.Unspecified), 2, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 74, "6", "Drone Edit", "3", 12, 32, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 4, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 75, "5", "Drone Edit", "1", 12, 35, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 1, 42, 0, 0, DateTimeKind.Unspecified), 4, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 76, "4", "Drone Edit", "3", 17, 18, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 77, "10", "Drone Edit", "6", 36, 48, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 1, 8, 6, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 100, "10", "Drone Add", "5", 45, 49, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), 2, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 99, "7", "Drone Delete", "2", 44, 14, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 1, 3, 29, 0, 0, DateTimeKind.Unspecified), 3, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 98, "5", "Drone Add", "4", 47, 34, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 2, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 97, "8", "Drone Delete", "9", 16, 20, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 12, 17, 0, 0, DateTimeKind.Unspecified), 3, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 96, "6", "Drone Edit", "9", 28, 47, "Drone 9", "LUOI_DIEN", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 95, "4", "Drone Add", "6", 49, 24, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 2, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 94, "2", "Drone Delete", "3", 20, 48, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 3, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 93, "7", "Drone Activity Log", "1", 39, 32, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 1, 10, 48, 0, 0, DateTimeKind.Unspecified), 20, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 92, "7", "Drone Edit", "1", 16, 17, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 91, "10", "Drone Edit", "5", 29, 49, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 4, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 52, "4", "Drone Delete", "1", 36, 33, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 2, 12, 25, 0, 0, DateTimeKind.Unspecified), 3, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 90, "3", "Drone Activity Log", "6", 25, 38, "Drone 6", "DE_DIEU", new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified), 20, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 88, "6", "Drone Activity Log", "8", 12, 19, "Drone 8", "DE_DIEU", new DateTime(2020, 12, 2, 4, 37, 0, 0, DateTimeKind.Unspecified), 20, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 87, "8", "Drone Activity Log", "4", 46, 21, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 20, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 86, "3", "Drone Delete", "8", 44, 27, "Drone 8", "CAY_TRONG", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 3, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 85, "7", "Drone Delete", "8", 18, 17, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 1, 5, 6, 0, 0, DateTimeKind.Unspecified), 3, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 84, "6", "Drone Delete", "1", 19, 33, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 1, 1, 43, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 83, "1", "Drone Add", "10", 31, 40, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 1, 2, 17, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 82, "8", "Drone Edit", "10", 16, 35, "Drone 10", "DE_DIEU", new DateTime(2020, 12, 2, 5, 41, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 81, "6", "Drone Delete", "9", 24, 33, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 79, "8", "Drone Activity Log", "9", 15, 17, "Drone 9", "DE_DIEU", new DateTime(2020, 12, 1, 10, 23, 0, 0, DateTimeKind.Unspecified), 20, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 78, "1", "Drone Add", "2", 12, 43, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 2, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 89, "4", "Drone Add", "1", 27, 40, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 1, 1, 41, 0, 0, DateTimeKind.Unspecified), 2, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 51, "6", "Drone Activity Log", "3", 39, 30, "Drone 3", "CAY_TRONG", new DateTime(2020, 12, 1, 6, 31, 0, 0, DateTimeKind.Unspecified), 20, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 80, "7", "Drone Edit", "6", 13, 20, "Drone 6", "DE_DIEU", new DateTime(2020, 12, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 49, "7", "Drone Add", "3", 20, 24, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 22, "5", "Drone Edit", "10", 31, 45, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 4, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 21, "8", "Drone Add", "9", 35, 18, "Drone 9", "LUOI_DIEN", new DateTime(2020, 12, 2, 3, 34, 0, 0, DateTimeKind.Unspecified), 2, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 20, "6", "Drone Edit", "2", 28, 22, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 4, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 19, "1", "Drone Delete", "4", 28, 23, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 6, 37, 0, 0, DateTimeKind.Unspecified), 3, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 18, "8", "Drone Delete", "7", 16, 24, "Drone 7", "CAY_TRONG", new DateTime(2020, 12, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), 3, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 17, "8", "Drone Activity Log", "8", 27, 17, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 4, 40, 0, 0, DateTimeKind.Unspecified), 20, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 15, "6", "Drone Add", "2", 45, 14, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 5, 20, 0, 0, DateTimeKind.Unspecified), 2, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 14, "3", "Drone Edit", "5", 14, 10, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 11, 19, 0, 0, DateTimeKind.Unspecified), 4, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 13, "6", "Drone Add", "4", 44, 31, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 2, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 12, "6", "Drone Add", "2", 19, 25, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 1, 5, 33, 0, 0, DateTimeKind.Unspecified), 2, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 11, "2", "Drone Delete", "7", 35, 41, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 15, 2, 0, 0, DateTimeKind.Unspecified), 3, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 10, "5", "Drone Add", "7", 36, 43, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 2, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 9, "3", "Drone Activity Log", "7", 49, 17, "Drone 7", "CAY_TRONG", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 20, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 8, "3", "Drone Edit", "10", 43, 11, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 4, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 7, "4", "Drone Edit", "1", 47, 37, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 1, 1, 8, 0, 0, DateTimeKind.Unspecified), 4, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 6, "2", "Drone Activity Log", "4", 21, 42, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 5, "5", "Drone Edit", "9", 28, 40, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 4, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 4, "2", "Drone Delete", "4", 46, 41, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 2, 5, 12, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 3, "5", "Drone Activity Log", "2", 41, 34, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 20, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 2, "1", "Drone Delete", "2", 37, 38, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 2, 1, 22, 0, 0, DateTimeKind.Unspecified), 3, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 50, "8", "Drone Add", "8", 41, 34, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 17, 7, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 23, "5", "Drone Delete", "1", 43, 33, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 8, 20, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 24, "6", "Drone Edit", "5", 37, 17, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 4, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 16, "5", "Drone Edit", "7", 21, 26, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 4, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 26, "8", "Drone Activity Log", "4", 32, 10, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 1, 9, 47, 0, 0, DateTimeKind.Unspecified), 20, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 48, "4", "Drone Activity Log", "8", 39, 48, "Drone 8", "CAY_TRONG", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 20, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 47, "2", "Drone Edit", "10", 24, 14, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 2, 11, 37, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 46, "6", "Drone Edit", "10", 49, 45, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 1, 7, 9, 0, 0, DateTimeKind.Unspecified), 4, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 25, "3", "Drone Add", "10", 40, 38, "Drone 10", "CHAY_RUNG", new DateTime(2020, 12, 2, 2, 12, 0, 0, DateTimeKind.Unspecified), 2, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 44, "4", "Drone Add", "4", 43, 30, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), 2, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 43, "8", "Drone Add", "1", 13, 31, "Drone 1", "CHAY_RUNG", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 2, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 42, "6", "Drone Edit", "7", 48, 22, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 15, 22, 0, 0, DateTimeKind.Unspecified), 4, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 41, "2", "Drone Add", "9", 47, 47, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 2, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 40, "7", "Drone Edit", "4", 19, 47, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 4, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 39, "3", "Drone Add", "2", 22, 46, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 2, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 38, "10", "Drone Add", "5", 32, 48, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified), 2, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 37, "9", "Drone Activity Log", "2", 37, 37, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 20, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 45, "2", "Drone Edit", "5", 19, 20, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 4, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 35, "5", "Drone Activity Log", "9", 45, 21, "Drone 9", "LUOI_DIEN", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 20, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 27, "10", "Drone Delete", "5", 48, 35, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 36, "2", "Drone Edit", "6", 22, 44, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 1, 2, 48, 0, 0, DateTimeKind.Unspecified), 4, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 29, "6", "Drone Delete", "10", 20, 27, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 3, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 30, "8", "Drone Add", "9", 44, 45, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 28, "10", "Drone Delete", "1", 19, 41, "Drone 1", "CHAY_RUNG", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 3, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 32, "10", "Drone Activity Log", "2", 47, 46, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 2, 17, 46, 0, 0, DateTimeKind.Unspecified), 20, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 33, "3", "Drone Edit", "5", 30, 11, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 34, "6", "Drone Edit", "5", 17, 47, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 31, "2", "Drone Edit", "10", 20, 25, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), 4, "7" });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "2", "Hình ảnh theo dõi DE_DIEU GNUQT", "9", "32", "5", "Image SR", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "8", "Hình ảnh theo dõi DE_DIEU APWMT", "9", "15", "3", "Image HL", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "6", "Hình ảnh theo dõi CAY_TRONG KTZLB", "6", "13", "5", "Image DZ", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "6", "Hình ảnh theo dõi CHAY_RUNG OWRMC", "10", "17", "2", "Image GX", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "6", "Hình ảnh theo dõi CHAY_RUNG UAHRM", "7", "5", "7", "Image JF", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "7", "Hình ảnh theo dõi CAY_TRONG WCPAD", "2", "9", "10", "Image VM", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "2", "Hình ảnh theo dõi LUOI_DIEN TAXKI", "7", "24", "3", "Image KU", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "7", "Hình ảnh theo dõi DE_DIEU NVPYJ", "7", "28", "9", "Image TT", "DE_DIEU", "0", new DateTime(2020, 12, 1, 3, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "9", "Hình ảnh theo dõi DE_DIEU PQWSK", "10", "18", "10", "Image AA", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "2", "Hình ảnh theo dõi CHAY_RUNG RPLMY", "10", "17", "11", "Image TP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "2", "Hình ảnh theo dõi DE_DIEU JRZGQ", "7", "26", "5", "Image YU", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "4", "Hình ảnh theo dõi CHAY_RUNG HRQXM", "9", "27", "8", "Image TC", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "Hình ảnh theo dõi CAY_TRONG UOKGE", "7", "14", "14", "Image UB", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "2", "Hình ảnh theo dõi DE_DIEU LECCI", "10", "10", "12", "Image EJ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 2, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "7", "Hình ảnh theo dõi LUOI_DIEN WWLSJ", "6", "36", "10", "Image DO", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "Hình ảnh theo dõi CHAY_RUNG AAIYN", "4", "2", "4", "Image RT", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 6, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "1", "Hình ảnh theo dõi CAY_TRONG BMLBO", "3", "29", "11", "Image NW", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "6", "Hình ảnh theo dõi LUOI_DIEN SEJZS", "6", "35", "5", "Image IF", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "6", "Hình ảnh theo dõi CHAY_RUNG ODPZN", "10", "18", "2", "Image YE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "1", "Hình ảnh theo dõi DE_DIEU GQPWN", "7", "9", "1", "Image XM", "DE_DIEU", "0", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "8", "Hình ảnh theo dõi CHAY_RUNG XUWTZ", "6", "3", "1", "Image TV", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "3", "Hình ảnh theo dõi LUOI_DIEN FACJR", "4", "12", "9", "Image LF", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "5", "Hình ảnh theo dõi DE_DIEU MZVAR", "4", "23", "5", "Image KT", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Hình ảnh theo dõi LUOI_DIEN SPMDI", "6", "31", "4", "Image CR", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "5", "Hình ảnh theo dõi LUOI_DIEN RKDME", "2", "17", "8", "Image LS", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "10", "Hình ảnh theo dõi CHAY_RUNG IVBTN", "9", "19", "3", "Image EQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "3", "Hình ảnh theo dõi DE_DIEU FIKDL", "7", "6", "9", "Image WY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "Hình ảnh theo dõi CAY_TRONG UFQTF", "1", "5", "1", "Image EJ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "Hình ảnh theo dõi CAY_TRONG ZRXAR", "9", "26", "7", "Image NE", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "Hình ảnh theo dõi LUOI_DIEN MSAQN", "7", "37", "12", "Image OH", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "3", "Hình ảnh theo dõi CHAY_RUNG LNYDN", "3", "27", "10", "Image SE", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "3", "Hình ảnh theo dõi DE_DIEU NKJFG", "4", "27", "2", "Image EF", "DE_DIEU", "0", new DateTime(2020, 12, 1, 3, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "4", "Hình ảnh theo dõi LUOI_DIEN DKDWV", "1", "10", "5", "Image ES", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 14, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "2", "Hình ảnh theo dõi CHAY_RUNG PBGHT", "1", "22", "14", "Image EM", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "7", "Hình ảnh theo dõi DE_DIEU YACOI", "10", "4", "7", "Image QF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "5", "Hình ảnh theo dõi DE_DIEU ULNHD", "6", "40", "7", "Image ZO", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "2", "Hình ảnh theo dõi CHAY_RUNG MSNCL", "4", "28", "13", "Image KU", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "10", "Hình ảnh theo dõi LUOI_DIEN YMDHQ", "5", "8", "11", "Image OS", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 13, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "Hình ảnh theo dõi CHAY_RUNG QRVSI", "7", "19", "8", "Image WW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "2", "Hình ảnh theo dõi CAY_TRONG XEHFC", "6", "21", "12", "Image RZ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "10", "Incident Delete", "13", "Incident JW", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "Incident Add", "1", "Incident JN", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 12, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "Incident Delete", "1", "Incident LB", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "Incident Activity Log", "2", "Incident AU", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "8", "Incident Activity Log", "6", "Incident SL", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "5", "Incident Edit", "8", "Incident EN", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 14, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "3", "Incident Edit", "7", "Incident OW", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 14, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "Incident Activity Log", "1", "Incident DY", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 13, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "Incident Delete", "12", "Incident HT", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "9", "Incident Activity Log", "1", "Incident BC", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 7, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "8", "Incident Delete", "2", "Incident SH", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "1", "Incident Activity Log", "4", "Incident BW", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 6, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "5", "Incident Activity Log", "13", "Incident AR", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "10", "Incident Edit", "9", "Incident PP", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 15, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "3", "Incident Activity Log", "8", "Incident NK", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 8, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "2", "Incident Add", "8", "Incident FW", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "2", "Incident Add", "12", "Incident EM", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 10, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "7", "Incident Delete", "8", "Incident LB", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "5", "Incident Add", "2", "Incident VJ", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "7", "Incident Delete", "7", "Incident WL", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "2", "Incident Edit", "9", "Incident HC", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 6, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "Incident Delete", "9", "Incident OA", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "6", "Incident Edit", "1", "Incident AE", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "2", "Incident Add", "14", "Incident UC", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 7, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "7", "Incident Delete", "3", "Incident GR", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 15, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "10", "Incident Add", "6", "Incident FF", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 12, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "3", "Incident Add", "5", "Incident OD", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 13, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "5", "Incident Activity Log", "8", "Incident QV", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "Incident Delete", "14", "Incident RM", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "Incident Delete", "9", "Incident YX", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 3, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "4", "Incident Activity Log", "7", "Incident SE", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 4, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "1", "Incident Activity Log", "13", "Incident EV", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "3", "Incident Activity Log", "1", "Incident LM", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 4, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "9", "Incident Activity Log", "6", "Incident AG", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "4", "Incident Add", "13", "Incident FY", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 17, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "4", "Incident Add", "7", "Incident TZ", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "6", "Incident Activity Log", "2", "Incident WT", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "9", "Incident Activity Log", "4", "Incident VG", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "10", "Incident Delete", "7", "Incident II", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "10", "Incident Add", "5", "Incident JQ", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "7", "MonitorRegion Edit", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "MonitorRegion Activity Log", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "8", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "9", "MonitorRegion Add", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 15, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "1", "MonitorRegion Edit", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "9", "MonitorRegion Delete", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "5", "MonitorRegion Add", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "MonitorRegion Activity Log", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "3", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "1", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "3", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "MonitorRegion Activity Log", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "5", "MonitorRegion Edit", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 15, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "7", "MonitorRegion Activity Log", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "1", "MonitorRegion Activity Log", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "1", "MonitorRegion Add", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 13, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "9", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "9", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 12, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "7", "MonitorRegion Delete", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 1, "10", "MonitorRegion Delete", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "DE_DIEU", "0", new DateTime(2020, 12, 2, 11, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "2", "MonitorRegion Edit", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 2, "8", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 3, "1", "MonitorRegion Activity Log", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 4, "3", "MonitorRegion Edit", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 5, "5", "MonitorRegion Add", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 7, "2", "MonitorRegion Edit", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "DE_DIEU", "0", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 8, "2", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 9, "5", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 12, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 6, "1", "MonitorRegion Delete", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "3", "MonitorRegion Edit", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "3", "MonitorRegion Delete", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "MonitorRegion Add", "5fec86a1f139ff00177a252e", "MonitorRegion 5fec86a1f139ff00177a252e", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "MonitorRegion Delete", "5fec0951eeec7500179c9bbd", "MonitorRegion 5fec0951eeec7500179c9bbd", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "5", "MonitorRegion Edit", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "7", "MonitorRegion Edit", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "3", "MonitorRegion Activity Log", "5fe1a1ade40ec00017660154", "MonitorRegion 5fe1a1ade40ec00017660154", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "7", "MonitorRegion Activity Log", "5fec08a6eeec7500179c9bbb", "MonitorRegion 5fec08a6eeec7500179c9bbb", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 11, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "10", "MonitorRegion Delete", "5fec08eeeeec7500179c9bbc", "MonitorRegion 5fec08eeeeec7500179c9bbc", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "9", "ObjectObserve Add", "5", "ObjectObserve WV", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 11, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "3", "ObjectObserve Activity Log", "2", "ObjectObserve MU", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "7", "ObjectObserve Edit", "19", "ObjectObserve UB", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 4, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "4", "ObjectObserve Edit", "12", "ObjectObserve AR", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 15, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "ObjectObserve Activity Log", "14", "ObjectObserve OW", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 10, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "6", "ObjectObserve Activity Log", "11", "ObjectObserve MX", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 16, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "7", "ObjectObserve Delete", "13", "ObjectObserve LI", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 11, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "10", "ObjectObserve Edit", "11", "ObjectObserve TL", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "7", "ObjectObserve Add", "9", "ObjectObserve AR", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "5", "ObjectObserve Delete", "8", "ObjectObserve FW", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 17, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "2", "ObjectObserve Delete", "20", "ObjectObserve LO", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 1, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "6", "ObjectObserve Delete", "12", "ObjectObserve EZ", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "10", "ObjectObserve Activity Log", "20", "ObjectObserve WA", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 4, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "5", "ObjectObserve Add", "10", "ObjectObserve NC", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 8, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "3", "ObjectObserve Edit", "18", "ObjectObserve KJ", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "4", "ObjectObserve Activity Log", "4", "ObjectObserve MY", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 4, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "2", "ObjectObserve Add", "6", "ObjectObserve KL", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 3, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "8", "ObjectObserve Add", "2", "ObjectObserve RM", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "ObjectObserve Activity Log", "14", "ObjectObserve AC", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 6, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "1", "ObjectObserve Activity Log", "16", "ObjectObserve WO", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 7, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "ObjectObserve Delete", "18", "ObjectObserve LY", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 13, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "10", "ObjectObserve Delete", "2", "ObjectObserve YQ", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "2", "ObjectObserve Add", "13", "ObjectObserve HL", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "6", "ObjectObserve Activity Log", "2", "ObjectObserve HW", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 16, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "10", "ObjectObserve Activity Log", "7", "ObjectObserve SX", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "4", "ObjectObserve Add", "2", "ObjectObserve KL", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 4, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "6", "ObjectObserve Edit", "15", "ObjectObserve OJ", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "ObjectObserve Activity Log", "3", "ObjectObserve QU", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 2, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "7", "ObjectObserve Delete", "8", "ObjectObserve QB", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 6, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "ObjectObserve Delete", "20", "ObjectObserve IC", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "1", "ObjectObserve Add", "16", "ObjectObserve DJ", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 10, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "2", "ObjectObserve Activity Log", "16", "ObjectObserve OQ", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 2, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "2", "ObjectObserve Activity Log", "8", "ObjectObserve DQ", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "ObjectObserve Delete", "19", "ObjectObserve VB", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 11, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "ObjectObserve Activity Log", "10", "ObjectObserve LR", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "6", "ObjectObserve Edit", "5", "ObjectObserve UD", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 13, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "10", "ObjectObserve Add", "7", "ObjectObserve CK", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 9, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "10", "ObjectObserve Delete", "18", "ObjectObserve CT", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "ObjectObserve Add", "5", "ObjectObserve TT", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 10, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "5", "ObjectObserve Activity Log", "17", "ObjectObserve ZW", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "5", "Payload Edit", "3", "1", "EC-CML-E", "DE_DIEU", "1", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "7", "Payload Edit", "7", "4", "VQ-ZLI-J", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "10", "Payload Delete", "2", "8", "HV-KGT-L", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "6", "Payload Activity Log", "9", "5", "HG-DEK-D", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "4", "Payload Delete", "6", "3", "KU-MLH-K", "DE_DIEU", "1", new DateTime(2020, 12, 1, 2, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "Payload Delete", "7", "5", "TG-NIP-N", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "4", "Payload Activity Log", "8", "10", "CL-RUY-O", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "1", "Payload Activity Log", "4", "5", "LN-JYK-N", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "4", "Payload Delete", "10", "9", "VN-ZAZ-C", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "2", "Payload Delete", "7", "9", "MB-YOH-X", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "5", "Payload Add", "2", "2", "UL-JLP-Q", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "8", "Payload Activity Log", "2", "10", "HC-MXW-V", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "10", "Payload Edit", "3", "6", "DK-WEJ-N", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "5", "Payload Delete", "5", "5", "YS-TZM-H", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "3", "Payload Activity Log", "7", "6", "QM-VMS-J", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 11, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "3", "Payload Delete", "5", "7", "RS-AWN-M", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "10", "Payload Edit", "9", "4", "KN-DDG-Z", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "8", "Payload Delete", "10", "8", "UL-FGX-O", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "Payload Edit", "5", "3", "PX-XDX-U", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "8", "Payload Activity Log", "8", "9", "DG-YQR-V", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "4", "Payload Add", "10", "10", "UT-LDD-I", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "3", "Payload Edit", "1", "4", "EE-LUG-E", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "2", "Payload Delete", "1", "1", "CV-MXL-R", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 9, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "9", "Payload Add", "6", "7", "CC-XNH-S", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "8", "Payload Edit", "2", "3", "GX-WGV-Z", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "1", "Payload Edit", "9", "4", "YD-HSP-M", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 15, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "1", "Payload Delete", "1", "6", "NP-XHK-K", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "Payload Activity Log", "2", "8", "JL-QEI-H", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "5", "Payload Activity Log", "5", "7", "OO-SEN-J", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "2", "Payload Activity Log", "9", "6", "BU-CEY-V", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "2", "Payload Add", "5", "5", "AZ-QJA-X", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "4", "Payload Edit", "3", "3", "NZ-GXI-W", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "8", "Payload Activity Log", "4", "3", "LG-CNR-O", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "Payload Delete", "7", "4", "PO-NCC-P", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "8", "Payload Delete", "7", "2", "VV-CMO-Q", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "4", "Payload Edit", "2", "10", "GL-JCO-L", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "2", "Payload Add", "2", "3", "PL-HEM-X", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "5", "Payload Edit", "10", "10", "NA-RGH-T", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "5", "Payload Add", "9", "5", "PQ-SCD-C", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "1", "Payload Add", "2", "8", "SE-EVF-T", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "4", "ResolveProblem Edit", "14", "ResolveProblem IL", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 12, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "ResolveProblem Delete", "1", "ResolveProblem UC", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 6, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "1", "ResolveProblem Activity Log", "4", "ResolveProblem IJ", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 9, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "8", "ResolveProblem Activity Log", "12", "ResolveProblem FV", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 12, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "5", "ResolveProblem Activity Log", "3", "ResolveProblem LW", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "6", "ResolveProblem Activity Log", "7", "ResolveProblem VS", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 3, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "4", "ResolveProblem Edit", "12", "ResolveProblem MX", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "10", "ResolveProblem Add", "9", "ResolveProblem DD", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "2", "ResolveProblem Add", "12", "ResolveProblem KN", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 13, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "8", "ResolveProblem Delete", "2", "ResolveProblem LV", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 3, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "3", "ResolveProblem Activity Log", "12", "ResolveProblem VJ", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "5", "ResolveProblem Activity Log", "8", "ResolveProblem GG", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "9", "ResolveProblem Add", "5", "ResolveProblem YC", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 16, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "7", "ResolveProblem Edit", "4", "ResolveProblem FX", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "ResolveProblem Add", "8", "ResolveProblem EH", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "4", "ResolveProblem Activity Log", "1", "ResolveProblem CM", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 5, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "8", "ResolveProblem Activity Log", "3", "ResolveProblem IZ", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 4, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "1", "ResolveProblem Delete", "12", "ResolveProblem FM", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "10", "ResolveProblem Edit", "11", "ResolveProblem QH", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 5, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "5", "ResolveProblem Add", "12", "ResolveProblem YP", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "ResolveProblem Edit", "11", "ResolveProblem OQ", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 10, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "7", "ResolveProblem Delete", "5", "ResolveProblem BP", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "9", "ResolveProblem Activity Log", "2", "ResolveProblem LQ", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "9", "ResolveProblem Delete", "5", "ResolveProblem KB", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "ResolveProblem Activity Log", "5", "ResolveProblem OM", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 12, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "5", "ResolveProblem Add", "12", "ResolveProblem SJ", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "2", "ResolveProblem Add", "7", "ResolveProblem YH", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 6, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "5", "ResolveProblem Activity Log", "8", "ResolveProblem BE", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 4, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "5", "ResolveProblem Edit", "9", "ResolveProblem UW", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "4", "ResolveProblem Delete", "14", "ResolveProblem ET", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 10, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "10", "ResolveProblem Delete", "4", "ResolveProblem SR", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "2", "ResolveProblem Add", "7", "ResolveProblem KC", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "1", "ResolveProblem Edit", "10", "ResolveProblem ES", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 13, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "10", "ResolveProblem Edit", "6", "ResolveProblem VO", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 6, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "ResolveProblem Activity Log", "5", "ResolveProblem DO", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 14, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "4", "ResolveProblem Delete", "9", "ResolveProblem EX", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "9", "ResolveProblem Activity Log", "14", "ResolveProblem RI", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 4, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "3", "ResolveProblem Add", "11", "ResolveProblem SZ", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 1, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "2", "ResolveProblem Add", "12", "ResolveProblem SZ", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "5", "ResolveProblem Delete", "11", "ResolveProblem SG", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 7, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "4", "Statical Edit", "54", "Statical BO", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 11, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "10", "Statical Edit", "52", "Statical EU", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 6, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "Statical Delete", "44", "Statical FU", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 16, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "10", "Statical Add", "48", "Statical CY", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "Statical Edit", "46", "Statical NP", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 8, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "10", "Statical Activity Log", "56", "Statical UE", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "4", "Statical Delete", "50", "Statical HI", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 7, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "5", "Statical Edit", "58", "Statical UU", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 7, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "4", "Statical Delete", "70", "Statical QV", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "1", "Statical Add", "62", "Statical YY", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 7, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "1", "Statical Edit", "64", "Statical RF", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 4, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "3", "Statical Delete", "66", "Statical XH", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Statical Add", "72", "Statical UT", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "Statical Edit", "74", "Statical LI", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "8", "Statical Delete", "76", "Statical NQ", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "7", "Statical Edit", "78", "Statical QD", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "10", "Statical Delete", "42", "Statical YN", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "3", "Statical Edit", "60", "Statical GK", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 1, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "6", "Statical Delete", "40", "Statical RC", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "3", "Statical Add", "68", "Statical ZR", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "4", "Statical Delete", "36", "Statical BB", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "8", "Statical Add", "38", "Statical NF", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Statical Delete", "0", "Statical OP", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 8, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "3", "Statical Activity Log", "2", "Statical NU", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 4, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "Statical Delete", "4", "Statical VA", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "6", "Statical Edit", "6", "Statical PC", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 5, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "3", "Statical Delete", "8", "Statical RH", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "7", "Statical Activity Log", "10", "Statical NO", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 10, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "7", "Statical Delete", "12", "Statical OF", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "2", "Statical Delete", "16", "Statical HO", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 8, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "1", "Statical Delete", "14", "Statical MM", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "1", "Statical Edit", "20", "Statical BT", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 7, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "Statical Add", "22", "Statical WQ", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "8", "Statical Delete", "24", "Statical XI", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 14, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "1", "Statical Add", "26", "Statical QS", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "5", "Statical Add", "28", "Statical EU", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "Statical Delete", "30", "Statical NV", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "5", "Statical Edit", "32", "Statical EW", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "5", "Statical Activity Log", "34", "Statical XC", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "2", "Statical Edit", "18", "Statical SQ", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 16, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 77, "9", "Giám sát Activity Log", "1", "Đợi giám sát 1", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 76, "3", "Giám sát Edit", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 5, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 78, "6", "Giám sát Edit", "3", "Đợi giám sát 3", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 83, "5", "Giám sát Delete", "7", "Đợi giám sát 7", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 3, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 80, "5", "Giám sát Activity Log", "6", "Đợi giám sát 6", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 81, "7", "Giám sát Delete", "9", "Đợi giám sát 9", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 82, "6", "Giám sát Edit", "5", "Đợi giám sát 5", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 4, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 75, "6", "Giám sát Add", "4", "Đợi giám sát 4", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 9, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 79, "6", "Giám sát Activity Log", "9", "Đợi giám sát 9", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 74, "10", "Giám sát Add", "10", "Đợi giám sát 10", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 64, "2", "Giám sát Add", "8", "Đợi giám sát 8", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 72, "7", "Giám sát Delete", "11", "Đợi giám sát 11", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 71, "3", "Giám sát Edit", "2", "Đợi giám sát 2", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 70, "7", "Giám sát Delete", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 69, "9", "Giám sát Delete", "1", "Đợi giám sát 1", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 8, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 68, "4", "Giám sát Add", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 67, "10", "Giám sát Delete", "12", "Đợi giám sát 12", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 66, "6", "Giám sát Activity Log", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 1, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 65, "2", "Giám sát Add", "13", "Đợi giám sát 13", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 84, "9", "Giám sát Delete", "8", "Đợi giám sát 8", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 1, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 63, "7", "Giám sát Delete", "3", "Đợi giám sát 3", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 62, "10", "Giám sát Edit", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 6, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 73, "2", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 85, "9", "Giám sát Edit", "9", "Đợi giám sát 9", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 95, "10", "Giám sát Add", "8", "Đợi giám sát 8", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 87, "3", "Giám sát Add", "6", "Đợi giám sát 6", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 9, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 61, "8", "Giám sát Add", "13", "Đợi giám sát 13", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 1, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 109, "5", "Giám sát Delete", "13", "Đợi giám sát 13", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 108, "7", "Giám sát Edit", "4", "Đợi giám sát 4", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 107, "10", "Giám sát Edit", "3", "Đợi giám sát 3", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 2, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 106, "4", "Giám sát Delete", "10", "Đợi giám sát 10", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 5, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 105, "2", "Giám sát Activity Log", "6", "Đợi giám sát 6", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 9, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 104, "1", "Giám sát Edit", "2", "Đợi giám sát 2", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 13, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 103, "5", "Giám sát Add", "6", "Đợi giám sát 6", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 7, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 102, "6", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 101, "7", "Giám sát Edit", "11", "Đợi giám sát 11", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 86, "2", "Giám sát Edit", "9", "Đợi giám sát 9", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 13, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 100, "4", "Giám sát Add", "10", "Đợi giám sát 10", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 9, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 98, "8", "Giám sát Delete", "4", "Đợi giám sát 4", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 15, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 97, "5", "Giám sát Activity Log", "8", "Đợi giám sát 8", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 96, "3", "Giám sát Activity Log", "7", "Đợi giám sát 7", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 94, "9", "Giám sát Edit", "1", "Đợi giám sát 1", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 5, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 93, "10", "Giám sát Edit", "3", "Đợi giám sát 3", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 92, "6", "Giám sát Add", "2", "Đợi giám sát 2", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 4, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 91, "9", "Giám sát Add", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 90, "6", "Giám sát Edit", "14", "Đợi giám sát 14", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 89, "10", "Giám sát Delete", "3", "Đợi giám sát 3", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 88, "1", "Giám sát Edit", "3", "Đợi giám sát 3", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 99, "2", "Giám sát Edit", "1", "Đợi giám sát 1", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 60, "2", "Giám sát Edit", "14", "Đợi giám sát 14", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "10", "Giám sát Add", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 16, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 58, "3", "Giám sát Activity Log", "2", "Đợi giám sát 2", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 3, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "7", "Giám sát Add", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "6", "Giám sát Delete", "7", "Đợi giám sát 7", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 9, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "10", "Giám sát Edit", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 10, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "6", "Giám sát Add", "11", "Đợi giám sát 11", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 8, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "3", "Giám sát Add", "11", "Đợi giám sát 11", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "5", "Giám sát Edit", "9", "Đợi giám sát 9", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 13, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 4, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 59, "5", "Giám sát Delete", "4", "Đợi giám sát 4", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "5", "Giám sát Delete", "3", "Đợi giám sát 3", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 12, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "2", "Giám sát Add", "3", "Đợi giám sát 3", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 12, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "Giám sát Activity Log", "9", "Đợi giám sát 9", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 2, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "5", "Giám sát Add", "10", "Đợi giám sát 10", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "7", "Giám sát Delete", "9", "Đợi giám sát 9", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 15, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "3", "Giám sát Activity Log", "2", "Đợi giám sát 2", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 1, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "Giám sát Edit", "12", "Đợi giám sát 12", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "8", "Giám sát Activity Log", "13", "Đợi giám sát 13", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "4", "Giám sát Delete", "9", "Đợi giám sát 9", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "3", "Giám sát Edit", "13", "Đợi giám sát 13", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 14, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "2", "Giám sát Edit", "9", "Đợi giám sát 9", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "2", "Giám sát Delete", "13", "Đợi giám sát 13", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "3", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "8", "Giám sát Delete", "9", "Đợi giám sát 9", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "5", "Giám sát Delete", "12", "Đợi giám sát 12", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "2", "Giám sát Activity Log", "2", "Đợi giám sát 2", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 11, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "3", "Giám sát Activity Log", "5", "Đợi giám sát 5", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 15, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "8", "Giám sát Delete", "11", "Đợi giám sát 11", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 15, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 57, "10", "Giám sát Activity Log", "7", "Đợi giám sát 7", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 11, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "9", "Giám sát Edit", "12", "Đợi giám sát 12", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 3, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 55, "3", "Giám sát Add", "11", "Đợi giám sát 11", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 54, "4", "Giám sát Delete", "6", "Đợi giám sát 6", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 3, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 53, "3", "Giám sát Activity Log", "6", "Đợi giám sát 6", "LUOI_DIEN", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 5, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 52, "9", "Giám sát Edit", "7", "Đợi giám sát 7", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 51, "5", "Giám sát Activity Log", "5", "Đợi giám sát 5", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 50, "7", "Giám sát Delete", "13", "Đợi giám sát 13", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 8, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "6", "Giám sát Activity Log", "11", "Đợi giám sát 11", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "Giám sát Edit", "3", "Đợi giám sát 3", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "2", "Giám sát Add", "14", "Đợi giám sát 14", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 56, "3", "Giám sát Edit", "5", "Đợi giám sát 5", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "3", "Giám sát Activity Log", "12", "Đợi giám sát 12", "CAY_TRONG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "2", "Giám sát Add", "1", "Đợi giám sát 1", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "5", "Giám sát Add", "11", "Đợi giám sát 11", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 2, 13, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "7", "Giám sát Add", "5", "Đợi giám sát 5", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 3, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "Giám sát Add", "13", "Đợi giám sát 13", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "10", "Giám sát Activity Log", "2", "Đợi giám sát 2", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 8, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "8", "Giám sát Delete", "4", "Đợi giám sát 4", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 2, 15, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "2", "Giám sát Delete", "2", "Đợi giám sát 2", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 13, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "Giám sát Edit", "11", "Đợi giám sát 11", "DE_DIEU", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 2, 12, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "7", "Giám sát Delete", "8", "Đợi giám sát 8", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 1, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 32, "9", "User Activity Log", "9", null, "Meta data example 22", "UFICT LNVF", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "14", new DateTime(2020, 12, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 39, "8", "User Add", "5", null, "Meta data example 29", "MKFZF JRFP", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "2", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 33, "4", "User Edit", "8", null, "Meta data example 23", "OAFJA KXAA", "DE_DIEU", "5fec0951eeec7500179c9bbd", "3", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 34, "7", "User Delete", "10", null, "Meta data example 24", "YXYXR XGUQ", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "5", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 35, "10", "User Edit", "4", null, "Meta data example 25", "CHQTP ZYMV", "DE_DIEU", "5fe1a1ade40ec00017660154", "6", new DateTime(2020, 12, 2, 3, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 36, "7", "User Add", "6", null, "Meta data example 26", "GPFSI UBGU", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "2", new DateTime(2020, 12, 2, 5, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 37, "1", "User Edit", "8", null, "Meta data example 27", "JYRMX XGLK", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 38, "5", "User Activity Log", "1", null, "Meta data example 28", "ESEOM HJLU", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "13", new DateTime(2020, 12, 2, 10, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 49, "8", "User Activity Log", "5", null, "Meta data example 39", "RNBXV TJJR", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "9", new DateTime(2020, 12, 1, 2, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 44, "1", "User Delete", "5", null, "Meta data example 34", "RGQCH AIGE", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "8", new DateTime(2020, 12, 2, 15, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 41, "8", "User Edit", "3", null, "Meta data example 31", "SMBZV NKRG", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "5", new DateTime(2020, 12, 1, 12, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 42, "4", "User Add", "7", null, "Meta data example 32", "KQMUB ZSRG", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "7", new DateTime(2020, 12, 1, 15, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 43, "5", "User Edit", "9", null, "Meta data example 33", "GBWNA FSCG", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 45, "5", "User Edit", "3", null, "Meta data example 35", "YAZOM FNFB", "DE_DIEU", "5fec0951eeec7500179c9bbd", "3", new DateTime(2020, 12, 2, 7, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 46, "6", "User Delete", "4", null, "Meta data example 36", "LYWGL RPOY", "CAY_TRONG", "5fec0951eeec7500179c9bbd", "6", new DateTime(2020, 12, 2, 4, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 47, "8", "User Edit", "5", null, "Meta data example 37", "VIKZJ EZJM", "DE_DIEU", "5fec0951eeec7500179c9bbd", "13", new DateTime(2020, 12, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 48, "5", "User Add", "8", null, "Meta data example 38", "QMNOQ FBHA", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "7", new DateTime(2020, 12, 1, 1, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 31, "1", "User Activity Log", "9", null, "Meta data example 21", "UHQUY GZRZ", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "7", new DateTime(2020, 12, 1, 15, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 40, "9", "User Activity Log", "8", null, "Meta data example 30", "VZZCH EPDV", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "9", new DateTime(2020, 12, 2, 7, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 30, "4", "User Delete", "2", null, "Meta data example 20", "FGOPL TKLH", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "10", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 19, "4", "User Edit", "4", null, "Meta data example 9", "JRNRI NKKG", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "13", new DateTime(2020, 12, 2, 10, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 28, "10", "User Add", "6", null, "Meta data example 18", "RLQLG IIGU", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "8", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 29, "4", "User Delete", "5", null, "Meta data example 19", "EWPPX BYPP", "DE_DIEU", "5fec0951eeec7500179c9bbd", "10", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 10, "4", "User Delete", "4", null, "Meta data example 0", "VMTEC CZWB", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "2", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 11, "4", "User Edit", "5", null, "Meta data example 1", "HUMXV WRLJ", "DE_DIEU", "5fec86a1f139ff00177a252e", "14", new DateTime(2020, 12, 2, 7, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 12, "5", "User Delete", "1", null, "Meta data example 2", "LLJHD BOUI", "DE_DIEU", "5fec0951eeec7500179c9bbd", "12", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 14, "4", "User Activity Log", "5", null, "Meta data example 4", "TYCYB LFPG", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "11", new DateTime(2020, 12, 2, 11, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 15, "2", "User Delete", "1", null, "Meta data example 5", "KMVZU KDMB", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "9", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 16, "4", "User Add", "8", null, "Meta data example 6", "NFNSR BQPX", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "5", new DateTime(2020, 12, 1, 8, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 17, "4", "User Delete", "2", null, "Meta data example 7", "SCUNQ NILF", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "3", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 13, "2", "User Delete", "2", null, "Meta data example 3", "WGEWA NDPR", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "8", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 20, "2", "User Add", "8", null, "Meta data example 10", "VPSYS HSII", "CAY_TRONG", "5fec86a1f139ff00177a252e", "14", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 21, "4", "User Delete", "8", null, "Meta data example 11", "CRHKE ORPU", "DE_DIEU", "5fec0951eeec7500179c9bbd", "2", new DateTime(2020, 12, 2, 1, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 22, "5", "User Delete", "1", null, "Meta data example 12", "QLOHY BPDF", "CAY_TRONG", "5fe1a1ade40ec00017660154", "6", new DateTime(2020, 12, 2, 17, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 23, "9", "User Add", "5", null, "Meta data example 13", "DYFEV GHPF", "CAY_TRONG", "5fec86a1f139ff00177a252e", "11", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 27, "2", "User Activity Log", "4", null, "Meta data example 17", "HCKDQ NPUT", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "14", new DateTime(2020, 12, 2, 9, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 24, "8", "User Edit", "6", null, "Meta data example 14", "RCVTN SJDN", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "13", new DateTime(2020, 12, 2, 5, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 25, "7", "User Edit", "2", null, "Meta data example 15", "WUPYK KBKA", "DE_DIEU", "5fec86a1f139ff00177a252e", "3", new DateTime(2020, 12, 1, 9, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 26, "1", "User Edit", "4", null, "Meta data example 16", "SPDGE DMCO", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "12", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 18, "10", "User Edit", "2", null, "Meta data example 8", "WZNXY JLEB", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "7", new DateTime(2020, 12, 1, 15, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 76, "4", "Video theo dõi DE_DIEU HXWBW", "3", "36", "10", "Video KD", "DE_DIEU", "0", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 77, "1", "Video theo dõi LUOI_DIEN RPYRS", "9", "21", "7", "Video KQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 78, "1", "Video theo dõi CHAY_RUNG EWHLS", "5", "6", "1", "Video LC", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 82, "1", "Video theo dõi CAY_TRONG MJJRX", "5", "11", "4", "Video TW", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 80, "5", "Video theo dõi CHAY_RUNG HDOMM", "7", "2", "1", "Video DE", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 81, "3", "Video theo dõi LUOI_DIEN UXOCP", "9", "12", "14", "Video YB", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 83, "7", "Video theo dõi DE_DIEU UWESU", "7", "35", "14", "Video UZ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 75, "8", "Video theo dõi CAY_TRONG VCUNN", "9", "7", "2", "Video EE", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 79, "4", "Video theo dõi CHAY_RUNG XEPJN", "3", "17", "12", "Video VF", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 74, "6", "Video theo dõi LUOI_DIEN LYKFS", "8", "34", "8", "Video OP", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 64, "9", "Video theo dõi LUOI_DIEN DMDUY", "6", "5", "6", "Video XI", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 72, "8", "Video theo dõi CHAY_RUNG NNYKM", "4", "34", "3", "Video HI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 71, "5", "Video theo dõi CHAY_RUNG TJXSJ", "5", "25", "11", "Video DR", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 5, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 69, "9", "Video theo dõi DE_DIEU TZSJO", "7", "31", "4", "Video VU", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 68, "5", "Video theo dõi DE_DIEU EBDOW", "3", "35", "10", "Video KX", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 67, "10", "Video theo dõi CAY_TRONG WFOFF", "2", "8", "12", "Video AN", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 1, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 66, "5", "Video theo dõi LUOI_DIEN DYAMU", "5", "14", "3", "Video DS", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 65, "4", "Video theo dõi DE_DIEU VBGDM", "4", "17", "12", "Video PV", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 84, "9", "Video theo dõi CAY_TRONG KCKPW", "7", "17", "6", "Video DY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 63, "1", "Video theo dõi CAY_TRONG FPFKX", "10", "38", "14", "Video DX", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 62, "3", "Video theo dõi CAY_TRONG LCVOK", "8", "24", "3", "Video VY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 73, "7", "Video theo dõi CHAY_RUNG AMSVK", "1", "5", "7", "Video IE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 85, "2", "Video theo dõi DE_DIEU RFRVX", "4", "22", "10", "Video ZJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 94, "8", "Video theo dõi DE_DIEU TXBSV", "4", "1", "14", "Video QD", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 87, "1", "Video theo dõi CAY_TRONG GSSPY", "6", "22", "9", "Video MG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 109, "2", "Video theo dõi CAY_TRONG ZAVOE", "2", "36", "7", "Video ZF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 108, "5", "Video theo dõi CHAY_RUNG FSGAF", "4", "6", "2", "Video NW", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 107, "5", "Video theo dõi CAY_TRONG UFIEE", "9", "39", "9", "Video PG", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 106, "10", "Video theo dõi CHAY_RUNG VUWDJ", "7", "28", "4", "Video MJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 105, "9", "Video theo dõi CAY_TRONG EJEWO", "8", "25", "11", "Video OR", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 104, "9", "Video theo dõi DE_DIEU ORPLF", "3", "23", "1", "Video OK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 103, "6", "Video theo dõi CAY_TRONG LJWKU", "9", "8", "7", "Video BE", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 102, "1", "Video theo dõi CHAY_RUNG OJIZY", "10", "39", "8", "Video IV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 101, "10", "Video theo dõi LUOI_DIEN KJWVR", "3", "36", "3", "Video VZ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 100, "5", "Video theo dõi CHAY_RUNG SQZTO", "2", "24", "4", "Video BZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 86, "1", "Video theo dõi LUOI_DIEN CEXDM", "2", "2", "2", "Video OY", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 99, "10", "Video theo dõi LUOI_DIEN NUXLN", "8", "4", "7", "Video RL", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 97, "7", "Video theo dõi DE_DIEU VAZHC", "7", "24", "1", "Video FH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 96, "3", "Video theo dõi LUOI_DIEN EUSKE", "6", "21", "12", "Video SN", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 4, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 95, "4", "Video theo dõi CHAY_RUNG IWISD", "9", "16", "2", "Video IW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 1, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 61, "5", "Video theo dõi DE_DIEU XCDGA", "10", "36", "5", "Video ZF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 4, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 93, "8", "Video theo dõi DE_DIEU ROTEO", "2", "36", "11", "Video GM", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 92, "4", "Video theo dõi DE_DIEU ZRWFH", "5", "13", "13", "Video WK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 1, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 91, "8", "Video theo dõi LUOI_DIEN EVIEL", "6", "15", "9", "Video ID", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 90, "3", "Video theo dõi CHAY_RUNG NFQQW", "4", "7", "3", "Video VJ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 89, "6", "Video theo dõi DE_DIEU KHZRC", "2", "24", "11", "Video BY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 4, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 88, "6", "Video theo dõi CHAY_RUNG YSSNO", "4", "11", "11", "Video MN", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 98, "5", "Video theo dõi CAY_TRONG JEKOG", "6", "28", "2", "Video KJ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 60, "9", "Video theo dõi CAY_TRONG PVMUU", "6", "11", "3", "Video LL", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 70, "4", "Video theo dõi LUOI_DIEN UAHYD", "8", "3", "8", "Video LG", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 58, "7", "Video theo dõi LUOI_DIEN HGLDF", "2", "9", "13", "Video PW", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "1", "Video theo dõi CHAY_RUNG BOUER", "10", "33", "8", "Video NZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "10", "Video theo dõi CAY_TRONG UEZNY", "1", "20", "12", "Video MM", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "9", "Video theo dõi CAY_TRONG GMMVI", "8", "14", "9", "Video HH", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "Video theo dõi LUOI_DIEN NMYED", "4", "27", "8", "Video WQ", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "3", "Video theo dõi CHAY_RUNG JQCBP", "4", "14", "3", "Video WX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Video theo dõi LUOI_DIEN DWMPT", "9", "11", "14", "Video XD", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "8", "Video theo dõi DE_DIEU HTOEQ", "3", "21", "5", "Video ZL", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "7", "Video theo dõi CAY_TRONG BEXEU", "4", "13", "14", "Video UP", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "5", "Video theo dõi LUOI_DIEN VGODK", "2", "1", "9", "Video LC", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Video theo dõi CHAY_RUNG DVAUP", "6", "10", "12", "Video WL", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "3", "Video theo dõi CHAY_RUNG WDQEB", "6", "39", "4", "Video HF", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "1", "Video theo dõi DE_DIEU WPTZI", "6", "24", "4", "Video BA", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "3", "Video theo dõi CHAY_RUNG KEIPK", "8", "16", "9", "Video UR", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "4", "Video theo dõi DE_DIEU SHBKT", "5", "19", "12", "Video JZ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "7", "Video theo dõi CHAY_RUNG BSXDZ", "7", "8", "7", "Video JS", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "Video theo dõi LUOI_DIEN IUAYI", "4", "24", "7", "Video SB", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "7", "Video theo dõi LUOI_DIEN VWSTB", "4", "7", "7", "Video RH", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 59, "6", "Video theo dõi DE_DIEU FIUMO", "1", "12", "10", "Video QR", "DE_DIEU", "1", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "1", "Video theo dõi CAY_TRONG KMAWT", "3", "3", "6", "Video IC", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "3", "Video theo dõi CHAY_RUNG APFDL", "1", "32", "9", "Video DN", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "9", "Video theo dõi CAY_TRONG FUQCI", "5", "39", "14", "Video WD", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "10", "Video theo dõi CAY_TRONG QPLIQ", "3", "10", "5", "Video AF", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "7", "Video theo dõi DE_DIEU FVOYH", "9", "4", "14", "Video DA", "DE_DIEU", "0", new DateTime(2020, 12, 2, 15, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "9", "Video theo dõi CHAY_RUNG FDIHK", "3", "40", "13", "Video HA", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "5", "Video theo dõi LUOI_DIEN AXCUR", "10", "25", "6", "Video GE", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "7", "Video theo dõi LUOI_DIEN ZUDOB", "4", "20", "6", "Video MR", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "8", "Video theo dõi CAY_TRONG IGGKX", "7", "23", "7", "Video KL", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 57, "7", "Video theo dõi CAY_TRONG SVPSP", "10", "18", "4", "Video LS", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 55, "10", "Video theo dõi DE_DIEU HDFDV", "3", "11", "12", "Video WZ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 54, "9", "Video theo dõi CHAY_RUNG CNNVB", "3", "24", "3", "Video QS", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 53, "6", "Video theo dõi DE_DIEU ZOYIW", "5", "24", "9", "Video GW", "DE_DIEU", "1", new DateTime(2020, 12, 1, 9, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 52, "10", "Video theo dõi LUOI_DIEN MXECQ", "8", "17", "9", "Video TT", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 51, "8", "Video theo dõi LUOI_DIEN JDLNR", "10", "28", "11", "Video TL", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 50, "4", "Video theo dõi CHAY_RUNG FMHPH", "2", "14", "11", "Video OT", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 6, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "7", "Video theo dõi DE_DIEU WHAXJ", "5", "7", "1", "Video YU", "DE_DIEU", "1", new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "3", "Video theo dõi DE_DIEU JBSPH", "3", "8", "1", "Video HK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "7", "Video theo dõi DE_DIEU DWTTH", "3", "11", "2", "Video JF", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 56, "6", "Video theo dõi CAY_TRONG WCLLT", "3", "25", "3", "Video RQ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "10", "Video theo dõi DE_DIEU HRXND", "3", "37", "2", "Video II", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "3", "Video theo dõi LUOI_DIEN TJFVP", "6", "20", "5", "Video XE", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "2", "Video theo dõi CAY_TRONG OSWKG", "1", "23", "6", "Video ON", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "6", "Video theo dõi DE_DIEU RPEHE", "8", "7", "11", "Video QG", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "7", "Video theo dõi LUOI_DIEN MPUIH", "7", "8", "1", "Video VK", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "3", "Video theo dõi CAY_TRONG ZSHVE", "6", "6", "3", "Video FT", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "4", "Video theo dõi LUOI_DIEN BJAIP", "1", "7", "2", "Video GM", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "5", "Video theo dõi DE_DIEU OONBZ", "2", "38", "8", "Video MJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "5", "Video theo dõi CHAY_RUNG MNJPK", "8", "22", "3", "Video KM", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "2", "Video theo dõi CAY_TRONG MSKEC", "1", "31", "10", "Video QW", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "Video theo dõi DE_DIEU MCZFR", "2", "25", "11", "Video DU", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "8", "Warning Edit", "5", "Warning SU", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "5", "Warning Edit", "5", "Warning TL", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 4, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "6", "Warning Edit", "6", "Warning AN", "CAY_TRONG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "8", "Warning Add", "8", "Warning RS", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 10, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "7", "Warning Add", "8", "Warning MK", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "9", "Warning Edit", "9", "Warning RI", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "9", "Warning Add", "9", "Warning XF", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 11, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "Warning Activity Log", "5", "Warning AV", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "7", "Warning Add", "1", "Warning MO", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "Warning Activity Log", "1", "Warning KA", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 12, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "2", "Warning Edit", "2", "Warning ZY", "CAY_TRONG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 10, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "5", "Warning Add", "1", "Warning YL", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "7", "Warning Edit", "7", "Warning AF", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 1, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "Warning Add", "9", "Warning IE", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "4", "Warning Edit", "9", "Warning LI", "LUOI_DIEN", "5fec08a6eeec7500179c9bbb", "0", new DateTime(2020, 12, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "9", "Warning Activity Log", "3", "Warning KB", "DE_DIEU", "5fec0951eeec7500179c9bbd", "1", new DateTime(2020, 12, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "10", "Warning Delete", "4", "Warning CJ", "LUOI_DIEN", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 9, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "9", "Warning Activity Log", "3", "Warning BW", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "9", "Warning Delete", "10", "Warning ZH", "CAY_TRONG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "Warning Delete", "2", "Warning MZ", "DE_DIEU", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 1, 2, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "1", "Warning Edit", "8", "Warning QE", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "2", "Warning Add", "4", "Warning RC", "CHAY_RUNG", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 6, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "8", "Warning Delete", "1", "Warning SL", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 4, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "9", "Warning Add", "9", "Warning CG", "CHAY_RUNG", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "1", "Warning Add", "1", "Warning CD", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "9", "Warning Add", "9", "Warning WQ", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "Warning Add", "9", "Warning KG", "DE_DIEU", "5fec0951eeec7500179c9bbd", "0", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "4", "Warning Edit", "7", "Warning SC", "CAY_TRONG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "1", "Warning Activity Log", "10", "Warning MD", "LUOI_DIEN", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 2, 15, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "6", "Warning Add", "5", "Warning VU", "CHAY_RUNG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "3", "Warning Add", "9", "Warning SL", "CHAY_RUNG", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 13, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "5", "Warning Delete", "2", "Warning CA", "CAY_TRONG", "5fe1a1ade40ec00017660154", "0", new DateTime(2020, 12, 1, 15, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "9", "Warning Add", "8", "Warning XF", "DE_DIEU", "5fe1a1ade40ec00017660154", "1", new DateTime(2020, 12, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "Warning Activity Log", "9", "Warning ZW", "LUOI_DIEN", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "2", "Warning Delete", "8", "Warning BO", "DE_DIEU", "5fec08a6eeec7500179c9bbb", "1", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "5", "Warning Edit", "8", "Warning DX", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "0", new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "9", "Warning Add", "4", "Warning PA", "DE_DIEU", "5fec08eeeeec7500179c9bbc", "1", new DateTime(2020, 12, 2, 12, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "7", "Warning Add", "3", "Warning XV", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "Warning Add", "9", "Warning AF", "DE_DIEU", "5fec86a1f139ff00177a252e", "0", new DateTime(2020, 12, 2, 9, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "2", "Warning Edit", "10", "Warning CY", "CHAY_RUNG", "5fec86a1f139ff00177a252e", "1", new DateTime(2020, 12, 2, 10, 42, 0, 0, DateTimeKind.Unspecified), 4 });
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
