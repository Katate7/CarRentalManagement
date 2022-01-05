using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "932287ff-a882-468e-be0e-9f2f79303d03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "27cd63ed-45a4-41cb-85dd-110ae5f7ff92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede21d00-269b-48dd-a8e6-92557033dea2", "AQAAAAEAACcQAAAAEG/W1kVHT4djcDEv33Z9uZSlWcv+ADBdzDqAIbYTvj55QLCjrzXovjiIcq4LjQ0LlQ==", "1ab63ffc-cb27-418c-8bbc-e5b17ea3fdd8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 518, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 1, 5, 17, 38, 40, 518, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 518, DateTimeKind.Local).AddTicks(7614), new DateTime(2022, 1, 5, 17, 38, 40, 518, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(6296), new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(6305), new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8882), new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8892), new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8894), new DateTime(2022, 1, 5, 17, 38, 40, 519, DateTimeKind.Local).AddTicks(8895) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "44c41f32-f893-414d-9895-2b947f5cec9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "3c62571c-d75a-49a4-a6a3-fab5bad9d124");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4af7abfa-9355-4b0c-a5af-8637cd0e90e9", "AQAAAAEAACcQAAAAEMh/QzxIVH+pYQyWCWFvRb+apNlv+WYOK7uzhmGXvLgcNHeQ0bkbHPIGTNrZT517/A==", "b7a96f78-c945-434b-8b05-c8009ebf28e5" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 336, DateTimeKind.Local).AddTicks(2325), new DateTime(2022, 1, 5, 16, 46, 28, 337, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 337, DateTimeKind.Local).AddTicks(2836), new DateTime(2022, 1, 5, 16, 46, 28, 337, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(3343), new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5905), new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5912), new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5914), new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5916), new DateTime(2022, 1, 5, 16, 46, 28, 338, DateTimeKind.Local).AddTicks(5917) });
        }
    }
}
