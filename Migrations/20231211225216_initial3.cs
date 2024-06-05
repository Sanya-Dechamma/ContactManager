using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GTSLQP_ContactManager.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "DateAdded", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(2023, 12, 11, 23, 52, 16, 257, DateTimeKind.Local).AddTicks(5835), "saanjseets@gmail.com", "Saanj", "Seetha", "9900932702" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "DateAdded", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(2023, 12, 11, 23, 52, 16, 257, DateTimeKind.Local).AddTicks(5917), "nilsoms12@yahoo.com", "Nyla", "Soms", "7335568990" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryId", "DateAdded", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { 3, 2, new DateTime(2023, 12, 11, 23, 52, 16, 257, DateTimeKind.Local).AddTicks(5922), "dechy1603@hotmail.com", "Drishya", "Dech", "8905347812" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "DateAdded", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 34, 58, 89, DateTimeKind.Local).AddTicks(5854), "john.doe@example.com", "John", "Doe", "123-456-7890" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "DateAdded", "Email", "FirstName", "LastName", "Phone" },
                values: new object[] { new DateTime(2023, 12, 11, 19, 34, 58, 89, DateTimeKind.Local).AddTicks(5922), "jane.smith@example.com", "Jane", "Smith", "987-654-3210" });
        }
    }
}
