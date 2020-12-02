using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class Seeder1 : Migration
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
                name: "SystemLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Level = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
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
                    { 32, "Drone Add", 44, 30, 42, "Drone DT", "IXZZM", new DateTime(2020, 12, 2, 13, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Drone Delete", 46, 26, 11, "Drone VE", "JQZHK", new DateTime(2020, 12, 1, 15, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Drone Edit", 48, 45, 14, "Drone CY", "ICKJB", new DateTime(2020, 12, 2, 8, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "Drone Delete", 50, 43, 35, "Drone ZV", "RQGQI", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Drone Devide Monitor Region", 52, 45, 27, "Drone EL", "RWMBX", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "Drone Edit", 54, 35, 38, "Drone SH", "EQLKW", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Drone Add", 58, 48, 35, "Drone CE", "ZMIVW", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Drone Delete", 60, 18, 30, "Drone CV", "UZQOJ", new DateTime(2020, 12, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Drone Add", 62, 28, 48, "Drone NQ", "QWFLR", new DateTime(2020, 12, 1, 14, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Drone Devide Monitor Region", 64, 46, 45, "Drone PI", "JFXUV", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "Drone Edit", 66, 13, 28, "Drone PR", "SHCKW", new DateTime(2020, 12, 2, 11, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Drone Add", 68, 38, 24, "Drone TR", "MBPWC", new DateTime(2020, 12, 2, 2, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Drone Edit", 70, 35, 20, "Drone RO", "RAOTT", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Drone Delete", 72, 18, 30, "Drone JN", "WJMRF", new DateTime(2020, 12, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Drone Add", 74, 25, 10, "Drone LG", "RXVCA", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Drone Add", 76, 36, 11, "Drone UW", "FEZPX", new DateTime(2020, 12, 2, 13, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Drone Edit", 78, 26, 33, "Drone OZ", "OHCVB", new DateTime(2020, 12, 1, 14, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Drone Edit", 42, 32, 10, "Drone BI", "WXHMI", new DateTime(2020, 12, 2, 11, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Drone Devide Monitor Region", 40, 32, 15, "Drone VA", "RXCUB", new DateTime(2020, 12, 2, 14, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "Drone Add", 56, 21, 19, "Drone YD", "TNEFQ", new DateTime(2020, 12, 2, 9, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Drone Devide Monitor Region", 36, 41, 42, "Drone PM", "IRICN", new DateTime(2020, 12, 2, 9, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Drone Add", 38, 20, 24, "Drone WE", "BZBUZ", new DateTime(2020, 12, 2, 13, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Drone Add", 2, 24, 24, "Drone QU", "UMVFM", new DateTime(2020, 12, 2, 13, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Drone Devide Monitor Region", 4, 23, 28, "Drone ML", "QLSAX", new DateTime(2020, 12, 1, 15, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "Drone Devide Monitor Region", 6, 36, 40, "Drone RL", "KMKUX", new DateTime(2020, 12, 2, 6, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Drone Add", 8, 30, 39, "Drone UP", "MVEDL", new DateTime(2020, 12, 1, 11, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Drone Add", 10, 33, 35, "Drone TM", "TQHPD", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Drone Edit", 12, 17, 20, "Drone YB", "LCSAS", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Drone Add", 14, 39, 11, "Drone HE", "EZEAR", new DateTime(2020, 12, 2, 1, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "Drone Add", 16, 34, 19, "Drone QI", "ASTRL", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Drone Devide Monitor Region", 0, 32, 16, "Drone BC", "NQYOM", new DateTime(2020, 12, 2, 3, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "Drone Edit", 20, 17, 45, "Drone LJ", "ZUIVY", new DateTime(2020, 12, 1, 12, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Drone Devide Monitor Region", 18, 20, 42, "Drone WV", "VOHGF", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Drone Delete", 32, 40, 22, "Drone LQ", "BVTAH", new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "Drone Edit", 30, 20, 22, "Drone VF", "JFWHR", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Drone Delete", 28, 35, 34, "Drone JD", "DNBXZ", new DateTime(2020, 12, 2, 13, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "Drone Add", 34, 22, 18, "Drone EX", "QMABG", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Drone Delete", 24, 39, 24, "Drone VE", "MEOKA", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Drone Edit", 22, 42, 48, "Drone OM", "UDZMQ", new DateTime(2020, 12, 1, 3, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Drone Devide Monitor Region", 26, 13, 38, "Drone UV", "UWEEQ", new DateTime(2020, 12, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Image Delete", 58, "Image QS", "1", new DateTime(2020, 12, 1, 11, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Image Delete", 46, "Image RV", "1", new DateTime(2020, 12, 1, 3, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Image Delete", 48, "Image JO", "0", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Image Devide Monitor Region", 50, "Image TP", "1", new DateTime(2020, 12, 1, 9, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "Image Add", 52, "Image HJ", "0", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Image Devide Monitor Region", 54, "Image IU", "1", new DateTime(2020, 12, 2, 16, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "Image Add", 44, "Image MF", "0", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Image Add", 56, "Image LZ", "0", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Image Devide Monitor Region", 60, "Image IC", "0", new DateTime(2020, 12, 1, 1, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Image Add", 68, "Image PD", "0", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Image Add", 64, "Image PO", "0", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "Image Delete", 66, "Image OU", "1", new DateTime(2020, 12, 2, 13, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Image Edit", 70, "Image WL", "1", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Image Devide Monitor Region", 72, "Image RD", "0", new DateTime(2020, 12, 2, 4, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "Image Add", 74, "Image KK", "1", new DateTime(2020, 12, 2, 14, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Image Edit", 76, "Image WI", "0", new DateTime(2020, 12, 1, 2, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Image Devide Monitor Region", 78, "Image EU", "1", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Image Delete", 42, "Image GA", "1", new DateTime(2020, 12, 2, 2, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Image Add", 62, "Image RT", "1", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Image Devide Monitor Region", 40, "Image RQ", "0", new DateTime(2020, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Image Devide Monitor Region", 16, "Image RE", "0", new DateTime(2020, 12, 2, 4, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "Image Edit", 36, "Image XP", "0", new DateTime(2020, 12, 1, 3, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Image Delete", 38, "Image SZ", "1", new DateTime(2020, 12, 1, 10, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Image Edit", 2, "Image QZ", "1", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Image Add", 4, "Image FY", "0", new DateTime(2020, 12, 2, 15, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Image Devide Monitor Region", 6, "Image VU", "1", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Image Edit", 8, "Image VZ", "0", new DateTime(2020, 12, 1, 6, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Image Delete", 10, "Image RL", "1", new DateTime(2020, 12, 1, 11, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Image Devide Monitor Region", 12, "Image ZQ", "0", new DateTime(2020, 12, 1, 13, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "Image Edit", 14, "Image JJ", "1", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Image Edit", 0, "Image ZT", "0", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Image Add", 34, "Image VK", "1", new DateTime(2020, 12, 2, 17, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Image Edit", 20, "Image UR", "0", new DateTime(2020, 12, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Image Add", 22, "Image PO", "1", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Image Edit", 24, "Image VB", "0", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Image Delete", 26, "Image KV", "1", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Image Devide Monitor Region", 28, "Image UJ", "0", new DateTime(2020, 12, 1, 14, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Image Edit", 30, "Image HG", "1", new DateTime(2020, 12, 2, 5, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Image Add", 32, "Image VK", "0", new DateTime(2020, 12, 1, 12, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Image Delete", 18, "Image PP", "1", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Incident Add", 54, "Incident FR", "1", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Incident Delete", 52, "Incident HD", "0", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Incident Devide Monitor Region", 50, "Incident BN", "1", new DateTime(2020, 12, 1, 13, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Incident Delete", 42, "Incident GT", "1", new DateTime(2020, 12, 2, 5, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Incident Edit", 46, "Incident IC", "1", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Incident Add", 44, "Incident SL", "0", new DateTime(2020, 12, 1, 12, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Incident Add", 58, "Incident GK", "1", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Incident Delete", 48, "Incident HK", "0", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Incident Add", 60, "Incident OG", "0", new DateTime(2020, 12, 2, 7, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Incident Delete", 70, "Incident IZ", "1", new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Incident Devide Monitor Region", 64, "Incident KL", "0", new DateTime(2020, 12, 1, 1, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "Incident Delete", 66, "Incident SM", "1", new DateTime(2020, 12, 1, 4, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Incident Delete", 68, "Incident JZ", "0", new DateTime(2020, 12, 1, 6, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "Incident Delete", 72, "Incident BF", "0", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Incident Devide Monitor Region", 74, "Incident BG", "1", new DateTime(2020, 12, 2, 1, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "Incident Add", 76, "Incident OE", "0", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Incident Delete", 78, "Incident RE", "1", new DateTime(2020, 12, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Incident Edit", 62, "Incident EM", "1", new DateTime(2020, 12, 2, 1, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Incident Edit", 40, "Incident KA", "0", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Incident Edit", 56, "Incident CF", "0", new DateTime(2020, 12, 2, 3, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Incident Devide Monitor Region", 36, "Incident GN", "0", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Incident Edit", 2, "Incident RP", "1", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Incident Edit", 4, "Incident AN", "0", new DateTime(2020, 12, 2, 5, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Incident Add", 6, "Incident FX", "1", new DateTime(2020, 12, 2, 7, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Incident Devide Monitor Region", 8, "Incident CG", "0", new DateTime(2020, 12, 2, 15, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Incident Delete", 10, "Incident WI", "1", new DateTime(2020, 12, 2, 6, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Incident Add", 12, "Incident HU", "0", new DateTime(2020, 12, 1, 8, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Incident Devide Monitor Region", 14, "Incident FI", "1", new DateTime(2020, 12, 1, 2, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Incident Add", 16, "Incident IZ", "0", new DateTime(2020, 12, 1, 4, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Incident Delete", 18, "Incident ZD", "1", new DateTime(2020, 12, 2, 6, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Incident Add", 0, "Incident TS", "0", new DateTime(2020, 12, 2, 13, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Incident Delete", 38, "Incident NJ", "1", new DateTime(2020, 12, 1, 4, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Incident Add", 22, "Incident RO", "1", new DateTime(2020, 12, 1, 4, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Incident Devide Monitor Region", 24, "Incident TZ", "0", new DateTime(2020, 12, 1, 9, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Incident Devide Monitor Region", 26, "Incident WA", "1", new DateTime(2020, 12, 2, 16, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Incident Devide Monitor Region", 28, "Incident RA", "0", new DateTime(2020, 12, 2, 2, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Incident Devide Monitor Region", 30, "Incident FX", "1", new DateTime(2020, 12, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Incident Add", 32, "Incident HJ", "0", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Incident Edit", 34, "Incident GT", "1", new DateTime(2020, 12, 2, 17, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Incident Devide Monitor Region", 20, "Incident MW", "0", new DateTime(2020, 12, 2, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "MonitorRegion Devide Monitor Region", 54, "MonitorRegion YU", "1", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "MonitorRegion Delete", 52, "MonitorRegion LW", "0", new DateTime(2020, 12, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "MonitorRegion Devide Monitor Region", 44, "MonitorRegion IS", "0", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "MonitorRegion Devide Monitor Region", 48, "MonitorRegion AF", "0", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "MonitorRegion Delete", 46, "MonitorRegion TK", "1", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "MonitorRegion Devide Monitor Region", 56, "MonitorRegion SK", "0", new DateTime(2020, 12, 2, 16, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "MonitorRegion Edit", 50, "MonitorRegion UP", "1", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "MonitorRegion Devide Monitor Region", 58, "MonitorRegion FS", "1", new DateTime(2020, 12, 2, 10, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "MonitorRegion Devide Monitor Region", 68, "MonitorRegion ZY", "0", new DateTime(2020, 12, 2, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "MonitorRegion Delete", 62, "MonitorRegion HX", "1", new DateTime(2020, 12, 2, 16, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "MonitorRegion Devide Monitor Region", 64, "MonitorRegion UZ", "0", new DateTime(2020, 12, 1, 3, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "MonitorRegion Edit", 66, "MonitorRegion MT", "1", new DateTime(2020, 12, 2, 12, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "MonitorRegion Delete", 70, "MonitorRegion WR", "1", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "MonitorRegion Delete", 72, "MonitorRegion ZF", "0", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "MonitorRegion Edit", 74, "MonitorRegion SE", "1", new DateTime(2020, 12, 2, 4, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "MonitorRegion Add", 76, "MonitorRegion HG", "0", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "MonitorRegion Delete", 42, "MonitorRegion XB", "1", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "MonitorRegion Delete", 60, "MonitorRegion HX", "0", new DateTime(2020, 12, 2, 3, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "MonitorRegion Add", 40, "MonitorRegion FJ", "0", new DateTime(2020, 12, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "MonitorRegion Edit", 78, "MonitorRegion KF", "1", new DateTime(2020, 12, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "MonitorRegion Edit", 36, "MonitorRegion ZH", "0", new DateTime(2020, 12, 1, 2, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "MonitorRegion Devide Monitor Region", 0, "MonitorRegion UB", "0", new DateTime(2020, 12, 2, 7, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "MonitorRegion Delete", 2, "MonitorRegion ZV", "1", new DateTime(2020, 12, 1, 15, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "MonitorRegion Delete", 4, "MonitorRegion WZ", "0", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "MonitorRegion Delete", 6, "MonitorRegion ED", "1", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "MonitorRegion Add", 8, "MonitorRegion LX", "0", new DateTime(2020, 12, 1, 14, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "MonitorRegion Add", 10, "MonitorRegion YH", "1", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "MonitorRegion Edit", 12, "MonitorRegion IU", "0", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "MonitorRegion Devide Monitor Region", 14, "MonitorRegion NA", "1", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "MonitorRegion Devide Monitor Region", 16, "MonitorRegion YQ", "0", new DateTime(2020, 12, 2, 13, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "MonitorRegion Add", 38, "MonitorRegion QB", "1", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "MonitorRegion Delete", 20, "MonitorRegion CH", "0", new DateTime(2020, 12, 1, 8, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "MonitorRegion Devide Monitor Region", 22, "MonitorRegion SR", "1", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "MonitorRegion Delete", 24, "MonitorRegion OM", "0", new DateTime(2020, 12, 2, 6, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "MonitorRegion Delete", 26, "MonitorRegion DD", "1", new DateTime(2020, 12, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "MonitorRegion Add", 28, "MonitorRegion XS", "0", new DateTime(2020, 12, 2, 9, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "MonitorRegion Delete", 30, "MonitorRegion BS", "1", new DateTime(2020, 12, 2, 1, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "MonitorRegion Delete", 32, "MonitorRegion RW", "0", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "MonitorRegion Edit", 34, "MonitorRegion RM", "1", new DateTime(2020, 12, 1, 1, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "MonitorRegion Add", 18, "MonitorRegion MS", "1", new DateTime(2020, 12, 2, 5, 15, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ObjectObserve Delete", 54, "ObjectObserve IW", "1", new DateTime(2020, 12, 2, 6, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "ObjectObserve Devide Monitor Region", 52, "ObjectObserve RD", "0", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "ObjectObserve Add", 50, "ObjectObserve KI", "1", new DateTime(2020, 12, 2, 6, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "ObjectObserve Edit", 42, "ObjectObserve QD", "1", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "ObjectObserve Devide Monitor Region", 46, "ObjectObserve RD", "1", new DateTime(2020, 12, 2, 6, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "ObjectObserve Devide Monitor Region", 44, "ObjectObserve VH", "0", new DateTime(2020, 12, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "ObjectObserve Edit", 56, "ObjectObserve ZA", "0", new DateTime(2020, 12, 2, 13, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ObjectObserve Add", 48, "ObjectObserve LA", "0", new DateTime(2020, 12, 1, 11, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "ObjectObserve Edit", 58, "ObjectObserve WM", "1", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "ObjectObserve Add", 66, "ObjectObserve PB", "1", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "ObjectObserve Add", 62, "ObjectObserve AP", "1", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "ObjectObserve Delete", 64, "ObjectObserve HU", "0", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "ObjectObserve Devide Monitor Region", 68, "ObjectObserve WX", "0", new DateTime(2020, 12, 1, 5, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "ObjectObserve Devide Monitor Region", 70, "ObjectObserve EF", "1", new DateTime(2020, 12, 1, 3, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "ObjectObserve Add", 72, "ObjectObserve HW", "0", new DateTime(2020, 12, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "ObjectObserve Devide Monitor Region", 74, "ObjectObserve KD", "1", new DateTime(2020, 12, 2, 6, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "ObjectObserve Delete", 76, "ObjectObserve TM", "0", new DateTime(2020, 12, 1, 6, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "ObjectObserve Add", 40, "ObjectObserve VH", "0", new DateTime(2020, 12, 1, 13, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "ObjectObserve Edit", 60, "ObjectObserve RQ", "0", new DateTime(2020, 12, 1, 7, 1, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "ObjectObserve Delete", 78, "ObjectObserve WR", "1", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "ObjectObserve Delete", 38, "ObjectObserve VQ", "1", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "ObjectObserve Delete", 34, "ObjectObserve QF", "1", new DateTime(2020, 12, 2, 6, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "ObjectObserve Delete", 36, "ObjectObserve HF", "0", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "ObjectObserve Edit", 0, "ObjectObserve ZM", "0", new DateTime(2020, 12, 1, 12, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "ObjectObserve Add", 2, "ObjectObserve RT", "1", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "ObjectObserve Devide Monitor Region", 4, "ObjectObserve SD", "0", new DateTime(2020, 12, 2, 10, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "ObjectObserve Devide Monitor Region", 6, "ObjectObserve UR", "1", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "ObjectObserve Edit", 10, "ObjectObserve PW", "1", new DateTime(2020, 12, 1, 14, 16, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "ObjectObserve Edit", 12, "ObjectObserve MT", "0", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "ObjectObserve Add", 14, "ObjectObserve TE", "1", new DateTime(2020, 12, 2, 6, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "ObjectObserve Add", 8, "ObjectObserve AO", "0", new DateTime(2020, 12, 2, 12, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "ObjectObserve Add", 18, "ObjectObserve KP", "1", new DateTime(2020, 12, 1, 4, 4, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "ObjectObserve Delete", 20, "ObjectObserve RS", "0", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "ObjectObserve Delete", 22, "ObjectObserve TT", "1", new DateTime(2020, 12, 2, 13, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "ObjectObserve Devide Monitor Region", 24, "ObjectObserve LS", "0", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "ObjectObserve Delete", 26, "ObjectObserve LQ", "1", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "ObjectObserve Devide Monitor Region", 28, "ObjectObserve LH", "0", new DateTime(2020, 12, 2, 10, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "ObjectObserve Edit", 30, "ObjectObserve XA", "1", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "ObjectObserve Add", 16, "ObjectObserve BN", "0", new DateTime(2020, 12, 2, 3, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "ObjectObserve Edit", 32, "ObjectObserve OY", "0", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "Payload Delete", 56, "Payload RQ", "0", new DateTime(2020, 12, 2, 2, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "Payload Add", 54, "Payload EG", "1", new DateTime(2020, 12, 2, 1, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Payload Add", 52, "Payload MV", "0", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Payload Add", 44, "Payload GE", "0", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Payload Add", 48, "Payload PH", "0", new DateTime(2020, 12, 1, 2, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Payload Add", 46, "Payload GK", "1", new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Payload Add", 58, "Payload NL", "1", new DateTime(2020, 12, 1, 10, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Payload Add", 50, "Payload WW", "1", new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Payload Edit", 60, "Payload GJ", "0", new DateTime(2020, 12, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Payload Edit", 78, "Payload JD", "1", new DateTime(2020, 12, 2, 3, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "Payload Delete", 64, "Payload BG", "0", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Payload Add", 66, "Payload NL", "1", new DateTime(2020, 12, 2, 2, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Payload Edit", 68, "Payload SL", "0", new DateTime(2020, 12, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "Payload Delete", 70, "Payload BX", "1", new DateTime(2020, 12, 1, 9, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "Payload Edit", 72, "Payload EM", "0", new DateTime(2020, 12, 2, 17, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Payload Devide Monitor Region", 74, "Payload BA", "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "Payload Add", 76, "Payload BR", "0", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "Payload Devide Monitor Region", 42, "Payload VG", "1", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "Payload Devide Monitor Region", 62, "Payload RJ", "1", new DateTime(2020, 12, 1, 6, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Payload Delete", 40, "Payload WX", "0", new DateTime(2020, 12, 1, 8, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Payload Delete", 36, "Payload IU", "0", new DateTime(2020, 12, 2, 7, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "Payload Add", 38, "Payload MZ", "1", new DateTime(2020, 12, 2, 8, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Payload Add", 0, "Payload SQ", "0", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Payload Edit", 2, "Payload MD", "1", new DateTime(2020, 12, 2, 8, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Payload Devide Monitor Region", 4, "Payload VC", "0", new DateTime(2020, 12, 2, 2, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "Payload Edit", 6, "Payload KE", "1", new DateTime(2020, 12, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Payload Add", 8, "Payload YP", "0", new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "Payload Edit", 12, "Payload OO", "0", new DateTime(2020, 12, 2, 4, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Payload Edit", 14, "Payload YO", "1", new DateTime(2020, 12, 1, 11, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Payload Add", 16, "Payload NW", "0", new DateTime(2020, 12, 1, 3, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Payload Edit", 10, "Payload GT", "1", new DateTime(2020, 12, 2, 1, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Payload Edit", 20, "Payload EC", "0", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Payload Add", 18, "Payload YH", "1", new DateTime(2020, 12, 1, 5, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Payload Devide Monitor Region", 32, "Payload RV", "0", new DateTime(2020, 12, 1, 1, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Payload Edit", 30, "Payload SR", "1", new DateTime(2020, 12, 1, 4, 13, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "Payload Devide Monitor Region", 28, "Payload BM", "0", new DateTime(2020, 12, 2, 11, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "Payload Add", 34, "Payload NA", "1", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Payload Delete", 24, "Payload WT", "0", new DateTime(2020, 12, 2, 7, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Payload Devide Monitor Region", 22, "Payload UJ", "1", new DateTime(2020, 12, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Payload Devide Monitor Region", 26, "Payload GI", "1", new DateTime(2020, 12, 1, 6, 16, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 40, "ResolveProblem Devide Monitor Region", 60, "ResolveProblem TM", "0", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "ResolveProblem Edit", 46, "ResolveProblem NZ", "1", new DateTime(2020, 12, 1, 6, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ResolveProblem Devide Monitor Region", 48, "ResolveProblem JL", "0", new DateTime(2020, 12, 2, 14, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "ResolveProblem Delete", 50, "ResolveProblem VP", "1", new DateTime(2020, 12, 2, 17, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "ResolveProblem Add", 52, "ResolveProblem HP", "0", new DateTime(2020, 12, 2, 15, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "ResolveProblem Edit", 54, "ResolveProblem OH", "1", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "ResolveProblem Edit", 56, "ResolveProblem KM", "0", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "ResolveProblem Delete", 58, "ResolveProblem LD", "1", new DateTime(2020, 12, 2, 13, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "ResolveProblem Devide Monitor Region", 62, "ResolveProblem QF", "1", new DateTime(2020, 12, 1, 15, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "ResolveProblem Devide Monitor Region", 40, "ResolveProblem TD", "0", new DateTime(2020, 12, 2, 12, 35, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "ResolveProblem Delete", 66, "ResolveProblem QH", "1", new DateTime(2020, 12, 2, 3, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "ResolveProblem Delete", 68, "ResolveProblem QM", "0", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "ResolveProblem Delete", 70, "ResolveProblem LJ", "1", new DateTime(2020, 12, 1, 10, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "ResolveProblem Edit", 72, "ResolveProblem AB", "0", new DateTime(2020, 12, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "ResolveProblem Devide Monitor Region", 74, "ResolveProblem TE", "1", new DateTime(2020, 12, 2, 14, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "ResolveProblem Edit", 76, "ResolveProblem HF", "0", new DateTime(2020, 12, 2, 5, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "ResolveProblem Devide Monitor Region", 78, "ResolveProblem AF", "1", new DateTime(2020, 12, 1, 14, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "ResolveProblem Edit", 44, "ResolveProblem VR", "0", new DateTime(2020, 12, 1, 7, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "ResolveProblem Delete", 64, "ResolveProblem FJ", "0", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "ResolveProblem Edit", 42, "ResolveProblem PR", "1", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "ResolveProblem Devide Monitor Region", 28, "ResolveProblem ZC", "0", new DateTime(2020, 12, 1, 5, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "ResolveProblem Devide Monitor Region", 38, "ResolveProblem ME", "1", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "ResolveProblem Edit", 0, "ResolveProblem BD", "0", new DateTime(2020, 12, 2, 3, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "ResolveProblem Add", 2, "ResolveProblem WL", "1", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "ResolveProblem Delete", 4, "ResolveProblem KT", "0", new DateTime(2020, 12, 1, 9, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "ResolveProblem Delete", 6, "ResolveProblem WZ", "1", new DateTime(2020, 12, 2, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "ResolveProblem Edit", 8, "ResolveProblem RZ", "0", new DateTime(2020, 12, 2, 3, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "ResolveProblem Add", 10, "ResolveProblem YZ", "1", new DateTime(2020, 12, 1, 10, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "ResolveProblem Devide Monitor Region", 14, "ResolveProblem OG", "1", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "ResolveProblem Edit", 16, "ResolveProblem SP", "0", new DateTime(2020, 12, 1, 8, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "ResolveProblem Edit", 18, "ResolveProblem HA", "1", new DateTime(2020, 12, 1, 14, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "ResolveProblem Devide Monitor Region", 12, "ResolveProblem KV", "0", new DateTime(2020, 12, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "ResolveProblem Devide Monitor Region", 22, "ResolveProblem AK", "1", new DateTime(2020, 12, 1, 8, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "ResolveProblem Edit", 20, "ResolveProblem EK", "0", new DateTime(2020, 12, 2, 8, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "ResolveProblem Delete", 34, "ResolveProblem SZ", "1", new DateTime(2020, 12, 1, 15, 32, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "ResolveProblem Add", 32, "ResolveProblem AI", "0", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "ResolveProblem Add", 30, "ResolveProblem CA", "1", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "ResolveProblem Delete", 36, "ResolveProblem WN", "0", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "ResolveProblem Edit", 26, "ResolveProblem ZM", "1", new DateTime(2020, 12, 2, 6, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "ResolveProblem Edit", 24, "ResolveProblem ZD", "0", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "Statical Edit", 44, "Statical KS", "0", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Statical Devide Monitor Region", 46, "Statical YU", "1", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "Statical Devide Monitor Region", 48, "Statical AM", "0", new DateTime(2020, 12, 1, 15, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "Statical Edit", 50, "Statical ZP", "1", new DateTime(2020, 12, 2, 11, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Statical Add", 52, "Statical WI", "0", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Statical Edit", 54, "Statical MF", "1", new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Statical Add", 56, "Statical CJ", "0", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Statical Delete", 58, "Statical GT", "1", new DateTime(2020, 12, 1, 12, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Statical Add", 60, "Statical TS", "0", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Statical Delete", 78, "Statical YF", "1", new DateTime(2020, 12, 2, 14, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Statical Edit", 64, "Statical RL", "0", new DateTime(2020, 12, 1, 11, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Statical Edit", 66, "Statical BY", "1", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Statical Devide Monitor Region", 68, "Statical CL", "0", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Statical Delete", 70, "Statical FM", "1", new DateTime(2020, 12, 2, 11, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "Statical Edit", 72, "Statical EI", "0", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Statical Delete", 74, "Statical GJ", "1", new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Statical Delete", 76, "Statical BM", "0", new DateTime(2020, 12, 2, 10, 46, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "Statical Add", 42, "Statical HY", "1", new DateTime(2020, 12, 2, 12, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Statical Add", 62, "Statical FJ", "1", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Statical Edit", 40, "Statical ZM", "0", new DateTime(2020, 12, 1, 14, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Statical Add", 0, "Statical KZ", "0", new DateTime(2020, 12, 2, 3, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Statical Devide Monitor Region", 36, "Statical HB", "0", new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Statical Delete", 38, "Statical FP", "1", new DateTime(2020, 12, 2, 8, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, "Statical Devide Monitor Region", 2, "Statical GZ", "1", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "Statical Delete", 4, "Statical BK", "0", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Statical Delete", 6, "Statical VD", "1", new DateTime(2020, 12, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Statical Edit", 8, "Statical TC", "0", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Statical Devide Monitor Region", 12, "Statical VU", "0", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "Statical Devide Monitor Region", 14, "Statical JP", "1", new DateTime(2020, 12, 2, 6, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Statical Edit", 16, "Statical RH", "0", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Statical Add", 10, "Statical SL", "1", new DateTime(2020, 12, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Statical Add", 20, "Statical WK", "0", new DateTime(2020, 12, 1, 14, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Statical Add", 22, "Statical BE", "1", new DateTime(2020, 12, 2, 17, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Statical Add", 24, "Statical YQ", "0", new DateTime(2020, 12, 2, 14, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 23, "Statical Devide Monitor Region", 26, "Statical IC", "1", new DateTime(2020, 12, 1, 11, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Statical Devide Monitor Region", 28, "Statical TL", "0", new DateTime(2020, 12, 1, 13, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Statical Edit", 30, "Statical IQ", "1", new DateTime(2020, 12, 1, 13, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Statical Add", 32, "Statical KB", "0", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Statical Edit", 18, "Statical PG", "1", new DateTime(2020, 12, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Statical Add", 34, "Statical NB", "1", new DateTime(2020, 12, 2, 6, 23, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "UavConnect Delete", 56, "UavConnect SL", "0", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "UavConnect Devide Monitor Region", 54, "UavConnect TE", "1", new DateTime(2020, 12, 1, 2, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "UavConnect Delete", 52, "UavConnect RF", "0", new DateTime(2020, 12, 1, 2, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "UavConnect Delete", 44, "UavConnect BN", "0", new DateTime(2020, 12, 2, 11, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "UavConnect Devide Monitor Region", 48, "UavConnect CM", "0", new DateTime(2020, 12, 2, 10, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "UavConnect Add", 46, "UavConnect LK", "1", new DateTime(2020, 12, 2, 4, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "UavConnect Delete", 42, "UavConnect FN", "1", new DateTime(2020, 12, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "UavConnect Delete", 50, "UavConnect LN", "1", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "UavConnect Delete", 58, "UavConnect XC", "1", new DateTime(2020, 12, 2, 9, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "UavConnect Edit", 76, "UavConnect VL", "0", new DateTime(2020, 12, 2, 12, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 41, "UavConnect Add", 62, "UavConnect WR", "1", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "UavConnect Add", 64, "UavConnect ID", "0", new DateTime(2020, 12, 1, 12, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 43, "UavConnect Edit", 66, "UavConnect YQ", "1", new DateTime(2020, 12, 2, 16, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "UavConnect Delete", 68, "UavConnect JU", "0", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "UavConnect Edit", 70, "UavConnect IY", "1", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "UavConnect Add", 72, "UavConnect VR", "0", new DateTime(2020, 12, 2, 7, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "UavConnect Devide Monitor Region", 74, "UavConnect PT", "1", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "UavConnect Delete", 78, "UavConnect AN", "1", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "UavConnect Add", 60, "UavConnect XK", "0", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "UavConnect Devide Monitor Region", 40, "UavConnect FN", "0", new DateTime(2020, 12, 2, 8, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "UavConnect Add", 20, "UavConnect NE", "0", new DateTime(2020, 12, 1, 4, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "UavConnect Add", 36, "UavConnect CI", "0", new DateTime(2020, 12, 2, 13, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "UavConnect Add", 0, "UavConnect EK", "0", new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "UavConnect Edit", 2, "UavConnect RU", "1", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "UavConnect Delete", 4, "UavConnect XS", "0", new DateTime(2020, 12, 1, 6, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "UavConnect Add", 6, "UavConnect AQ", "1", new DateTime(2020, 12, 2, 5, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "UavConnect Add", 8, "UavConnect SQ", "0", new DateTime(2020, 12, 2, 14, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "UavConnect Delete", 10, "UavConnect FX", "1", new DateTime(2020, 12, 2, 13, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "UavConnect Devide Monitor Region", 12, "UavConnect IY", "0", new DateTime(2020, 12, 1, 3, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "UavConnect Add", 14, "UavConnect WK", "1", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "UavConnect Devide Monitor Region", 38, "UavConnect LT", "1", new DateTime(2020, 12, 2, 8, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "UavConnect Delete", 18, "UavConnect JJ", "1", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "UavConnect Add", 22, "UavConnect FM", "1", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "UavConnect Devide Monitor Region", 24, "UavConnect VY", "0", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "UavConnect Edit", 26, "UavConnect WO", "1", new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "UavConnect Edit", 28, "UavConnect IA", "0", new DateTime(2020, 12, 2, 2, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "UavConnect Delete", 30, "UavConnect SA", "1", new DateTime(2020, 12, 2, 1, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "UavConnect Edit", 32, "UavConnect FB", "0", new DateTime(2020, 12, 2, 5, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "UavConnect Delete", 34, "UavConnect BS", "1", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "UavConnect Add", 16, "UavConnect YZ", "0", new DateTime(2020, 12, 2, 8, 45, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Video Add", 54, "Video AM", "1", new DateTime(2020, 12, 2, 12, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Video Devide Monitor Region", 52, "Video OZ", "0", new DateTime(2020, 12, 2, 10, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "Video Devide Monitor Region", 50, "Video UK", "1", new DateTime(2020, 12, 2, 13, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Video Devide Monitor Region", 42, "Video KH", "1", new DateTime(2020, 12, 1, 9, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "Video Add", 46, "Video QJ", "1", new DateTime(2020, 12, 1, 5, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Video Edit", 44, "Video HJ", "0", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Video Devide Monitor Region", 56, "Video UE", "0", new DateTime(2020, 12, 1, 2, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "Video Edit", 48, "Video WV", "0", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Video Devide Monitor Region", 58, "Video OU", "1", new DateTime(2020, 12, 2, 4, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "Video Devide Monitor Region", 66, "Video IR", "1", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "Video Edit", 62, "Video JU", "1", new DateTime(2020, 12, 2, 13, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "Video Devide Monitor Region", 64, "Video WQ", "0", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Video Delete", 68, "Video RK", "0", new DateTime(2020, 12, 2, 12, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Video Edit", 70, "Video AI", "1", new DateTime(2020, 12, 1, 7, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Video Edit", 72, "Video FS", "0", new DateTime(2020, 12, 1, 10, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Video Devide Monitor Region", 74, "Video AI", "1", new DateTime(2020, 12, 2, 17, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Video Delete", 40, "Video AU", "0", new DateTime(2020, 12, 1, 8, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Video Delete", 78, "Video AP", "1", new DateTime(2020, 12, 1, 5, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Video Delete", 60, "Video AQ", "0", new DateTime(2020, 12, 1, 8, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Video Edit", 76, "Video GA", "0", new DateTime(2020, 12, 1, 10, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Video Devide Monitor Region", 38, "Video XO", "1", new DateTime(2020, 12, 2, 2, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "Video Edit", 34, "Video EN", "1", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Video Add", 36, "Video NK", "0", new DateTime(2020, 12, 1, 9, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Video Add", 0, "Video VW", "0", new DateTime(2020, 12, 1, 8, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Video Delete", 2, "Video MJ", "1", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Video Edit", 4, "Video HS", "0", new DateTime(2020, 12, 2, 10, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Video Devide Monitor Region", 6, "Video QD", "1", new DateTime(2020, 12, 2, 16, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Video Edit", 10, "Video XS", "1", new DateTime(2020, 12, 1, 4, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Video Edit", 12, "Video QP", "0", new DateTime(2020, 12, 2, 5, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Video Edit", 14, "Video LY", "1", new DateTime(2020, 12, 2, 3, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "Video Add", 8, "Video RT", "0", new DateTime(2020, 12, 1, 1, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Video Edit", 18, "Video MV", "1", new DateTime(2020, 12, 2, 1, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Video Edit", 16, "Video YX", "0", new DateTime(2020, 12, 2, 2, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Video Devide Monitor Region", 30, "Video ZS", "1", new DateTime(2020, 12, 1, 8, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Video Edit", 28, "Video AB", "0", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Video Devide Monitor Region", 26, "Video VP", "1", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Video Edit", 32, "Video AY", "0", new DateTime(2020, 12, 2, 10, 11, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Video Devide Monitor Region", 22, "Video HS", "1", new DateTime(2020, 12, 1, 6, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "Video Delete", 20, "Video JL", "0", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Video Devide Monitor Region", 24, "Video OD", "0", new DateTime(2020, 12, 1, 7, 15, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Warning Devide Monitor Region", 54, "Warning TW", "1", new DateTime(2020, 12, 2, 15, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Warning Edit", 42, "Warning FR", "1", new DateTime(2020, 12, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Warning Edit", 44, "Warning YR", "0", new DateTime(2020, 12, 1, 13, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Warning Add", 46, "Warning OU", "1", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Warning Add", 48, "Warning NT", "0", new DateTime(2020, 12, 1, 2, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Warning Delete", 50, "Warning FJ", "1", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Warning Devide Monitor Region", 52, "Warning KK", "0", new DateTime(2020, 12, 2, 10, 28, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "Warning Devide Monitor Region", 56, "Warning VW", "0", new DateTime(2020, 12, 2, 11, 16, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Warning Edit", 40, "Warning TB", "0", new DateTime(2020, 12, 2, 5, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Warning Add", 60, "Warning TJ", "0", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Warning Add", 62, "Warning NL", "1", new DateTime(2020, 12, 2, 10, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "Warning Delete", 64, "Warning BF", "0", new DateTime(2020, 12, 2, 13, 2, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Warning Delete", 66, "Warning MJ", "1", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Warning Devide Monitor Region", 68, "Warning LI", "0", new DateTime(2020, 12, 2, 2, 12, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Warning Edit", 70, "Warning AA", "1", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Warning Add", 72, "Warning WM", "0", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Warning Add", 74, "Warning DE", "1", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Warning Devide Monitor Region", 58, "Warning XG", "1", new DateTime(2020, 12, 1, 15, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Warning Add", 38, "Warning OC", "1", new DateTime(2020, 12, 1, 4, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Warning Edit", 76, "Warning VA", "0", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Warning Add", 34, "Warning NZ", "1", new DateTime(2020, 12, 2, 13, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Warning Edit", 0, "Warning JD", "0", new DateTime(2020, 12, 2, 11, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Warning Devide Monitor Region", 2, "Warning UF", "1", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "Warning Add", 4, "Warning VU", "0", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Warning Add", 6, "Warning AH", "1", new DateTime(2020, 12, 1, 13, 46, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Warning Add", 8, "Warning QV", "0", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Warning Delete", 10, "Warning TJ", "1", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Warning Edit", 12, "Warning YW", "0", new DateTime(2020, 12, 2, 14, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Warning Devide Monitor Region", 14, "Warning UC", "1", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Warning Delete", 16, "Warning RN", "0", new DateTime(2020, 12, 2, 6, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Warning Delete", 18, "Warning TE", "1", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Warning Devide Monitor Region", 20, "Warning JT", "0", new DateTime(2020, 12, 2, 2, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "Warning Add", 22, "Warning YR", "1", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Warning Devide Monitor Region", 24, "Warning YI", "0", new DateTime(2020, 12, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Warning Add", 26, "Warning EK", "1", new DateTime(2020, 12, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Warning Edit", 28, "Warning LD", "0", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Warning Add", 30, "Warning HP", "1", new DateTime(2020, 12, 1, 13, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Warning Edit", 32, "Warning XI", "0", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 28, "Warning Delete", 36, "Warning RO", "0", new DateTime(2020, 12, 2, 10, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Warning Add", 78, "Warning UK", "1", new DateTime(2020, 12, 1, 7, 17, 0, 0, DateTimeKind.Unspecified), 2 }
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
