using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcoreapp.Migrations
{
    public partial class seeder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "WarningLog");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "WorkName",
                table: "UserLog");

            migrationBuilder.AddColumn<string>(
                name: "Metadata",
                table: "UserLog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TargetId",
                table: "UserLog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 32, 39, "Drone FI", "EPNXG", new DateTime(2020, 12, 1, 7, 33, 0, 0, DateTimeKind.Unspecified), 3 });

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
                columns: new[] { "Description", "Latitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 33, "Drone VD", "VQMSC", new DateTime(2020, 12, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), 4 });

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
                columns: new[] { "Name", "RegionName", "Timestamp" },
                values: new object[] { "Drone TC", "SYUAX", new DateTime(2020, 12, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Latitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 38, "Drone AD", "RWXPN", new DateTime(2020, 12, 2, 14, 31, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 19, 23, "Drone MH", "UQFCG", new DateTime(2020, 12, 1, 12, 44, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 32, 15, "Drone AM", "IBTDR", new DateTime(2020, 12, 1, 14, 27, 0, 0, DateTimeKind.Unspecified), 2 });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 28, 14, "Drone CJ", "POQBY", new DateTime(2020, 12, 1, 2, 25, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 42, "Drone IF", "RUCWV", new DateTime(2020, 12, 1, 3, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 13, 14, "Drone ZD", "BROJF", new DateTime(2020, 12, 2, 14, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 27, 20, "Drone HS", "QUJYW", new DateTime(2020, 12, 2, 9, 22, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 48, 47, "Drone XM", "CIBMH", new DateTime(2020, 12, 1, 13, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 42,
                columns: new[] { "Description", "Latitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 19, "Drone TK", "GYTYS", new DateTime(2020, 12, 2, 4, 16, 0, 0, DateTimeKind.Unspecified), 3 });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 31, 30, "Drone GW", "JLWZZ", new DateTime(2020, 12, 2, 6, 21, 0, 0, DateTimeKind.Unspecified), 4 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Metadata",
                table: "UserLog");

            migrationBuilder.DropColumn(
                name: "TargetId",
                table: "UserLog");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "WarningLog",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserLog",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "UserLog",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "UserLog",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 10,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 34, 23, "Drone JB", "VBOSC", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified), 4 });

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
                columns: new[] { "Description", "Latitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 17, "Drone OJ", "DSRTM", new DateTime(2020, 12, 2, 15, 12, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 14,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 27, 10, "Drone IH", "NZNVM", new DateTime(2020, 12, 2, 2, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 15,
                columns: new[] { "Name", "RegionName", "Timestamp" },
                values: new object[] { "Drone GZ", "PKBDE", new DateTime(2020, 12, 2, 1, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 16,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 15, 40, "Drone FP", "MRIHY", new DateTime(2020, 12, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), 4 });

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
                columns: new[] { "Latitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 43, "Drone RL", "WNBCU", new DateTime(2020, 12, 2, 13, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 19,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 19, 49, "Drone VC", "AUTXQ", new DateTime(2020, 12, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 34, 27, "Drone XM", "KJSES", new DateTime(2020, 12, 1, 5, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 22,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 15, 37, "Drone XA", "AXHRF", new DateTime(2020, 12, 1, 17, 12, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 14, 42, "Drone OX", "ETQVA", new DateTime(2020, 12, 2, 16, 10, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 25,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 20, 31, "Drone GM", "MUSKZ", new DateTime(2020, 12, 2, 12, 7, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 26,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 45, 16, "Drone LR", "HMWSN", new DateTime(2020, 12, 1, 11, 7, 0, 0, DateTimeKind.Unspecified), 2 });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 34, 47, "Drone RH", "VKZZH", new DateTime(2020, 12, 1, 1, 15, 0, 0, DateTimeKind.Unspecified), 4 });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 47, 21, "Drone UY", "BUZOA", new DateTime(2020, 12, 2, 5, 10, 0, 0, DateTimeKind.Unspecified), 4 });

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
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Delete", 49, 44, "Drone GQ", "EKRAG", new DateTime(2020, 12, 2, 14, 17, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 34,
                columns: new[] { "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 13, "Drone VW", "QOLRA", new DateTime(2020, 12, 1, 16, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 35,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 17, 18, "Drone TL", "PGXMR", new DateTime(2020, 12, 2, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 36,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 44, 30, "Drone GT", "OPLFA", new DateTime(2020, 12, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 22, 20, "Drone LE", "YLLRU", new DateTime(2020, 12, 2, 4, 15, 0, 0, DateTimeKind.Unspecified) });

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
                columns: new[] { "Description", "Latitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Edit", 39, "Drone YX", "TCIWV", new DateTime(2020, 12, 2, 11, 49, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 43,
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 32, 27, "Drone TP", "AIBKH", new DateTime(2020, 12, 1, 3, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DroneLogs",
                keyColumn: "EntityLogPrimaryKeyId",
                keyValue: 44,
                columns: new[] { "Description", "Latitude", "Longitude", "Name", "RegionName", "Timestamp", "Type" },
                values: new object[] { "Drone Add", 22, 21, "Drone VB", "IJMSI", new DateTime(2020, 12, 1, 10, 33, 0, 0, DateTimeKind.Unspecified), 2 });

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
                columns: new[] { "Latitude", "Longitude", "Name", "RegionName", "Timestamp" },
                values: new object[] { 33, 25, "Drone TC", "OERMJ", new DateTime(2020, 12, 1, 3, 34, 0, 0, DateTimeKind.Unspecified) });

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
    }
}
