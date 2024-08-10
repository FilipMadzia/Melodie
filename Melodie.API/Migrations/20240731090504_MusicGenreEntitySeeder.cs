using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class MusicGenreEntitySeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9420f81-942c-4e2c-940d-6a8a38a3c4a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("de42d5f2-b086-437e-8ec0-cf059ea002da"));

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "TrackEntityId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ad39e64-0137-400e-9833-5b63e0ee341e"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(8991), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("493da5ab-bf5d-4c5b-a75a-20112425af51"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(9002), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4fc473f9-26a3-41d2-bed6-7a06f96379a2"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(8995), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("56ea9e32-2651-49ce-9712-6e29301874c7"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(9000), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("63ad6288-edca-4b6b-acca-5da4e409ff78"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(8998), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4c242883-bc71-4a4d-9b79-7fbf58ff8d2c"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(8896), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("aef5cf53-01bf-4c10-8d85-9352033e0f56"), new DateTime(2024, 7, 31, 11, 5, 3, 484, DateTimeKind.Local).AddTicks(8950), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("0ad39e64-0137-400e-9833-5b63e0ee341e"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("493da5ab-bf5d-4c5b-a75a-20112425af51"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("4fc473f9-26a3-41d2-bed6-7a06f96379a2"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("56ea9e32-2651-49ce-9712-6e29301874c7"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("63ad6288-edca-4b6b-acca-5da4e409ff78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c242883-bc71-4a4d-9b79-7fbf58ff8d2c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aef5cf53-01bf-4c10-8d85-9352033e0f56"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("b9420f81-942c-4e2c-940d-6a8a38a3c4a4"), new DateTime(2024, 7, 31, 10, 9, 20, 362, DateTimeKind.Local).AddTicks(8744), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("de42d5f2-b086-437e-8ec0-cf059ea002da"), new DateTime(2024, 7, 31, 10, 9, 20, 362, DateTimeKind.Local).AddTicks(8801), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }
    }
}
