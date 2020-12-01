using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class seeder1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 34, 23, "Drone JB", "VBOSC", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 38, 47, "Drone HM", "RFMOB", new DateTime(2020, 12, 1, 6, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 38, 44, "Drone RY", "MIZJI", new DateTime(2020, 12, 2, 13, 35, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 17, 24, "Drone OJ", "DSRTM", new DateTime(2020, 12, 2, 15, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 27, 10, "Drone IH", "NZNVM", new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 44, 33, "Drone GZ", "PKBDE", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 15, 40, "Drone FP", "MRIHY", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 11, 13, "Drone HJ", "CHPJR", new DateTime(2020, 12, 2, 16, 45, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 43, 17, "Drone RL", "WNBCU", new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 19, 49, "Drone VC", "AUTXQ", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 40, 19, "Drone CB", "TWHUG", new DateTime(2020, 12, 1, 8, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 34, 27, "Drone XM", "KJSES", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 15, 37, "Drone XA", "AXHRF", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 48, 23, "Drone RO", "GDGDM", new DateTime(2020, 12, 2, 8, 29, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 14, 42, "Drone OX", "ETQVA", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 20, 31, "Drone GM", "MUSKZ", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 45, 16, "Drone LR", "HMWSN", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 45, 21, "Drone XV", "VMOCV", new DateTime(2020, 12, 2, 12, 27, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 34, 47, "Drone RH", "VKZZH", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 16, 25, "Drone QV", "ANEKF", new DateTime(2020, 12, 2, 10, 14, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 45, 18, "Drone VU", "REWZV", new DateTime(2020, 12, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 47, 21, "Drone UY", "BUZOA", new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 13, 49, "Drone MV", "ZZPPG", new DateTime(2020, 12, 2, 2, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude", "RegionName", "Timestamp" },
                values: new object[] { 49, 44, "EKRAG", new DateTime(2020, 12, 2, 14, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 36, 13, "Drone VW", "QOLRA", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 17, 18, "Drone TL", "PGXMR", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 44, 30, "Drone GT", "OPLFA", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 36, 36, "Drone UM", "IGVLE", new DateTime(2020, 12, 2, 4, 13, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 33, 31, "Drone HO", "DUXMI", new DateTime(2020, 12, 2, 9, 30, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 34, 26, "Drone IY", "DQZAP", new DateTime(2020, 12, 1, 8, 11, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 22, 20, "Drone LE", "YLLRU", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 41, 30, "Drone LU", "UHIUA", new DateTime(2020, 12, 1, 4, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 39, 44, "Drone YX", "TCIWV", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 32, 27, "Drone TP", "AIBKH", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 22, 21, "Drone VB", "IJMSI", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 15, 47, "Drone UD", "QOSBZ", new DateTime(2020, 12, 2, 6, 5, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 41, 27, "Drone BQ", "VEGMA", new DateTime(2020, 12, 1, 7, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 33, 25, "Drone TC", "OERMJ", new DateTime(2020, 12, 1, 3, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 16, 41, "Drone CM", "SILRZ", new DateTime(2020, 12, 1, 8, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 39, 16, "Drone VI", "BQGHG", new DateTime(2020, 12, 2, 9, 44, 0, 0, DateTimeKind.Unspecified), 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 42, 44, "Drone JL", null, new DateTime(2020, 12, 1, 4, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 11,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 15, 32, "Drone RD", null, new DateTime(2020, 12, 2, 2, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 12,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 32, 36, "Drone BO", null, new DateTime(2020, 12, 1, 5, 9, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 13,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 45, 23, "Drone BR", null, new DateTime(2020, 12, 2, 16, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 49, 21, "Drone PM", null, new DateTime(2020, 12, 2, 14, 41, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 39, 41, "Drone WK", null, new DateTime(2020, 12, 2, 2, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 32, 10, "Drone RP", null, new DateTime(2020, 12, 1, 5, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 17,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 20, 14, "Drone HM", null, new DateTime(2020, 12, 2, 16, 16, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 18,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 16, 38, "Drone SE", null, new DateTime(2020, 12, 1, 3, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 24, 35, "Drone EP", null, new DateTime(2020, 12, 1, 8, 35, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 20,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 35, 23, "Drone FK", null, new DateTime(2020, 12, 2, 10, 26, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 21,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 30, 21, "Drone YB", null, new DateTime(2020, 12, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 23, 15, "Drone FK", null, new DateTime(2020, 12, 2, 17, 43, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 23,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 32, 44, "Drone IC", null, new DateTime(2020, 12, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 24,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 41, 21, "Drone GM", null, new DateTime(2020, 12, 2, 11, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 21, 13, "Drone HT", null, new DateTime(2020, 12, 2, 11, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 13, 18, "Drone JF", null, new DateTime(2020, 12, 1, 7, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 27,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 19, 32, "Drone OR", null, new DateTime(2020, 12, 2, 14, 5, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 28,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 49, 31, "Drone AB", null, new DateTime(2020, 12, 1, 2, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 29,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 10, 33, "Drone XZ", null, new DateTime(2020, 12, 1, 5, 42, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 30,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 30, 45, "Drone VX", null, new DateTime(2020, 12, 2, 14, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 31,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 23, 42, "Drone QV", null, new DateTime(2020, 12, 2, 13, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 32,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 26, 15, "Drone PQ", null, new DateTime(2020, 12, 2, 12, 28, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 33,
                columns: new[] { "Latitude", "Longitude", "RegionName", "Timestamp" },
                values: new object[] { 14, 21, null, new DateTime(2020, 12, 1, 5, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 10, 27, "Drone SJ", null, new DateTime(2020, 12, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 20, 19, "Drone QA", null, new DateTime(2020, 12, 2, 14, 42, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 38, 27, "Drone FL", null, new DateTime(2020, 12, 1, 13, 34, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 37,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 18, 20, "Drone DU", null, new DateTime(2020, 12, 1, 5, 11, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 38,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 26, 38, "Drone HR", null, new DateTime(2020, 12, 1, 2, 38, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 39,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 44, 24, "Drone BY", null, new DateTime(2020, 12, 2, 9, 19, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 40,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 38, 18, "Drone XH", null, new DateTime(2020, 12, 2, 9, 37, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 41,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 12, 18, "Drone CM", null, new DateTime(2020, 12, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 13, 34, "Drone EQ", null, new DateTime(2020, 12, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 49, 41, "Drone SR", null, new DateTime(2020, 12, 1, 1, 43, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 44, 16, "Drone XC", null, new DateTime(2020, 12, 2, 1, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 45,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 22, 38, "Drone JV", null, new DateTime(2020, 12, 1, 12, 48, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 46,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 46, 26, "Drone JJ", null, new DateTime(2020, 12, 1, 8, 49, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 47,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 29, 18, "Drone AS", null, new DateTime(2020, 12, 2, 1, 48, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 48,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 49, 14, "Drone NR", null, new DateTime(2020, 12, 2, 3, 8, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 49,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 42, 33, "Drone NJ", null, new DateTime(2020, 12, 1, 11, 33, 0, 0, DateTimeKind.Unspecified), 2 });
        }
    }
}
