using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHelp.Data.Migrations
{
    public partial class change1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-3d56fd7217",
                column: "ConcurrencyStamp",
                value: "40a39fd6-832d-4996-a975-bd13d4324be4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "4be0e3d7-d83a-4b0b-896d-0b8451043639");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7214",
                column: "ConcurrencyStamp",
                value: "e485d0db-5cfd-4e02-be15-65de8ab58bb5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17ff665f-011d-4c9a-8bad-dae71367c152", "AQAAAAEAACcQAAAAEFmZuc8FrpYXV2EiM9DO4GtnBs8w7jLnYxyZzPspyQhONYeUXZX35P7fFcy9/ddSkw==", "1580dbdb-cb2a-46aa-b785-545323d72ab1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d528b32-9172-4ddc-8966-e0bf84388d60", "AQAAAAEAACcQAAAAEE6KQ/St7m9cTw7CP7jGlXpL5iPoTFF2RBPKdpAt7m+Zfji9pEaMqdWVRcCN5f2lXA==", "1d143173-7d53-4f37-95a1-ed5a2dc6102d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3y0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbe5266-99fd-4d20-8c20-ad0336fa1417", "AQAAAAEAACcQAAAAELpLCkqB6/uDzq5Lr9+DwxNbMDKlgs9pw+FOJJFW2zNWxxIN4pM9hos/MkcbVcpgmA==", "5cc0263e-49cf-4b83-8135-4e9bf3d44c88" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-3d56fd7217",
                column: "ConcurrencyStamp",
                value: "65634bc7-d64f-4a44-ad84-4715ff72b3e2");

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
        }
    }
}
