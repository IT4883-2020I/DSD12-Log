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
                    { 32, "Drone Delete", 44, 43, 41, "Drone JA", "NIGPS", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Drone Add", 46, 43, 14, "Drone PK", "KNRYW", new DateTime(2020, 12, 2, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Drone Add", 48, 12, 17, "Drone AQ", "RIBDZ", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Drone Delete", 50, 39, 24, "Drone DD", "HSUOE", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Drone Add", 52, 11, 15, "Drone SN", "NIRPL", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Drone Add", 54, 15, 45, "Drone QW", "TZZGT", new DateTime(2020, 12, 2, 13, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Drone Delete", 58, 23, 19, "Drone LA", "RVHAP", new DateTime(2020, 12, 1, 2, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Drone Delete", 60, 14, 22, "Drone VQ", "KNLOX", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Drone Activity Log", 62, 14, 35, "Drone JR", "VXKZB", new DateTime(2020, 12, 1, 14, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Drone Edit", 64, 40, 44, "Drone QR", "WQOGK", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Drone Edit", 66, 38, 17, "Drone MO", "YFXPK", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Drone Delete", 68, 48, 48, "Drone HF", "YRVGE", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Drone Add", 70, 23, 11, "Drone KK", "HURPM", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Drone Delete", 72, 30, 25, "Drone UX", "EQDYX", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Drone Activity Log", 74, 38, 38, "Drone AN", "WVPSX", new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "Drone Delete", 76, 30, 28, "Drone KM", "ICAKO", new DateTime(2020, 12, 2, 16, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Drone Edit", 78, 44, 12, "Drone BD", "KIYPY", new DateTime(2020, 12, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Drone Edit", 42, 14, 38, "Drone NA", "TLAKV", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "Drone Add", 40, 22, 48, "Drone KP", "NTFJU", new DateTime(2020, 12, 1, 2, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Drone Add", 56, 38, 39, "Drone WJ", "AYSMM", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Drone Delete", 36, 14, 13, "Drone FN", "VWLNA", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "Drone Activity Log", 38, 19, 11, "Drone SI", "RNRFX", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Drone Edit", 2, 34, 26, "Drone GG", "ITDNA", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Drone Edit", 4, 22, 28, "Drone ZU", "JHXVJ", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Drone Add", 6, 27, 36, "Drone GG", "SZFYG", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "Drone Activity Log", 8, 18, 33, "Drone MM", "WRNVS", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Drone Delete", 10, 40, 23, "Drone UA", "AQWYM", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Drone Edit", 12, 36, 34, "Drone DA", "EHHOB", new DateTime(2020, 12, 2, 10, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Drone Activity Log", 14, 32, 33, "Drone DI", "XALSL", new DateTime(2020, 12, 1, 14, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Drone Add", 16, 36, 16, "Drone KX", "NHRJS", new DateTime(2020, 12, 2, 5, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Drone Delete", 0, 49, 44, "Drone RB", "XSFDR", new DateTime(2020, 12, 1, 1, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Drone Activity Log", 20, 20, 19, "Drone RU", "YQTYY", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Drone Activity Log", 18, 25, 37, "Drone WS", "ULVTD", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "Drone Add", 32, 13, 27, "Drone OU", "KYMJM", new DateTime(2020, 12, 2, 11, 48, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Drone Activity Log", 30, 12, 32, "Drone EW", "NYSCM", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Drone Add", 28, 43, 15, "Drone JC", "HNTVJ", new DateTime(2020, 12, 2, 7, 25, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Drone Delete", 34, 27, 35, "Drone EK", "UZOOW", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Drone Activity Log", 24, 21, 27, "Drone QV", "HUKED", new DateTime(2020, 12, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "Drone Edit", 22, 26, 27, "Drone TA", "QPYSA", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Drone Activity Log", 26, 38, 12, "Drone GU", "KKUQI", new DateTime(2020, 12, 1, 11, 34, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ImageLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 39, "Image Add", 58, "Image GH", "1", new DateTime(2020, 12, 2, 11, 37, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Image Edit", 46, "Image BA", "1", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Image Delete", 48, "Image EX", "0", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Image Edit", 50, "Image AM", "1", new DateTime(2020, 12, 1, 5, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Image Delete", 52, "Image LO", "0", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "Image Add", 54, "Image MU", "1", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Image Edit", 44, "Image PS", "0", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Image Delete", 56, "Image DW", "0", new DateTime(2020, 12, 1, 7, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Image Activity Log", 60, "Image RU", "0", new DateTime(2020, 12, 1, 2, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "Image Activity Log", 68, "Image YT", "0", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Image Edit", 64, "Image WO", "0", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Image Delete", 66, "Image AP", "1", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Image Edit", 70, "Image SP", "1", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "Image Add", 72, "Image QZ", "0", new DateTime(2020, 12, 1, 1, 49, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Image Delete", 74, "Image LF", "1", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Image Add", 76, "Image TH", "0", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Image Activity Log", 78, "Image RO", "1", new DateTime(2020, 12, 2, 7, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Image Add", 42, "Image SC", "1", new DateTime(2020, 12, 1, 6, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Image Delete", 62, "Image MM", "1", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Image Activity Log", 40, "Image TU", "0", new DateTime(2020, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Image Add", 16, "Image TT", "0", new DateTime(2020, 12, 1, 14, 28, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Image Delete", 36, "Image ZW", "0", new DateTime(2020, 12, 1, 5, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "Image Activity Log", 38, "Image QR", "1", new DateTime(2020, 12, 1, 7, 24, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Image Activity Log", 2, "Image KQ", "1", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "Image Activity Log", 4, "Image KF", "0", new DateTime(2020, 12, 2, 15, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "Image Activity Log", 6, "Image TZ", "1", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Image Add", 8, "Image ZJ", "0", new DateTime(2020, 12, 1, 7, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Image Edit", 10, "Image MI", "1", new DateTime(2020, 12, 2, 11, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Image Edit", 12, "Image DE", "0", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Image Add", 14, "Image TV", "1", new DateTime(2020, 12, 1, 13, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Image Add", 0, "Image QU", "0", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Image Add", 34, "Image TC", "1", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "Image Add", 20, "Image QH", "0", new DateTime(2020, 12, 1, 2, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 21, "Image Edit", 22, "Image GT", "1", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "Image Edit", 24, "Image LY", "0", new DateTime(2020, 12, 1, 14, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Image Delete", 26, "Image GK", "1", new DateTime(2020, 12, 1, 6, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Image Add", 28, "Image HJ", "0", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "Image Edit", 30, "Image EQ", "1", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Image Edit", 32, "Image VQ", "0", new DateTime(2020, 12, 1, 9, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Image Add", 18, "Image PC", "1", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "IncidentLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Incident Delete", 54, "Incident IC", "1", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "Incident Edit", 52, "Incident MV", "0", new DateTime(2020, 12, 1, 4, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "Incident Activity Log", 50, "Incident JR", "1", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Incident Delete", 42, "Incident WT", "1", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "Incident Add", 46, "Incident DE", "1", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "Incident Delete", 44, "Incident RS", "0", new DateTime(2020, 12, 2, 13, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "Incident Edit", 58, "Incident EW", "1", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Incident Delete", 48, "Incident EU", "0", new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Incident Add", 60, "Incident XH", "0", new DateTime(2020, 12, 2, 8, 32, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Incident Activity Log", 70, "Incident NI", "1", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Incident Edit", 64, "Incident SP", "0", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Incident Add", 66, "Incident RC", "1", new DateTime(2020, 12, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Incident Activity Log", 68, "Incident EO", "0", new DateTime(2020, 12, 1, 1, 5, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "Incident Edit", 72, "Incident WC", "0", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 47, "Incident Edit", 74, "Incident XC", "1", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 48, "Incident Edit", 76, "Incident RL", "0", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "Incident Delete", 78, "Incident ET", "1", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Incident Delete", 62, "Incident GS", "1", new DateTime(2020, 12, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Incident Add", 40, "Incident UO", "0", new DateTime(2020, 12, 1, 7, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Incident Add", 56, "Incident DB", "0", new DateTime(2020, 12, 1, 6, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Incident Edit", 36, "Incident LJ", "0", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Incident Add", 2, "Incident AC", "1", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Incident Delete", 4, "Incident IK", "0", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, "Incident Activity Log", 6, "Incident HM", "1", new DateTime(2020, 12, 2, 13, 45, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Incident Edit", 8, "Incident AM", "0", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "Incident Edit", 10, "Incident BA", "1", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "Incident Edit", 12, "Incident HZ", "0", new DateTime(2020, 12, 1, 12, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Incident Delete", 14, "Incident EO", "1", new DateTime(2020, 12, 1, 7, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Incident Edit", 16, "Incident PA", "0", new DateTime(2020, 12, 1, 5, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Incident Edit", 18, "Incident TD", "1", new DateTime(2020, 12, 2, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "Incident Activity Log", 0, "Incident NC", "0", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Incident Edit", 38, "Incident PL", "1", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Incident Activity Log", 22, "Incident HL", "1", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Incident Delete", 24, "Incident WU", "0", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "Incident Delete", 26, "Incident MD", "1", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Incident Activity Log", 28, "Incident MZ", "0", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Incident Add", 30, "Incident UO", "1", new DateTime(2020, 12, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 26, "Incident Add", 32, "Incident RB", "0", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Incident Activity Log", 34, "Incident MN", "1", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "Incident Activity Log", 20, "Incident OC", "0", new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "MonitorRegionLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "MonitorRegion Delete", 54, "MonitorRegion SZ", "1", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "MonitorRegion Activity Log", 52, "MonitorRegion EK", "0", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "MonitorRegion Activity Log", 44, "MonitorRegion OF", "0", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "MonitorRegion Delete", 48, "MonitorRegion FM", "0", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "MonitorRegion Add", 46, "MonitorRegion LG", "1", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "MonitorRegion Add", 56, "MonitorRegion QP", "0", new DateTime(2020, 12, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "MonitorRegion Delete", 50, "MonitorRegion DA", "1", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "MonitorRegion Add", 58, "MonitorRegion PB", "1", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "MonitorRegion Activity Log", 68, "MonitorRegion XI", "0", new DateTime(2020, 12, 2, 7, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "MonitorRegion Edit", 62, "MonitorRegion GQ", "1", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "MonitorRegion Delete", 64, "MonitorRegion JH", "0", new DateTime(2020, 12, 1, 9, 36, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "MonitorRegion Edit", 66, "MonitorRegion BC", "1", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "MonitorRegion Activity Log", 70, "MonitorRegion OG", "1", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "MonitorRegion Activity Log", 72, "MonitorRegion HF", "0", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "MonitorRegion Add", 74, "MonitorRegion HD", "1", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "MonitorRegion Edit", 76, "MonitorRegion YF", "0", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "MonitorRegion Activity Log", 42, "MonitorRegion NE", "1", new DateTime(2020, 12, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "MonitorRegion Edit", 60, "MonitorRegion RG", "0", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "MonitorRegion Delete", 40, "MonitorRegion YW", "0", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "MonitorRegion Activity Log", 78, "MonitorRegion QW", "1", new DateTime(2020, 12, 2, 13, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "MonitorRegion Edit", 36, "MonitorRegion JC", "0", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "MonitorRegion Edit", 0, "MonitorRegion YT", "0", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "MonitorRegion Delete", 2, "MonitorRegion DT", "1", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "MonitorRegion Edit", 4, "MonitorRegion PF", "0", new DateTime(2020, 12, 2, 16, 35, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "MonitorRegion Add", 6, "MonitorRegion FK", "1", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 14, "MonitorRegion Edit", 8, "MonitorRegion QU", "0", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "MonitorRegion Delete", 10, "MonitorRegion VF", "1", new DateTime(2020, 12, 1, 3, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "MonitorRegion Activity Log", 12, "MonitorRegion AP", "0", new DateTime(2020, 12, 1, 4, 37, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "MonitorRegion Delete", 14, "MonitorRegion VP", "1", new DateTime(2020, 12, 1, 10, 28, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "MonitorRegion Add", 16, "MonitorRegion AL", "0", new DateTime(2020, 12, 2, 1, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "MonitorRegion Add", 38, "MonitorRegion ID", "1", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "MonitorRegion Edit", 20, "MonitorRegion BP", "0", new DateTime(2020, 12, 1, 12, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "MonitorRegion Add", 22, "MonitorRegion KS", "1", new DateTime(2020, 12, 2, 4, 40, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "MonitorRegion Activity Log", 24, "MonitorRegion PV", "0", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "MonitorRegion Edit", 26, "MonitorRegion OH", "1", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "MonitorRegion Add", 28, "MonitorRegion VR", "0", new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "MonitorRegion Activity Log", 30, "MonitorRegion QB", "1", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "MonitorRegion Activity Log", 32, "MonitorRegion TE", "0", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "MonitorRegion Activity Log", 34, "MonitorRegion MI", "1", new DateTime(2020, 12, 1, 8, 21, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "MonitorRegion Edit", 18, "MonitorRegion TJ", "1", new DateTime(2020, 12, 1, 7, 23, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "ObjectObserves",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "ObjectObserve Delete", 54, "ObjectObserve ZT", "1", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "ObjectObserve Activity Log", 52, "ObjectObserve IV", "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "ObjectObserve Add", 50, "ObjectObserve IE", "1", new DateTime(2020, 12, 1, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "ObjectObserve Delete", 42, "ObjectObserve VG", "1", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "ObjectObserve Activity Log", 46, "ObjectObserve EQ", "1", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "ObjectObserve Add", 44, "ObjectObserve FV", "0", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "ObjectObserve Edit", 56, "ObjectObserve ZD", "0", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ObjectObserve Activity Log", 48, "ObjectObserve GF", "0", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "ObjectObserve Edit", 58, "ObjectObserve TP", "1", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "ObjectObserve Delete", 66, "ObjectObserve HJ", "1", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "ObjectObserve Edit", 62, "ObjectObserve BI", "1", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 42, "ObjectObserve Delete", 64, "ObjectObserve BV", "0", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "ObjectObserve Edit", 68, "ObjectObserve GT", "0", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "ObjectObserve Delete", 70, "ObjectObserve IR", "1", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 46, "ObjectObserve Activity Log", 72, "ObjectObserve CQ", "0", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "ObjectObserve Activity Log", 74, "ObjectObserve KU", "1", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "ObjectObserve Edit", 76, "ObjectObserve VS", "0", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "ObjectObserve Delete", 40, "ObjectObserve RG", "0", new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "ObjectObserve Activity Log", 60, "ObjectObserve JW", "0", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "ObjectObserve Delete", 78, "ObjectObserve VW", "1", new DateTime(2020, 12, 2, 6, 19, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "ObjectObserve Add", 38, "ObjectObserve CO", "1", new DateTime(2020, 12, 1, 9, 12, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "ObjectObserve Delete", 34, "ObjectObserve YZ", "1", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "ObjectObserve Add", 36, "ObjectObserve YZ", "0", new DateTime(2020, 12, 2, 11, 16, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "ObjectObserve Edit", 0, "ObjectObserve VN", "0", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "ObjectObserve Activity Log", 2, "ObjectObserve ZF", "1", new DateTime(2020, 12, 2, 5, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "ObjectObserve Activity Log", 4, "ObjectObserve YY", "0", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "ObjectObserve Add", 6, "ObjectObserve IR", "1", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "ObjectObserve Edit", 10, "ObjectObserve PE", "1", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 16, "ObjectObserve Edit", 12, "ObjectObserve EQ", "0", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "ObjectObserve Edit", 14, "ObjectObserve VI", "1", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 14, "ObjectObserve Add", 8, "ObjectObserve JV", "0", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "ObjectObserve Add", 18, "ObjectObserve RP", "1", new DateTime(2020, 12, 1, 3, 44, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "ObjectObserve Delete", 20, "ObjectObserve BN", "0", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "ObjectObserve Activity Log", 22, "ObjectObserve OV", "1", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "ObjectObserve Edit", 24, "ObjectObserve ZF", "0", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "ObjectObserve Delete", 26, "ObjectObserve ZP", "1", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "ObjectObserve Delete", 28, "ObjectObserve RN", "0", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "ObjectObserve Delete", 30, "ObjectObserve PO", "1", new DateTime(2020, 12, 2, 14, 43, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "ObjectObserve Activity Log", 16, "ObjectObserve KZ", "0", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, "ObjectObserve Add", 32, "ObjectObserve XB", "0", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "Payloads",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "Payload Add", 56, "Payload YF", "0", new DateTime(2020, 12, 2, 14, 11, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "Payload Edit", 54, "Payload QN", "1", new DateTime(2020, 12, 1, 4, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Payload Delete", 52, "Payload TC", "0", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 32, "Payload Edit", 44, "Payload SQ", "0", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "Payload Edit", 48, "Payload KP", "0", new DateTime(2020, 12, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Payload Edit", 46, "Payload AR", "1", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "Payload Activity Log", 58, "Payload YW", "1", new DateTime(2020, 12, 2, 15, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "Payload Edit", 50, "Payload MJ", "1", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "Payload Add", 60, "Payload KY", "0", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Payload Delete", 78, "Payload FN", "1", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 42, "Payload Activity Log", 64, "Payload ND", "0", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 43, "Payload Delete", 66, "Payload KK", "1", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 44, "Payload Add", 68, "Payload IZ", "0", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 45, "Payload Activity Log", 70, "Payload UF", "1", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "Payload Add", 72, "Payload CS", "0", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "Payload Delete", 74, "Payload QX", "1", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Payload Edit", 76, "Payload CK", "0", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Payload Delete", 42, "Payload MF", "1", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Payload Add", 62, "Payload EQ", "1", new DateTime(2020, 12, 2, 5, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Payload Activity Log", 40, "Payload BV", "0", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "Payload Edit", 36, "Payload FU", "0", new DateTime(2020, 12, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 29, "Payload Activity Log", 38, "Payload RP", "1", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Payload Edit", 0, "Payload UQ", "0", new DateTime(2020, 12, 2, 11, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Payload Delete", 2, "Payload UJ", "1", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Payload Edit", 4, "Payload JE", "0", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Payload Activity Log", 6, "Payload BK", "1", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Payload Delete", 8, "Payload SN", "0", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Payload Delete", 12, "Payload HK", "0", new DateTime(2020, 12, 1, 8, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "Payload Delete", 14, "Payload AT", "1", new DateTime(2020, 12, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Payload Activity Log", 16, "Payload EO", "0", new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Payload Delete", 10, "Payload HH", "1", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Payload Delete", 20, "Payload VU", "0", new DateTime(2020, 12, 2, 15, 40, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, "Payload Edit", 18, "Payload OV", "1", new DateTime(2020, 12, 1, 2, 29, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "Payload Activity Log", 32, "Payload AR", "0", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, "Payload Add", 30, "Payload CW", "1", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 24, "Payload Activity Log", 28, "Payload QM", "0", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "Payload Delete", 34, "Payload PU", "1", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 22, "Payload Delete", 24, "Payload PT", "0", new DateTime(2020, 12, 1, 8, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "Payload Edit", 22, "Payload BY", "1", new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Payload Activity Log", 26, "Payload ST", "1", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "ResolveProblemLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 40, "ResolveProblem Delete", 60, "ResolveProblem LI", "0", new DateTime(2020, 12, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 33, "ResolveProblem Edit", 46, "ResolveProblem EX", "1", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 34, "ResolveProblem Delete", 48, "ResolveProblem DI", "0", new DateTime(2020, 12, 1, 12, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "ResolveProblem Delete", 50, "ResolveProblem BI", "1", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 36, "ResolveProblem Activity Log", 52, "ResolveProblem KF", "0", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, "ResolveProblem Delete", 54, "ResolveProblem CO", "1", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 38, "ResolveProblem Activity Log", 56, "ResolveProblem ZH", "0", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, "ResolveProblem Delete", 58, "ResolveProblem QU", "1", new DateTime(2020, 12, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "ResolveProblem Edit", 62, "ResolveProblem CA", "1", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 30, "ResolveProblem Delete", 40, "ResolveProblem XT", "0", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "ResolveProblem Add", 66, "ResolveProblem KA", "1", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "ResolveProblem Edit", 68, "ResolveProblem JF", "0", new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 45, "ResolveProblem Edit", 70, "ResolveProblem CB", "1", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 46, "ResolveProblem Add", 72, "ResolveProblem MD", "0", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "ResolveProblem Activity Log", 74, "ResolveProblem TY", "1", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "ResolveProblem Edit", 76, "ResolveProblem YV", "0", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 49, "ResolveProblem Add", 78, "ResolveProblem VL", "1", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 32, "ResolveProblem Add", 44, "ResolveProblem IK", "0", new DateTime(2020, 12, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "ResolveProblem Add", 64, "ResolveProblem OQ", "0", new DateTime(2020, 12, 1, 15, 13, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 31, "ResolveProblem Edit", 42, "ResolveProblem LK", "1", new DateTime(2020, 12, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 24, "ResolveProblem Delete", 28, "ResolveProblem BK", "0", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 29, "ResolveProblem Edit", 38, "ResolveProblem IX", "1", new DateTime(2020, 12, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "ResolveProblem Edit", 0, "ResolveProblem PY", "0", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "ResolveProblem Add", 2, "ResolveProblem LU", "1", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "ResolveProblem Add", 4, "ResolveProblem SZ", "0", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "ResolveProblem Activity Log", 6, "ResolveProblem XU", "1", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "ResolveProblem Edit", 8, "ResolveProblem JD", "0", new DateTime(2020, 12, 1, 6, 10, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "ResolveProblem Delete", 10, "ResolveProblem OU", "1", new DateTime(2020, 12, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "ResolveProblem Delete", 14, "ResolveProblem JH", "1", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "ResolveProblem Activity Log", 16, "ResolveProblem OJ", "0", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "ResolveProblem Add", 18, "ResolveProblem ZH", "1", new DateTime(2020, 12, 1, 13, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "ResolveProblem Edit", 12, "ResolveProblem GC", "0", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "ResolveProblem Delete", 22, "ResolveProblem ZM", "1", new DateTime(2020, 12, 1, 9, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "ResolveProblem Delete", 20, "ResolveProblem NT", "0", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 27, "ResolveProblem Delete", 34, "ResolveProblem FJ", "1", new DateTime(2020, 12, 2, 4, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "ResolveProblem Add", 32, "ResolveProblem KK", "0", new DateTime(2020, 12, 2, 3, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "ResolveProblem Delete", 30, "ResolveProblem JX", "1", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "ResolveProblem Activity Log", 36, "ResolveProblem FF", "0", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "ResolveProblem Edit", 26, "ResolveProblem XV", "1", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 22, "ResolveProblem Add", 24, "ResolveProblem RL", "0", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "StaticalLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 32, "Statical Add", 44, "Statical JK", "0", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 33, "Statical Delete", 46, "Statical OD", "1", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Statical Edit", 48, "Statical BJ", "0", new DateTime(2020, 12, 2, 11, 6, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 35, "Statical Edit", 50, "Statical YV", "1", new DateTime(2020, 12, 1, 7, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Statical Delete", 52, "Statical PN", "0", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 37, "Statical Add", 54, "Statical JP", "1", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 38, "Statical Add", 56, "Statical PI", "0", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 39, "Statical Delete", 58, "Statical TM", "1", new DateTime(2020, 12, 2, 16, 25, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 40, "Statical Activity Log", 60, "Statical CG", "0", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "Statical Activity Log", 78, "Statical XR", "1", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Statical Edit", 64, "Statical OQ", "0", new DateTime(2020, 12, 1, 6, 3, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 43, "Statical Edit", 66, "Statical ID", "1", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Statical Delete", 68, "Statical IS", "0", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 45, "Statical Add", 70, "Statical JL", "1", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Statical Delete", 72, "Statical OS", "0", new DateTime(2020, 12, 1, 2, 18, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Statical Add", 74, "Statical NR", "1", new DateTime(2020, 12, 1, 12, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "Statical Edit", 76, "Statical TH", "0", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 31, "Statical Activity Log", 42, "Statical HW", "1", new DateTime(2020, 12, 2, 14, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "Statical Activity Log", 62, "Statical DA", "1", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, "Statical Activity Log", 40, "Statical RL", "0", new DateTime(2020, 12, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, "Statical Add", 0, "Statical QM", "0", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "Statical Add", 36, "Statical RW", "0", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Statical Activity Log", 38, "Statical HD", "1", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, "Statical Add", 2, "Statical EU", "1", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, "Statical Activity Log", 4, "Statical IE", "0", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "Statical Activity Log", 6, "Statical SG", "1", new DateTime(2020, 12, 2, 15, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, "Statical Delete", 8, "Statical NB", "0", new DateTime(2020, 12, 1, 4, 14, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Statical Add", 12, "Statical BQ", "0", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Statical Delete", 14, "Statical TR", "1", new DateTime(2020, 12, 1, 10, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 18, "Statical Activity Log", 16, "Statical AY", "0", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, "Statical Delete", 10, "Statical RS", "1", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Statical Edit", 20, "Statical VG", "0", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Statical Activity Log", 22, "Statical DQ", "1", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Statical Activity Log", 24, "Statical NC", "0", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Statical Activity Log", 26, "Statical RA", "1", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Statical Edit", 28, "Statical XK", "0", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Statical Delete", 30, "Statical MW", "1", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Statical Edit", 32, "Statical HE", "0", new DateTime(2020, 12, 2, 9, 47, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "Statical Add", 18, "Statical WF", "1", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Statical Activity Log", 34, "Statical MT", "1", new DateTime(2020, 12, 1, 13, 25, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.InsertData(
                table: "UavConnectLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 38, "UavConnect Add", 56, "UavConnect BY", "0", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 37, "UavConnect Activity Log", 54, "UavConnect MH", "1", new DateTime(2020, 12, 2, 2, 9, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, "UavConnect Activity Log", 52, "UavConnect AE", "0", new DateTime(2020, 12, 2, 2, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "UavConnect Activity Log", 44, "UavConnect OZ", "0", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, "UavConnect Edit", 48, "UavConnect VJ", "0", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "UavConnect Delete", 46, "UavConnect VB", "1", new DateTime(2020, 12, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 31, "UavConnect Activity Log", 42, "UavConnect DK", "1", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, "UavConnect Edit", 50, "UavConnect FO", "1", new DateTime(2020, 12, 1, 2, 48, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 39, "UavConnect Add", 58, "UavConnect OC", "1", new DateTime(2020, 12, 2, 1, 7, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 48, "UavConnect Activity Log", 76, "UavConnect FS", "0", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 41, "UavConnect Add", 62, "UavConnect LU", "1", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 42, "UavConnect Delete", 64, "UavConnect DP", "0", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "UavConnect Activity Log", 66, "UavConnect VQ", "1", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 44, "UavConnect Activity Log", 68, "UavConnect QS", "0", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "UavConnect Activity Log", 70, "UavConnect LB", "1", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "UavConnect Add", 72, "UavConnect AP", "0", new DateTime(2020, 12, 1, 14, 9, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 47, "UavConnect Activity Log", 74, "UavConnect PY", "1", new DateTime(2020, 12, 2, 16, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "UavConnect Edit", 78, "UavConnect SB", "1", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 40, "UavConnect Delete", 60, "UavConnect UX", "0", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "UavConnect Add", 40, "UavConnect EZ", "0", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 20, "UavConnect Add", 20, "UavConnect VS", "0", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 28, "UavConnect Edit", 36, "UavConnect VK", "0", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 10, "UavConnect Add", 0, "UavConnect RR", "0", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "UavConnect Edit", 2, "UavConnect JT", "1", new DateTime(2020, 12, 2, 14, 37, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "UavConnect Edit", 4, "UavConnect UB", "0", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "UavConnect Delete", 6, "UavConnect GN", "1", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "UavConnect Edit", 8, "UavConnect XA", "0", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, "UavConnect Add", 10, "UavConnect YS", "1", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 16, "UavConnect Delete", 12, "UavConnect IW", "0", new DateTime(2020, 12, 2, 3, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 17, "UavConnect Add", 14, "UavConnect HD", "1", new DateTime(2020, 12, 1, 15, 43, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "UavConnect Edit", 38, "UavConnect ZZ", "1", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 19, "UavConnect Delete", 18, "UavConnect VE", "1", new DateTime(2020, 12, 1, 2, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 21, "UavConnect Add", 22, "UavConnect XS", "1", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "UavConnect Delete", 24, "UavConnect XA", "0", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 23, "UavConnect Delete", 26, "UavConnect ZH", "1", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "UavConnect Add", 28, "UavConnect SG", "0", new DateTime(2020, 12, 1, 15, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 25, "UavConnect Edit", 30, "UavConnect EW", "1", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 26, "UavConnect Activity Log", 32, "UavConnect OA", "0", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, "UavConnect Add", 34, "UavConnect XN", "1", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, "UavConnect Edit", 16, "UavConnect JR", "0", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.InsertData(
                table: "VideoLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Video Add", 54, "Video VZ", "1", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 36, "Video Add", 52, "Video LB", "0", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 35, "Video Activity Log", 50, "Video KF", "1", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Video Activity Log", 42, "Video EL", "1", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, "Video Activity Log", 46, "Video RS", "1", new DateTime(2020, 12, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, "Video Activity Log", 44, "Video YF", "0", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, "Video Add", 56, "Video LR", "0", new DateTime(2020, 12, 1, 5, 20, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 34, "Video Delete", 48, "Video QN", "0", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "Video Delete", 58, "Video WC", "1", new DateTime(2020, 12, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Video Add", 66, "Video YN", "1", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 41, "Video Activity Log", 62, "Video GS", "1", new DateTime(2020, 12, 2, 17, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Video Edit", 64, "Video XP", "0", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 44, "Video Activity Log", 68, "Video UM", "0", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Video Activity Log", 70, "Video LJ", "1", new DateTime(2020, 12, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 46, "Video Delete", 72, "Video HN", "0", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 47, "Video Delete", 74, "Video PT", "1", new DateTime(2020, 12, 1, 9, 26, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 30, "Video Add", 40, "Video QZ", "0", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 49, "Video Add", 78, "Video VS", "1", new DateTime(2020, 12, 1, 6, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 40, "Video Activity Log", 60, "Video PI", "0", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "Video Add", 76, "Video CU", "0", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 29, "Video Edit", 38, "Video EG", "1", new DateTime(2020, 12, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 27, "Video Activity Log", 34, "Video ZU", "1", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, "Video Add", 36, "Video YO", "0", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 10, "Video Add", 0, "Video NI", "0", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Video Delete", 2, "Video TJ", "1", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Video Add", 4, "Video DS", "0", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 13, "Video Delete", 6, "Video CD", "1", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, "Video Activity Log", 10, "Video EN", "1", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, "Video Add", 12, "Video WL", "0", new DateTime(2020, 12, 1, 14, 23, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 17, "Video Delete", 14, "Video ZQ", "1", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Video Activity Log", 8, "Video GL", "0", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Video Edit", 18, "Video DS", "1", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 18, "Video Delete", 16, "Video MG", "0", new DateTime(2020, 12, 1, 11, 20, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 25, "Video Activity Log", 30, "Video LF", "1", new DateTime(2020, 12, 2, 9, 14, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, "Video Activity Log", 28, "Video UN", "0", new DateTime(2020, 12, 1, 7, 31, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, "Video Delete", 26, "Video JO", "1", new DateTime(2020, 12, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Video Activity Log", 32, "Video EO", "0", new DateTime(2020, 12, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, "Video Activity Log", 22, "Video AM", "1", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, "Video Add", 20, "Video QF", "0", new DateTime(2020, 12, 1, 7, 2, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 22, "Video Delete", 24, "Video MF", "0", new DateTime(2020, 12, 2, 12, 19, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "WarningLogs",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Name", "State", "Timestamp", "Type" },
                values: new object[,]
                {
                    { 37, "Warning Activity Log", 54, "Warning EC", "1", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, "Warning Edit", 42, "Warning QK", "1", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 32, "Warning Edit", 44, "Warning GT", "0", new DateTime(2020, 12, 2, 13, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 33, "Warning Delete", 46, "Warning WA", "1", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, "Warning Delete", 48, "Warning PX", "0", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 35, "Warning Edit", 50, "Warning JC", "1", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 36, "Warning Edit", 52, "Warning KW", "0", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 38, "Warning Add", 56, "Warning LS", "0", new DateTime(2020, 12, 2, 14, 47, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 30, "Warning Activity Log", 40, "Warning IJ", "0", new DateTime(2020, 12, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, "Warning Delete", 60, "Warning DK", "0", new DateTime(2020, 12, 1, 9, 13, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 41, "Warning Activity Log", 62, "Warning KU", "1", new DateTime(2020, 12, 1, 3, 42, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 42, "Warning Delete", 64, "Warning YJ", "0", new DateTime(2020, 12, 2, 8, 17, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 43, "Warning Add", 66, "Warning QP", "1", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 44, "Warning Activity Log", 68, "Warning YI", "0", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 45, "Warning Add", 70, "Warning WJ", "1", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 46, "Warning Activity Log", 72, "Warning XH", "0", new DateTime(2020, 12, 2, 15, 44, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 47, "Warning Delete", 74, "Warning RT", "1", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 39, "Warning Activity Log", 58, "Warning MJ", "1", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, "Warning Delete", 38, "Warning EX", "1", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 48, "Warning Add", 76, "Warning AE", "0", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 27, "Warning Delete", 34, "Warning ZW", "1", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, "Warning Edit", 0, "Warning OP", "0", new DateTime(2020, 12, 1, 3, 39, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 11, "Warning Activity Log", 2, "Warning QL", "1", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, "Warning Activity Log", 4, "Warning RY", "0", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, "Warning Delete", 6, "Warning CJ", "1", new DateTime(2020, 12, 1, 4, 29, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 14, "Warning Add", 8, "Warning TG", "0", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Warning Delete", 10, "Warning PB", "1", new DateTime(2020, 12, 2, 9, 3, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Warning Activity Log", 12, "Warning AF", "0", new DateTime(2020, 12, 2, 11, 1, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, "Warning Activity Log", 14, "Warning CF", "1", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, "Warning Activity Log", 16, "Warning SP", "0", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, "Warning Edit", 18, "Warning IJ", "1", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 20, "Warning Edit", 20, "Warning SR", "0", new DateTime(2020, 12, 1, 2, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 21, "Warning Activity Log", 22, "Warning ZU", "1", new DateTime(2020, 12, 2, 16, 17, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, "Warning Edit", 24, "Warning PR", "0", new DateTime(2020, 12, 1, 14, 44, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 23, "Warning Delete", 26, "Warning CR", "1", new DateTime(2020, 12, 1, 13, 37, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 24, "Warning Edit", 28, "Warning AM", "0", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 25, "Warning Delete", 30, "Warning WT", "1", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 26, "Warning Delete", 32, "Warning FE", "0", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 28, "Warning Delete", 36, "Warning QL", "0", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 49, "Warning Delete", 78, "Warning JE", "1", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 3 }
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
