using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueReef.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoleManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleManagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registraions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleManagementId = table.Column<int>(type: "int", nullable: true),
                    Rememberme = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registraions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registraions_RoleManagements_RoleManagementId",
                        column: x => x.RoleManagementId,
                        principalTable: "RoleManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registraions_RoleManagementId",
                table: "Registraions",
                column: "RoleManagementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registraions");

            migrationBuilder.DropTable(
                name: "RoleManagements");
        }
    }
}
