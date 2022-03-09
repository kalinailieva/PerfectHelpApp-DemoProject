using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHelp.Data.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Newsletters_NewsletterId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-563d56fd7217", "2c5e174e-3b0e-446f-86af-483d56fc7211" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-563d56fd7217");

            migrationBuilder.RenameColumn(
                name: "NewsletterId",
                table: "AspNetUsers",
                newName: "SubscribersId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_NewsletterId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_SubscribersId");

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b18942e5-d785-484d-b259-a066b7fed71f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7214",
                column: "ConcurrencyStamp",
                value: "e5c80fb3-6555-48d2-a94d-c63b9ebfd469");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-3d56fd7217", "65634bc7-d64f-4a44-ad84-4715ff72b3e2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "2c5e174e-3b0e-446f-86af-483d56fc7211" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6193d50e-96db-4c32-b824-569e84e423b8", "AQAAAAEAACcQAAAAEJ6hNntqNxqCCK50hQTgOSjKq46iLZTuOBejzoZ6HKoE0KEqnu98KXKLfzBERH7FKA==", "665540c4-bcd7-4965-a16b-d092a7d6da0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a7e5bc9-18e0-4836-921c-165cbc9309da", "AQAAAAEAACcQAAAAEDw8z7V/fH7QjoRgQaLIbXgqxyjTflx5uhmzF4yCeeai0bzgibDUUDOUHcQ2AmiGAg==", "32645430-e6b2-470c-9877-e5f8c3438323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3y0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a2b43fd-a55d-4443-99a9-c535d4f9c42a", "AQAAAAEAACcQAAAAEPzNWvP0muZCQS0Fh3BqC0y5XL43BwUs2nY3neHD2FS5JD+tJ+JAttMFVGeK6lNLXw==", "5ec77c5b-72fa-48fd-a9b3-868e6ecf28c8" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscribers_SubscribersId",
                table: "AspNetUsers",
                column: "SubscribersId",
                principalTable: "Subscribers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscribers_SubscribersId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-3d56fd7217");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "2c5e174e-3b0e-446f-86af-483d56fc7211" });

            migrationBuilder.RenameColumn(
                name: "SubscribersId",
                table: "AspNetUsers",
                newName: "NewsletterId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_SubscribersId",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_NewsletterId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "2277708b-446d-4d8f-8295-05adba119c7a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7214",
                column: "ConcurrencyStamp",
                value: "dbe2d7d0-7a1e-4c0d-9035-966d1dc70532");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-563d56fd7217", "ef9c86a8-f06e-4e7f-b69c-cc72a5287744", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5929058c-f2ae-4b69-b6b8-39f0bf357ff1", "AQAAAAEAACcQAAAAEFRB864vA99nr5lkd05x5wkp3Ti3Eqm48yHK7saINI6dYhnunvtV1T0Xs4qZw4sMJQ==", "d43da728-58fd-4578-91dc-fb48b239fced" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d96471f7-0097-4f7a-b0ab-2c18c9953336", "AQAAAAEAACcQAAAAEBBG78mq9WTOPFiqzHPQmX5e1oJtozyguEKnT/af0QW2+C4OLRgOsbGqgBZlik1Ncw==", "2975700b-4bed-4beb-8d7d-cbd2e39f98e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3y0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7525ea4f-e4dd-4b27-a273-f5acd7d5583c", "AQAAAAEAACcQAAAAEL1+7nCHTZfC+sgFmMVLTTsooazBj4aQBhTil7k2ImB5/GCOM9bP5wwzaY4maqJNMQ==", "840cf473-c820-4a8f-bf6d-45c45af1b184" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-563d56fd7217", "2c5e174e-3b0e-446f-86af-483d56fc7211" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Newsletters_NewsletterId",
                table: "AspNetUsers",
                column: "NewsletterId",
                principalTable: "Newsletters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
