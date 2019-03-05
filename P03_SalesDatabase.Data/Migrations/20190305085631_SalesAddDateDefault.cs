using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P03_SalesDatabase.Data.Migrations
{
    public partial class SalesAddDateDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                maxLength: 250,
                nullable: false,
                defaultValue: "No description",
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true,
                oldDefaultValue: "No description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                maxLength: 250,
                nullable: true,
                defaultValue: "No description",
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldDefaultValue: "No description");
        }
    }
}
