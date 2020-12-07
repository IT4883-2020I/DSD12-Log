using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class link1 : Migration
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
                    { 32, "Drone Add", 44, 47, 23, "Drone BV", "DE_DIEU", 0, "CYXRY", new DateTime(2020, 12, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Drone Add", 46, 10, 43, "Drone EC", "CHAY_RUNG", 0, "QFKGD", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Drone Add", 48, 17, 19, "Drone DW", "CAY_TRONG", 0, "AMWBE", new DateTime(2020, 12, 1, 1, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Drone Activity Log", 50, 13, 23, "Drone WF", "DE_DIEU", 0, "KGWLZ", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "Drone Activity Log", 52, 26, 18, "Drone SW", "CAY_TRONG", 0, "TMMGV", new DateTime(2020, 12, 2, 9, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "Drone Delete", 54, 25, 15, "Drone RK", "CAY_TRONG", 0, "BHORY", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "Drone Activity Log", 58, 19, 32, "Drone KD", "CHAY_RUNG", 0, "BDGRF", new DateTime(2020, 12, 2, 6, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "Drone Activity Log", 60, 36, 22, "Drone WG", "CHAY_RUNG", 0, "ANNRR", new DateTime(2020, 12, 1, 6, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "Drone Delete", 62, 18, 22, "Drone EU", "CAY_TRONG", 0, "PJZXO", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Drone Edit", 64, 43, 11, "Drone WP", "DE_DIEU", 0, "WNQOT", new DateTime(2020, 12, 1, 3, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Drone Activity Log", 66, 39, 21, "Drone FH", "CAY_TRONG", 0, "ONFRM", new DateTime(2020, 12, 1, 9, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Drone Edit", 68, 44, 28, "Drone TR", "CAY_TRONG", 0, "EURLD", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "Drone Activity Log", 70, 21, 38, "Drone AK", "CHAY_RUNG", 0, "EVSYT", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "Drone Activity Log", 72, 30, 16, "Drone OB", "CHAY_RUNG", 0, "IMVSU", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "Drone Add", 74, 14, 47, "Drone OV", "CAY_TRONG", 0, "YOCER", new DateTime(2020, 12, 1, 1, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Drone Delete", 76, 13, 14, "Drone IP", "CAY_TRONG", 0, "CITUN", new DateTime(2020, 12, 2, 11, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Drone Add", 78, 17, 45, "Drone QF", "CAY_TRONG", 0, "WSKYD", new DateTime(2020, 12, 1, 12, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "Drone Edit", 42, 16, 39, "Drone EU", "DE_DIEU", 0, "NXMDU", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Drone Activity Log", 40, 27, 15, "Drone JY", "CHAY_RUNG", 0, "OXKFX", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "Drone Delete", 56, 18, 46, "Drone TX", "CAY_TRONG", 0, "UKDII", new DateTime(2020, 12, 1, 1, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Drone Activity Log", 36, 33, 49, "Drone MZ", "CHAY_RUNG", 0, "CJVJI", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Drone Activity Log", 38, 29, 28, "Drone SJ", "DE_DIEU", 0, "BNOPE", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Drone Delete", 2, 45, 43, "Drone TY", "CAY_TRONG", 0, "MMFVV", new DateTime(2020, 12, 2, 13, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Drone Add", 4, 38, 34, "Drone TC", "CHAY_RUNG", 0, "XLXZI", new DateTime(2020, 12, 2, 1, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Drone Delete", 6, 34, 18, "Drone MS", "CAY_TRONG", 0, "NQDGJ", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Drone Activity Log", 8, 48, 10, "Drone UV", "CAY_TRONG", 0, "EGVWI", new DateTime(2020, 12, 1, 6, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Drone Edit", 10, 27, 12, "Drone SM", "CAY_TRONG", 0, "VBQAN", new DateTime(2020, 12, 2, 3, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Drone Edit", 12, 33, 11, "Drone AJ", "CAY_TRONG", 0, "MLCSI", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Drone Activity Log", 14, 25, 31, "Drone HZ", "CAY_TRONG", 0, "UGDIU", new DateTime(2020, 12, 2, 7, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Drone Activity Log", 16, 36, 12, "Drone CW", "CHAY_RUNG", 0, "THQPX", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Drone Edit", 0, 30, 34, "Drone YN", "CAY_TRONG", 0, "RWSQZ", new DateTime(2020, 12, 2, 12, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Drone Activity Log", 20, 43, 34, "Drone AP", "CHAY_RUNG", 0, "ENUXK", new DateTime(2020, 12, 1, 6, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Drone Add", 18, 30, 45, "Drone BZ", "DE_DIEU", 0, "QJEHC", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Drone Add", 32, 31, 42, "Drone SU", "CAY_TRONG", 0, "PQFLU", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Drone Edit", 30, 45, 31, "Drone UL", "DE_DIEU", 0, "RLSAA", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Drone Edit", 28, 12, 36, "Drone CP", "DE_DIEU", 0, "GHEHN", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Drone Delete", 34, 48, 28, "Drone PJ", "DE_DIEU", 0, "UKHKY", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Drone Edit", 24, 43, 16, "Drone XS", "DE_DIEU", 0, "CRHGB", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Drone Add", 22, 29, 42, "Drone MT", "CAY_TRONG", 0, "WXCCR", new DateTime(2020, 12, 2, 12, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "Drone Delete", 26, 36, 13, "Drone CV", "CAY_TRONG", 0, "PZBZV", new DateTime(2020, 12, 2, 3, 46, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Image Add", 0, 58, "Image WF", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Image Activity Log", 0, 46, "Image BJ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "Image Edit", 0, 48, "Image KX", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 12, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "Image Add", 0, 50, "Image ZH", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Image Add", 0, 52, "Image LV", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 15, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Image Add", 0, 54, "Image DF", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Image Activity Log", 0, 44, "Image GZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "Image Edit", 0, 56, "Image UP", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Image Add", 0, 60, "Image XX", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Image Edit", 0, 68, "Image UD", "DE_DIEU", "0", new DateTime(2020, 12, 1, 2, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "Image Delete", 0, 64, "Image UR", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 1, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Image Activity Log", 0, 66, "Image UM", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 11, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Image Add", 0, 70, "Image DN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Image Delete", 0, 72, "Image ZU", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Image Delete", 0, 74, "Image BF", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 1, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Image Edit", 0, 76, "Image VR", "DE_DIEU", "0", new DateTime(2020, 12, 1, 2, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Image Activity Log", 0, 78, "Image FJ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Image Activity Log", 0, 42, "Image DU", "DE_DIEU", "1", new DateTime(2020, 12, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "Image Edit", 0, 62, "Image XE", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Image Activity Log", 0, 40, "Image UA", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Image Add", 0, 16, "Image OS", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Image Add", 0, 36, "Image UQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Image Add", 0, 38, "Image RJ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Image Activity Log", 0, 2, "Image YQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "Image Delete", 0, 4, "Image LX", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Image Edit", 0, 6, "Image HL", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Image Add", 0, 8, "Image ZP", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Image Add", 0, 10, "Image YO", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Image Add", 0, 12, "Image WK", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Image Edit", 0, 14, "Image CQ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 3, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Image Delete", 0, 0, "Image TT", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Image Edit", 0, 34, "Image YH", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Image Delete", 0, 20, "Image NN", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Image Activity Log", 0, 22, "Image ZV", "DE_DIEU", "1", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Image Add", 0, 24, "Image OZ", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "Image Activity Log", 0, 26, "Image ZI", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Image Edit", 0, 28, "Image VP", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Image Edit", 0, 30, "Image TQ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 6, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Image Edit", 0, 32, "Image FK", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Image Edit", 0, 18, "Image LB", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "ImageId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type", "VideoId" },
                values: new object[,]
                {
                    { 37, "Incident Activity Log", 54, 0, "Incident JT", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 14, 11, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 36, "Incident Activity Log", 52, 0, "Incident WL", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 35, "Incident Delete", 50, 0, "Incident AY", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 31, "Incident Activity Log", 42, 0, "Incident EO", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 17, 27, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 33, "Incident Activity Log", 46, 0, "Incident SX", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 32, "Incident Activity Log", 44, 0, "Incident JG", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 15, 15, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 39, "Incident Edit", 58, 0, "Incident BG", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 5, 42, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 34, "Incident Delete", 48, 0, "Incident QY", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 14, 11, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 40, "Incident Edit", 60, 0, "Incident NH", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 10, 16, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 45, "Incident Delete", 70, 0, "Incident EI", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 42, "Incident Activity Log", 64, 0, "Incident HF", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 43, "Incident Activity Log", 66, 0, "Incident SR", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 44, "Incident Activity Log", 68, 0, "Incident UJ", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 46, "Incident Add", 72, 0, "Incident ZF", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 47, "Incident Delete", 74, 0, "Incident JW", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 48, "Incident Delete", 76, 0, "Incident AS", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 49, "Incident Add", 78, 0, "Incident SQ", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 41, "Incident Activity Log", 62, 0, "Incident OS", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 30, "Incident Activity Log", 40, 0, "Incident CU", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 4, 6, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 38, "Incident Add", 56, 0, "Incident NN", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 28, "Incident Add", 36, 0, "Incident GL", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 7, 19, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 11, "Incident Add", 2, 0, "Incident IQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 3, 20, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 12, "Incident Add", 4, 0, "Incident QK", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 1, 20, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 13, "Incident Delete", 6, 0, "Incident AN", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 14, "Incident Edit", 8, 0, "Incident TY", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 10, 28, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 15, "Incident Edit", 10, 0, "Incident XC", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 3, 38, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 16, "Incident Activity Log", 12, 0, "Incident TW", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 17, "Incident Add", 14, 0, "Incident HH", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 6, 39, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 18, "Incident Delete", 16, 0, "Incident NV", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 1, 31, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 19, "Incident Activity Log", 18, 0, "Incident VM", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 10, "Incident Delete", 0, 0, "Incident TQ", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 12, 37, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 29, "Incident Delete", 38, 0, "Incident SU", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 21, "Incident Delete", 22, 0, "Incident MD", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 22, "Incident Activity Log", 24, 0, "Incident AS", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 20, 0 },
                    { 23, "Incident Delete", 26, 0, "Incident UQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 24, "Incident Add", 28, 0, "Incident JI", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 25, "Incident Edit", 30, 0, "Incident BB", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 26, "Incident Edit", 32, 0, "Incident CH", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 27, "Incident Edit", 34, 0, "Incident YC", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 1, 1, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 20, "Incident Add", 20, 0, "Incident MR", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 14, 40, 0, 0, DateTimeKind.Unspecified), 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "MonitorRegion Activity Log", 54, "MonitorRegion PZ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "MonitorRegion Activity Log", 52, "MonitorRegion NP", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 6, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "MonitorRegion Activity Log", 44, "MonitorRegion WC", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "MonitorRegion Add", 48, "MonitorRegion UC", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "MonitorRegion Edit", 46, "MonitorRegion JY", "DE_DIEU", "1", new DateTime(2020, 12, 1, 13, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "MonitorRegion Add", 56, "MonitorRegion YF", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "MonitorRegion Edit", 50, "MonitorRegion GU", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "MonitorRegion Delete", 58, "MonitorRegion FQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "MonitorRegion Activity Log", 68, "MonitorRegion ZQ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "MonitorRegion Add", 62, "MonitorRegion PO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 7, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "MonitorRegion Delete", 64, "MonitorRegion DX", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "MonitorRegion Edit", 66, "MonitorRegion MB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "MonitorRegion Add", 70, "MonitorRegion FJ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "MonitorRegion Edit", 72, "MonitorRegion GW", "DE_DIEU", "0", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "MonitorRegion Delete", 74, "MonitorRegion SB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "MonitorRegion Add", 76, "MonitorRegion BV", "DE_DIEU", "0", new DateTime(2020, 12, 2, 6, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "MonitorRegion Add", 42, "MonitorRegion YF", "DE_DIEU", "1", new DateTime(2020, 12, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "MonitorRegion Edit", 60, "MonitorRegion MI", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "MonitorRegion Activity Log", 40, "MonitorRegion KK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "MonitorRegion Delete", 78, "MonitorRegion ZA", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "MonitorRegion Activity Log", 36, "MonitorRegion CG", "DE_DIEU", "0", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "MonitorRegion Edit", 0, "MonitorRegion XE", "DE_DIEU", "0", new DateTime(2020, 12, 2, 16, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "MonitorRegion Delete", 2, "MonitorRegion GS", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "MonitorRegion Edit", 4, "MonitorRegion KI", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "MonitorRegion Delete", 6, "MonitorRegion OX", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "MonitorRegion Activity Log", 8, "MonitorRegion VP", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "MonitorRegion Delete", 10, "MonitorRegion VF", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 13, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "MonitorRegion Delete", 12, "MonitorRegion BM", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 3, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "MonitorRegion Delete", 14, "MonitorRegion RQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "MonitorRegion Activity Log", 16, "MonitorRegion MW", "DE_DIEU", "0", new DateTime(2020, 12, 2, 10, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "MonitorRegion Edit", 38, "MonitorRegion OU", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "MonitorRegion Delete", 20, "MonitorRegion IB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "MonitorRegion Add", 22, "MonitorRegion TX", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "MonitorRegion Add", 24, "MonitorRegion XA", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 13, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "MonitorRegion Delete", 26, "MonitorRegion ZU", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "MonitorRegion Add", 28, "MonitorRegion WV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "MonitorRegion Delete", 30, "MonitorRegion XB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 3, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "MonitorRegion Edit", 32, "MonitorRegion ZC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "MonitorRegion Delete", 34, "MonitorRegion DP", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "MonitorRegion Delete", 18, "MonitorRegion ZF", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 6, 11, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ObjectObserve Activity Log", 54, "ObjectObserve TZ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "ObjectObserve Edit", 52, "ObjectObserve NL", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "ObjectObserve Edit", 50, "ObjectObserve YO", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "ObjectObserve Edit", 42, "ObjectObserve FQ", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 10, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "ObjectObserve Edit", 46, "ObjectObserve LE", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 4, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "ObjectObserve Add", 44, "ObjectObserve FM", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "ObjectObserve Edit", 56, "ObjectObserve WC", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ObjectObserve Activity Log", 48, "ObjectObserve FA", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 4, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "ObjectObserve Edit", 58, "ObjectObserve GX", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 1, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "ObjectObserve Activity Log", 66, "ObjectObserve JO", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "ObjectObserve Activity Log", 62, "ObjectObserve CQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "ObjectObserve Edit", 64, "ObjectObserve SR", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 14, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "ObjectObserve Edit", 68, "ObjectObserve YD", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "ObjectObserve Activity Log", 70, "ObjectObserve HM", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 2, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "ObjectObserve Activity Log", 72, "ObjectObserve QX", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "ObjectObserve Delete", 74, "ObjectObserve RL", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 5, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "ObjectObserve Delete", 76, "ObjectObserve CL", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 17, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "ObjectObserve Add", 40, "ObjectObserve EY", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "ObjectObserve Edit", 60, "ObjectObserve DV", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "ObjectObserve Activity Log", 78, "ObjectObserve BJ", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 11, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "ObjectObserve Add", 38, "ObjectObserve ZW", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 2, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "ObjectObserve Add", 34, "ObjectObserve RX", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "ObjectObserve Delete", 36, "ObjectObserve VV", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 11, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "ObjectObserve Add", 0, "ObjectObserve HH", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "ObjectObserve Activity Log", 2, "ObjectObserve CF", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "ObjectObserve Edit", 4, "ObjectObserve NC", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "ObjectObserve Add", 6, "ObjectObserve KS", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "ObjectObserve Activity Log", 10, "ObjectObserve ZO", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 9, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "ObjectObserve Delete", 12, "ObjectObserve UJ", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 5, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "ObjectObserve Add", 14, "ObjectObserve LC", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "ObjectObserve Activity Log", 8, "ObjectObserve FE", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "ObjectObserve Delete", 18, "ObjectObserve ON", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 8, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "ObjectObserve Add", 16, "ObjectObserve FD", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "ObjectObserve Edit", 30, "ObjectObserve TE", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "ObjectObserve Add", 28, "ObjectObserve XO", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "ObjectObserve Add", 26, "ObjectObserve UR", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 1, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "ObjectObserve Edit", 32, "ObjectObserve OA", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 8, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "ObjectObserve Edit", 22, "ObjectObserve TK", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 9, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "ObjectObserve Add", 20, "ObjectObserve UP", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 3, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "ObjectObserve Delete", 24, "ObjectObserve US", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "Payload Delete", 0, 56, "Payload ED", "DE_DIEU", "0", new DateTime(2020, 12, 1, 11, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "Payload Add", 0, 44, "Payload GC", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 13, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Payload Delete", 0, 46, "Payload ZJ", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Payload Add", 0, 48, "Payload HJ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Payload Activity Log", 0, 50, "Payload DP", "DE_DIEU", "1", new DateTime(2020, 12, 1, 14, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "Payload Delete", 0, 52, "Payload EV", "DE_DIEU", "0", new DateTime(2020, 12, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "Payload Delete", 0, 54, "Payload MR", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 12, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "Payload Edit", 0, 58, "Payload NH", "DE_DIEU", "1", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Payload Delete", 0, 42, "Payload QO", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 2, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Payload Edit", 0, 62, "Payload KT", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "Payload Edit", 0, 64, "Payload RK", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Payload Delete", 0, 66, "Payload OT", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Payload Delete", 0, 68, "Payload XL", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Payload Delete", 0, 70, "Payload UN", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "Payload Delete", 0, 72, "Payload WD", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 7, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Payload Activity Log", 0, 74, "Payload PE", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 13, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "Payload Add", 0, 78, "Payload DL", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 4, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Payload Edit", 0, 60, "Payload IW", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 7, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Payload Edit", 0, 40, "Payload TU", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 10, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Payload Delete", 0, 76, "Payload JG", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 2, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Payload Activity Log", 0, 36, "Payload HN", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Payload Activity Log", 0, 38, "Payload JD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 11, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Payload Delete", 0, 2, "Payload ZJ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Payload Edit", 0, 4, "Payload WP", "DE_DIEU", "0", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Payload Activity Log", 0, 6, "Payload ON", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 8, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Payload Edit", 0, 8, "Payload QM", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Payload Delete", 0, 10, "Payload PZ", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Payload Delete", 0, 12, "Payload WK", "DE_DIEU", "0", new DateTime(2020, 12, 1, 7, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "Payload Delete", 0, 14, "Payload PI", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Payload Activity Log", 0, 16, "Payload WT", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 2, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Payload Edit", 0, 0, "Payload DI", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 17, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Payload Add", 0, 20, "Payload ZH", "DE_DIEU", "0", new DateTime(2020, 12, 2, 2, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Payload Delete", 0, 22, "Payload OA", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Payload Delete", 0, 24, "Payload FV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 11, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "Payload Add", 0, 26, "Payload MM", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Payload Add", 0, 28, "Payload AZ", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 16, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Payload Activity Log", 0, 30, "Payload AL", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Payload Delete", 0, 32, "Payload KV", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Payload Activity Log", 0, 34, "Payload VU", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 9, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Payload Activity Log", 0, 18, "Payload BD", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ResolveProblem Delete", 54, "ResolveProblem GI", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "ResolveProblem Add", 52, "ResolveProblem AP", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "ResolveProblem Activity Log", 44, "ResolveProblem ZR", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 13, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "ResolveProblem Edit", 48, "ResolveProblem PI", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 13, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "ResolveProblem Activity Log", 46, "ResolveProblem CJ", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "ResolveProblem Delete", 56, "ResolveProblem MX", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "ResolveProblem Delete", 50, "ResolveProblem QX", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 9, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "ResolveProblem Add", 58, "ResolveProblem PK", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "ResolveProblem Activity Log", 68, "ResolveProblem BP", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "ResolveProblem Add", 62, "ResolveProblem RH", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 13, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "ResolveProblem Delete", 64, "ResolveProblem PF", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "ResolveProblem Edit", 66, "ResolveProblem UQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "ResolveProblem Activity Log", 70, "ResolveProblem PL", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 8, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "ResolveProblem Edit", 72, "ResolveProblem XO", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "ResolveProblem Edit", 74, "ResolveProblem QQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 2, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "ResolveProblem Delete", 76, "ResolveProblem TA", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "ResolveProblem Edit", 42, "ResolveProblem UI", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "ResolveProblem Edit", 60, "ResolveProblem TV", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 7, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "ResolveProblem Add", 40, "ResolveProblem HY", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "ResolveProblem Edit", 78, "ResolveProblem HI", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "ResolveProblem Delete", 36, "ResolveProblem EN", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 9, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "ResolveProblem Add", 0, "ResolveProblem LQ", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 14, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "ResolveProblem Delete", 2, "ResolveProblem BW", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "ResolveProblem Edit", 4, "ResolveProblem ZE", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 12, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "ResolveProblem Edit", 6, "ResolveProblem HC", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "ResolveProblem Activity Log", 8, "ResolveProblem GA", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 15, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "ResolveProblem Edit", 10, "ResolveProblem WP", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "ResolveProblem Delete", 12, "ResolveProblem YS", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "ResolveProblem Activity Log", 14, "ResolveProblem XZ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 11, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "ResolveProblem Activity Log", 16, "ResolveProblem EU", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 14, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "ResolveProblem Edit", 38, "ResolveProblem RW", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "ResolveProblem Edit", 20, "ResolveProblem ZE", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 6, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "ResolveProblem Activity Log", 22, "ResolveProblem PB", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 9, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "ResolveProblem Delete", 24, "ResolveProblem NY", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 11, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "ResolveProblem Activity Log", 26, "ResolveProblem PG", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 4, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "ResolveProblem Add", 28, "ResolveProblem ZY", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "ResolveProblem Edit", 30, "ResolveProblem PL", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "ResolveProblem Add", 32, "ResolveProblem RF", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "ResolveProblem Delete", 34, "ResolveProblem BB", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 3, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "ResolveProblem Delete", 18, "ResolveProblem AN", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 12, 1, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Statical Delete", 54, "Statical CX", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 11, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Statical Activity Log", 52, "Statical JZ", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 5, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "Statical Delete", 50, "Statical HH", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 13, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Statical Add", 42, "Statical EE", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Statical Add", 46, "Statical HD", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Statical Edit", 44, "Statical PE", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 12, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Statical Add", 56, "Statical OR", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Statical Add", 48, "Statical AE", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 12, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Statical Add", 58, "Statical NO", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Statical Delete", 66, "Statical BU", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Statical Activity Log", 62, "Statical BN", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Statical Edit", 64, "Statical GI", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Statical Activity Log", 68, "Statical CF", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 3, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Statical Edit", 70, "Statical QB", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 6, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Statical Add", 72, "Statical MP", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 15, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Statical Delete", 74, "Statical IF", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Statical Activity Log", 76, "Statical KX", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Statical Activity Log", 40, "Statical ZP", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "Statical Delete", 60, "Statical HP", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 5, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Statical Edit", 78, "Statical YQ", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Statical Delete", 38, "Statical OV", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Statical Edit", 34, "Statical BK", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Statical Activity Log", 36, "Statical WQ", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Statical Edit", 0, "Statical LY", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 12, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Statical Edit", 2, "Statical DH", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Statical Delete", 4, "Statical AC", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Statical Delete", 6, "Statical YG", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Statical Activity Log", 10, "Statical HU", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "Statical Activity Log", 12, "Statical RP", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "Statical Edit", 14, "Statical UQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 7, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Statical Activity Log", 8, "Statical PD", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Statical Delete", 18, "Statical KZ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 11, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Statical Add", 16, "Statical IM", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 7, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Statical Edit", 30, "Statical JC", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 5, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Statical Delete", 28, "Statical NR", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 15, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "Statical Activity Log", 26, "Statical MH", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 5, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Statical Delete", 32, "Statical NV", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Statical Delete", 22, "Statical KY", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Statical Add", 20, "Statical TQ", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Statical Edit", 24, "Statical DU", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 17, 39, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "UavConnect Edit", 0, 56, "UavConnect LX", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "UavConnect Activity Log", 0, 44, "UavConnect WD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 5, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "UavConnect Delete", 0, 46, "UavConnect TA", "DE_DIEU", "1", new DateTime(2020, 12, 1, 7, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "UavConnect Edit", 0, 48, "UavConnect ND", "DE_DIEU", "0", new DateTime(2020, 12, 2, 4, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "UavConnect Activity Log", 0, 50, "UavConnect ZS", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "UavConnect Activity Log", 0, 52, "UavConnect IC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "UavConnect Activity Log", 0, 54, "UavConnect TM", "DE_DIEU", "1", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "UavConnect Delete", 0, 78, "UavConnect JH", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "UavConnect Add", 0, 42, "UavConnect TK", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "UavConnect Add", 0, 62, "UavConnect BZ", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "UavConnect Delete", 0, 64, "UavConnect MY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 5, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "UavConnect Delete", 0, 66, "UavConnect TZ", "DE_DIEU", "1", new DateTime(2020, 12, 2, 15, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "UavConnect Add", 0, 68, "UavConnect CO", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "UavConnect Add", 0, 70, "UavConnect HI", "DE_DIEU", "1", new DateTime(2020, 12, 1, 10, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "UavConnect Edit", 0, 72, "UavConnect RY", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "UavConnect Edit", 0, 74, "UavConnect UD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "UavConnect Delete", 0, 76, "UavConnect HP", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "UavConnect Delete", 0, 60, "UavConnect NC", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "UavConnect Add", 0, 40, "UavConnect JU", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "UavConnect Delete", 0, 58, "UavConnect JI", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 7, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "UavConnect Delete", 0, 36, "UavConnect YL", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 11, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "UavConnect Delete", 0, 0, "UavConnect WK", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "UavConnect Delete", 0, 2, "UavConnect KI", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "UavConnect Edit", 0, 4, "UavConnect OY", "DE_DIEU", "0", new DateTime(2020, 12, 2, 1, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "UavConnect Add", 0, 6, "UavConnect DA", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 15, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "UavConnect Edit", 0, 8, "UavConnect KG", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 4, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "UavConnect Activity Log", 0, 10, "UavConnect NF", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "UavConnect Activity Log", 0, 12, "UavConnect LW", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 13, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "UavConnect Delete", 0, 14, "UavConnect KR", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "UavConnect Activity Log", 0, 16, "UavConnect ZD", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "UavConnect Edit", 0, 38, "UavConnect LL", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "UavConnect Delete", 0, 20, "UavConnect SH", "DE_DIEU", "0", new DateTime(2020, 12, 1, 13, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "UavConnect Activity Log", 0, 22, "UavConnect GY", "CHAY_RUNG", "1", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "UavConnect Add", 0, 24, "UavConnect NR", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "UavConnect Add", 0, 26, "UavConnect IB", "DE_DIEU", "1", new DateTime(2020, 12, 1, 5, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "UavConnect Edit", 0, 28, "UavConnect RU", "DE_DIEU", "0", new DateTime(2020, 12, 1, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "UavConnect Edit", 0, 30, "UavConnect WF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 1, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "UavConnect Delete", 0, 32, "UavConnect IG", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "UavConnect Activity Log", 0, 34, "UavConnect VW", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "UavConnect Add", 0, 18, "UavConnect UX", "DE_DIEU", "1", new DateTime(2020, 12, 2, 13, 10, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "IncidentId", "Metadata", "ProjectType", "RegionId", "ResolveProblemId", "Timestamp", "Type", "UserId" },
                values: new object[,]
                {
                    { 38, "User Add", 56, 0, "Meta data example 28", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 2, 83 },
                    { 37, "User Delete", 54, 0, "Meta data example 27", "DE_DIEU", 0, 0, new DateTime(2020, 12, 2, 3, 35, 0, 0, DateTimeKind.Unspecified), 3, 80 },
                    { 36, "User Delete", 52, 0, "Meta data example 26", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), 3, 77 },
                    { 32, "User Add", 44, 0, "Meta data example 22", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 2, 65 },
                    { 34, "User Activity Log", 48, 0, "Meta data example 24", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 20, 71 },
                    { 33, "User Delete", 46, 0, "Meta data example 23", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 8, 37, 0, 0, DateTimeKind.Unspecified), 3, 68 },
                    { 39, "User Delete", 58, 0, "Meta data example 29", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 3, 86 },
                    { 35, "User Delete", 50, 0, "Meta data example 25", "DE_DIEU", 0, 0, new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified), 3, 74 },
                    { 40, "User Edit", 60, 0, "Meta data example 30", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 4, 89 },
                    { 44, "User Delete", 68, 0, "Meta data example 34", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 3, 101 },
                    { 42, "User Delete", 64, 0, "Meta data example 32", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 3, 95 },
                    { 43, "User Delete", 66, 0, "Meta data example 33", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 3, 98 },
                    { 45, "User Edit", 70, 0, "Meta data example 35", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 4, 104 },
                    { 46, "User Activity Log", 72, 0, "Meta data example 36", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 20, 107 },
                    { 47, "User Add", 74, 0, "Meta data example 37", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 2, 14, 11, 0, 0, DateTimeKind.Unspecified), 2, 110 },
                    { 48, "User Add", 76, 0, "Meta data example 38", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 2, 113 },
                    { 49, "User Add", 78, 0, "Meta data example 39", "DE_DIEU", 0, 0, new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 2, 116 },
                    { 31, "User Edit", 42, 0, "Meta data example 21", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 6, 27, 0, 0, DateTimeKind.Unspecified), 4, 62 },
                    { 41, "User Edit", 62, 0, "Meta data example 31", "DE_DIEU", 0, 0, new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 4, 92 },
                    { 30, "User Edit", 40, 0, "Meta data example 20", "DE_DIEU", 0, 0, new DateTime(2020, 12, 2, 3, 4, 0, 0, DateTimeKind.Unspecified), 4, 59 },
                    { 29, "User Activity Log", 38, 0, "Meta data example 19", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 20, 56 },
                    { 28, "User Add", 36, 0, "Meta data example 18", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 16, 33, 0, 0, DateTimeKind.Unspecified), 2, 53 },
                    { 10, "User Edit", 0, 0, "Meta data example 0", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 2, 47, 0, 0, DateTimeKind.Unspecified), 4, -1 },
                    { 11, "User Add", 2, 0, "Meta data example 1", "DE_DIEU", 0, 0, new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 12, "User Delete", 4, 0, "Meta data example 2", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 1, 33, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 13, "User Add", 6, 0, "Meta data example 3", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 3, 23, 0, 0, DateTimeKind.Unspecified), 2, 8 },
                    { 14, "User Delete", 8, 0, "Meta data example 4", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 3, 11 },
                    { 16, "User Edit", 12, 0, "Meta data example 6", "DE_DIEU", 0, 0, new DateTime(2020, 12, 2, 17, 48, 0, 0, DateTimeKind.Unspecified), 4, 17 },
                    { 17, "User Activity Log", 14, 0, "Meta data example 7", "DE_DIEU", 0, 0, new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 20, 20 },
                    { 18, "User Edit", 16, 0, "Meta data example 8", "DE_DIEU", 0, 0, new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 4, 23 },
                    { 15, "User Delete", 10, 0, "Meta data example 5", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 3, 14 },
                    { 20, "User Add", 20, 0, "Meta data example 10", "DE_DIEU", 0, 0, new DateTime(2020, 12, 2, 10, 40, 0, 0, DateTimeKind.Unspecified), 2, 29 },
                    { 19, "User Add", 18, 0, "Meta data example 9", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), 2, 26 },
                    { 26, "User Activity Log", 32, 0, "Meta data example 16", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 20, 47 },
                    { 25, "User Delete", 30, 0, "Meta data example 15", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 1, 11, 11, 0, 0, DateTimeKind.Unspecified), 3, 44 },
                    { 24, "User Activity Log", 28, 0, "Meta data example 14", "CHAY_RUNG", 0, 0, new DateTime(2020, 12, 2, 7, 21, 0, 0, DateTimeKind.Unspecified), 20, 41 },
                    { 27, "User Add", 34, 0, "Meta data example 17", "DE_DIEU", 0, 0, new DateTime(2020, 12, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 2, 50 },
                    { 22, "User Edit", 24, 0, "Meta data example 12", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 4, 35 },
                    { 21, "User Activity Log", 22, 0, "Meta data example 11", "DE_DIEU", 0, 0, new DateTime(2020, 12, 1, 11, 19, 0, 0, DateTimeKind.Unspecified), 20, 32 },
                    { 23, "User Edit", 26, 0, "Meta data example 13", "CAY_TRONG", 0, 0, new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 4, 38 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "DroneId", "EntityId", "Name", "ProjectType", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Video Activity Log", 0, 58, "Video PM", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "Video Edit", 0, 44, "Video GQ", "DE_DIEU", "0", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Video Edit", 0, 46, "Video GO", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Video Add", 0, 48, "Video CA", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 14, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Video Delete", 0, 50, "Video BD", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Video Edit", 0, 52, "Video VC", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "Video Add", 0, 54, "Video DX", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 4, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Video Edit", 0, 56, "Video DV", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Video Activity Log", 0, 78, "Video WD", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "Video Edit", 0, 76, "Video FR", "DE_DIEU", "0", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Video Delete", 0, 62, "Video ST", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Video Delete", 0, 64, "Video NL", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Video Activity Log", 0, 66, "Video XN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Video Add", 0, 68, "Video AY", "CAY_TRONG", "0", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Video Activity Log", 0, 70, "Video GP", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 7, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "Video Edit", 0, 72, "Video IB", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 1, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Video Edit", 0, 74, "Video UN", "DE_DIEU", "1", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Video Delete", 0, 42, "Video GG", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 5, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Video Add", 0, 60, "Video QN", "DE_DIEU", "0", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Video Delete", 0, 40, "Video UV", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Video Edit", 0, 18, "Video CB", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Video Edit", 0, 36, "Video DW", "CHAY_RUNG", "0", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Video Delete", 0, 38, "Video JT", "DE_DIEU", "1", new DateTime(2020, 12, 2, 10, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Video Add", 0, 0, "Video RJ", "DE_DIEU", "0", new DateTime(2020, 12, 1, 2, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Video Activity Log", 0, 2, "Video OD", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "Video Delete", 0, 4, "Video YN", "DE_DIEU", "0", new DateTime(2020, 12, 1, 1, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Video Edit", 0, 6, "Video UF", "DE_DIEU", "1", new DateTime(2020, 12, 2, 6, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Video Delete", 0, 10, "Video LI", "DE_DIEU", "1", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Video Add", 0, 12, "Video PQ", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 1, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Video Add", 0, 14, "Video VX", "DE_DIEU", "1", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Video Edit", 0, 8, "Video GR", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 6, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Video Delete", 0, 20, "Video NO", "DE_DIEU", "0", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Video Delete", 0, 22, "Video QC", "CAY_TRONG", "1", new DateTime(2020, 12, 2, 17, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Video Add", 0, 24, "Video WF", "DE_DIEU", "0", new DateTime(2020, 12, 1, 9, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Video Delete", 0, 34, "Video SQ", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 13, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "Video Activity Log", 0, 26, "Video OF", "CHAY_RUNG", "1", new DateTime(2020, 12, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Video Add", 0, 28, "Video RF", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Video Edit", 0, 30, "Video TU", "CAY_TRONG", "1", new DateTime(2020, 12, 1, 9, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Video Edit", 0, 32, "Video EK", "CAY_TRONG", "0", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Video Delete", 0, 16, "Video VW", "CHAY_RUNG", "0", new DateTime(2020, 12, 1, 8, 11, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "ProjectType", "RegionId", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 36, "Warning Add", 52, "Warning KO", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Warning Delete", 50, "Warning PM", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 8, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Warning Delete", 42, "Warning BP", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Warning Edit", 46, "Warning LG", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Warning Edit", 44, "Warning FN", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 4, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "Warning Add", 54, "Warning MM", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Warning Edit", 48, "Warning MI", "DE_DIEU", 0, "0", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Warning Edit", 56, "Warning RA", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Warning Activity Log", 74, "Warning WH", "DE_DIEU", 0, "1", new DateTime(2020, 12, 2, 12, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "Warning Delete", 60, "Warning SO", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Warning Delete", 62, "Warning EA", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Warning Edit", 64, "Warning RM", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Warning Delete", 66, "Warning VF", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 5, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Warning Delete", 68, "Warning HF", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Warning Edit", 70, "Warning FN", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 6, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Warning Add", 72, "Warning JG", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 13, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Warning Add", 40, "Warning DW", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 1, 1, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Warning Activity Log", 58, "Warning AD", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Warning Add", 38, "Warning RX", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 3, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Warning Edit", 20, "Warning AH", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 15, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Warning Activity Log", 34, "Warning AM", "CHAY_RUNG", 0, "1", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "Warning Delete", 76, "Warning YQ", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Warning Delete", 0, "Warning JB", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Warning Edit", 2, "Warning WA", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 8, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Warning Edit", 4, "Warning AZ", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Warning Edit", 6, "Warning PA", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 14, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Warning Activity Log", 8, "Warning NH", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Warning Add", 10, "Warning MZ", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 13, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Warning Edit", 12, "Warning MY", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Warning Edit", 14, "Warning AB", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Warning Activity Log", 16, "Warning ZY", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Warning Delete", 18, "Warning DQ", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Warning Edit", 22, "Warning ZR", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "Warning Edit", 24, "Warning GG", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 9, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Warning Add", 26, "Warning EQ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 5, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Warning Add", 28, "Warning OX", "DE_DIEU", 0, "0", new DateTime(2020, 12, 2, 12, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Warning Edit", 30, "Warning KV", "CAY_TRONG", 0, "1", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Warning Activity Log", 32, "Warning RX", "CAY_TRONG", 0, "0", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "Warning Edit", 36, "Warning WI", "CHAY_RUNG", 0, "0", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Warning Delete", 78, "Warning QJ", "DE_DIEU", 0, "1", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified), 3 }
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
