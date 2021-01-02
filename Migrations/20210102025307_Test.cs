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
                values: new object[] { 1, "6", "Drone Edit", "4", 34, 15, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 2, 5, 38, 0, 0, DateTimeKind.Unspecified), 4, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 73, "4", "Drone Delete", "2", 20, 40, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 2, 38, 0, 0, DateTimeKind.Unspecified), 3, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 72, "7", "Drone Delete", "8", 32, 46, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 1, 15, 29, 0, 0, DateTimeKind.Unspecified), 3, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 71, "6", "Drone Edit", "5", 34, 37, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 4, "1" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 70, "1", "Drone Edit", "3", 18, 16, "Drone 3", "CHAY_RUNG", new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 69, "6", "Drone Activity Log", "7", 32, 19, "Drone 7", "CHAY_RUNG", new DateTime(2020, 12, 2, 12, 13, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 68, "2", "Drone Activity Log", "2", 39, 10, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 20, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 67, "3", "Drone Edit", "2", 16, 47, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 4, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 66, "6", "Drone Delete", "7", 33, 15, "Drone 7", "CAY_TRONG", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 3, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 65, "2", "Drone Delete", "1", 29, 43, "Drone 1", "DE_DIEU", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 3, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 64, "1", "Drone Delete", "3", 30, 44, "Drone 3", "CHAY_RUNG", new DateTime(2020, 12, 1, 12, 8, 0, 0, DateTimeKind.Unspecified), 3, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 63, "1", "Drone Edit", "2", 40, 44, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 4, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 62, "10", "Drone Edit", "5", 26, 44, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 3, 18, 0, 0, DateTimeKind.Unspecified), 4, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 61, "7", "Drone Add", "9", 26, 47, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 2, 9, 3, 0, 0, DateTimeKind.Unspecified), 2, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 60, "2", "Drone Add", "8", 29, 23, "Drone 8", "DE_DIEU", new DateTime(2020, 12, 1, 14, 21, 0, 0, DateTimeKind.Unspecified), 2, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 59, "2", "Drone Add", "6", 12, 22, "Drone 6", "LUOI_DIEN", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 2, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 58, "4", "Drone Activity Log", "3", 26, 43, "Drone 3", "CAY_TRONG", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 20, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 57, "5", "Drone Activity Log", "3", 36, 49, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 1, 11, 41, 0, 0, DateTimeKind.Unspecified), 20, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 56, "6", "Drone Delete", "5", 29, 36, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 1, 5, 0, 0, DateTimeKind.Unspecified), 3, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 55, "5", "Drone Activity Log", "6", 46, 30, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 2, 12, 5, 0, 0, DateTimeKind.Unspecified), 20, "1" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 54, "5", "Drone Activity Log", "5", 22, 31, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 2, 16, 2, 0, 0, DateTimeKind.Unspecified), 20, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 53, "9", "Drone Delete", "2", 29, 30, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 3, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 74, "2", "Drone Edit", "7", 42, 15, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 4, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 75, "9", "Drone Activity Log", "9", 29, 24, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 2, 5, 21, 0, 0, DateTimeKind.Unspecified), 20, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 76, "2", "Drone Edit", "7", 20, 25, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 17, 4, 0, 0, DateTimeKind.Unspecified), 4, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 77, "4", "Drone Delete", "7", 27, 28, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 3, "1" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 100, "3", "Drone Delete", "1", 10, 30, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 3, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 99, "8", "Drone Activity Log", "1", 11, 46, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 2, 15, 46, 0, 0, DateTimeKind.Unspecified), 20, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 98, "6", "Drone Edit", "2", 16, 21, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 1, 14, 42, 0, 0, DateTimeKind.Unspecified), 4, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 97, "2", "Drone Delete", "10", 29, 43, "Drone 10", "DE_DIEU", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 3, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 96, "8", "Drone Activity Log", "7", 23, 15, "Drone 7", "CHAY_RUNG", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 20, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 95, "10", "Drone Delete", "4", 42, 14, "Drone 4", "DE_DIEU", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 3, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 94, "8", "Drone Edit", "8", 36, 28, "Drone 8", "CAY_TRONG", new DateTime(2020, 12, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 93, "3", "Drone Activity Log", "6", 21, 38, "Drone 6", "DE_DIEU", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 20, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 92, "3", "Drone Add", "9", 43, 44, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 1, 3, 30, 0, 0, DateTimeKind.Unspecified), 2, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 91, "9", "Drone Edit", "3", 27, 44, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 1, 10, 9, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 52, "10", "Drone Add", "7", 26, 12, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 2, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 90, "6", "Drone Activity Log", "10", 35, 41, "Drone 10", "DE_DIEU", new DateTime(2020, 12, 1, 11, 34, 0, 0, DateTimeKind.Unspecified), 20, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 88, "10", "Drone Delete", "2", 45, 49, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 8, 37, 0, 0, DateTimeKind.Unspecified), 3, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 87, "5", "Drone Add", "1", 11, 30, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 2, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 86, "3", "Drone Add", "3", 21, 48, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified), 2, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 85, "7", "Drone Activity Log", "9", 23, 19, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 1, 11, 41, 0, 0, DateTimeKind.Unspecified), 20, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 84, "2", "Drone Edit", "2", 42, 23, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 4, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 83, "7", "Drone Delete", "2", 17, 17, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 3, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 82, "6", "Drone Add", "7", 20, 39, "Drone 7", "LUOI_DIEN", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 2, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 81, "1", "Drone Activity Log", "3", 13, 31, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified), 20, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 79, "8", "Drone Add", "2", 43, 18, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 2, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 78, "2", "Drone Edit", "1", 28, 29, "Drone 1", "CHAY_RUNG", new DateTime(2020, 12, 1, 12, 49, 0, 0, DateTimeKind.Unspecified), 4, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 89, "5", "Drone Activity Log", "6", 38, 49, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 20, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 51, "8", "Drone Delete", "10", 46, 40, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 2, 4, 14, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 80, "4", "Drone Activity Log", "2", 41, 18, "Drone 2", "CHAY_RUNG", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 20, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 49, "2", "Drone Edit", "8", 10, 10, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 11, 45, 0, 0, DateTimeKind.Unspecified), 4, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 22, "9", "Drone Delete", "4", 26, 49, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 1, 1, 12, 0, 0, DateTimeKind.Unspecified), 3, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 21, "2", "Drone Delete", "5", 19, 22, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 3, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 20, "1", "Drone Add", "7", 26, 37, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 2, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 19, "10", "Drone Add", "2", 17, 48, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 2, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 18, "4", "Drone Add", "8", 36, 22, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 15, 23, 0, 0, DateTimeKind.Unspecified), 2, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 17, "8", "Drone Delete", "3", 38, 47, "Drone 3", "CAY_TRONG", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 15, "1", "Drone Add", "2", 12, 29, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 16, 48, 0, 0, DateTimeKind.Unspecified), 2, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 14, "7", "Drone Add", "4", 25, 11, "Drone 4", "LUOI_DIEN", new DateTime(2020, 12, 2, 1, 11, 0, 0, DateTimeKind.Unspecified), 2, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 13, "6", "Drone Edit", "8", 42, 45, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 4, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 12, "1", "Drone Edit", "9", 38, 30, "Drone 9", "CHAY_RUNG", new DateTime(2020, 12, 1, 9, 25, 0, 0, DateTimeKind.Unspecified), 4, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 11, "3", "Drone Activity Log", "2", 46, 35, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 20, "7" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 10, "3", "Drone Edit", "10", 20, 21, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 4, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 9, "4", "Drone Edit", "1", 21, 28, "Drone 1", "CAY_TRONG", new DateTime(2020, 12, 2, 8, 14, 0, 0, DateTimeKind.Unspecified), 4, "12" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 8, "10", "Drone Delete", "10", 37, 43, "Drone 10", "DE_DIEU", new DateTime(2020, 12, 1, 2, 33, 0, 0, DateTimeKind.Unspecified), 3, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 7, "6", "Drone Edit", "9", 22, 41, "Drone 9", "CAY_TRONG", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 4, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 6, "6", "Drone Add", "6", 49, 20, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 2, 5, 19, 0, 0, DateTimeKind.Unspecified), 2, "9" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 5, "9", "Drone Delete", "5", 20, 45, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 3, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 4, "4", "Drone Edit", "5", 46, 27, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 1, 10, 32, 0, 0, DateTimeKind.Unspecified), 4, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 3, "2", "Drone Delete", "3", 16, 13, "Drone 3", "LUOI_DIEN", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 3, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 2, "10", "Drone Edit", "8", 13, 24, "Drone 8", "DE_DIEU", new DateTime(2020, 12, 1, 9, 16, 0, 0, DateTimeKind.Unspecified), 4, "1" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 50, "2", "Drone Add", "6", 47, 36, "Drone 6", "CHAY_RUNG", new DateTime(2020, 12, 2, 9, 19, 0, 0, DateTimeKind.Unspecified), 2, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 23, "9", "Drone Edit", "5", 11, 10, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), 4, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 24, "7", "Drone Edit", "2", 45, 25, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 1, 31, 0, 0, DateTimeKind.Unspecified), 4, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 16, "8", "Drone Edit", "7", 42, 37, "Drone 7", "DE_DIEU", new DateTime(2020, 12, 2, 14, 24, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 26, "10", "Drone Add", "4", 13, 35, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 2, "1" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 48, "2", "Drone Add", "3", 15, 12, "Drone 3", "CHAY_RUNG", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 2, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 47, "6", "Drone Delete", "3", 16, 27, "Drone 3", "CAY_TRONG", new DateTime(2020, 12, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), 3, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 46, "3", "Drone Edit", "5", 23, 35, "Drone 5", "LUOI_DIEN", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 4, "2" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 25, "3", "Drone Edit", "4", 13, 29, "Drone 4", "CAY_TRONG", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 4, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 44, "8", "Drone Add", "4", 49, 23, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 1, 11, 12, 0, 0, DateTimeKind.Unspecified), 2, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 43, "9", "Drone Activity Log", "6", 40, 30, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 20, "10" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 42, "2", "Drone Activity Log", "10", 15, 25, "Drone 10", "CAY_TRONG", new DateTime(2020, 12, 2, 5, 8, 0, 0, DateTimeKind.Unspecified), 20, "8" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 41, "6", "Drone Delete", "8", 37, 41, "Drone 8", "LUOI_DIEN", new DateTime(2020, 12, 2, 8, 21, 0, 0, DateTimeKind.Unspecified), 3, "13" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 40, "9", "Drone Delete", "3", 20, 21, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 3, "4" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 39, "4", "Drone Activity Log", "10", 28, 12, "Drone 10", "DE_DIEU", new DateTime(2020, 12, 1, 12, 8, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 38, "8", "Drone Activity Log", "5", 26, 49, "Drone 5", "CHAY_RUNG", new DateTime(2020, 12, 1, 14, 3, 0, 0, DateTimeKind.Unspecified), 20, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 37, "8", "Drone Activity Log", "10", 46, 41, "Drone 10", "LUOI_DIEN", new DateTime(2020, 12, 1, 2, 31, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 45, "4", "Drone Edit", "2", 29, 21, "Drone 2", "DE_DIEU", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 4, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 35, "2", "Drone Delete", "6", 25, 45, "Drone 6", "CAY_TRONG", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 3, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 27, "4", "Drone Add", "2", 15, 31, "Drone 2", "LUOI_DIEN", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 2, "1" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 36, "6", "Drone Edit", "4", 28, 49, "Drone 4", "CHAY_RUNG", new DateTime(2020, 12, 1, 10, 43, 0, 0, DateTimeKind.Unspecified), 4, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 29, "6", "Drone Activity Log", "3", 37, 34, "Drone 3", "DE_DIEU", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 20, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 30, "4", "Drone Add", "5", 16, 17, "Drone 5", "CAY_TRONG", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 2, "3" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 28, "9", "Drone Add", "3", 26, 30, "Drone 3", "CHAY_RUNG", new DateTime(2020, 12, 2, 7, 44, 0, 0, DateTimeKind.Unspecified), 2, "11" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 32, "9", "Drone Delete", "5", 39, 47, "Drone 5", "DE_DIEU", new DateTime(2020, 12, 2, 7, 33, 0, 0, DateTimeKind.Unspecified), 3, "14" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 33, "10", "Drone Add", "2", 41, 26, "Drone 2", "CAY_TRONG", new DateTime(2020, 12, 1, 4, 7, 0, 0, DateTimeKind.Unspecified), 2, "5" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 34, "6", "Drone Edit", "1", 29, 28, "Drone 1", "LUOI_DIEN", new DateTime(2020, 12, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), 4, "6" });

            migrationBuilder.InsertData(
                table: "DroneLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Latitude", "Longitude", "Name", "ProjectType", "Timestamp", "Type", "UavConnectId" },
                values: new object[] { 31, "7", "Drone Add", "8", 10, 39, "Drone 8", "CHAY_RUNG", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 2, "1" });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "10", "Hình ảnh theo dõi CAY_TRONG BJRSH", "2", "29", "11", "Image EJ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "8", "Hình ảnh theo dõi LUOI_DIEN EAHRR", "8", "40", "12", "Image WO", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "5", "Hình ảnh theo dõi DE_DIEU GIMJK", "3", "29", "2", "Image YC", "DE_DIEU", "0", new DateTime(2020, 12, 1, 14, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "7", "Hình ảnh theo dõi CAY_TRONG PMAGU", "5", "31", "6", "Image QQ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "8", "Hình ảnh theo dõi CAY_TRONG SRBCA", "4", "4", "7", "Image YP", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "Hình ảnh theo dõi CHAY_RUNG MZCRN", "10", "6", "12", "Image XF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "7", "Hình ảnh theo dõi CHAY_RUNG NHYWE", "7", "24", "14", "Image RD", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "1", "Hình ảnh theo dõi CAY_TRONG GMDNX", "3", "19", "4", "Image ZJ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "Hình ảnh theo dõi LUOI_DIEN TYZPD", "5", "8", "3", "Image GK", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 9, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "9", "Hình ảnh theo dõi DE_DIEU LRYOX", "1", "18", "3", "Image PG", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "1", "Hình ảnh theo dõi LUOI_DIEN HPZIN", "8", "25", "10", "Image CV", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 8, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "10", "Hình ảnh theo dõi CAY_TRONG HMXAR", "7", "38", "3", "Image XY", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "10", "Hình ảnh theo dõi CAY_TRONG BVUAC", "9", "6", "1", "Image YS", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "6", "Hình ảnh theo dõi DE_DIEU OOKBW", "5", "31", "5", "Image FY", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "4", "Hình ảnh theo dõi LUOI_DIEN CGHQJ", "4", "15", "13", "Image KP", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "7", "Hình ảnh theo dõi CHAY_RUNG YGAFM", "8", "5", "10", "Image WV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 13, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "2", "Hình ảnh theo dõi CAY_TRONG IAGRI", "10", "17", "10", "Image VR", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "8", "Hình ảnh theo dõi LUOI_DIEN PQXJW", "7", "15", "4", "Image JI", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "1", "Hình ảnh theo dõi CAY_TRONG TWXLW", "8", "26", "14", "Image LL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "4", "Hình ảnh theo dõi CAY_TRONG HPIDB", "6", "6", "11", "Image EP", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "9", "Hình ảnh theo dõi CHAY_RUNG ZLRFQ", "6", "37", "4", "Image AJ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "Hình ảnh theo dõi CHAY_RUNG DFYPX", "7", "37", "9", "Image SA", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "9", "Hình ảnh theo dõi LUOI_DIEN CBMOK", "7", "27", "7", "Image ZV", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "4", "Hình ảnh theo dõi LUOI_DIEN OXJCZ", "10", "17", "3", "Image KE", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "9", "Hình ảnh theo dõi LUOI_DIEN OJDWW", "6", "21", "12", "Image EW", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "7", "Hình ảnh theo dõi DE_DIEU KQUNV", "10", "24", "9", "Image QJ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "4", "Hình ảnh theo dõi CHAY_RUNG WZRRE", "6", "36", "8", "Image DM", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "Hình ảnh theo dõi CHAY_RUNG QEVXK", "1", "5", "6", "Image SH", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "5", "Hình ảnh theo dõi CAY_TRONG NZFAT", "10", "24", "8", "Image NZ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "1", "Hình ảnh theo dõi CHAY_RUNG WQWNE", "3", "13", "7", "Image SH", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "3", "Hình ảnh theo dõi LUOI_DIEN ZJADD", "9", "24", "2", "Image EI", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 4, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "6", "Hình ảnh theo dõi LUOI_DIEN PLAZI", "5", "16", "11", "Image OC", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "10", "Hình ảnh theo dõi LUOI_DIEN BBPEY", "5", "14", "3", "Image HA", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "3", "Hình ảnh theo dõi CHAY_RUNG MFJAD", "4", "26", "14", "Image WB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "10", "Hình ảnh theo dõi CHAY_RUNG XOPJE", "1", "11", "1", "Image XY", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "6", "Hình ảnh theo dõi CHAY_RUNG FIKHM", "8", "29", "8", "Image ZD", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "5", "Hình ảnh theo dõi DE_DIEU OPLCC", "5", "3", "1", "Image DH", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "10", "Hình ảnh theo dõi LUOI_DIEN BBWTU", "7", "38", "1", "Image TT", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "7", "Hình ảnh theo dõi LUOI_DIEN HBNJZ", "8", "20", "10", "Image DT", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 16, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "6", "Hình ảnh theo dõi LUOI_DIEN KCCTZ", "3", "16", "3", "Image TC", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "8", "Incident Activity Log", "8", "Incident GF", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 14, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "8", "Incident Activity Log", "12", "Incident CN", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 2, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "7", "Incident Add", "11", "Incident XA", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "2", "Incident Add", "4", "Incident OS", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "10", "Incident Delete", "12", "Incident DX", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "8", "Incident Edit", "1", "Incident KO", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 14, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "4", "Incident Edit", "5", "Incident RR", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "5", "Incident Delete", "1", "Incident TX", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 9, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "10", "Incident Delete", "1", "Incident AX", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 3, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "4", "Incident Delete", "6", "Incident JX", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 13, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "10", "Incident Edit", "1", "Incident MI", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 4, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "1", "Incident Delete", "1", "Incident SM", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "7", "Incident Add", "7", "Incident SE", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "Incident Edit", "6", "Incident SA", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 2, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Incident Edit", "4", "Incident HX", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 12, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "4", "Incident Edit", "8", "Incident UE", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 3, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "3", "Incident Activity Log", "4", "Incident EG", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "2", "Incident Delete", "12", "Incident DO", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 14, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "1", "Incident Edit", "6", "Incident EJ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "10", "Incident Add", "9", "Incident JY", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "Incident Activity Log", "3", "Incident CX", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "1", "Incident Edit", "10", "Incident QP", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "7", "Incident Activity Log", "14", "Incident YW", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 2, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "Incident Edit", "11", "Incident AI", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 1, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "1", "Incident Delete", "8", "Incident YI", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 14, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "Incident Activity Log", "1", "Incident BJ", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 1, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "3", "Incident Delete", "7", "Incident NV", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "10", "Incident Delete", "11", "Incident PY", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 14, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "10", "Incident Delete", "3", "Incident IA", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "10", "Incident Activity Log", "1", "Incident BV", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 6, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "5", "Incident Add", "10", "Incident XV", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "9", "Incident Add", "5", "Incident JD", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "10", "Incident Delete", "12", "Incident IV", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "9", "Incident Activity Log", "11", "Incident ZO", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "4", "Incident Add", "2", "Incident SL", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "6", "Incident Activity Log", "7", "Incident LA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 7, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "1", "Incident Activity Log", "6", "Incident AZ", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "1", "Incident Add", "4", "Incident PD", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 6, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "10", "Incident Add", "2", "Incident EL", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 5, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "Incident Delete", "6", "Incident CB", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 1, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "8", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "MonitorRegion Edit", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "9", "MonitorRegion Delete", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 1, 15, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "6", "MonitorRegion Edit", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "3", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "6", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "9", "MonitorRegion Add", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "10", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "8", "MonitorRegion Delete", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "9", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "8", "MonitorRegion Add", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "3", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "7", "MonitorRegion Delete", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "8", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "MonitorRegion Edit", "2", "MonitorRegion 2", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 10, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "2", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "8", "MonitorRegion Delete", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "10", "MonitorRegion Edit", "1", "MonitorRegion 1", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "6", "MonitorRegion Activity Log", "4", "MonitorRegion 4", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 1, "3", "MonitorRegion Delete", "4", "MonitorRegion 4", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "9", "MonitorRegion Edit", "4", "MonitorRegion 4", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 2, "8", "MonitorRegion Edit", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 5, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 3, "3", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 4, "9", "MonitorRegion Add", "4", "MonitorRegion 4", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 5, "7", "MonitorRegion Delete", "3", "MonitorRegion 3", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 7, "3", "MonitorRegion Activity Log", "2", "MonitorRegion 2", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 13, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 8, "2", "MonitorRegion Edit", "2", "MonitorRegion 2", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 9, "7", "MonitorRegion Edit", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "MonitorRegion Activity Log", "3", "MonitorRegion 3", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 6, "1", "MonitorRegion Edit", "1", "MonitorRegion 1", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "6", "MonitorRegion Activity Log", "1", "MonitorRegion 1", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "1", "MonitorRegion Add", "3", "MonitorRegion 3", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 10, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "5", "MonitorRegion Add", "3", "MonitorRegion 3", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "1", "MonitorRegion Delete", "3", "MonitorRegion 3", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "5", "MonitorRegion Delete", "2", "MonitorRegion 2", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "1", "MonitorRegion Delete", "2", "MonitorRegion 2", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "MonitorRegion Delete", "4", "MonitorRegion 4", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 1, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "8", "MonitorRegion Edit", "4", "MonitorRegion 4", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 6, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "8", "MonitorRegion Delete", "3", "MonitorRegion 3", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "9", "ObjectObserve Add", "15", "ObjectObserve BX", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "1", "ObjectObserve Add", "10", "ObjectObserve DM", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 3, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "8", "ObjectObserve Activity Log", "12", "ObjectObserve YK", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 4, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "3", "ObjectObserve Activity Log", "9", "ObjectObserve PJ", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "4", "ObjectObserve Delete", "4", "ObjectObserve CE", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 15, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "5", "ObjectObserve Add", "6", "ObjectObserve DL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "4", "ObjectObserve Activity Log", "10", "ObjectObserve TL", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "9", "ObjectObserve Delete", "14", "ObjectObserve FZ", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 3, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "3", "ObjectObserve Activity Log", "17", "ObjectObserve CY", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 6, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "6", "ObjectObserve Activity Log", "2", "ObjectObserve LW", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "7", "ObjectObserve Add", "6", "ObjectObserve DN", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 12, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "10", "ObjectObserve Delete", "1", "ObjectObserve NZ", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "ObjectObserve Activity Log", "18", "ObjectObserve AK", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "1", "ObjectObserve Add", "17", "ObjectObserve XN", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "ObjectObserve Edit", "13", "ObjectObserve YC", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "10", "ObjectObserve Add", "13", "ObjectObserve LD", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "4", "ObjectObserve Add", "4", "ObjectObserve FE", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 10, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "1", "ObjectObserve Delete", "16", "ObjectObserve LG", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 12, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "ObjectObserve Activity Log", "16", "ObjectObserve PA", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "5", "ObjectObserve Add", "11", "ObjectObserve YW", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "5", "ObjectObserve Edit", "20", "ObjectObserve GR", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 16, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "6", "ObjectObserve Delete", "4", "ObjectObserve EI", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "5", "ObjectObserve Delete", "11", "ObjectObserve MX", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "4", "ObjectObserve Add", "8", "ObjectObserve GK", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 1, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "5", "ObjectObserve Edit", "14", "ObjectObserve QY", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 15, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "2", "ObjectObserve Edit", "5", "ObjectObserve YG", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "2", "ObjectObserve Edit", "5", "ObjectObserve OF", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 4, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "5", "ObjectObserve Delete", "19", "ObjectObserve IN", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "3", "ObjectObserve Add", "3", "ObjectObserve EJ", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "10", "ObjectObserve Activity Log", "8", "ObjectObserve OF", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "9", "ObjectObserve Edit", "7", "ObjectObserve QK", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 5, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "6", "ObjectObserve Add", "5", "ObjectObserve BD", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 13, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "ObjectObserve Edit", "9", "ObjectObserve UA", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "6", "ObjectObserve Activity Log", "7", "ObjectObserve IN", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "5", "ObjectObserve Edit", "11", "ObjectObserve DG", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "2", "ObjectObserve Add", "17", "ObjectObserve ZI", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "9", "ObjectObserve Activity Log", "5", "ObjectObserve CA", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 13, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "3", "ObjectObserve Edit", "17", "ObjectObserve FL", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 10, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "9", "ObjectObserve Delete", "16", "ObjectObserve CG", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 9, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "2", "ObjectObserve Activity Log", "18", "ObjectObserve YC", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "4", "Payload Add", "6", "10", "XA-WBD-N", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 6, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "10", "Payload Delete", "4", "10", "FN-TKV-L", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "10", "Payload Add", "4", "7", "TV-EOU-X", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "7", "Payload Activity Log", "10", "3", "DJ-MUL-P", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 16, 15, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "7", "Payload Activity Log", "1", "3", "PZ-GGW-U", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "10", "Payload Add", "4", "4", "FT-UAV-L", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "Payload Edit", "7", "2", "GX-BYW-S", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 16, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "2", "Payload Edit", "5", "8", "DP-IHM-X", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "Payload Edit", "7", "7", "OM-EZR-Z", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "4", "Payload Delete", "2", "1", "NP-GNF-G", "DE_DIEU", "1", new DateTime(2020, 12, 1, 2, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "8", "Payload Activity Log", "4", "1", "ML-VOW-F", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 4, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "7", "Payload Delete", "5", "7", "JX-YJW-C", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 7, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "7", "Payload Delete", "5", "7", "TX-YSX-Z", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "6", "Payload Edit", "10", "8", "KW-YFT-F", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "2", "Payload Add", "8", "6", "FU-JAS-G", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "7", "Payload Delete", "2", "9", "OA-NHH-E", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "6", "Payload Add", "6", "6", "PG-PUW-G", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "7", "Payload Edit", "2", "3", "HH-MRN-S", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "3", "Payload Edit", "3", "3", "CK-OYL-F", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "8", "Payload Activity Log", "6", "4", "MZ-UXB-J", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "4", "Payload Activity Log", "3", "4", "UT-QLT-I", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "8", "Payload Delete", "2", "6", "NN-FLN-O", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "6", "Payload Edit", "10", "9", "AJ-YIT-A", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "1", "Payload Delete", "9", "5", "AD-XOD-E", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "9", "Payload Add", "7", "5", "FV-XMM-P", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "6", "Payload Add", "7", "5", "ZE-TSQ-X", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 13, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "9", "Payload Edit", "9", "9", "RK-EUN-O", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 12, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "1", "Payload Delete", "10", "7", "LB-JLZ-L", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "Payload Delete", "5", "8", "SM-ARF-X", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "Payload Add", "4", "10", "ND-ZMC-J", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Payload Add", "7", "9", "II-ALZ-S", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "4", "Payload Delete", "4", "7", "TS-UQQ-V", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "9", "Payload Activity Log", "2", "8", "TO-BME-V", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Payload Delete", "7", "10", "RT-BKZ-K", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "4", "Payload Add", "4", "7", "HF-HKE-H", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "10", "Payload Add", "8", "2", "WT-HWS-B", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "5", "Payload Activity Log", "5", "6", "TG-BPC-I", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "4", "Payload Activity Log", "4", "6", "OX-ZYN-U", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "4", "Payload Edit", "6", "6", "LO-TDI-F", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "10", "Payload Add", "3", "6", "FE-PDC-S", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "8", "ResolveProblem Delete", "1", "ResolveProblem HW", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "2", "ResolveProblem Activity Log", "1", "ResolveProblem IB", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "9", "ResolveProblem Edit", "5", "ResolveProblem OJ", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 9, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "3", "ResolveProblem Add", "14", "ResolveProblem QP", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "ResolveProblem Activity Log", "11", "ResolveProblem WO", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "8", "ResolveProblem Activity Log", "12", "ResolveProblem FB", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "2", "ResolveProblem Edit", "1", "ResolveProblem GQ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 8, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "ResolveProblem Add", "6", "ResolveProblem CX", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 13, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "2", "ResolveProblem Delete", "6", "ResolveProblem BH", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 2, 2, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "1", "ResolveProblem Delete", "5", "ResolveProblem FA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 1, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "2", "ResolveProblem Activity Log", "14", "ResolveProblem DI", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 15, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "10", "ResolveProblem Add", "12", "ResolveProblem RN", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "10", "ResolveProblem Add", "6", "ResolveProblem MU", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 6, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "2", "ResolveProblem Activity Log", "4", "ResolveProblem CS", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "1", "ResolveProblem Activity Log", "9", "ResolveProblem WP", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "8", "ResolveProblem Delete", "10", "ResolveProblem VA", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "3", "ResolveProblem Edit", "5", "ResolveProblem FB", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "10", "ResolveProblem Activity Log", "6", "ResolveProblem QE", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 8, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "8", "ResolveProblem Add", "7", "ResolveProblem XH", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "9", "ResolveProblem Activity Log", "4", "ResolveProblem RK", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "3", "ResolveProblem Add", "8", "ResolveProblem AK", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "2", "ResolveProblem Add", "10", "ResolveProblem TY", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 8, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "8", "ResolveProblem Edit", "4", "ResolveProblem NP", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 9, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "8", "ResolveProblem Edit", "3", "ResolveProblem AE", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 10, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "ResolveProblem Delete", "11", "ResolveProblem UK", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "10", "ResolveProblem Activity Log", "3", "ResolveProblem NV", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "10", "ResolveProblem Delete", "8", "ResolveProblem RK", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 2, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "1", "ResolveProblem Add", "11", "ResolveProblem XT", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "2", "ResolveProblem Activity Log", "5", "ResolveProblem YT", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 5, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "4", "ResolveProblem Activity Log", "10", "ResolveProblem GW", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "ResolveProblem Add", "12", "ResolveProblem IP", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "5", "ResolveProblem Delete", "14", "ResolveProblem ZR", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 4, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "10", "ResolveProblem Activity Log", "13", "ResolveProblem LP", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 5, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "ResolveProblem Activity Log", "11", "ResolveProblem ZS", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 15, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "9", "ResolveProblem Activity Log", "14", "ResolveProblem BS", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 4, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "6", "ResolveProblem Activity Log", "14", "ResolveProblem GY", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 12, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "4", "ResolveProblem Edit", "3", "ResolveProblem WL", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "7", "ResolveProblem Delete", "9", "ResolveProblem JY", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 14, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "10", "ResolveProblem Add", "11", "ResolveProblem XU", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "ResolveProblem Activity Log", "4", "ResolveProblem BV", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 11, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "10", "Statical Activity Log", "54", "Statical HU", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 14, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "8", "Statical Delete", "52", "Statical RF", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "10", "Statical Add", "44", "Statical IC", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "7", "Statical Activity Log", "48", "Statical MT", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 7, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "7", "Statical Add", "46", "Statical OA", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "6", "Statical Delete", "56", "Statical LK", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 2, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "6", "Statical Edit", "50", "Statical ZE", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "2", "Statical Edit", "58", "Statical ID", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 7, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "2", "Statical Activity Log", "70", "Statical QX", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 11, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "4", "Statical Edit", "62", "Statical JY", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "6", "Statical Add", "64", "Statical XT", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "9", "Statical Delete", "66", "Statical XF", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 14, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Statical Delete", "72", "Statical JL", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 11, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "9", "Statical Delete", "74", "Statical OC", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "9", "Statical Add", "76", "Statical JK", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 5, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "8", "Statical Activity Log", "78", "Statical FB", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "5", "Statical Edit", "42", "Statical NL", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 12, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "8", "Statical Activity Log", "60", "Statical YK", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "1", "Statical Add", "40", "Statical RR", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 7, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "8", "Statical Edit", "68", "Statical LF", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "3", "Statical Activity Log", "36", "Statical KO", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "2", "Statical Activity Log", "38", "Statical UH", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "10", "Statical Activity Log", "0", "Statical AC", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "6", "Statical Edit", "2", "Statical AV", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 11, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "9", "Statical Delete", "4", "Statical EZ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "7", "Statical Delete", "6", "Statical FY", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "6", "Statical Edit", "8", "Statical QP", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "5", "Statical Delete", "10", "Statical FT", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "1", "Statical Add", "12", "Statical JH", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "9", "Statical Activity Log", "16", "Statical TQ", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 7, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "6", "Statical Delete", "14", "Statical LD", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "9", "Statical Activity Log", "20", "Statical US", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 16, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "Statical Delete", "22", "Statical NN", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 9, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Statical Activity Log", "24", "Statical FZ", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "1", "Statical Edit", "26", "Statical QT", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "1", "Statical Edit", "28", "Statical HS", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "5", "Statical Add", "30", "Statical NV", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 9, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "8", "Statical Edit", "32", "Statical TA", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "3", "Statical Delete", "34", "Statical KB", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 4, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "5", "Statical Activity Log", "18", "Statical NK", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 77, "6", "Giám sát Edit", "8", "Đợi giám sát 8", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 76, "5", "Giám sát Edit", "14", "Đợi giám sát 14", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 78, "8", "Giám sát Activity Log", "3", "Đợi giám sát 3", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 83, "8", "Giám sát Edit", "13", "Đợi giám sát 13", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 12, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 80, "9", "Giám sát Delete", "10", "Đợi giám sát 10", "DE_DIEU", "3", "0", new DateTime(2020, 12, 2, 9, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 81, "8", "Giám sát Add", "10", "Đợi giám sát 10", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 15, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 82, "9", "Giám sát Edit", "3", "Đợi giám sát 3", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 75, "3", "Giám sát Add", "4", "Đợi giám sát 4", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 79, "5", "Giám sát Edit", "1", "Đợi giám sát 1", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 74, "8", "Giám sát Activity Log", "2", "Đợi giám sát 2", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 64, "4", "Giám sát Activity Log", "5", "Đợi giám sát 5", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 3, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 72, "3", "Giám sát Add", "4", "Đợi giám sát 4", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 4, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 71, "3", "Giám sát Delete", "4", "Đợi giám sát 4", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 15, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 70, "7", "Giám sát Activity Log", "3", "Đợi giám sát 3", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 10, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 69, "4", "Giám sát Add", "4", "Đợi giám sát 4", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 68, "4", "Giám sát Delete", "3", "Đợi giám sát 3", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 67, "2", "Giám sát Edit", "1", "Đợi giám sát 1", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 5, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 66, "3", "Giám sát Activity Log", "11", "Đợi giám sát 11", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 65, "3", "Giám sát Add", "8", "Đợi giám sát 8", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 84, "2", "Giám sát Activity Log", "2", "Đợi giám sát 2", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 63, "4", "Giám sát Add", "13", "Đợi giám sát 13", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 62, "6", "Giám sát Add", "13", "Đợi giám sát 13", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 3, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 73, "8", "Giám sát Add", "5", "Đợi giám sát 5", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 85, "6", "Giám sát Delete", "10", "Đợi giám sát 10", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 10, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 95, "2", "Giám sát Edit", "2", "Đợi giám sát 2", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 87, "1", "Giám sát Activity Log", "11", "Đợi giám sát 11", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 14, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 61, "7", "Giám sát Activity Log", "14", "Đợi giám sát 14", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 109, "5", "Giám sát Activity Log", "11", "Đợi giám sát 11", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 108, "4", "Giám sát Activity Log", "12", "Đợi giám sát 12", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 107, "2", "Giám sát Add", "1", "Đợi giám sát 1", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 106, "1", "Giám sát Edit", "8", "Đợi giám sát 8", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 11, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 105, "2", "Giám sát Delete", "12", "Đợi giám sát 12", "DE_DIEU", "2", "1", new DateTime(2020, 12, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 104, "10", "Giám sát Activity Log", "9", "Đợi giám sát 9", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 103, "10", "Giám sát Activity Log", "4", "Đợi giám sát 4", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 102, "5", "Giám sát Activity Log", "2", "Đợi giám sát 2", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 7, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 101, "9", "Giám sát Edit", "5", "Đợi giám sát 5", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 86, "1", "Giám sát Delete", "1", "Đợi giám sát 1", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 100, "2", "Giám sát Edit", "12", "Đợi giám sát 12", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 3, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 98, "9", "Giám sát Add", "6", "Đợi giám sát 6", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 97, "8", "Giám sát Add", "12", "Đợi giám sát 12", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 96, "7", "Giám sát Activity Log", "6", "Đợi giám sát 6", "DE_DIEU", "2", "0", new DateTime(2020, 12, 2, 12, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 94, "6", "Giám sát Add", "11", "Đợi giám sát 11", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 12, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 93, "1", "Giám sát Add", "2", "Đợi giám sát 2", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 9, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 92, "3", "Giám sát Edit", "12", "Đợi giám sát 12", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 7, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 91, "9", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 3, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 90, "9", "Giám sát Delete", "13", "Đợi giám sát 13", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 89, "4", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 16, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 88, "6", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 99, "3", "Giám sát Edit", "6", "Đợi giám sát 6", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 60, "7", "Giám sát Edit", "9", "Đợi giám sát 9", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 6, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "9", "Giám sát Activity Log", "8", "Đợi giám sát 8", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 3, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 58, "3", "Giám sát Edit", "13", "Đợi giám sát 13", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 12, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "8", "Giám sát Activity Log", "13", "Đợi giám sát 13", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "5", "Giám sát Add", "14", "Đợi giám sát 14", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 15, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "10", "Giám sát Edit", "12", "Đợi giám sát 12", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 2, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "9", "Giám sát Delete", "2", "Đợi giám sát 2", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 11, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "7", "Giám sát Edit", "11", "Đợi giám sát 11", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 6, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "2", "Giám sát Add", "13", "Đợi giám sát 13", "DE_DIEU", "4", "0", new DateTime(2020, 12, 1, 10, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "10", "Giám sát Edit", "8", "Đợi giám sát 8", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 6, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 59, "2", "Giám sát Add", "9", "Đợi giám sát 9", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 2, 17, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "6", "Giám sát Activity Log", "10", "Đợi giám sát 10", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 3, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "6", "Giám sát Edit", "6", "Đợi giám sát 6", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 8, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "2", "Giám sát Edit", "1", "Đợi giám sát 1", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 10, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "5", "Giám sát Add", "12", "Đợi giám sát 12", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "9", "Giám sát Delete", "11", "Đợi giám sát 11", "LUOI_DIEN", "4", "1", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "10", "Giám sát Activity Log", "11", "Đợi giám sát 11", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 6, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "9", "Giám sát Add", "2", "Đợi giám sát 2", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 9, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "6", "Giám sát Edit", "13", "Đợi giám sát 13", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "10", "Giám sát Activity Log", "7", "Đợi giám sát 7", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 5, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "10", "Giám sát Edit", "14", "Đợi giám sát 14", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 2, 16, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "10", "Giám sát Activity Log", "5", "Đợi giám sát 5", "DE_DIEU", "4", "1", new DateTime(2020, 12, 2, 7, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "8", "Giám sát Activity Log", "1", "Đợi giám sát 1", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "6", "Giám sát Edit", "12", "Đợi giám sát 12", "DE_DIEU", "2", "1", new DateTime(2020, 12, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "9", "Giám sát Delete", "13", "Đợi giám sát 13", "DE_DIEU", "3", "0", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "4", "Giám sát Add", "10", "Đợi giám sát 10", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 1, 8, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "10", "Giám sát Add", "7", "Đợi giám sát 7", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 2, 15, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "1", "Giám sát Delete", "9", "Đợi giám sát 9", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 57, "7", "Giám sát Add", "1", "Đợi giám sát 1", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "4", "Giám sát Edit", "6", "Đợi giám sát 6", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 8, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 55, "1", "Giám sát Edit", "3", "Đợi giám sát 3", "DE_DIEU", "1", "1", new DateTime(2020, 12, 1, 9, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 54, "2", "Giám sát Add", "8", "Đợi giám sát 8", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 53, "4", "Giám sát Activity Log", "8", "Đợi giám sát 8", "CAY_TRONG", "3", "1", new DateTime(2020, 12, 2, 13, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 52, "9", "Giám sát Delete", "5", "Đợi giám sát 5", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 1, 15, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 51, "1", "Giám sát Activity Log", "9", "Đợi giám sát 9", "LUOI_DIEN", "2", "1", new DateTime(2020, 12, 1, 12, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 50, "8", "Giám sát Edit", "8", "Đợi giám sát 8", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 1, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "7", "Giám sát Activity Log", "12", "Đợi giám sát 12", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 1, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "7", "Giám sát Add", "5", "Đợi giám sát 5", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 12, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "6", "Giám sát Add", "11", "Đợi giám sát 11", "DE_DIEU", "1", "1", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 56, "5", "Giám sát Add", "6", "Đợi giám sát 6", "CHAY_RUNG", "1", "0", new DateTime(2020, 12, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "2", "Giám sát Edit", "12", "Đợi giám sát 12", "DE_DIEU", "3", "1", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "5", "Giám sát Delete", "2", "Đợi giám sát 2", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "7", "Giám sát Add", "7", "Đợi giám sát 7", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "7", "Giám sát Add", "11", "Đợi giám sát 11", "LUOI_DIEN", "1", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "9", "Giám sát Edit", "12", "Đợi giám sát 12", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 1, 15, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "1", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 13, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "9", "Giám sát Delete", "13", "Đợi giám sát 13", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "7", "Giám sát Add", "10", "Đợi giám sát 10", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 7, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "9", "Giám sát Activity Log", "13", "Đợi giám sát 13", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "8", "Giám sát Add", "6", "Đợi giám sát 6", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 32, "9", "User Delete", "3", null, "Meta data example 22", "BUXZO HABU", "DE_DIEU", "1", "11", new DateTime(2020, 12, 2, 12, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 39, "4", "User Delete", "7", null, "Meta data example 29", "UZOHY CNTP", "DE_DIEU", "1", "14", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 33, "4", "User Activity Log", "2", null, "Meta data example 23", "JDCPA XFFX", "CAY_TRONG", "1", "7", new DateTime(2020, 12, 1, 14, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 34, "3", "User Edit", "3", null, "Meta data example 24", "YMYTB YLSY", "LUOI_DIEN", "1", "11", new DateTime(2020, 12, 1, 12, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 35, "10", "User Delete", "5", null, "Meta data example 25", "TZZDE TCFR", "LUOI_DIEN", "3", "12", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 36, "4", "User Edit", "5", null, "Meta data example 26", "UVYFD HNDN", "DE_DIEU", "1", "4", new DateTime(2020, 12, 2, 14, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 37, "2", "User Activity Log", "7", null, "Meta data example 27", "DPABM PWEX", "DE_DIEU", "4", "13", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 38, "7", "User Edit", "6", null, "Meta data example 28", "WIDIC KDZK", "LUOI_DIEN", "4", "11", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 49, "1", "User Delete", "7", null, "Meta data example 39", "ZETVX DLBG", "DE_DIEU", "1", "14", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 44, "2", "User Activity Log", "7", null, "Meta data example 34", "KGIVJ XRMO", "DE_DIEU", "1", "6", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 41, "10", "User Edit", "7", null, "Meta data example 31", "XXHBT LSQC", "CHAY_RUNG", "1", "9", new DateTime(2020, 12, 1, 14, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 42, "7", "User Edit", "5", null, "Meta data example 32", "DNSGZ EBSD", "CAY_TRONG", "2", "5", new DateTime(2020, 12, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 43, "4", "User Delete", "7", null, "Meta data example 33", "BDODE ODYA", "CHAY_RUNG", "2", "7", new DateTime(2020, 12, 2, 12, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 45, "3", "User Delete", "3", null, "Meta data example 35", "JXQWR XOYF", "CHAY_RUNG", "2", "4", new DateTime(2020, 12, 2, 4, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 46, "8", "User Add", "9", null, "Meta data example 36", "BHUGO UJEW", "CAY_TRONG", "3", "7", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 47, "10", "User Add", "6", null, "Meta data example 37", "IUQDI XFXW", "CHAY_RUNG", "2", "7", new DateTime(2020, 12, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 48, "3", "User Add", "4", null, "Meta data example 38", "MPEQA DMRM", "CHAY_RUNG", "4", "5", new DateTime(2020, 12, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 31, "8", "User Delete", "7", null, "Meta data example 21", "KPSNR JVXV", "DE_DIEU", "1", "9", new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 40, "7", "User Activity Log", "5", null, "Meta data example 30", "LHFEI DZXQ", "DE_DIEU", "1", "2", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 30, "10", "User Add", "2", null, "Meta data example 20", "OZFGX VXTB", "LUOI_DIEN", "3", "13", new DateTime(2020, 12, 1, 1, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 19, "9", "User Delete", "1", null, "Meta data example 9", "RFBJM TKOV", "DE_DIEU", "4", "2", new DateTime(2020, 12, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 28, "5", "User Edit", "9", null, "Meta data example 18", "WKMUO WGAF", "CHAY_RUNG", "3", "7", new DateTime(2020, 12, 2, 1, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 29, "4", "User Delete", "1", null, "Meta data example 19", "ODGPV PXUO", "CAY_TRONG", "2", "4", new DateTime(2020, 12, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 10, "9", "User Delete", "5", null, "Meta data example 0", "JHKUE DDRE", "CAY_TRONG", "1", "5", new DateTime(2020, 12, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 11, "3", "User Activity Log", "6", null, "Meta data example 1", "FAGHX EWFV", "LUOI_DIEN", "3", "7", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 12, "1", "User Add", "7", null, "Meta data example 2", "RIQQC OJBG", "DE_DIEU", "2", "6", new DateTime(2020, 12, 1, 13, 14, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 14, "8", "User Add", "2", null, "Meta data example 4", "VVFHZ UXTR", "CAY_TRONG", "1", "14", new DateTime(2020, 12, 2, 12, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 15, "7", "User Edit", "1", null, "Meta data example 5", "AKKMP AQUR", "DE_DIEU", "3", "14", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 16, "5", "User Edit", "3", null, "Meta data example 6", "TBKRL IICV", "DE_DIEU", "4", "3", new DateTime(2020, 12, 2, 14, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 17, "7", "User Edit", "8", null, "Meta data example 7", "EEFPL WDIR", "CAY_TRONG", "2", "10", new DateTime(2020, 12, 1, 12, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 13, "7", "User Edit", "1", null, "Meta data example 3", "NWSEM IZSZ", "CHAY_RUNG", "4", "9", new DateTime(2020, 12, 1, 12, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 20, "5", "User Edit", "7", null, "Meta data example 10", "MVYBM WFVB", "CAY_TRONG", "3", "9", new DateTime(2020, 12, 2, 2, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 21, "7", "User Edit", "4", null, "Meta data example 11", "XHDIZ DQVE", "LUOI_DIEN", "3", "14", new DateTime(2020, 12, 1, 9, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 22, "10", "User Delete", "7", null, "Meta data example 12", "XCNJY YCWD", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 3, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 23, "7", "User Edit", "1", null, "Meta data example 13", "LPMZW WSJD", "DE_DIEU", "4", "9", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 27, "6", "User Add", "6", null, "Meta data example 17", "LHRPL HYRV", "CAY_TRONG", "4", "2", new DateTime(2020, 12, 2, 2, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 24, "7", "User Edit", "2", null, "Meta data example 14", "XPEVO JCSJ", "LUOI_DIEN", "4", "7", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 25, "9", "User Delete", "2", null, "Meta data example 15", "CPJMU JHOC", "CHAY_RUNG", "3", "7", new DateTime(2020, 12, 2, 11, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 26, "3", "User Edit", "10", null, "Meta data example 16", "TISJH HUDM", "LUOI_DIEN", "2", "6", new DateTime(2020, 12, 1, 11, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "IncidentId", "Metadata", "Name", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type" },
                values: new object[] { 18, "8", "User Delete", "4", null, "Meta data example 8", "RQKPM CLFO", "LUOI_DIEN", "2", "9", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 76, "8", "Video theo dõi DE_DIEU HZMQE", "3", "27", "5", "Video AA", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 77, "9", "Video theo dõi CHAY_RUNG VPAPE", "5", "16", "1", "Video RQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 78, "5", "Video theo dõi LUOI_DIEN BVAPY", "2", "1", "4", "Video KS", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 82, "7", "Video theo dõi DE_DIEU BWNGU", "3", "14", "8", "Video TN", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 80, "6", "Video theo dõi CHAY_RUNG NOPGT", "2", "14", "6", "Video LN", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 81, "9", "Video theo dõi CHAY_RUNG QBTJA", "9", "34", "2", "Video NN", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 83, "3", "Video theo dõi CAY_TRONG GKVTG", "5", "17", "14", "Video AE", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 75, "10", "Video theo dõi LUOI_DIEN ZRWPC", "1", "34", "6", "Video VJ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 79, "7", "Video theo dõi CAY_TRONG VLTAM", "3", "27", "14", "Video NU", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 74, "10", "Video theo dõi CHAY_RUNG ZQSOZ", "7", "25", "2", "Video BD", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 64, "1", "Video theo dõi LUOI_DIEN SAVNS", "3", "40", "11", "Video OI", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 72, "2", "Video theo dõi LUOI_DIEN DYDSR", "5", "2", "12", "Video IC", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 9, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 71, "8", "Video theo dõi CAY_TRONG FDNAF", "6", "1", "12", "Video QY", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 69, "4", "Video theo dõi DE_DIEU CFQPP", "9", "14", "4", "Video HS", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 68, "10", "Video theo dõi DE_DIEU WNOBT", "7", "30", "13", "Video PV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 67, "8", "Video theo dõi CHAY_RUNG ZSIRM", "2", "5", "6", "Video KS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 66, "4", "Video theo dõi LUOI_DIEN MLLDC", "5", "3", "10", "Video WV", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 65, "4", "Video theo dõi DE_DIEU BVOZF", "9", "9", "1", "Video FK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 15, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 84, "8", "Video theo dõi LUOI_DIEN UFBQB", "1", "12", "10", "Video JF", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 63, "3", "Video theo dõi DE_DIEU XJUYC", "7", "12", "8", "Video XH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 62, "8", "Video theo dõi CAY_TRONG DLPSK", "8", "20", "8", "Video DH", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 73, "4", "Video theo dõi CHAY_RUNG QWAXF", "2", "23", "11", "Video FC", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 85, "7", "Video theo dõi DE_DIEU IAYXR", "9", "3", "7", "Video IB", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 94, "9", "Video theo dõi CHAY_RUNG NBADX", "1", "25", "4", "Video XP", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 87, "2", "Video theo dõi CHAY_RUNG ATZJQ", "5", "2", "8", "Video TS", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 109, "2", "Video theo dõi CAY_TRONG PVRVO", "7", "22", "3", "Video AR", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 108, "2", "Video theo dõi CHAY_RUNG JMBVY", "5", "34", "14", "Video FZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 5, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 107, "5", "Video theo dõi DE_DIEU EBMTR", "4", "12", "12", "Video WM", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 106, "9", "Video theo dõi CAY_TRONG AAWXY", "6", "19", "11", "Video SB", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 105, "8", "Video theo dõi DE_DIEU KIMYK", "4", "20", "10", "Video OD", "DE_DIEU", "1", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 104, "1", "Video theo dõi CHAY_RUNG ALWMA", "3", "8", "3", "Video ND", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 103, "1", "Video theo dõi CAY_TRONG SBUXZ", "6", "15", "9", "Video TO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 102, "3", "Video theo dõi LUOI_DIEN OSUBD", "5", "2", "1", "Video AZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 101, "2", "Video theo dõi CAY_TRONG WXLCG", "6", "37", "5", "Video UR", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 100, "1", "Video theo dõi DE_DIEU YDEEV", "3", "14", "10", "Video LU", "DE_DIEU", "0", new DateTime(2020, 12, 1, 5, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 86, "1", "Video theo dõi CAY_TRONG XLYPA", "1", "23", "8", "Video NA", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 99, "4", "Video theo dõi CAY_TRONG TSALP", "6", "14", "10", "Video SU", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 97, "4", "Video theo dõi CAY_TRONG RUQUQ", "9", "18", "1", "Video ES", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 96, "1", "Video theo dõi CHAY_RUNG YJLNP", "8", "9", "7", "Video AF", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 95, "5", "Video theo dõi CAY_TRONG EHQDG", "2", "16", "2", "Video YI", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 61, "7", "Video theo dõi DE_DIEU NEDGC", "1", "16", "14", "Video OD", "DE_DIEU", "1", new DateTime(2020, 12, 1, 15, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 93, "8", "Video theo dõi CHAY_RUNG EGYCO", "9", "21", "9", "Video GY", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 92, "6", "Video theo dõi CAY_TRONG HIAFT", "10", "5", "6", "Video FW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 91, "10", "Video theo dõi DE_DIEU EIPIJ", "2", "17", "13", "Video WZ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 90, "10", "Video theo dõi CHAY_RUNG JNVVB", "8", "17", "13", "Video OH", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 89, "9", "Video theo dõi CAY_TRONG QXYTV", "4", "10", "9", "Video QF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 88, "7", "Video theo dõi CAY_TRONG WLPVL", "4", "40", "10", "Video WG", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 14, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 98, "5", "Video theo dõi DE_DIEU JFUIV", "3", "35", "12", "Video WR", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 60, "10", "Video theo dõi LUOI_DIEN UHRGB", "8", "1", "3", "Video GI", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 70, "8", "Video theo dõi CAY_TRONG ZYLQM", "1", "10", "6", "Video EO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 58, "2", "Video theo dõi DE_DIEU QKPBE", "8", "7", "10", "Video JM", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 31, "5", "Video theo dõi LUOI_DIEN JDDUI", "8", "36", "8", "Video PT", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 10, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 30, "4", "Video theo dõi LUOI_DIEN AQQUS", "3", "24", "5", "Video EB", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 29, "6", "Video theo dõi CAY_TRONG HFOTF", "1", "31", "12", "Video TR", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 28, "10", "Video theo dõi DE_DIEU HJRFC", "10", "10", "12", "Video TE", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 27, "1", "Video theo dõi CAY_TRONG APNCG", "9", "36", "12", "Video UF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 26, "2", "Video theo dõi CAY_TRONG CTPBV", "9", "39", "3", "Video BM", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 25, "8", "Video theo dõi DE_DIEU RJVFF", "3", "7", "1", "Video OR", "DE_DIEU", "1", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 24, "3", "Video theo dõi CHAY_RUNG MVLEK", "10", "26", "9", "Video WR", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 23, "3", "Video theo dõi LUOI_DIEN WSTTN", "2", "12", "10", "Video HG", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 13, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 22, "5", "Video theo dõi CHAY_RUNG OZFFC", "2", "26", "11", "Video BY", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 32, "3", "Video theo dõi DE_DIEU EOXWW", "6", "9", "11", "Video LZ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 21, "8", "Video theo dõi LUOI_DIEN NOGEB", "6", "21", "6", "Video NX", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 8, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 19, "10", "Video theo dõi CAY_TRONG QAIDB", "8", "21", "4", "Video BH", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 18, "5", "Video theo dõi CHAY_RUNG ZECIT", "9", "31", "13", "Video MS", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 17, "8", "Video theo dõi LUOI_DIEN YTKUE", "9", "37", "10", "Video XG", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 7, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 16, "1", "Video theo dõi LUOI_DIEN JPLJT", "5", "8", "13", "Video WK", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 1, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 15, "10", "Video theo dõi CAY_TRONG MULFK", "1", "21", "10", "Video EJ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 13, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 59, "4", "Video theo dõi CAY_TRONG KPZOO", "6", "3", "9", "Video SO", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 13, "5", "Video theo dõi LUOI_DIEN TSSWZ", "10", "23", "9", "Video GI", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 12, "7", "Video theo dõi CAY_TRONG FYBVY", "5", "19", "13", "Video MG", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 11, "3", "Video theo dõi LUOI_DIEN THMQH", "4", "23", "13", "Video QQ", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 9, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 10, "3", "Video theo dõi DE_DIEU UELDN", "6", "20", "2", "Video WT", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 20, "4", "Video theo dõi DE_DIEU IZMKU", "3", "31", "1", "Video ZN", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "Video theo dõi CAY_TRONG OWUPN", "8", "7", "2", "Video SB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 1, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 14, "8", "Video theo dõi CAY_TRONG OYWEY", "1", "12", "10", "Video MI", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 35, "8", "Video theo dõi CHAY_RUNG HGWYP", "7", "21", "1", "Video JJ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 34, "1", "Video theo dõi CHAY_RUNG YEBPD", "9", "7", "3", "Video KO", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 57, "7", "Video theo dõi CAY_TRONG IGGQV", "6", "38", "8", "Video KV", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 55, "7", "Video theo dõi CHAY_RUNG YYVGD", "1", "39", "12", "Video AF", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 10, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 54, "8", "Video theo dõi DE_DIEU WABMM", "3", "6", "10", "Video JF", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 53, "3", "Video theo dõi LUOI_DIEN GZTZQ", "2", "31", "2", "Video YL", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 52, "2", "Video theo dõi LUOI_DIEN WPOYM", "10", "12", "5", "Video KZ", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 12, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 51, "10", "Video theo dõi CHAY_RUNG ICHMB", "7", "25", "7", "Video FW", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 50, "1", "Video theo dõi CHAY_RUNG GHYNQ", "2", "15", "13", "Video OK", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 49, "1", "Video theo dõi CAY_TRONG RFJTU", "3", "16", "10", "Video CA", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 48, "9", "Video theo dõi CHAY_RUNG NIKEJ", "10", "26", "10", "Video LM", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 15, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "Video theo dõi DE_DIEU ZWZIU", "1", "36", "11", "Video LW", "DE_DIEU", "1", new DateTime(2020, 12, 2, 5, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 56, "1", "Video theo dõi CHAY_RUNG IKWFO", "5", "24", "11", "Video BM", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 45, "8", "Video theo dõi DE_DIEU KTLBG", "8", "21", "8", "Video XO", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 46, "3", "Video theo dõi LUOI_DIEN CTGKF", "10", "5", "8", "Video AS", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 5, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 38, "9", "Video theo dõi CAY_TRONG BVWDN", "2", "3", "6", "Video EU", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 39, "5", "Video theo dõi CAY_TRONG AVOPP", "4", "10", "2", "Video BU", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "Video theo dõi DE_DIEU MCDWD", "6", "16", "13", "Video KL", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 37, "3", "Video theo dõi LUOI_DIEN RGFVK", "2", "17", "14", "Video MY", "LUOI_DIEN", "1", new DateTime(2020, 12, 1, 11, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 42, "7", "Video theo dõi DE_DIEU IEWTM", "7", "23", "6", "Video GD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 43, "10", "Video theo dõi CAY_TRONG WVQAG", "6", "6", "9", "Video XZ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "Video theo dõi LUOI_DIEN MAIHI", "3", "37", "7", "Video BN", "LUOI_DIEN", "0", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 41, "10", "Video theo dõi LUOI_DIEN SMYWE", "10", "5", "7", "Video SS", "LUOI_DIEN", "1", new DateTime(2020, 12, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "DroneId", "EntityId", "IncidentId", "Link", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[] { 36, "7", "Video theo dõi LUOI_DIEN LQPRV", "5", "3", "12", "Video VM", "LUOI_DIEN", "0", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 31, "3", "Warning Add", "10", "Warning HH", "DE_DIEU", "4", "1", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 38, "6", "Warning Edit", "6", "Warning ZX", "DE_DIEU", "1", "0", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 32, "9", "Warning Delete", "5", "Warning SW", "CHAY_RUNG", "3", "0", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 33, "3", "Warning Delete", "7", "Warning VH", "LUOI_DIEN", "3", "1", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 34, "4", "Warning Edit", "9", "Warning AZ", "CAY_TRONG", "2", "0", new DateTime(2020, 12, 1, 11, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 35, "9", "Warning Delete", "3", "Warning RW", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 1, 2, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 36, "8", "Warning Add", "4", "Warning IP", "DE_DIEU", "1", "0", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 37, "5", "Warning Activity Log", "8", "Warning ZQ", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 43, "4", "Warning Edit", "5", "Warning ZG", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 40, "2", "Warning Add", "10", "Warning EN", "CHAY_RUNG", "4", "0", new DateTime(2020, 12, 1, 2, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 41, "1", "Warning Activity Log", "9", "Warning ID", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 7, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 42, "2", "Warning Add", "9", "Warning RF", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 14, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 44, "6", "Warning Edit", "5", "Warning WF", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 45, "7", "Warning Add", "10", "Warning BH", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 2, 4, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 46, "2", "Warning Activity Log", "8", "Warning ZX", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 47, "1", "Warning Delete", "9", "Warning ZY", "CAY_TRONG", "2", "1", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 30, "8", "Warning Delete", "9", "Warning HL", "LUOI_DIEN", "3", "0", new DateTime(2020, 12, 1, 4, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 39, "6", "Warning Activity Log", "10", "Warning LR", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 29, "10", "Warning Add", "2", "Warning GO", "CAY_TRONG", "1", "1", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 17, "5", "Warning Delete", "3", "Warning JZ", "CHAY_RUNG", "3", "1", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 27, "2", "Warning Edit", "3", "Warning IV", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 2, 10, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 48, "5", "Warning Activity Log", "6", "Warning JH", "DE_DIEU", "2", "0", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 10, "7", "Warning Add", "2", "Warning PZ", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 11, "9", "Warning Activity Log", "3", "Warning DQ", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 12, "3", "Warning Edit", "7", "Warning CC", "CAY_TRONG", "3", "0", new DateTime(2020, 12, 2, 1, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 13, "1", "Warning Activity Log", "7", "Warning MB", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 14, "7", "Warning Delete", "2", "Warning CU", "CAY_TRONG", "1", "0", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 15, "10", "Warning Add", "5", "Warning BV", "CAY_TRONG", "4", "1", new DateTime(2020, 12, 2, 6, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 16, "3", "Warning Edit", "4", "Warning KV", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 18, "7", "Warning Edit", "5", "Warning PJ", "CHAY_RUNG", "2", "0", new DateTime(2020, 12, 1, 14, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 19, "7", "Warning Delete", "10", "Warning QZ", "CHAY_RUNG", "4", "1", new DateTime(2020, 12, 1, 11, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 20, "5", "Warning Edit", "7", "Warning FR", "DE_DIEU", "4", "0", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 21, "2", "Warning Edit", "4", "Warning GH", "CHAY_RUNG", "2", "1", new DateTime(2020, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 22, "4", "Warning Add", "6", "Warning UI", "CAY_TRONG", "4", "0", new DateTime(2020, 12, 2, 11, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 23, "8", "Warning Edit", "1", "Warning KN", "DE_DIEU", "3", "1", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 24, "1", "Warning Activity Log", "6", "Warning MX", "LUOI_DIEN", "4", "0", new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 25, "8", "Warning Delete", "6", "Warning ZL", "CHAY_RUNG", "1", "1", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 26, "9", "Warning Delete", "10", "Warning AH", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 28, "5", "Warning Delete", "2", "Warning OF", "LUOI_DIEN", "2", "0", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "AuthorId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[] { 49, "1", "Warning Activity Log", "7", "Warning LI", "LUOI_DIEN", "1", "1", new DateTime(2020, 12, 1, 14, 24, 0, 0, DateTimeKind.Unspecified), 20 });
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
