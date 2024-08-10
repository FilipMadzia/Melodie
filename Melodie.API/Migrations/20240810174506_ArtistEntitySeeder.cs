using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class ArtistEntitySeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a4cc7240-8726-4193-acc0-3b8cce6126a0"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4082), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c24cc7be-37e9-4e3d-932e-2c8774584892"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4091), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c9048a62-ec1b-456e-9794-5f2e6c537864"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4087), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cd0ecd8e-e1f5-4d57-8c0a-4d0389ac1e23"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4089), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "TrackEntityId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3d616fe5-c7a0-44b5-a810-e5fc27ce09f4"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4031), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("68a45255-5c5c-4299-bac1-ff60195381f0"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4046), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8bf1ae5e-d9fb-4147-bc42-3ad8aa8ed1cf"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4028), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d986b817-3fc9-43b7-9adb-de275ddf930d"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4024), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e22c363d-afd2-4651-bf10-a31e11c597ed"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(4033), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("91f89a93-37ff-480b-a233-40da5b581735"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(3981), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ebd8aeb5-726b-4a90-863f-a9fc70c1391c"), new DateTime(2024, 8, 10, 19, 45, 5, 624, DateTimeKind.Local).AddTicks(3922), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a4cc7240-8726-4193-acc0-3b8cce6126a0"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("c24cc7be-37e9-4e3d-932e-2c8774584892"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("c9048a62-ec1b-456e-9794-5f2e6c537864"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("cd0ecd8e-e1f5-4d57-8c0a-4d0389ac1e23"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("3d616fe5-c7a0-44b5-a810-e5fc27ce09f4"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("68a45255-5c5c-4299-bac1-ff60195381f0"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("8bf1ae5e-d9fb-4147-bc42-3ad8aa8ed1cf"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("d986b817-3fc9-43b7-9adb-de275ddf930d"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("e22c363d-afd2-4651-bf10-a31e11c597ed"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("91f89a93-37ff-480b-a233-40da5b581735"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ebd8aeb5-726b-4a90-863f-a9fc70c1391c"));

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
    }
}
