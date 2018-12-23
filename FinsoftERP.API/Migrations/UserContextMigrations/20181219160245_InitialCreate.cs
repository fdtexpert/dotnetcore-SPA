using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinsoftERP.API.Migrations.UserContextMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SYSTEMS_USERS",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(300)", maxLength: 300, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYSTEMS_USERS", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SYSTEMS_USERS");
        }
    }
}
