using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfectHelp.Data.Migrations
{
    public partial class change3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotRegisteredEmails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotRegisteredEmails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-3d56fd7217",
                column: "ConcurrencyStamp",
                value: "aa54fb01-0ce5-4cf8-83d1-509c7e8a180b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b2448722-0d12-4799-be60-e25bf12fa4bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7214",
                column: "ConcurrencyStamp",
                value: "0effb6a9-e19d-4c2e-b8fc-b702fe1238a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52b6e023-1b29-4055-95e4-4f93e13918c6", "AQAAAAEAACcQAAAAECMxgeRgzhgnUGzccnxSLov67oWbcNlPhHQsdK9lIrHWHY3c70pKLqmqB0nJudacLQ==", "044b2b22-e226-49c2-937f-9e70dbdd592b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93724490-3e01-4900-b521-a1f2b7909007", "AQAAAAEAACcQAAAAEOxOIMyXpUyJk1THJkHLHcfyenymIItOXwSFoZWZaZmaQb4U+Cys6NsCtYind45XLw==", "0edb313c-21c3-49fe-8163-5ad05862f2a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5e174e-3y0e-446f-86af-483d56fc7211",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11046878-4e70-47cf-a567-572f9ecec073", "AQAAAAEAACcQAAAAEHBcJu0Zu1ieLYmhRXWo/FWpT/fCAJFgan2VMqwHD2DTB/oe9phm1HvBP4/obw0dvQ==", "5da11fb4-8466-4610-a6d4-768ec002be45" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotRegisteredEmails");

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
    }
}
