using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPTemplateIntegration.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisteredOn",
                value: new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisteredOn",
                value: new DateTime(2025, 11, 3, 14, 14, 26, 26, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "RegisteredOn",
                value: new DateTime(2025, 11, 8, 14, 14, 26, 29, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3,
                column: "RegisteredOn",
                value: new DateTime(2025, 11, 23, 14, 14, 26, 29, DateTimeKind.Local).AddTicks(4816));
        }
    }
}
