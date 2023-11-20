using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gamification.UI.Migrations
{
    public partial class ChatsModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SenderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverID",
                        column: x => x.ReceiverID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ApplicationServer", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45z.4.ucc.md", "bf44655f-0e71-4616-99af-62f63f01eb0b", "AQAAAAIAAYagAAAAEBK8UyF4YPc1NN+FVvLodXPWRtPwirbQS8bUSZsD3Js1cIAtiWCQtRgmReDTMymlig==", "5c97daa8-13b7-4b8c-9915-cfff9aad65ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ApplicationServer", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45z.4.ucc.md", "cbad97ac-5e9f-4e22-b4aa-8b7c96ef7471", "AQAAAAIAAYagAAAAED1OSGWfgNPXW2okLT8UKmsUhwIbmM+mXUopsZhsxqku/JiH76jvu4ZhAXidFj1JuA==", "5e5412e9-7b4b-4d79-8086-b5deb435b36f" });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverID",
                table: "Messages",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderID",
                table: "Messages",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a17d64c5-d3b5-40cd-af2f-04386a783a1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "596c46d2-9546-438b-9d82-03ad2002fe7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ApplicationServer", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45z.4.ucc.md/sap", "776271d5-eab9-4283-a5c3-5e516fce02fb", "AQAAAAEAACcQAAAAEH09C2/lRxNhBw8hKrP8A8o3yzRUXY55+ZFZb3FTayvzbuOP4naWm9lA1gQW47MxUQ==", "70a3c9ec-46eb-4ad2-9832-d98864db8a12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ApplicationServer", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45z.4.ucc.md/sap", "6ddf598f-57fa-4288-a9f7-9fd0f2f01334", "AQAAAAEAACcQAAAAECGZC0tB741pd5ISdFhSN2I4SwZfRPZzzaT9pEs8bT0cINboVUTBDAq+7aelAGuqtQ==", "7500f7f6-3504-40f1-b220-133f886b4315" });
        }
    }
}
