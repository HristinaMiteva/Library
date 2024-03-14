using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"), "Free Spirit Publishing" },
                    { new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"), "Arbordale Publishing" },
                    { new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"), "Chronicle Books" },
                    { new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"), "Albert Whitman" },
                    { new Guid("931e6d94-1fc5-4af1-a722-f05bde8c64f9"), "August House" },
                    { new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"), "Candlewick Press" },
                    { new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"), "Kids Can Press" },
                    { new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"), "Flying Eye Books" },
                    { new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"), "Quirk Books" },
                    { new Guid("ea3480ae-657b-4bcf-ac44-8e45081b58e6"), "Holiday House" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("1ec7709f-f106-441d-b0d8-dbdc5d06971d"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("36bda0c2-9ea8-4c67-a86f-f81486343f12"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d24ced7-7e83-4dae-9b60-d559d9d96bb0"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d2db36e-b584-4abf-a093-5b9ffe196486"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("931e6d94-1fc5-4af1-a722-f05bde8c64f9"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b2b63af9-18b0-48f4-9078-30836e6f54f7"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("bb40bb66-099d-40ff-8994-d5dc15e3d97d"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e04651b0-5913-4ee7-a691-cdb85933f3ee"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e6dc8da9-4a57-4821-beb3-24117746b333"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ea3480ae-657b-4bcf-ac44-8e45081b58e6"));
        }
    }
}
