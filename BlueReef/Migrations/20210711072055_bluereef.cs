using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueReef.Migrations
{
    public partial class bluereef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "sendEmails",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "sendEmails",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SendemailID",
                table: "sendEmails",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "sendEmails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "sendEmails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "sendEmails");

            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "sendEmails");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "sendEmails",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "sendEmails",
                newName: "ContactNumber");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "sendEmails",
                newName: "SendemailID");
        }
    }
}
