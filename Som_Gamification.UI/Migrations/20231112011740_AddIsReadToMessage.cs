using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamification.UI.Migrations
{
    public partial class AddIsReadToMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5dbc593-503b-4cba-a610-72dd3684fc65", "AQAAAAIAAYagAAAAEINw2q2ASayMZ68JQNfU/iebjUIsqC4Zt340qG4wBFO4gxAz8gGehV5vqwqppJ/RzA==", "b5c29411-ff6f-4958-ad86-d9a5cd15bcb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e11fc6a-c037-41d4-816b-5d4196bb161c", "AQAAAAIAAYagAAAAEH0HKb/oW6g1TlQUlbKKhH7ARmE+vS10YYIpfZmMhIcZt0P2Nmug6dQYNh80u38kNw==", "54141c70-9b99-4cc2-a9fb-47e5d1551a16" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf44655f-0e71-4616-99af-62f63f01eb0b", "AQAAAAIAAYagAAAAEBK8UyF4YPc1NN+FVvLodXPWRtPwirbQS8bUSZsD3Js1cIAtiWCQtRgmReDTMymlig==", "5c97daa8-13b7-4b8c-9915-cfff9aad65ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbad97ac-5e9f-4e22-b4aa-8b7c96ef7471", "AQAAAAIAAYagAAAAED1OSGWfgNPXW2okLT8UKmsUhwIbmM+mXUopsZhsxqku/JiH76jvu4ZhAXidFj1JuA==", "5e5412e9-7b4b-4d79-8086-b5deb435b36f" });
        }
    }
}
