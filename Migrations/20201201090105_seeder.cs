using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class seeder : Migration
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegionName = table.Column<string>(nullable: true),
                    Longitude = table.Column<int>(nullable: false),
                    Latitude = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticalLogs", x => x.EntityLogPrimaryKeyId);
                });

            migrationBuilder.CreateTable(
                name: "UavConnectLogs",
                columns: table => new
                {
                    EntityLogPrimaryKeyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Metadata = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
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
                    EntityId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
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
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "Drone Delete", 44, 38, 18, "Drone TF", "MNVZB", new DateTime(2020, 12, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Drone Delete", 46, 20, 34, "Drone BB", "SCEKC", new DateTime(2020, 12, 2, 7, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Drone Add", 48, 44, 30, "Drone PZ", "HSSTI", new DateTime(2020, 12, 1, 7, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Drone Edit", 50, 49, 22, "Drone ZR", "LWOSS", new DateTime(2020, 12, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Drone Edit", 52, 27, 29, "Drone YL", "AZHNZ", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "Drone Add", 54, 19, 41, "Drone HO", "DPWCY", new DateTime(2020, 12, 2, 13, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Drone Edit", 58, 36, 17, "Drone MW", "OYNEF", new DateTime(2020, 12, 1, 2, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Drone Edit", 60, 46, 13, "Drone OA", "LKKCT", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Drone Delete", 62, 47, 28, "Drone WZ", "GSQST", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Drone Add", 64, 28, 42, "Drone LT", "HOMKY", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Drone Add", 66, 18, 37, "Drone GV", "RKYBL", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Drone Delete", 68, 29, 15, "Drone LF", "TDRNX", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Drone Edit", 70, 39, 28, "Drone PD", "ISZHJ", new DateTime(2020, 12, 1, 11, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Drone Edit", 72, 41, 10, "Drone MV", "ZJXQA", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Drone Edit", 74, 23, 26, "Drone ZX", "QKLIP", new DateTime(2020, 12, 2, 12, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Drone Add", 76, 41, 46, "Drone LH", "WAZQF", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Drone Edit", 78, 10, 29, "Drone MQ", "IVBGL", new DateTime(2020, 12, 1, 14, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Drone Delete", 42, 40, 21, "Drone ST", "AHIIY", new DateTime(2020, 12, 2, 2, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Drone Delete", 40, 28, 40, "Drone CS", "UIFPF", new DateTime(2020, 12, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "Drone Edit", 56, 43, 15, "Drone AI", "FIBGZ", new DateTime(2020, 12, 1, 14, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Drone Add", 36, 45, 40, "Drone BI", "ZENPA", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Drone Delete", 38, 30, 20, "Drone VY", "MUQUB", new DateTime(2020, 12, 2, 5, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Drone Add", 2, 37, 31, "Drone FY", "IJQYI", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Drone Add", 4, 20, 39, "Drone VX", "KKRQU", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Drone Edit", 6, 13, 42, "Drone MW", "IKONV", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Drone Add", 8, 45, 21, "Drone QS", "KOSTV", new DateTime(2020, 12, 1, 11, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Drone Edit", 10, 47, 44, "Drone AO", "SGNCJ", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Drone Add", 12, 14, 13, "Drone OM", "GOWFS", new DateTime(2020, 12, 1, 8, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Drone Add", 14, 49, 23, "Drone WL", "SYEHP", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Drone Edit", 16, 37, 17, "Drone FM", "MOOUM", new DateTime(2020, 12, 2, 14, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Drone Add", 0, 47, 36, "Drone DK", "WPVNS", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Drone Add", 20, 41, 49, "Drone QJ", "WLHHP", new DateTime(2020, 12, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Drone Edit", 18, 37, 47, "Drone UO", "RWXNI", new DateTime(2020, 12, 1, 12, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Drone Add", 32, 49, 32, "Drone SV", "QATQE", new DateTime(2020, 12, 2, 17, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Drone Edit", 30, 37, 48, "Drone OI", "ESSUD", new DateTime(2020, 12, 2, 11, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Drone Edit", 28, 39, 10, "Drone EF", "KWKEO", new DateTime(2020, 12, 1, 9, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Drone Add", 34, 14, 21, "Drone NF", "VFFNC", new DateTime(2020, 12, 2, 13, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Drone Edit", 24, 43, 16, "Drone TQ", "URPVM", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Drone Edit", 22, 36, 14, "Drone LF", "CRBXL", new DateTime(2020, 12, 2, 14, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Drone Add", 26, 16, 19, "Drone YS", "BCOVQ", new DateTime(2020, 12, 2, 15, 13, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Image Edit", 58, "Image AF", "1", new DateTime(2020, 12, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Image Edit", 46, "Image PW", "1", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Image Add", 48, "Image PC", "0", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Image Add", 50, "Image SR", "1", new DateTime(2020, 12, 2, 2, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Image Edit", 52, "Image NT", "0", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "Image Delete", 54, "Image GY", "1", new DateTime(2020, 12, 2, 13, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "Image Add", 44, "Image OE", "0", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Image Add", 56, "Image YO", "0", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Image Edit", 60, "Image PO", "0", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Image Add", 68, "Image WS", "0", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Image Edit", 64, "Image MY", "0", new DateTime(2020, 12, 2, 7, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Image Delete", 66, "Image KL", "1", new DateTime(2020, 12, 1, 8, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Image Add", 70, "Image SX", "1", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Image Edit", 72, "Image ZL", "0", new DateTime(2020, 12, 2, 14, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Image Add", 74, "Image HE", "1", new DateTime(2020, 12, 2, 4, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Image Add", 76, "Image VA", "0", new DateTime(2020, 12, 1, 15, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Image Edit", 78, "Image LJ", "1", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Image Edit", 42, "Image HZ", "1", new DateTime(2020, 12, 2, 7, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Image Delete", 62, "Image NA", "1", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Image Delete", 40, "Image GU", "0", new DateTime(2020, 12, 2, 2, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Image Add", 16, "Image TU", "0", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Image Add", 36, "Image ER", "0", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Image Add", 38, "Image RU", "1", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Image Edit", 2, "Image ND", "1", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Image Add", 4, "Image AZ", "0", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Image Add", 6, "Image ZZ", "1", new DateTime(2020, 12, 2, 14, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Image Delete", 8, "Image NB", "0", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Image Add", 10, "Image CF", "1", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Image Delete", 12, "Image JO", "0", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "Image Edit", 14, "Image XE", "1", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Image Add", 0, "Image OH", "0", new DateTime(2020, 12, 2, 2, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Image Edit", 34, "Image MU", "1", new DateTime(2020, 12, 1, 15, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Image Edit", 20, "Image AS", "0", new DateTime(2020, 12, 1, 3, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Image Add", 22, "Image JI", "1", new DateTime(2020, 12, 2, 1, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Image Edit", 24, "Image GD", "0", new DateTime(2020, 12, 1, 11, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Image Edit", 26, "Image HN", "1", new DateTime(2020, 12, 1, 2, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Image Add", 28, "Image GH", "0", new DateTime(2020, 12, 1, 4, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Image Delete", 30, "Image ZG", "1", new DateTime(2020, 12, 2, 13, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Image Delete", 32, "Image IZ", "0", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Image Edit", 18, "Image GG", "1", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Incident Add", 54, "Incident DR", "1", new DateTime(2020, 12, 2, 14, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Incident Delete", 52, "Incident PN", "0", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Incident Delete", 50, "Incident NF", "1", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Incident Delete", 42, "Incident WG", "1", new DateTime(2020, 12, 2, 17, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Incident Add", 46, "Incident QQ", "1", new DateTime(2020, 12, 1, 10, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Incident Edit", 44, "Incident WV", "0", new DateTime(2020, 12, 2, 1, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Incident Edit", 58, "Incident SH", "1", new DateTime(2020, 12, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Incident Delete", 48, "Incident SR", "0", new DateTime(2020, 12, 1, 6, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Incident Edit", 60, "Incident NN", "0", new DateTime(2020, 12, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "Incident Add", 70, "Incident PB", "1", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Incident Delete", 64, "Incident AT", "0", new DateTime(2020, 12, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Incident Edit", 66, "Incident UX", "1", new DateTime(2020, 12, 1, 4, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Incident Add", 68, "Incident BE", "0", new DateTime(2020, 12, 2, 11, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Incident Add", 72, "Incident YL", "0", new DateTime(2020, 12, 2, 1, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Incident Delete", 74, "Incident KP", "1", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Incident Delete", 76, "Incident MD", "0", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Incident Edit", 78, "Incident MN", "1", new DateTime(2020, 12, 1, 1, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Incident Edit", 62, "Incident UJ", "1", new DateTime(2020, 12, 1, 15, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Incident Delete", 40, "Incident GP", "0", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "Incident Add", 56, "Incident IU", "0", new DateTime(2020, 12, 2, 5, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Incident Add", 36, "Incident YP", "0", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Incident Delete", 2, "Incident EY", "1", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Incident Delete", 4, "Incident CM", "0", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Incident Add", 6, "Incident VI", "1", new DateTime(2020, 12, 2, 6, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Incident Edit", 8, "Incident BP", "0", new DateTime(2020, 12, 2, 6, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Incident Add", 10, "Incident KJ", "1", new DateTime(2020, 12, 2, 9, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Incident Add", 12, "Incident HI", "0", new DateTime(2020, 12, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Incident Add", 14, "Incident VQ", "1", new DateTime(2020, 12, 2, 15, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Incident Add", 16, "Incident GH", "0", new DateTime(2020, 12, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Incident Add", 18, "Incident MW", "1", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Incident Add", 0, "Incident LQ", "0", new DateTime(2020, 12, 1, 8, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Incident Add", 38, "Incident FX", "1", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Incident Add", 22, "Incident FO", "1", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Incident Delete", 24, "Incident TV", "0", new DateTime(2020, 12, 1, 1, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "Incident Delete", 26, "Incident PZ", "1", new DateTime(2020, 12, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Incident Delete", 28, "Incident PA", "0", new DateTime(2020, 12, 2, 12, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "Incident Delete", 30, "Incident TC", "1", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Incident Add", 32, "Incident VT", "0", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Incident Add", 34, "Incident TS", "1", new DateTime(2020, 12, 2, 14, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Incident Delete", 20, "Incident OM", "0", new DateTime(2020, 12, 2, 10, 34, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "MonitorRegion Add", 54, "MonitorRegion JZ", "1", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "MonitorRegion Add", 52, "MonitorRegion NS", "0", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "MonitorRegion Edit", 44, "MonitorRegion EF", "0", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "MonitorRegion Add", 48, "MonitorRegion RT", "0", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "MonitorRegion Add", 46, "MonitorRegion DQ", "1", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "MonitorRegion Edit", 56, "MonitorRegion QW", "0", new DateTime(2020, 12, 1, 10, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "MonitorRegion Delete", 50, "MonitorRegion GN", "1", new DateTime(2020, 12, 2, 7, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "MonitorRegion Edit", 58, "MonitorRegion UV", "1", new DateTime(2020, 12, 1, 11, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "MonitorRegion Add", 68, "MonitorRegion SW", "0", new DateTime(2020, 12, 2, 8, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "MonitorRegion Delete", 62, "MonitorRegion OL", "1", new DateTime(2020, 12, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "MonitorRegion Edit", 64, "MonitorRegion IX", "0", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "MonitorRegion Add", 66, "MonitorRegion KF", "1", new DateTime(2020, 12, 1, 3, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "MonitorRegion Delete", 70, "MonitorRegion IW", "1", new DateTime(2020, 12, 1, 13, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "MonitorRegion Delete", 72, "MonitorRegion XJ", "0", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "MonitorRegion Add", 74, "MonitorRegion SA", "1", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "MonitorRegion Edit", 76, "MonitorRegion BI", "0", new DateTime(2020, 12, 2, 15, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "MonitorRegion Delete", 42, "MonitorRegion NM", "1", new DateTime(2020, 12, 1, 7, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "MonitorRegion Delete", 60, "MonitorRegion BK", "0", new DateTime(2020, 12, 1, 5, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "MonitorRegion Add", 40, "MonitorRegion SM", "0", new DateTime(2020, 12, 2, 3, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "MonitorRegion Delete", 78, "MonitorRegion NW", "1", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "MonitorRegion Delete", 36, "MonitorRegion QO", "0", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "MonitorRegion Edit", 0, "MonitorRegion MV", "0", new DateTime(2020, 12, 1, 12, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "MonitorRegion Add", 2, "MonitorRegion LR", "1", new DateTime(2020, 12, 2, 17, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "MonitorRegion Edit", 4, "MonitorRegion MM", "0", new DateTime(2020, 12, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "MonitorRegion Edit", 6, "MonitorRegion WT", "1", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "MonitorRegion Delete", 8, "MonitorRegion RC", "0", new DateTime(2020, 12, 2, 1, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "MonitorRegion Add", 10, "MonitorRegion OA", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "MonitorRegion Add", 12, "MonitorRegion XV", "0", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "MonitorRegion Add", 14, "MonitorRegion YY", "1", new DateTime(2020, 12, 2, 8, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "MonitorRegion Delete", 16, "MonitorRegion CP", "0", new DateTime(2020, 12, 2, 7, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "MonitorRegion Edit", 38, "MonitorRegion NJ", "1", new DateTime(2020, 12, 2, 16, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "MonitorRegion Add", 20, "MonitorRegion KZ", "0", new DateTime(2020, 12, 1, 5, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "MonitorRegion Add", 22, "MonitorRegion MZ", "1", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "MonitorRegion Edit", 24, "MonitorRegion XT", "0", new DateTime(2020, 12, 2, 1, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "MonitorRegion Delete", 26, "MonitorRegion DI", "1", new DateTime(2020, 12, 2, 13, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "MonitorRegion Edit", 28, "MonitorRegion KT", "0", new DateTime(2020, 12, 1, 3, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "MonitorRegion Add", 30, "MonitorRegion KO", "1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "MonitorRegion Edit", 32, "MonitorRegion AB", "0", new DateTime(2020, 12, 2, 3, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "MonitorRegion Delete", 34, "MonitorRegion NG", "1", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "MonitorRegion Add", 18, "MonitorRegion AA", "1", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ObjectObserve Delete", 54, "ObjectObserve DS", "1", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "ObjectObserve Edit", 52, "ObjectObserve XR", "0", new DateTime(2020, 12, 2, 7, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "ObjectObserve Edit", 50, "ObjectObserve OB", "1", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "ObjectObserve Delete", 42, "ObjectObserve DN", "1", new DateTime(2020, 12, 2, 10, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "ObjectObserve Add", 46, "ObjectObserve VC", "1", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "ObjectObserve Edit", 44, "ObjectObserve GN", "0", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "ObjectObserve Edit", 56, "ObjectObserve EZ", "0", new DateTime(2020, 12, 1, 3, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ObjectObserve Add", 48, "ObjectObserve JA", "0", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "ObjectObserve Add", 58, "ObjectObserve LQ", "1", new DateTime(2020, 12, 2, 11, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "ObjectObserve Delete", 66, "ObjectObserve AQ", "1", new DateTime(2020, 12, 2, 10, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "ObjectObserve Delete", 62, "ObjectObserve DU", "1", new DateTime(2020, 12, 1, 9, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "ObjectObserve Edit", 64, "ObjectObserve OO", "0", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "ObjectObserve Add", 68, "ObjectObserve TY", "0", new DateTime(2020, 12, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "ObjectObserve Delete", 70, "ObjectObserve ZC", "1", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "ObjectObserve Delete", 72, "ObjectObserve ZD", "0", new DateTime(2020, 12, 1, 13, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "ObjectObserve Add", 74, "ObjectObserve OS", "1", new DateTime(2020, 12, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "ObjectObserve Edit", 76, "ObjectObserve JB", "0", new DateTime(2020, 12, 1, 15, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "ObjectObserve Edit", 40, "ObjectObserve ED", "0", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "ObjectObserve Delete", 60, "ObjectObserve LD", "0", new DateTime(2020, 12, 2, 12, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "ObjectObserve Delete", 78, "ObjectObserve XZ", "1", new DateTime(2020, 12, 1, 6, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "ObjectObserve Delete", 38, "ObjectObserve QN", "1", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "ObjectObserve Add", 34, "ObjectObserve MM", "1", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "ObjectObserve Edit", 36, "ObjectObserve SI", "0", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "ObjectObserve Delete", 0, "ObjectObserve BD", "0", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "ObjectObserve Delete", 2, "ObjectObserve CC", "1", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "ObjectObserve Add", 4, "ObjectObserve QX", "0", new DateTime(2020, 12, 2, 9, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "ObjectObserve Delete", 6, "ObjectObserve ZM", "1", new DateTime(2020, 12, 1, 1, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "ObjectObserve Delete", 10, "ObjectObserve XB", "1", new DateTime(2020, 12, 1, 9, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "ObjectObserve Delete", 12, "ObjectObserve AT", "0", new DateTime(2020, 12, 1, 5, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "ObjectObserve Edit", 14, "ObjectObserve TU", "1", new DateTime(2020, 12, 1, 6, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "ObjectObserve Delete", 8, "ObjectObserve VU", "0", new DateTime(2020, 12, 1, 14, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "ObjectObserve Edit", 18, "ObjectObserve NH", "1", new DateTime(2020, 12, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "ObjectObserve Add", 20, "ObjectObserve LN", "0", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "ObjectObserve Add", 22, "ObjectObserve IT", "1", new DateTime(2020, 12, 1, 7, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "ObjectObserve Edit", 24, "ObjectObserve UY", "0", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "ObjectObserve Add", 26, "ObjectObserve ZY", "1", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "ObjectObserve Add", 28, "ObjectObserve RZ", "0", new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "ObjectObserve Edit", 30, "ObjectObserve XO", "1", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "ObjectObserve Edit", 16, "ObjectObserve OD", "0", new DateTime(2020, 12, 1, 2, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "ObjectObserve Edit", 32, "ObjectObserve UP", "0", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "Payload Edit", 56, "Payload DB", "0", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 37, "Payload Add", 54, "Payload WM", "1", new DateTime(2020, 12, 2, 16, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Payload Edit", 52, "Payload YI", "0", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Payload Edit", 44, "Payload TR", "0", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Payload Edit", 48, "Payload IU", "0", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Payload Edit", 46, "Payload SK", "1", new DateTime(2020, 12, 2, 12, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Payload Add", 58, "Payload MV", "1", new DateTime(2020, 12, 1, 6, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Payload Edit", 50, "Payload WE", "1", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Payload Add", 60, "Payload PJ", "0", new DateTime(2020, 12, 1, 15, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Payload Edit", 78, "Payload EP", "1", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "Payload Edit", 64, "Payload WQ", "0", new DateTime(2020, 12, 2, 10, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Payload Delete", 66, "Payload XA", "1", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Payload Add", 68, "Payload QA", "0", new DateTime(2020, 12, 1, 13, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Payload Add", 70, "Payload OE", "1", new DateTime(2020, 12, 2, 11, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Payload Add", 72, "Payload HQ", "0", new DateTime(2020, 12, 1, 4, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Payload Delete", 74, "Payload UP", "1", new DateTime(2020, 12, 2, 17, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Payload Delete", 76, "Payload CA", "0", new DateTime(2020, 12, 2, 12, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Payload Edit", 42, "Payload SD", "1", new DateTime(2020, 12, 2, 4, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Payload Edit", 62, "Payload IT", "1", new DateTime(2020, 12, 2, 15, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Payload Add", 40, "Payload XK", "0", new DateTime(2020, 12, 1, 11, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Payload Add", 36, "Payload NT", "0", new DateTime(2020, 12, 1, 3, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Payload Edit", 38, "Payload NZ", "1", new DateTime(2020, 12, 2, 1, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Payload Add", 0, "Payload HG", "0", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Payload Add", 2, "Payload BJ", "1", new DateTime(2020, 12, 2, 9, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Payload Add", 4, "Payload PG", "0", new DateTime(2020, 12, 1, 9, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Payload Add", 6, "Payload RW", "1", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Payload Delete", 8, "Payload AW", "0", new DateTime(2020, 12, 2, 11, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Payload Edit", 12, "Payload LJ", "0", new DateTime(2020, 12, 2, 12, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Payload Delete", 14, "Payload NM", "1", new DateTime(2020, 12, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Payload Delete", 16, "Payload CB", "0", new DateTime(2020, 12, 2, 16, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Payload Add", 10, "Payload IU", "1", new DateTime(2020, 12, 1, 1, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Payload Delete", 20, "Payload OE", "0", new DateTime(2020, 12, 1, 1, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Payload Add", 18, "Payload FK", "1", new DateTime(2020, 12, 2, 6, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Payload Delete", 32, "Payload TT", "0", new DateTime(2020, 12, 2, 5, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "Payload Delete", 30, "Payload TV", "1", new DateTime(2020, 12, 1, 2, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Payload Edit", 28, "Payload IN", "0", new DateTime(2020, 12, 1, 4, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Payload Delete", 34, "Payload MA", "1", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Payload Delete", 24, "Payload XW", "0", new DateTime(2020, 12, 2, 17, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Payload Edit", 22, "Payload IB", "1", new DateTime(2020, 12, 2, 14, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Payload Delete", 26, "Payload RK", "1", new DateTime(2020, 12, 1, 1, 5, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 40, "ResolveProblem Delete", 60, "ResolveProblem HZ", "0", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "ResolveProblem Edit", 46, "ResolveProblem RU", "1", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ResolveProblem Edit", 48, "ResolveProblem JJ", "0", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "ResolveProblem Edit", 50, "ResolveProblem FB", "1", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "ResolveProblem Delete", 52, "ResolveProblem ZY", "0", new DateTime(2020, 12, 1, 15, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "ResolveProblem Delete", 54, "ResolveProblem MN", "1", new DateTime(2020, 12, 2, 8, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "ResolveProblem Add", 56, "ResolveProblem LA", "0", new DateTime(2020, 12, 2, 10, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "ResolveProblem Edit", 58, "ResolveProblem LA", "1", new DateTime(2020, 12, 2, 4, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "ResolveProblem Delete", 62, "ResolveProblem ZH", "1", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "ResolveProblem Edit", 40, "ResolveProblem WF", "0", new DateTime(2020, 12, 2, 7, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "ResolveProblem Add", 66, "ResolveProblem IU", "1", new DateTime(2020, 12, 2, 8, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "ResolveProblem Delete", 68, "ResolveProblem GN", "0", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "ResolveProblem Delete", 70, "ResolveProblem ZA", "1", new DateTime(2020, 12, 2, 17, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "ResolveProblem Delete", 72, "ResolveProblem RK", "0", new DateTime(2020, 12, 2, 2, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "ResolveProblem Edit", 74, "ResolveProblem XY", "1", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "ResolveProblem Delete", 76, "ResolveProblem HK", "0", new DateTime(2020, 12, 1, 7, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "ResolveProblem Edit", 78, "ResolveProblem LT", "1", new DateTime(2020, 12, 1, 13, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "ResolveProblem Add", 44, "ResolveProblem QF", "0", new DateTime(2020, 12, 2, 10, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "ResolveProblem Add", 64, "ResolveProblem EZ", "0", new DateTime(2020, 12, 1, 12, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "ResolveProblem Delete", 42, "ResolveProblem FG", "1", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "ResolveProblem Edit", 28, "ResolveProblem EH", "0", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "ResolveProblem Delete", 38, "ResolveProblem YK", "1", new DateTime(2020, 12, 2, 1, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "ResolveProblem Delete", 0, "ResolveProblem AK", "0", new DateTime(2020, 12, 2, 8, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "ResolveProblem Delete", 2, "ResolveProblem TC", "1", new DateTime(2020, 12, 1, 14, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "ResolveProblem Add", 4, "ResolveProblem YC", "0", new DateTime(2020, 12, 1, 5, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "ResolveProblem Add", 6, "ResolveProblem QY", "1", new DateTime(2020, 12, 1, 13, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "ResolveProblem Delete", 8, "ResolveProblem WC", "0", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "ResolveProblem Delete", 10, "ResolveProblem SR", "1", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "ResolveProblem Edit", 14, "ResolveProblem GW", "1", new DateTime(2020, 12, 2, 6, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "ResolveProblem Delete", 16, "ResolveProblem JI", "0", new DateTime(2020, 12, 1, 1, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "ResolveProblem Delete", 18, "ResolveProblem SN", "1", new DateTime(2020, 12, 2, 12, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "ResolveProblem Add", 12, "ResolveProblem NH", "0", new DateTime(2020, 12, 1, 12, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "ResolveProblem Add", 22, "ResolveProblem RK", "1", new DateTime(2020, 12, 2, 15, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "ResolveProblem Add", 20, "ResolveProblem JU", "0", new DateTime(2020, 12, 2, 2, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "ResolveProblem Delete", 34, "ResolveProblem JA", "1", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "ResolveProblem Edit", 32, "ResolveProblem EI", "0", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "ResolveProblem Delete", 30, "ResolveProblem KV", "1", new DateTime(2020, 12, 1, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "ResolveProblem Delete", 36, "ResolveProblem QU", "0", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "ResolveProblem Edit", 26, "ResolveProblem EK", "1", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "ResolveProblem Edit", 24, "ResolveProblem YY", "0", new DateTime(2020, 12, 1, 13, 28, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "Statical Delete", 44, "Statical WK", "0", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Statical Edit", 46, "Statical FJ", "1", new DateTime(2020, 12, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Statical Add", 48, "Statical FS", "0", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Statical Edit", 50, "Statical AK", "1", new DateTime(2020, 12, 2, 2, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Statical Delete", 52, "Statical II", "0", new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "Statical Delete", 54, "Statical PR", "1", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "Statical Edit", 56, "Statical BR", "0", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Statical Edit", 58, "Statical VG", "1", new DateTime(2020, 12, 2, 6, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Statical Edit", 60, "Statical LT", "0", new DateTime(2020, 12, 2, 5, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Statical Delete", 78, "Statical LL", "1", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Statical Add", 64, "Statical LS", "0", new DateTime(2020, 12, 2, 1, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Statical Delete", 66, "Statical TY", "1", new DateTime(2020, 12, 1, 11, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Statical Edit", 68, "Statical ZR", "0", new DateTime(2020, 12, 1, 6, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "Statical Delete", 70, "Statical JM", "1", new DateTime(2020, 12, 1, 14, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "Statical Edit", 72, "Statical WQ", "0", new DateTime(2020, 12, 1, 2, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Statical Edit", 74, "Statical YB", "1", new DateTime(2020, 12, 2, 1, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Statical Add", 76, "Statical XZ", "0", new DateTime(2020, 12, 1, 6, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "Statical Delete", 42, "Statical MQ", "1", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Statical Delete", 62, "Statical AY", "1", new DateTime(2020, 12, 1, 3, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Statical Delete", 40, "Statical OD", "0", new DateTime(2020, 12, 1, 7, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Statical Delete", 0, "Statical XV", "0", new DateTime(2020, 12, 1, 8, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Statical Edit", 36, "Statical RG", "0", new DateTime(2020, 12, 2, 3, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Statical Delete", 38, "Statical KN", "1", new DateTime(2020, 12, 1, 12, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Statical Edit", 2, "Statical RK", "1", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Statical Edit", 4, "Statical RF", "0", new DateTime(2020, 12, 2, 1, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Statical Add", 6, "Statical AA", "1", new DateTime(2020, 12, 2, 1, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Statical Delete", 8, "Statical IX", "0", new DateTime(2020, 12, 2, 6, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Statical Edit", 12, "Statical FE", "0", new DateTime(2020, 12, 2, 2, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Statical Edit", 14, "Statical QL", "1", new DateTime(2020, 12, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Statical Delete", 16, "Statical DW", "0", new DateTime(2020, 12, 1, 15, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Statical Add", 10, "Statical OK", "1", new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Statical Edit", 20, "Statical JQ", "0", new DateTime(2020, 12, 1, 12, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Statical Delete", 22, "Statical XD", "1", new DateTime(2020, 12, 1, 9, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Statical Edit", 24, "Statical EB", "0", new DateTime(2020, 12, 2, 8, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Statical Delete", 26, "Statical NH", "1", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Statical Edit", 28, "Statical FZ", "0", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Statical Add", 30, "Statical UG", "1", new DateTime(2020, 12, 1, 9, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Statical Edit", 32, "Statical WV", "0", new DateTime(2020, 12, 2, 11, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Statical Delete", 18, "Statical OU", "1", new DateTime(2020, 12, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Statical Edit", 34, "Statical RS", "1", new DateTime(2020, 12, 1, 4, 22, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "UavConnect Add", 56, "UavConnect TT", "0", new DateTime(2020, 12, 2, 5, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "UavConnect Add", 54, "UavConnect UX", "1", new DateTime(2020, 12, 2, 5, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "UavConnect Edit", 52, "UavConnect GG", "0", new DateTime(2020, 12, 2, 6, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "UavConnect Delete", 44, "UavConnect VU", "0", new DateTime(2020, 12, 2, 6, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "UavConnect Add", 48, "UavConnect WW", "0", new DateTime(2020, 12, 1, 1, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "UavConnect Edit", 46, "UavConnect PK", "1", new DateTime(2020, 12, 1, 11, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "UavConnect Delete", 42, "UavConnect DG", "1", new DateTime(2020, 12, 2, 12, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "UavConnect Delete", 50, "UavConnect JO", "1", new DateTime(2020, 12, 2, 13, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "UavConnect Edit", 58, "UavConnect ZP", "1", new DateTime(2020, 12, 2, 13, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "UavConnect Edit", 76, "UavConnect WZ", "0", new DateTime(2020, 12, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "UavConnect Add", 62, "UavConnect EZ", "1", new DateTime(2020, 12, 2, 16, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "UavConnect Edit", 64, "UavConnect ZL", "0", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "UavConnect Edit", 66, "UavConnect AV", "1", new DateTime(2020, 12, 2, 14, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "UavConnect Delete", 68, "UavConnect NR", "0", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "UavConnect Add", 70, "UavConnect CW", "1", new DateTime(2020, 12, 2, 1, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "UavConnect Edit", 72, "UavConnect PV", "0", new DateTime(2020, 12, 1, 9, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "UavConnect Delete", 74, "UavConnect QH", "1", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "UavConnect Add", 78, "UavConnect KK", "1", new DateTime(2020, 12, 2, 1, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "UavConnect Edit", 60, "UavConnect EX", "0", new DateTime(2020, 12, 2, 16, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "UavConnect Edit", 40, "UavConnect TZ", "0", new DateTime(2020, 12, 2, 12, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "UavConnect Edit", 20, "UavConnect LS", "0", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "UavConnect Add", 36, "UavConnect FF", "0", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "UavConnect Add", 0, "UavConnect JE", "0", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "UavConnect Add", 2, "UavConnect BJ", "1", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "UavConnect Edit", 4, "UavConnect DJ", "0", new DateTime(2020, 12, 2, 16, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "UavConnect Add", 6, "UavConnect SB", "1", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "UavConnect Add", 8, "UavConnect PR", "0", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "UavConnect Add", 10, "UavConnect VG", "1", new DateTime(2020, 12, 1, 5, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "UavConnect Add", 12, "UavConnect QM", "0", new DateTime(2020, 12, 2, 16, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "UavConnect Add", 14, "UavConnect DT", "1", new DateTime(2020, 12, 1, 9, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "UavConnect Delete", 38, "UavConnect OD", "1", new DateTime(2020, 12, 2, 13, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "UavConnect Add", 18, "UavConnect DS", "1", new DateTime(2020, 12, 2, 8, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "UavConnect Add", 22, "UavConnect UY", "1", new DateTime(2020, 12, 2, 4, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "UavConnect Delete", 24, "UavConnect LE", "0", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "UavConnect Add", 26, "UavConnect TV", "1", new DateTime(2020, 12, 2, 14, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "UavConnect Delete", 28, "UavConnect PY", "0", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "UavConnect Delete", 30, "UavConnect RI", "1", new DateTime(2020, 12, 2, 14, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "UavConnect Add", 32, "UavConnect GL", "0", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "UavConnect Add", 34, "UavConnect SU", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "UavConnect Delete", 16, "UavConnect XK", "0", new DateTime(2020, 12, 1, 1, 11, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Video Delete", 54, "Video JO", "1", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Video Delete", 52, "Video OJ", "0", new DateTime(2020, 12, 2, 12, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Video Add", 50, "Video VN", "1", new DateTime(2020, 12, 2, 2, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "Video Delete", 42, "Video AJ", "1", new DateTime(2020, 12, 1, 10, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Video Add", 46, "Video JI", "1", new DateTime(2020, 12, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Video Add", 44, "Video CP", "0", new DateTime(2020, 12, 2, 3, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Video Delete", 56, "Video KH", "0", new DateTime(2020, 12, 2, 9, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Video Delete", 48, "Video MI", "0", new DateTime(2020, 12, 2, 3, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "Video Edit", 58, "Video ME", "1", new DateTime(2020, 12, 1, 13, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Video Add", 66, "Video ZE", "1", new DateTime(2020, 12, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Video Delete", 62, "Video AZ", "1", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Video Delete", 64, "Video MQ", "0", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Video Add", 68, "Video ZK", "0", new DateTime(2020, 12, 2, 16, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Video Add", 70, "Video BD", "1", new DateTime(2020, 12, 1, 11, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Video Edit", 72, "Video VY", "0", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Video Delete", 74, "Video DR", "1", new DateTime(2020, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Video Edit", 40, "Video WL", "0", new DateTime(2020, 12, 2, 12, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Video Edit", 78, "Video AQ", "1", new DateTime(2020, 12, 1, 14, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Video Edit", 60, "Video KW", "0", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Video Edit", 76, "Video DN", "0", new DateTime(2020, 12, 2, 2, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Video Delete", 38, "Video FJ", "1", new DateTime(2020, 12, 1, 10, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Video Delete", 34, "Video QG", "1", new DateTime(2020, 12, 1, 13, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Video Add", 36, "Video TE", "0", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Video Delete", 0, "Video JN", "0", new DateTime(2020, 12, 1, 2, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Video Edit", 2, "Video AA", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Video Add", 4, "Video TB", "0", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Video Add", 6, "Video HG", "1", new DateTime(2020, 12, 1, 12, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Video Add", 10, "Video LK", "1", new DateTime(2020, 12, 1, 9, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Video Add", 12, "Video EG", "0", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Video Delete", 14, "Video FB", "1", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Video Edit", 8, "Video ND", "0", new DateTime(2020, 12, 2, 3, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Video Delete", 18, "Video HS", "1", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Video Edit", 16, "Video RI", "0", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Video Add", 30, "Video HT", "1", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Video Edit", 28, "Video RR", "0", new DateTime(2020, 12, 1, 4, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Video Edit", 26, "Video WY", "1", new DateTime(2020, 12, 2, 16, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Video Add", 32, "Video TJ", "0", new DateTime(2020, 12, 2, 1, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Video Delete", 22, "Video YB", "1", new DateTime(2020, 12, 1, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Video Add", 20, "Video XA", "0", new DateTime(2020, 12, 2, 12, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Video Edit", 24, "Video CV", "0", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Warning Delete", 54, "Warning GO", "1", new DateTime(2020, 12, 1, 13, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Warning Add", 42, "Warning VA", "1", new DateTime(2020, 12, 1, 5, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Warning Delete", 44, "Warning KT", "0", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Warning Add", 46, "Warning MC", "1", new DateTime(2020, 12, 2, 14, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Warning Delete", 48, "Warning DS", "0", new DateTime(2020, 12, 1, 15, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Warning Add", 50, "Warning XT", "1", new DateTime(2020, 12, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Warning Edit", 52, "Warning OW", "0", new DateTime(2020, 12, 1, 1, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Warning Edit", 56, "Warning PI", "0", new DateTime(2020, 12, 1, 6, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Warning Add", 40, "Warning XK", "0", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Warning Edit", 60, "Warning VE", "0", new DateTime(2020, 12, 2, 17, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "Warning Add", 62, "Warning QY", "1", new DateTime(2020, 12, 1, 11, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Warning Add", 64, "Warning EK", "0", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Warning Add", 66, "Warning LT", "1", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Warning Add", 68, "Warning FH", "0", new DateTime(2020, 12, 1, 7, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Warning Add", 70, "Warning UH", "1", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Warning Add", 72, "Warning QX", "0", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Warning Edit", 74, "Warning GY", "1", new DateTime(2020, 12, 2, 11, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Warning Add", 58, "Warning OO", "1", new DateTime(2020, 12, 1, 13, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Warning Add", 38, "Warning NY", "1", new DateTime(2020, 12, 2, 4, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Warning Add", 76, "Warning QR", "0", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Warning Delete", 34, "Warning KX", "1", new DateTime(2020, 12, 2, 13, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Warning Edit", 0, "Warning LA", "0", new DateTime(2020, 12, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Warning Add", 2, "Warning YT", "1", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Warning Delete", 4, "Warning TF", "0", new DateTime(2020, 12, 2, 1, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Warning Edit", 6, "Warning TP", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Warning Edit", 8, "Warning CP", "0", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Warning Delete", 10, "Warning UP", "1", new DateTime(2020, 12, 2, 17, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Warning Add", 12, "Warning OS", "0", new DateTime(2020, 12, 1, 7, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Warning Add", 14, "Warning YZ", "1", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Warning Delete", 16, "Warning AM", "0", new DateTime(2020, 12, 1, 7, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Warning Edit", 18, "Warning JC", "1", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Warning Edit", 20, "Warning TZ", "0", new DateTime(2020, 12, 1, 10, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Warning Add", 22, "Warning JI", "1", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Warning Edit", 24, "Warning SB", "0", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Warning Edit", 26, "Warning VP", "1", new DateTime(2020, 12, 1, 2, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Warning Add", 28, "Warning FD", "0", new DateTime(2020, 12, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Warning Add", 30, "Warning EV", "1", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Warning Delete", 32, "Warning UD", "0", new DateTime(2020, 12, 2, 6, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Warning Edit", 36, "Warning UM", "0", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Warning Edit", 78, "Warning EF", "1", new DateTime(2020, 12, 2, 1, 45, 0, 0, DateTimeKind.Unspecified), 4 }
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
