using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class seeder3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "UserLog");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserLog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 47, 29, "Drone CE", "OKLKL", new DateTime(2020, 12, 1, 5, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 43, 31, "Drone OF", "ASNPD", new DateTime(2020, 12, 2, 8, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 19, 37, "Drone OO", "UACJK", new DateTime(2020, 12, 2, 1, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 27, 32, "Drone AP", "VTLRJ", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 44, 37, "Drone NL", "KWKYF", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 43, 21, "Drone GC", "RKETV", new DateTime(2020, 12, 1, 4, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 22, 48, "Drone QB", "PJFAU", new DateTime(2020, 12, 2, 12, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 40, 25, "Drone MB", "VLPRQ", new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 10, 35, "Drone GM", "COEHD", new DateTime(2020, 12, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 27, 38, "Drone UF", "OARZK", new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 31, 35, "Drone PE", "QMCZV", new DateTime(2020, 12, 1, 15, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 26, "Drone TL", "VKDUY", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 32, 42, "Drone VV", "IDRGB", new DateTime(2020, 12, 2, 3, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 20, 46, "Drone BO", "WYLUY", new DateTime(2020, 12, 2, 17, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 12, 18, "Drone BF", "FAAEK", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 18, 20, "Drone RI", "KKLTC", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 14, 10, "Drone ZM", "OMQHD", new DateTime(2020, 12, 2, 5, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 37, 21, "Drone JV", "QTDWE", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 24, 43, "Drone HT", "VCPYS", new DateTime(2020, 12, 1, 7, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 18, 41, "Drone BG", "XDWRJ", new DateTime(2020, 12, 1, 17, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 30, 25, "Drone HX", "QPFLK", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 23, 42, "Drone JI", "NENRY", new DateTime(2020, 12, 1, 15, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 48, 31, "Drone KD", "PRXAC", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 31, 48, "Drone VM", "SJJZC", new DateTime(2020, 12, 1, 5, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 48, 39, "Drone JJ", "MYGOD", new DateTime(2020, 12, 1, 9, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 18, 10, "Drone CI", "EJKNT", new DateTime(2020, 12, 2, 5, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 42, "Drone FC", "VWBRE", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 39, 45, "Drone YD", "MYTBX", new DateTime(2020, 12, 2, 11, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 45, 33, "Drone TW", "SYEZC", new DateTime(2020, 12, 1, 3, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 42, 31, "Drone PN", "IJWSZ", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 19, 22, "Drone UK", "AVEGU", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 41, 26, "Drone HR", "VACFQ", new DateTime(2020, 12, 2, 4, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 22, 48, "Drone IL", "GSVVX", new DateTime(2020, 12, 2, 3, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 16, 32, "Drone KG", "ZVJVJ", new DateTime(2020, 12, 2, 10, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 35, 48, "Drone WX", "LCBBU", new DateTime(2020, 12, 2, 17, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 25, 31, "Drone RP", "OXECR", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 37, 14, "Drone ST", "RQMGU", new DateTime(2020, 12, 2, 7, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 14, 43, "Drone PY", "JCHZL", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 22, 12, "Drone PL", "TFTOG", new DateTime(2020, 12, 2, 16, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 46, 48, "Drone JK", "VXHZE", new DateTime(2020, 12, 2, 3, 43, 0, 0, DateTimeKind.Unspecified), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserLog");

            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "UserLog",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 32, 39, "Drone FI", "EPNXG", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 37, 19, "Drone UI", "WUWYA", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 25, 39, "Drone OM", "KFDKW", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 33, 24, "Drone VD", "VQMSC", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 40, 22, "Drone IC", "BKHIZ", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 44, 33, "Drone TC", "SYUAX", new DateTime(2020, 12, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 23, 34, "Drone XQ", "HWGSK", new DateTime(2020, 12, 1, 14, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 36, 42, "Drone PY", "DWBQS", new DateTime(2020, 12, 1, 5, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 38, 17, "Drone AD", "RWXPN", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 17, 23, "Drone MT", "CCRXT", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 41, 25, "Drone LP", "OCLGP", new DateTime(2020, 12, 2, 1, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 23, "Drone MH", "UQFCG", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 13, 16, "Drone MX", "AUIBW", new DateTime(2020, 12, 1, 11, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 40, 26, "Drone SX", "TEPHF", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 40, 27, "Drone SL", "CZCQE", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 32, 29, "Drone AV", "HTUWU", new DateTime(2020, 12, 2, 1, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 30, 35, "Drone SF", "VOWZD", new DateTime(2020, 12, 2, 13, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 48, 14, "Drone HZ", "FENKV", new DateTime(2020, 12, 1, 11, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 23, 37, "Drone QZ", "TOAHK", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 32, 15, "Drone AM", "IBTDR", new DateTime(2020, 12, 1, 14, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 40, 27, "Drone YN", "IZMQW", new DateTime(2020, 12, 1, 14, 47, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 24, 39, "Drone AK", "TALZF", new DateTime(2020, 12, 2, 8, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 40, 40, "Drone OF", "UTDFA", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 28, 14, "Drone CJ", "POQBY", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 36, 42, "Drone IF", "RUCWV", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 13, 14, "Drone ZD", "BROJF", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 20, "Drone HS", "QUJYW", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 13, 46, "Drone LK", "UIAHH", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 18, 36, "Drone OD", "QGHKX", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 32, 22, "Drone VY", "NIDIZ", new DateTime(2020, 12, 2, 2, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 27, 38, "Drone LI", "LILET", new DateTime(2020, 12, 1, 5, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 48, 47, "Drone XM", "CIBMH", new DateTime(2020, 12, 1, 13, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 19, 44, "Drone TK", "GYTYS", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 29, 11, "Drone JU", "QXKND", new DateTime(2020, 12, 2, 5, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 31, 30, "Drone GW", "JLWZZ", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 49, 44, "Drone RD", "XWHPN", new DateTime(2020, 12, 1, 2, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 40, 44, "Drone ZX", "VMCAC", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 39, 18, "Drone VH", "XJNWB", new DateTime(2020, 12, 2, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 15, 48, "Drone NQ", "NCDWB", new DateTime(2020, 12, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 23, 39, "Drone VO", "BNBVL", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 });
        }
    }
}
