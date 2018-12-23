using Microsoft.EntityFrameworkCore.Migrations;

namespace FinsoftERP.API.Migrations.ERPContextMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FIN_STAT_SUB",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false),
                    CDESC = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Remarks = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FIN_STAT_SUB", x => x.CODE);
                });

            migrationBuilder.CreateTable(
                name: "LD_CTRL",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "VARCHAR(2)", maxLength: 2, nullable: false),
                    CDESC = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Remarks = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LD_CTRL", x => x.CODE);
                });

            migrationBuilder.CreateTable(
                name: "LD_GEN",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "VARCHAR(4)", maxLength: 4, nullable: false),
                    CDESC = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Remarks = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LD_GEN", x => x.CODE);
                });

            migrationBuilder.CreateTable(
                name: "LD_MAIN",
                columns: table => new
                {
                    CODE = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    CDESC = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Remarks = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    ACC_TYPE = table.Column<string>(type: "VARCHAR(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LD_MAIN", x => x.CODE);
                    table.ForeignKey(
                        name: "FK_LD_MAIN_FIN_STAT_SUB_ACC_TYPE",
                        column: x => x.ACC_TYPE,
                        principalTable: "FIN_STAT_SUB",
                        principalColumn: "CODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LD_MAIN_ACC_TYPE",
                table: "LD_MAIN",
                column: "ACC_TYPE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LD_CTRL");

            migrationBuilder.DropTable(
                name: "LD_GEN");

            migrationBuilder.DropTable(
                name: "LD_MAIN");

            migrationBuilder.DropTable(
                name: "FIN_STAT_SUB");
        }
    }
}
