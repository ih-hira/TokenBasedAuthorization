using Microsoft.EntityFrameworkCore.Migrations;

namespace TouchAntenna.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    user_id = table.Column<string>(nullable: false),
                    user_nm = table.Column<string>(nullable: true),
                    user_descrip = table.Column<string>(nullable: true),
                    home_branch_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.user_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUser");
        }
    }
}
