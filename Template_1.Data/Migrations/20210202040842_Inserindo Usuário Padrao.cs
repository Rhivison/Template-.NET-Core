using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Template_1.Data.Migrations
{
    public partial class InserindoUsuárioPadrao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), "userdefault@template.com", "User Default" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"));
        }
    }
}
