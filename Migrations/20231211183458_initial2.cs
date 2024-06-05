using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTSLQP_ContactManager.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 19, 34, 58, 89, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 19, 34, 58, 89, DateTimeKind.Local).AddTicks(5922));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 19, 28, 35, 93, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 12, 11, 19, 28, 35, 93, DateTimeKind.Local).AddTicks(5070));
        }
    }
}
