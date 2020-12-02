using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class Seeder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Latitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 41, "Drone VV", "UEJDJ", new DateTime(2020, 12, 2, 17, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 24, 35, "Drone RJ", "NOOHH", new DateTime(2020, 12, 1, 2, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 45, 10, "Drone GU", "DTEZX", new DateTime(2020, 12, 2, 11, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 39, 40, "Drone PH", "ZJGMT", new DateTime(2020, 12, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 30, 36, "Drone AW", "OUUEH", new DateTime(2020, 12, 2, 10, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 16, 14, "Drone VY", "QICIX", new DateTime(2020, 12, 2, 12, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 38, 36, "Drone SU", "OIOTJ", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 36, 12, "Drone IF", "JPEAO", new DateTime(2020, 12, 2, 8, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 25, 40, "Drone FO", "HOSNX", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 34, 18, "Drone LX", "WNJPE", new DateTime(2020, 12, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 16, 34, "Drone NQ", "KGYLA", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 15, 23, "Drone WB", "AHUSV", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 19, 14, "Drone LD", "CDBJC", new DateTime(2020, 12, 2, 4, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 19, 18, "Drone FI", "TLWVJ", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 36, 22, "Drone UY", "SAPIJ", new DateTime(2020, 12, 2, 15, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 40, 35, "Drone WH", "XWMPL", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 48, 49, "Drone NB", "MBMAK", new DateTime(2020, 12, 2, 13, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 14, 37, "Drone VN", "DQROQ", new DateTime(2020, 12, 1, 3, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 23, 19, "Drone TY", "ZVZUG", new DateTime(2020, 12, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 20, 47, "Drone NX", "FGLGY", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 25, 34, "Drone HO", "EWIIS", new DateTime(2020, 12, 1, 3, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 44, 43, "Drone JD", "ZPETD", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 30, 39, "Drone MT", "JRQPW", new DateTime(2020, 12, 2, 9, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 20, 44, "Drone VB", "CEUDC", new DateTime(2020, 12, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 31, 28, "Drone FC", "SUKUM", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 27, 11, "Drone FE", "HVVRO", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 43, 21, "Drone IA", "DIWHX", new DateTime(2020, 12, 2, 15, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 23, 37, "Drone KB", "COFNN", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 21, 42, "Drone JQ", "OOAIY", new DateTime(2020, 12, 2, 17, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 33, 14, "Drone CF", "OZIBQ", new DateTime(2020, 12, 1, 12, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 25, 20, "Drone TS", "AYATY", new DateTime(2020, 12, 1, 5, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 47, 18, "Drone PE", "TTSXZ", new DateTime(2020, 12, 1, 7, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 42, 19, "Drone VX", "TRCZE", new DateTime(2020, 12, 2, 6, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 18, 20, "Drone ZA", "SSTXZ", new DateTime(2020, 12, 1, 5, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Latitude", "Longitude", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 33, 19, "JHNOK", new DateTime(2020, 12, 1, 2, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 38, 19, "Drone SE", "VQPFQ", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 23, 38, "Drone FT", "VLHZZ", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 32, 44, "Drone VK", "BGBFZ", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 15, 39, "Drone PM", "SRNRB", new DateTime(2020, 12, 1, 14, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 11, 41, "Drone RD", "MHDOG", new DateTime(2020, 12, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image WC", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image SG", new DateTime(2020, 12, 2, 3, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image BO", new DateTime(2020, 12, 1, 12, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image AM", new DateTime(2020, 12, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image YB", new DateTime(2020, 12, 1, 13, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image QX", new DateTime(2020, 12, 2, 12, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image EW", new DateTime(2020, 12, 1, 13, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image XC", new DateTime(2020, 12, 2, 8, 47, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image WR", new DateTime(2020, 12, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image KB", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image DF", new DateTime(2020, 12, 2, 2, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image JE", new DateTime(2020, 12, 2, 1, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image CK", new DateTime(2020, 12, 1, 6, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image GY", new DateTime(2020, 12, 2, 12, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image PW", new DateTime(2020, 12, 1, 6, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image DT", new DateTime(2020, 12, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image MO", new DateTime(2020, 12, 2, 6, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image WZ", new DateTime(2020, 12, 1, 12, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image ZY", new DateTime(2020, 12, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image RW", new DateTime(2020, 12, 1, 2, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image PR", new DateTime(2020, 12, 1, 8, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image BW", new DateTime(2020, 12, 1, 11, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image IO", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image HN", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image RX", new DateTime(2020, 12, 2, 3, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image WI", new DateTime(2020, 12, 1, 7, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image SS", new DateTime(2020, 12, 1, 3, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image DX", new DateTime(2020, 12, 2, 16, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image BH", new DateTime(2020, 12, 1, 5, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image QK", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image CL", new DateTime(2020, 12, 2, 17, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image BQ", new DateTime(2020, 12, 1, 12, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image NN", new DateTime(2020, 12, 1, 6, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image GV", new DateTime(2020, 12, 2, 11, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image YF", new DateTime(2020, 12, 1, 5, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image CE", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image SC", new DateTime(2020, 12, 2, 16, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image VY", new DateTime(2020, 12, 1, 2, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image QM", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image AA", new DateTime(2020, 12, 1, 12, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident VT", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident AI", new DateTime(2020, 12, 1, 10, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident VN", new DateTime(2020, 12, 2, 5, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident BC", new DateTime(2020, 12, 2, 15, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident AO", new DateTime(2020, 12, 2, 6, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident WY", new DateTime(2020, 12, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident NN", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident BF", new DateTime(2020, 12, 1, 14, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident VP", new DateTime(2020, 12, 2, 9, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident SZ", new DateTime(2020, 12, 1, 6, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident MX", new DateTime(2020, 12, 1, 8, 1, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident GD", new DateTime(2020, 12, 1, 15, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident ZC", new DateTime(2020, 12, 1, 7, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident MN", new DateTime(2020, 12, 1, 1, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident QF", new DateTime(2020, 12, 2, 11, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident RV", new DateTime(2020, 12, 2, 13, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident JH", new DateTime(2020, 12, 2, 17, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident MA", new DateTime(2020, 12, 1, 11, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident OU", new DateTime(2020, 12, 2, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident WE", new DateTime(2020, 12, 1, 11, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident UD", new DateTime(2020, 12, 1, 6, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident OO", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident KU", new DateTime(2020, 12, 2, 14, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident EX", new DateTime(2020, 12, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident OA", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident GK", new DateTime(2020, 12, 1, 9, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident CE", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident ZI", new DateTime(2020, 12, 2, 10, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident CA", new DateTime(2020, 12, 2, 15, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident QR", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident ID", new DateTime(2020, 12, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident LR", new DateTime(2020, 12, 1, 2, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident IC", new DateTime(2020, 12, 1, 9, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident RG", new DateTime(2020, 12, 2, 6, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident JF", new DateTime(2020, 12, 1, 10, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident UX", new DateTime(2020, 12, 2, 2, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident SH", new DateTime(2020, 12, 1, 7, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident OT", new DateTime(2020, 12, 2, 10, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident YU", new DateTime(2020, 12, 1, 10, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident VM", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion XT", new DateTime(2020, 12, 1, 5, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion JJ", new DateTime(2020, 12, 1, 9, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AS", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion XP", new DateTime(2020, 12, 1, 7, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion GQ", new DateTime(2020, 12, 2, 16, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AM", new DateTime(2020, 12, 1, 10, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion TX", new DateTime(2020, 12, 2, 1, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion QS", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion ZR", new DateTime(2020, 12, 2, 2, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion TX", new DateTime(2020, 12, 2, 13, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AD", new DateTime(2020, 12, 1, 8, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion XW", new DateTime(2020, 12, 2, 8, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion XQ", new DateTime(2020, 12, 2, 11, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion OK", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion OG", new DateTime(2020, 12, 2, 16, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion IL", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion MQ", new DateTime(2020, 12, 1, 3, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion HH", new DateTime(2020, 12, 1, 6, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AG", new DateTime(2020, 12, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion QK", new DateTime(2020, 12, 1, 7, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion VG", new DateTime(2020, 12, 2, 7, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion DX", new DateTime(2020, 12, 1, 2, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion HJ", new DateTime(2020, 12, 1, 4, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AC", new DateTime(2020, 12, 2, 8, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AF", new DateTime(2020, 12, 2, 11, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion WC", new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion XQ", new DateTime(2020, 12, 1, 9, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion EG", new DateTime(2020, 12, 2, 12, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion AS", new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion VX", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion XG", new DateTime(2020, 12, 2, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion PT", new DateTime(2020, 12, 2, 5, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion NK", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion UB", new DateTime(2020, 12, 2, 1, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion CM", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion CH", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion JE", new DateTime(2020, 12, 1, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion PS", new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion LR", new DateTime(2020, 12, 2, 5, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion PD", new DateTime(2020, 12, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve IU", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve CW", 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve XD", new DateTime(2020, 12, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve QX", new DateTime(2020, 12, 2, 5, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve IL", new DateTime(2020, 12, 1, 3, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve TQ", new DateTime(2020, 12, 1, 3, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve HH", new DateTime(2020, 12, 1, 4, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve XX", new DateTime(2020, 12, 2, 13, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve YT", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve XN", new DateTime(2020, 12, 2, 13, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve PN", new DateTime(2020, 12, 1, 6, 29, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve DJ", new DateTime(2020, 12, 2, 7, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve ZH", new DateTime(2020, 12, 2, 17, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve PX", new DateTime(2020, 12, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve QC", new DateTime(2020, 12, 1, 12, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve CG", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve CF", new DateTime(2020, 12, 2, 4, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve RN", new DateTime(2020, 12, 1, 1, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve LK", new DateTime(2020, 12, 2, 7, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve SE", new DateTime(2020, 12, 1, 15, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve KZ", new DateTime(2020, 12, 2, 9, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve LB", new DateTime(2020, 12, 2, 9, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve SE", new DateTime(2020, 12, 2, 5, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve LU", new DateTime(2020, 12, 1, 15, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve US", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve HG", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve ZV", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve CV", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve SX", new DateTime(2020, 12, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve LR", new DateTime(2020, 12, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve OG", new DateTime(2020, 12, 1, 11, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve EF", new DateTime(2020, 12, 2, 4, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve EE", new DateTime(2020, 12, 2, 10, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve AK", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve GQ", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve VX", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve UD", new DateTime(2020, 12, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve CS", new DateTime(2020, 12, 2, 17, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve RI", new DateTime(2020, 12, 2, 12, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve HT", new DateTime(2020, 12, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload OU", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload OR", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload AD", new DateTime(2020, 12, 2, 3, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload JM", new DateTime(2020, 12, 1, 12, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload GZ", new DateTime(2020, 12, 1, 3, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload AF", new DateTime(2020, 12, 1, 11, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload NY", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload MX", new DateTime(2020, 12, 1, 12, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload ZW", new DateTime(2020, 12, 2, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload RB", new DateTime(2020, 12, 1, 11, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload YK", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload BR", new DateTime(2020, 12, 2, 16, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload SW", new DateTime(2020, 12, 1, 4, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload RR", new DateTime(2020, 12, 2, 9, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload DS", new DateTime(2020, 12, 1, 8, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload HF", new DateTime(2020, 12, 1, 14, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload MD", new DateTime(2020, 12, 1, 2, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload KE", new DateTime(2020, 12, 1, 12, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload UB", new DateTime(2020, 12, 1, 7, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload XO", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload NJ", new DateTime(2020, 12, 2, 12, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload JL", new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload BE", new DateTime(2020, 12, 1, 3, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload PI", new DateTime(2020, 12, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload UV", new DateTime(2020, 12, 1, 7, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload UI", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload BR", new DateTime(2020, 12, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload BF", new DateTime(2020, 12, 2, 1, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload WN", new DateTime(2020, 12, 2, 14, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload YG", new DateTime(2020, 12, 2, 11, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload JU", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload FD", new DateTime(2020, 12, 1, 14, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload IT", new DateTime(2020, 12, 2, 5, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload AG", new DateTime(2020, 12, 2, 17, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload DX", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload ZP", new DateTime(2020, 12, 2, 4, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload WA", new DateTime(2020, 12, 2, 5, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload RW", new DateTime(2020, 12, 2, 16, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload EM", new DateTime(2020, 12, 1, 1, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload DN", new DateTime(2020, 12, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem RL", new DateTime(2020, 12, 2, 2, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem DC", new DateTime(2020, 12, 2, 8, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem PK", new DateTime(2020, 12, 1, 7, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem JI", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem CC", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem DB", new DateTime(2020, 12, 1, 3, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem SY", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem SM", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem MH", new DateTime(2020, 12, 2, 6, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem MD", new DateTime(2020, 12, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem EY", new DateTime(2020, 12, 2, 14, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem DD", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem QY", new DateTime(2020, 12, 2, 15, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem RM", new DateTime(2020, 12, 2, 3, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem QZ", new DateTime(2020, 12, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem LN", new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem DI", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem FW", new DateTime(2020, 12, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem UY", new DateTime(2020, 12, 2, 16, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem TQ", new DateTime(2020, 12, 1, 2, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem ID", new DateTime(2020, 12, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem KF", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem KY", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem AN", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem JA", new DateTime(2020, 12, 2, 8, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem NC", new DateTime(2020, 12, 2, 7, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem XA", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem XI", new DateTime(2020, 12, 1, 12, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem LY", new DateTime(2020, 12, 1, 7, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem CJ", new DateTime(2020, 12, 1, 1, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem QX", new DateTime(2020, 12, 1, 11, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem OJ", new DateTime(2020, 12, 2, 1, 2, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem PG", new DateTime(2020, 12, 2, 13, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem KB", new DateTime(2020, 12, 2, 9, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem QD", new DateTime(2020, 12, 2, 10, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem MW", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem SG", new DateTime(2020, 12, 1, 2, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem LV", new DateTime(2020, 12, 2, 13, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem BK", new DateTime(2020, 12, 1, 11, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem MY", new DateTime(2020, 12, 2, 10, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical KG", new DateTime(2020, 12, 2, 17, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical CX", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical FP", new DateTime(2020, 12, 1, 4, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical LC", new DateTime(2020, 12, 2, 9, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical TZ", new DateTime(2020, 12, 1, 12, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical KV", new DateTime(2020, 12, 1, 12, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical WW", new DateTime(2020, 12, 1, 17, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical ER", new DateTime(2020, 12, 2, 9, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical UL", new DateTime(2020, 12, 1, 2, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical UN", new DateTime(2020, 12, 2, 13, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical UX", new DateTime(2020, 12, 2, 1, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical XP", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical PE", new DateTime(2020, 12, 1, 3, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical YQ", new DateTime(2020, 12, 2, 15, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical II", new DateTime(2020, 12, 2, 7, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical CI", new DateTime(2020, 12, 1, 3, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical XH", new DateTime(2020, 12, 1, 17, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical ZL", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical DG", new DateTime(2020, 12, 2, 14, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical YH", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical YL", new DateTime(2020, 12, 2, 9, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical PR", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical PW", new DateTime(2020, 12, 1, 12, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical HU", new DateTime(2020, 12, 1, 13, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical LY", new DateTime(2020, 12, 2, 3, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical SV", new DateTime(2020, 12, 1, 5, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical NS", new DateTime(2020, 12, 2, 1, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical VW", new DateTime(2020, 12, 2, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical KU", new DateTime(2020, 12, 1, 2, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical PT", new DateTime(2020, 12, 2, 17, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical OQ", new DateTime(2020, 12, 1, 13, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical HZ", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical FS", new DateTime(2020, 12, 2, 7, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical UM", new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical IQ", new DateTime(2020, 12, 1, 14, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical VO", new DateTime(2020, 12, 2, 10, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical QL", new DateTime(2020, 12, 1, 4, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical GK", new DateTime(2020, 12, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical JC", new DateTime(2020, 12, 1, 12, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical VF", new DateTime(2020, 12, 2, 12, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect JH", new DateTime(2020, 12, 2, 8, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect UJ", new DateTime(2020, 12, 2, 3, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect VU", new DateTime(2020, 12, 2, 2, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect DY", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect TM", new DateTime(2020, 12, 2, 8, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect FH", new DateTime(2020, 12, 1, 14, 43, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect ZZ", new DateTime(2020, 12, 2, 5, 46, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect FJ", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect JF", new DateTime(2020, 12, 1, 12, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect RN", new DateTime(2020, 12, 1, 2, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect OC", new DateTime(2020, 12, 1, 14, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect MB", new DateTime(2020, 12, 2, 11, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect YW", new DateTime(2020, 12, 2, 14, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect FQ", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect FP", new DateTime(2020, 12, 2, 6, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect ZR", new DateTime(2020, 12, 2, 12, 4, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect QV", new DateTime(2020, 12, 2, 10, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect PM", new DateTime(2020, 12, 2, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect FE", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect NL", new DateTime(2020, 12, 2, 11, 21, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect OD", new DateTime(2020, 12, 2, 6, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect QO", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect PH", new DateTime(2020, 12, 2, 5, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect GH", new DateTime(2020, 12, 2, 12, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect KU", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect BZ", new DateTime(2020, 12, 1, 3, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect UJ", new DateTime(2020, 12, 1, 5, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect SB", new DateTime(2020, 12, 2, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect WZ", new DateTime(2020, 12, 2, 10, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect HH", new DateTime(2020, 12, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect VK", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect QQ", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect TP", new DateTime(2020, 12, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect MK", new DateTime(2020, 12, 2, 7, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect WJ", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect SE", new DateTime(2020, 12, 1, 15, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect RE", new DateTime(2020, 12, 1, 7, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect DT", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect QV", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect PU", new DateTime(2020, 12, 1, 15, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "UserLog",
                columns: new[] { "EntityLogPrimaryKeyId", "Description", "EntityId", "Metadata", "Timestamp", "Type", "UserId" },
                values: new object[,]
                {
                    { 47, "Statical Edit", 74, "Meta data example 37", new DateTime(2020, 12, 1, 5, 33, 0, 0, DateTimeKind.Unspecified), 4, 110 },
                    { 31, "Statical Delete", 42, "Meta data example 21", new DateTime(2020, 12, 2, 3, 24, 0, 0, DateTimeKind.Unspecified), 3, 62 },
                    { 32, "Statical Edit", 44, "Meta data example 22", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 4, 65 },
                    { 33, "Statical Add", 46, "Meta data example 23", new DateTime(2020, 12, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 2, 68 },
                    { 34, "Statical Add", 48, "Meta data example 24", new DateTime(2020, 12, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), 2, 71 },
                    { 35, "Statical Delete", 50, "Meta data example 25", new DateTime(2020, 12, 1, 5, 39, 0, 0, DateTimeKind.Unspecified), 3, 74 },
                    { 36, "Statical Delete", 52, "Meta data example 26", new DateTime(2020, 12, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), 3, 77 },
                    { 37, "Statical Delete", 54, "Meta data example 27", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified), 3, 80 },
                    { 38, "Statical Edit", 56, "Meta data example 28", new DateTime(2020, 12, 2, 12, 45, 0, 0, DateTimeKind.Unspecified), 4, 83 },
                    { 40, "Statical Delete", 60, "Meta data example 30", new DateTime(2020, 12, 1, 13, 19, 0, 0, DateTimeKind.Unspecified), 3, 89 },
                    { 41, "Statical Add", 62, "Meta data example 31", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 2, 92 },
                    { 42, "Statical Add", 64, "Meta data example 32", new DateTime(2020, 12, 2, 2, 7, 0, 0, DateTimeKind.Unspecified), 2, 95 },
                    { 43, "Statical Edit", 66, "Meta data example 33", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 4, 98 },
                    { 44, "Statical Activity Log", 68, "Meta data example 34", new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 20, 101 },
                    { 45, "Statical Add", 70, "Meta data example 35", new DateTime(2020, 12, 2, 7, 26, 0, 0, DateTimeKind.Unspecified), 2, 104 },
                    { 46, "Statical Edit", 72, "Meta data example 36", new DateTime(2020, 12, 1, 12, 27, 0, 0, DateTimeKind.Unspecified), 4, 107 },
                    { 39, "Statical Activity Log", 58, "Meta data example 29", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 20, 86 },
                    { 30, "Statical Edit", 40, "Meta data example 20", new DateTime(2020, 12, 1, 9, 1, 0, 0, DateTimeKind.Unspecified), 4, 59 },
                    { 21, "Statical Edit", 22, "Meta data example 11", new DateTime(2020, 12, 1, 7, 18, 0, 0, DateTimeKind.Unspecified), 4, 32 },
                    { 28, "Statical Delete", 36, "Meta data example 18", new DateTime(2020, 12, 2, 15, 11, 0, 0, DateTimeKind.Unspecified), 3, 53 },
                    { 11, "Statical Edit", 2, "Meta data example 1", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 12, "Statical Delete", 4, "Meta data example 2", new DateTime(2020, 12, 1, 8, 29, 0, 0, DateTimeKind.Unspecified), 3, 5 },
                    { 13, "Statical Activity Log", 6, "Meta data example 3", new DateTime(2020, 12, 2, 15, 49, 0, 0, DateTimeKind.Unspecified), 20, 8 },
                    { 14, "Statical Edit", 8, "Meta data example 4", new DateTime(2020, 12, 1, 15, 18, 0, 0, DateTimeKind.Unspecified), 4, 11 },
                    { 15, "Statical Delete", 10, "Meta data example 5", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 3, 14 },
                    { 16, "Statical Add", 12, "Meta data example 6", new DateTime(2020, 12, 1, 15, 8, 0, 0, DateTimeKind.Unspecified), 2, 17 },
                    { 17, "Statical Activity Log", 14, "Meta data example 7", new DateTime(2020, 12, 1, 2, 35, 0, 0, DateTimeKind.Unspecified), 20, 20 },
                    { 18, "Statical Edit", 16, "Meta data example 8", new DateTime(2020, 12, 2, 16, 48, 0, 0, DateTimeKind.Unspecified), 4, 23 },
                    { 19, "Statical Add", 18, "Meta data example 9", new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 2, 26 },
                    { 20, "Statical Add", 20, "Meta data example 10", new DateTime(2020, 12, 1, 7, 38, 0, 0, DateTimeKind.Unspecified), 2, 29 },
                    { 48, "Statical Edit", 76, "Meta data example 38", new DateTime(2020, 12, 1, 13, 38, 0, 0, DateTimeKind.Unspecified), 4, 113 },
                    { 22, "Statical Activity Log", 24, "Meta data example 12", new DateTime(2020, 12, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), 20, 35 },
                    { 23, "Statical Delete", 26, "Meta data example 13", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 3, 38 },
                    { 24, "Statical Activity Log", 28, "Meta data example 14", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified), 20, 41 },
                    { 25, "Statical Delete", 30, "Meta data example 15", new DateTime(2020, 12, 2, 4, 26, 0, 0, DateTimeKind.Unspecified), 3, 44 },
                    { 26, "Statical Activity Log", 32, "Meta data example 16", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified), 20, 47 },
                    { 27, "Statical Edit", 34, "Meta data example 17", new DateTime(2020, 12, 2, 9, 42, 0, 0, DateTimeKind.Unspecified), 4, 50 },
                    { 29, "Statical Delete", 38, "Meta data example 19", new DateTime(2020, 12, 1, 10, 7, 0, 0, DateTimeKind.Unspecified), 3, 56 },
                    { 49, "Statical Edit", 78, "Meta data example 39", new DateTime(2020, 12, 2, 5, 26, 0, 0, DateTimeKind.Unspecified), 4, 116 },
                    { 10, "Statical Edit", 0, "Meta data example 0", new DateTime(2020, 12, 1, 6, 1, 0, 0, DateTimeKind.Unspecified), 4, -1 }
                });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video BR", new DateTime(2020, 12, 2, 9, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video RE", new DateTime(2020, 12, 2, 15, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video XP", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video RI", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video FM", new DateTime(2020, 12, 2, 12, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video UF", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video MY", new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video EY", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video OH", new DateTime(2020, 12, 1, 10, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video LL", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video NN", new DateTime(2020, 12, 2, 3, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video LE", new DateTime(2020, 12, 2, 7, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video AG", new DateTime(2020, 12, 1, 9, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video XE", new DateTime(2020, 12, 1, 12, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video TA", new DateTime(2020, 12, 1, 5, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video WP", new DateTime(2020, 12, 2, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video FV", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video BN", new DateTime(2020, 12, 2, 5, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video MW", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video WD", new DateTime(2020, 12, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video PL", new DateTime(2020, 12, 1, 3, 35, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video DD", new DateTime(2020, 12, 1, 6, 4, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video GU", new DateTime(2020, 12, 2, 15, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video TT", new DateTime(2020, 12, 2, 10, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video RP", new DateTime(2020, 12, 1, 14, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video NK", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video NR", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video BG", new DateTime(2020, 12, 1, 15, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video WM", new DateTime(2020, 12, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video MY", new DateTime(2020, 12, 2, 12, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video KE", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video EH", new DateTime(2020, 12, 2, 4, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video LQ", new DateTime(2020, 12, 2, 13, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video YQ", new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video DM", new DateTime(2020, 12, 1, 16, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video IJ", new DateTime(2020, 12, 1, 6, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video HY", new DateTime(2020, 12, 1, 13, 16, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video VJ", new DateTime(2020, 12, 2, 5, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video EO", new DateTime(2020, 12, 1, 1, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video OH", new DateTime(2020, 12, 1, 1, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning TA", new DateTime(2020, 12, 1, 3, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning AS", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning UD", new DateTime(2020, 12, 1, 4, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning BN", new DateTime(2020, 12, 2, 4, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning RS", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning QN", new DateTime(2020, 12, 2, 10, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning TO", new DateTime(2020, 12, 1, 9, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning ZY", new DateTime(2020, 12, 2, 16, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning YI", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning HX", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning PJ", new DateTime(2020, 12, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning TB", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning IH", new DateTime(2020, 12, 2, 5, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning IB", new DateTime(2020, 12, 2, 12, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning NO", new DateTime(2020, 12, 2, 16, 32, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning HP", new DateTime(2020, 12, 2, 1, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning JS", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning JC", new DateTime(2020, 12, 1, 15, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning RT", new DateTime(2020, 12, 1, 4, 11, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning WC", new DateTime(2020, 12, 1, 8, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning YM", new DateTime(2020, 12, 2, 13, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning BL", new DateTime(2020, 12, 2, 14, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning PX", new DateTime(2020, 12, 2, 7, 16, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning TI", new DateTime(2020, 12, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning HL", new DateTime(2020, 12, 1, 13, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning UL", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning JQ", new DateTime(2020, 12, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning NX", new DateTime(2020, 12, 2, 13, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning HG", new DateTime(2020, 12, 1, 16, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning WC", new DateTime(2020, 12, 2, 17, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning JM", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning OJ", new DateTime(2020, 12, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning EM", new DateTime(2020, 12, 2, 4, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning TS", new DateTime(2020, 12, 1, 6, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning AQ", new DateTime(2020, 12, 1, 11, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning KB", new DateTime(2020, 12, 1, 15, 7, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning EX", new DateTime(2020, 12, 1, 10, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning SM", new DateTime(2020, 12, 1, 17, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning RL", new DateTime(2020, 12, 1, 3, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning BU", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified), 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "UserLog",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49);

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Latitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 49, "Drone RB", "XSFDR", new DateTime(2020, 12, 1, 1, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 34, 26, "Drone GG", "ITDNA", new DateTime(2020, 12, 2, 2, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 22, 28, "Drone ZU", "JHXVJ", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 27, 36, "Drone GG", "SZFYG", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 18, 33, "Drone MM", "WRNVS", new DateTime(2020, 12, 2, 4, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 40, 23, "Drone UA", "AQWYM", new DateTime(2020, 12, 1, 5, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 36, 34, "Drone DA", "EHHOB", new DateTime(2020, 12, 2, 10, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 32, 33, "Drone DI", "XALSL", new DateTime(2020, 12, 1, 14, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 36, 16, "Drone KX", "NHRJS", new DateTime(2020, 12, 2, 5, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 25, 37, "Drone WS", "ULVTD", new DateTime(2020, 12, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 20, 19, "Drone RU", "YQTYY", new DateTime(2020, 12, 2, 12, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 26, 27, "Drone TA", "QPYSA", new DateTime(2020, 12, 2, 9, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 21, 27, "Drone QV", "HUKED", new DateTime(2020, 12, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 38, 12, "Drone GU", "KKUQI", new DateTime(2020, 12, 1, 11, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 43, 15, "Drone JC", "HNTVJ", new DateTime(2020, 12, 2, 7, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 12, 32, "Drone EW", "NYSCM", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 13, 27, "Drone OU", "KYMJM", new DateTime(2020, 12, 2, 11, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 27, 35, "Drone EK", "UZOOW", new DateTime(2020, 12, 1, 7, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 14, 13, "Drone FN", "VWLNA", new DateTime(2020, 12, 2, 7, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 19, 11, "Drone SI", "RNRFX", new DateTime(2020, 12, 2, 12, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 22, 48, "Drone KP", "NTFJU", new DateTime(2020, 12, 1, 2, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 14, 38, "Drone NA", "TLAKV", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 43, 41, "Drone JA", "NIGPS", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 43, 14, "Drone PK", "KNRYW", new DateTime(2020, 12, 2, 14, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 12, 17, "Drone AQ", "RIBDZ", new DateTime(2020, 12, 2, 17, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 39, 24, "Drone DD", "HSUOE", new DateTime(2020, 12, 1, 2, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 11, 15, "Drone SN", "NIRPL", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 15, 45, "Drone QW", "TZZGT", new DateTime(2020, 12, 2, 13, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 38, 39, "Drone WJ", "AYSMM", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 23, 19, "Drone LA", "RVHAP", new DateTime(2020, 12, 1, 2, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 14, 22, "Drone VQ", "KNLOX", new DateTime(2020, 12, 2, 3, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 14, 35, "Drone JR", "VXKZB", new DateTime(2020, 12, 1, 14, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 40, 44, "Drone QR", "WQOGK", new DateTime(2020, 12, 1, 14, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 38, 17, "Drone MO", "YFXPK", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Latitude", "Longitude", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 48, 48, "YRVGE", new DateTime(2020, 12, 1, 3, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 23, 11, "Drone KK", "HURPM", new DateTime(2020, 12, 2, 9, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 30, 25, "Drone UX", "EQDYX", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Activity Log", 38, 38, "Drone AN", "WVPSX", new DateTime(2020, 12, 2, 5, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 30, 28, "Drone KM", "ICAKO", new DateTime(2020, 12, 2, 16, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 44, 12, "Drone BD", "KIYPY", new DateTime(2020, 12, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image QU", new DateTime(2020, 12, 2, 6, 26, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image KQ", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image KF", new DateTime(2020, 12, 2, 15, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image TZ", new DateTime(2020, 12, 2, 17, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image ZJ", new DateTime(2020, 12, 1, 7, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image MI", new DateTime(2020, 12, 2, 11, 10, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image DE", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image TV", new DateTime(2020, 12, 1, 13, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image TT", new DateTime(2020, 12, 1, 14, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image PC", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image QH", new DateTime(2020, 12, 1, 2, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image GT", new DateTime(2020, 12, 2, 17, 31, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image LY", new DateTime(2020, 12, 1, 14, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image GK", new DateTime(2020, 12, 1, 6, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image HJ", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image EQ", new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image VQ", new DateTime(2020, 12, 1, 9, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image TC", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image ZW", new DateTime(2020, 12, 1, 5, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image QR", new DateTime(2020, 12, 1, 7, 24, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image TU", new DateTime(2020, 12, 1, 10, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image SC", new DateTime(2020, 12, 1, 6, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image PS", new DateTime(2020, 12, 2, 8, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image BA", new DateTime(2020, 12, 2, 7, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image EX", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image AM", new DateTime(2020, 12, 1, 5, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image LO", new DateTime(2020, 12, 2, 13, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Add", "Image MU", new DateTime(2020, 12, 2, 16, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image DW", new DateTime(2020, 12, 1, 7, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image GH", new DateTime(2020, 12, 2, 11, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image RU", new DateTime(2020, 12, 1, 2, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image MM", new DateTime(2020, 12, 2, 14, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image WO", new DateTime(2020, 12, 2, 12, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image AP", new DateTime(2020, 12, 2, 11, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Activity Log", "Image YT", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Edit", "Image SP", new DateTime(2020, 12, 2, 3, 33, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image QZ", new DateTime(2020, 12, 1, 1, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Image Delete", "Image LF", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image TH", new DateTime(2020, 12, 1, 12, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ImageLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Image RO", new DateTime(2020, 12, 2, 7, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident NC", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident AC", new DateTime(2020, 12, 2, 1, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident IK", new DateTime(2020, 12, 1, 4, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident HM", new DateTime(2020, 12, 2, 13, 45, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident AM", new DateTime(2020, 12, 2, 17, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident BA", new DateTime(2020, 12, 1, 2, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident HZ", new DateTime(2020, 12, 1, 12, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident EO", new DateTime(2020, 12, 1, 7, 18, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident PA", new DateTime(2020, 12, 1, 5, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident TD", new DateTime(2020, 12, 2, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident OC", new DateTime(2020, 12, 1, 4, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident HL", new DateTime(2020, 12, 2, 7, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident WU", new DateTime(2020, 12, 2, 12, 49, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident MD", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident MZ", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident UO", new DateTime(2020, 12, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident RB", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident MN", new DateTime(2020, 12, 1, 7, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident LJ", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Incident PL", new DateTime(2020, 12, 1, 1, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident UO", new DateTime(2020, 12, 1, 7, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident WT", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident RS", new DateTime(2020, 12, 2, 13, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident DE", new DateTime(2020, 12, 2, 4, 19, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident EU", new DateTime(2020, 12, 1, 10, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident JR", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident MV", new DateTime(2020, 12, 1, 4, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident IC", new DateTime(2020, 12, 2, 6, 12, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident DB", new DateTime(2020, 12, 1, 6, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident EW", new DateTime(2020, 12, 1, 4, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident XH", new DateTime(2020, 12, 2, 8, 32, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident GS", new DateTime(2020, 12, 1, 6, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident SP", new DateTime(2020, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Add", "Incident RC", new DateTime(2020, 12, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident EO", new DateTime(2020, 12, 1, 1, 5, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Activity Log", "Incident NI", new DateTime(2020, 12, 1, 10, 41, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident WC", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident XC", new DateTime(2020, 12, 2, 1, 41, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Edit", "Incident RL", new DateTime(2020, 12, 1, 9, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "IncidentLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Incident Delete", "Incident ET", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion YT", new DateTime(2020, 12, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion DT", new DateTime(2020, 12, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion PF", new DateTime(2020, 12, 2, 16, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion FK", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion QU", new DateTime(2020, 12, 2, 17, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion VF", new DateTime(2020, 12, 1, 3, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion AP", new DateTime(2020, 12, 1, 4, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion VP", new DateTime(2020, 12, 1, 10, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion AL", new DateTime(2020, 12, 2, 1, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion TJ", new DateTime(2020, 12, 1, 7, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion BP", new DateTime(2020, 12, 1, 12, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion KS", new DateTime(2020, 12, 2, 4, 40, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion PV", new DateTime(2020, 12, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion OH", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion VR", new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion QB", new DateTime(2020, 12, 2, 13, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion TE", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion MI", new DateTime(2020, 12, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion JC", new DateTime(2020, 12, 2, 3, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion ID", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion YW", new DateTime(2020, 12, 1, 15, 28, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion NE", new DateTime(2020, 12, 1, 16, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion OF", new DateTime(2020, 12, 2, 2, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion LG", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion FM", new DateTime(2020, 12, 2, 2, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion DA", new DateTime(2020, 12, 1, 7, 45, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion EK", new DateTime(2020, 12, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion SZ", new DateTime(2020, 12, 2, 3, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion QP", new DateTime(2020, 12, 1, 17, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Add", "MonitorRegion PB", new DateTime(2020, 12, 1, 4, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion RG", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion GQ", new DateTime(2020, 12, 2, 17, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Delete", "MonitorRegion JH", new DateTime(2020, 12, 1, 9, 36, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion BC", new DateTime(2020, 12, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion XI", new DateTime(2020, 12, 2, 7, 37, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion OG", new DateTime(2020, 12, 1, 9, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Activity Log", "MonitorRegion HF", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion HD", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "MonitorRegion Edit", "MonitorRegion YF", new DateTime(2020, 12, 2, 9, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "MonitorRegionLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "MonitorRegion QW", new DateTime(2020, 12, 2, 13, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve VN", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve ZF", 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve YY", new DateTime(2020, 12, 2, 17, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve IR", new DateTime(2020, 12, 2, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve JV", new DateTime(2020, 12, 2, 9, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve PE", new DateTime(2020, 12, 2, 7, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve EQ", new DateTime(2020, 12, 1, 10, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve VI", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve KZ", new DateTime(2020, 12, 1, 1, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve RP", new DateTime(2020, 12, 1, 3, 44, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve BN", new DateTime(2020, 12, 1, 8, 34, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve OV", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve ZF", new DateTime(2020, 12, 2, 11, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve ZP", new DateTime(2020, 12, 1, 16, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve RN", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve PO", new DateTime(2020, 12, 2, 14, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve XB", new DateTime(2020, 12, 2, 1, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve YZ", new DateTime(2020, 12, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve YZ", new DateTime(2020, 12, 2, 11, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve CO", new DateTime(2020, 12, 1, 9, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve RG", new DateTime(2020, 12, 2, 9, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve VG", new DateTime(2020, 12, 2, 4, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve FV", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve EQ", new DateTime(2020, 12, 1, 1, 38, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve GF", new DateTime(2020, 12, 1, 7, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Add", "ObjectObserve IE", new DateTime(2020, 12, 1, 10, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve IV", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve ZT", new DateTime(2020, 12, 1, 13, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve ZD", new DateTime(2020, 12, 2, 15, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve TP", new DateTime(2020, 12, 2, 15, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve JW", new DateTime(2020, 12, 1, 6, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve BI", new DateTime(2020, 12, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve BV", new DateTime(2020, 12, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve HJ", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve GT", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve IR", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ObjectObserve CQ", new DateTime(2020, 12, 2, 15, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Activity Log", "ObjectObserve KU", new DateTime(2020, 12, 1, 10, 19, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Edit", "ObjectObserve VS", new DateTime(2020, 12, 1, 7, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ObjectObserves",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ObjectObserve Delete", "ObjectObserve VW", new DateTime(2020, 12, 2, 6, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload UQ", new DateTime(2020, 12, 2, 11, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload UJ", new DateTime(2020, 12, 1, 12, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload JE", new DateTime(2020, 12, 2, 5, 23, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload BK", new DateTime(2020, 12, 2, 14, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload SN", new DateTime(2020, 12, 1, 1, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload HH", new DateTime(2020, 12, 2, 8, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload HK", new DateTime(2020, 12, 1, 8, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload AT", new DateTime(2020, 12, 1, 9, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload EO", new DateTime(2020, 12, 2, 13, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload OV", new DateTime(2020, 12, 1, 2, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload VU", new DateTime(2020, 12, 2, 15, 40, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload BY", new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload PT", new DateTime(2020, 12, 1, 8, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload ST", new DateTime(2020, 12, 1, 2, 11, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload QM", new DateTime(2020, 12, 2, 5, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload CW", new DateTime(2020, 12, 2, 14, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload AR", new DateTime(2020, 12, 1, 13, 33, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload PU", new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload FU", new DateTime(2020, 12, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload RP", new DateTime(2020, 12, 2, 5, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload BV", new DateTime(2020, 12, 2, 11, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload MF", new DateTime(2020, 12, 2, 17, 47, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload SQ", new DateTime(2020, 12, 2, 17, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload AR", new DateTime(2020, 12, 1, 5, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload KP", new DateTime(2020, 12, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload MJ", new DateTime(2020, 12, 1, 7, 14, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload TC", new DateTime(2020, 12, 2, 3, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload QN", new DateTime(2020, 12, 1, 4, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload YF", new DateTime(2020, 12, 2, 14, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload YW", new DateTime(2020, 12, 2, 15, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload KY", new DateTime(2020, 12, 2, 10, 8, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload EQ", new DateTime(2020, 12, 2, 5, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Activity Log", "Payload ND", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload KK", new DateTime(2020, 12, 1, 12, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload IZ", new DateTime(2020, 12, 2, 17, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Payload UF", new DateTime(2020, 12, 2, 6, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Add", "Payload CS", new DateTime(2020, 12, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload QX", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Edit", "Payload CK", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Payloads",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Payload Delete", "Payload FN", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem PY", new DateTime(2020, 12, 2, 13, 17, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem LU", new DateTime(2020, 12, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem SZ", new DateTime(2020, 12, 2, 3, 31, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem XU", new DateTime(2020, 12, 1, 9, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem JD", new DateTime(2020, 12, 1, 6, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem OU", new DateTime(2020, 12, 1, 6, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem GC", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem JH", new DateTime(2020, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem OJ", new DateTime(2020, 12, 2, 11, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem ZH", new DateTime(2020, 12, 1, 13, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem NT", new DateTime(2020, 12, 1, 7, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem ZM", new DateTime(2020, 12, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem RL", new DateTime(2020, 12, 1, 15, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem XV", new DateTime(2020, 12, 1, 8, 28, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem BK", new DateTime(2020, 12, 1, 4, 33, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem JX", new DateTime(2020, 12, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem KK", new DateTime(2020, 12, 2, 3, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem FJ", new DateTime(2020, 12, 2, 4, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem FF", new DateTime(2020, 12, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem IX", new DateTime(2020, 12, 1, 5, 45, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem XT", new DateTime(2020, 12, 1, 12, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem LK", new DateTime(2020, 12, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem IK", new DateTime(2020, 12, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem EX", new DateTime(2020, 12, 2, 6, 24, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem DI", new DateTime(2020, 12, 1, 12, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem BI", new DateTime(2020, 12, 2, 5, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Activity Log", "ResolveProblem KF", new DateTime(2020, 12, 2, 12, 20, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem CO", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem ZH", new DateTime(2020, 12, 2, 4, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem QU", new DateTime(2020, 12, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Delete", "ResolveProblem LI", new DateTime(2020, 12, 2, 16, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem CA", new DateTime(2020, 12, 2, 15, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem OQ", new DateTime(2020, 12, 1, 15, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem KA", new DateTime(2020, 12, 2, 3, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem JF", new DateTime(2020, 12, 2, 15, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Edit", "ResolveProblem CB", new DateTime(2020, 12, 1, 10, 26, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem MD", new DateTime(2020, 12, 2, 11, 38, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem TY", new DateTime(2020, 12, 2, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "ResolveProblem YV", new DateTime(2020, 12, 2, 5, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ResolveProblemLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "ResolveProblem Add", "ResolveProblem VL", new DateTime(2020, 12, 2, 16, 36, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical QM", new DateTime(2020, 12, 1, 7, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical EU", new DateTime(2020, 12, 1, 6, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical IE", new DateTime(2020, 12, 1, 1, 34, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical SG", new DateTime(2020, 12, 2, 15, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical NB", new DateTime(2020, 12, 1, 4, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical RS", new DateTime(2020, 12, 2, 4, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical BQ", new DateTime(2020, 12, 1, 1, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical TR", new DateTime(2020, 12, 1, 10, 6, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical AY", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical WF", new DateTime(2020, 12, 2, 5, 3, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical VG", new DateTime(2020, 12, 2, 6, 9, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical DQ", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical NC", new DateTime(2020, 12, 1, 10, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical RA", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical XK", new DateTime(2020, 12, 2, 15, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Delete", "Statical MW", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical HE", new DateTime(2020, 12, 2, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical MT", new DateTime(2020, 12, 1, 13, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical RW", new DateTime(2020, 12, 1, 13, 39, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical HD", new DateTime(2020, 12, 1, 7, 13, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical RL", new DateTime(2020, 12, 1, 12, 39, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical HW", new DateTime(2020, 12, 2, 14, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical JK", new DateTime(2020, 12, 1, 15, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical OD", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical BJ", new DateTime(2020, 12, 2, 11, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical YV", new DateTime(2020, 12, 1, 7, 37, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical PN", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical JP", new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical PI", new DateTime(2020, 12, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical TM", new DateTime(2020, 12, 2, 16, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical CG", new DateTime(2020, 12, 1, 14, 8, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical DA", new DateTime(2020, 12, 2, 6, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Edit", "Statical OQ", new DateTime(2020, 12, 1, 6, 3, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical ID", new DateTime(2020, 12, 2, 16, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical IS", new DateTime(2020, 12, 1, 5, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical JL", new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical OS", new DateTime(2020, 12, 1, 2, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Add", "Statical NR", new DateTime(2020, 12, 1, 12, 2, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Statical TH", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StaticalLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Statical Activity Log", "Statical XR", new DateTime(2020, 12, 1, 9, 14, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect RR", new DateTime(2020, 12, 2, 8, 35, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect JT", new DateTime(2020, 12, 2, 14, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect UB", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect GN", new DateTime(2020, 12, 2, 6, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect XA", new DateTime(2020, 12, 1, 2, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect YS", new DateTime(2020, 12, 2, 3, 17, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect IW", new DateTime(2020, 12, 2, 3, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect HD", new DateTime(2020, 12, 1, 15, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect JR", new DateTime(2020, 12, 1, 3, 2, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect VE", new DateTime(2020, 12, 1, 2, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect VS", new DateTime(2020, 12, 2, 3, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect XS", new DateTime(2020, 12, 2, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect XA", new DateTime(2020, 12, 2, 2, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect ZH", new DateTime(2020, 12, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect SG", new DateTime(2020, 12, 1, 15, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect EW", new DateTime(2020, 12, 1, 5, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect OA", new DateTime(2020, 12, 2, 15, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect XN", new DateTime(2020, 12, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect VK", new DateTime(2020, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect ZZ", new DateTime(2020, 12, 2, 11, 32, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect EZ", new DateTime(2020, 12, 2, 4, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect DK", new DateTime(2020, 12, 2, 17, 10, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect OZ", new DateTime(2020, 12, 2, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect VB", new DateTime(2020, 12, 1, 17, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect VJ", new DateTime(2020, 12, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect FO", new DateTime(2020, 12, 1, 2, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "UavConnect AE", new DateTime(2020, 12, 2, 2, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect MH", new DateTime(2020, 12, 2, 2, 9, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect BY", new DateTime(2020, 12, 1, 8, 18, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect OC", new DateTime(2020, 12, 2, 1, 7, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect UX", new DateTime(2020, 12, 2, 14, 23, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect LU", new DateTime(2020, 12, 2, 9, 34, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Delete", "UavConnect DP", new DateTime(2020, 12, 1, 4, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect VQ", new DateTime(2020, 12, 2, 7, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect QS", new DateTime(2020, 12, 2, 11, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect LB", new DateTime(2020, 12, 1, 1, 23, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Add", "UavConnect AP", new DateTime(2020, 12, 1, 14, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect PY", new DateTime(2020, 12, 2, 16, 27, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Activity Log", "UavConnect FS", new DateTime(2020, 12, 2, 16, 6, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "UavConnectLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "UavConnect Edit", "UavConnect SB", new DateTime(2020, 12, 1, 10, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video NI", new DateTime(2020, 12, 1, 5, 21, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video TJ", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video DS", new DateTime(2020, 12, 2, 17, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video CD", new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video GL", new DateTime(2020, 12, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video EN", new DateTime(2020, 12, 2, 1, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video WL", new DateTime(2020, 12, 1, 14, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video ZQ", new DateTime(2020, 12, 2, 5, 13, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video MG", new DateTime(2020, 12, 1, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Edit", "Video DS", new DateTime(2020, 12, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video QF", new DateTime(2020, 12, 1, 7, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video AM", new DateTime(2020, 12, 2, 3, 32, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video MF", new DateTime(2020, 12, 2, 12, 19, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video JO", new DateTime(2020, 12, 2, 8, 10, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video UN", new DateTime(2020, 12, 1, 7, 31, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video LF", new DateTime(2020, 12, 2, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video EO", new DateTime(2020, 12, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video ZU", new DateTime(2020, 12, 1, 1, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video YO", new DateTime(2020, 12, 2, 2, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video EG", new DateTime(2020, 12, 1, 17, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video QZ", new DateTime(2020, 12, 2, 7, 6, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video EL", new DateTime(2020, 12, 2, 2, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video YF", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video RS", new DateTime(2020, 12, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video QN", new DateTime(2020, 12, 1, 9, 20, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video KF", new DateTime(2020, 12, 1, 13, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video LB", new DateTime(2020, 12, 2, 8, 5, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video VZ", new DateTime(2020, 12, 1, 9, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video LR", new DateTime(2020, 12, 1, 5, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video WC", new DateTime(2020, 12, 2, 2, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video PI", new DateTime(2020, 12, 2, 15, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video GS", new DateTime(2020, 12, 2, 17, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video XP", new DateTime(2020, 12, 1, 11, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video YN", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video UM", new DateTime(2020, 12, 2, 10, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Activity Log", "Video LJ", new DateTime(2020, 12, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Delete", "Video HN", new DateTime(2020, 12, 1, 11, 16, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video PT", new DateTime(2020, 12, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Video Add", "Video CU", new DateTime(2020, 12, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "VideoLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Video VS", new DateTime(2020, 12, 1, 6, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning OP", new DateTime(2020, 12, 1, 3, 39, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning QL", new DateTime(2020, 12, 1, 2, 49, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning RY", new DateTime(2020, 12, 1, 4, 36, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning CJ", new DateTime(2020, 12, 1, 4, 29, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning TG", new DateTime(2020, 12, 1, 14, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning PB", new DateTime(2020, 12, 2, 9, 3, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning AF", new DateTime(2020, 12, 2, 11, 1, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning CF", new DateTime(2020, 12, 1, 5, 48, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning SP", new DateTime(2020, 12, 1, 12, 40, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning IJ", new DateTime(2020, 12, 1, 5, 40, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning SR", new DateTime(2020, 12, 1, 2, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning ZU", new DateTime(2020, 12, 2, 16, 17, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning PR", new DateTime(2020, 12, 1, 14, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning CR", new DateTime(2020, 12, 1, 13, 37, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning AM", new DateTime(2020, 12, 1, 10, 38, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning WT", new DateTime(2020, 12, 1, 10, 24, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning FE", new DateTime(2020, 12, 1, 13, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning ZW", new DateTime(2020, 12, 1, 2, 39, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning QL", new DateTime(2020, 12, 1, 15, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning EX", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning IJ", new DateTime(2020, 12, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning QK", new DateTime(2020, 12, 2, 4, 8, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning GT", new DateTime(2020, 12, 2, 13, 44, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning WA", new DateTime(2020, 12, 2, 6, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning PX", new DateTime(2020, 12, 1, 11, 44, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning JC", new DateTime(2020, 12, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Edit", "Warning KW", new DateTime(2020, 12, 1, 8, 4, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning EC", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning LS", new DateTime(2020, 12, 2, 14, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning MJ", new DateTime(2020, 12, 2, 10, 3, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning DK", new DateTime(2020, 12, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning KU", new DateTime(2020, 12, 1, 3, 42, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning YJ", new DateTime(2020, 12, 2, 8, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning QP", new DateTime(2020, 12, 2, 2, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning YI", new DateTime(2020, 12, 2, 4, 22, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning WJ", new DateTime(2020, 12, 1, 5, 24, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Activity Log", "Warning XH", new DateTime(2020, 12, 2, 15, 44, 0, 0, DateTimeKind.Unspecified), 20 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Name", "Timestamp" },
                values: new object[] { "Warning RT", new DateTime(2020, 12, 1, 11, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Add", "Warning AE", new DateTime(2020, 12, 1, 15, 41, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WarningLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Timestamp", "Type" },
                values: new object[] { "Warning Delete", "Warning JE", new DateTime(2020, 12, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), 3 });
        }
    }
}
