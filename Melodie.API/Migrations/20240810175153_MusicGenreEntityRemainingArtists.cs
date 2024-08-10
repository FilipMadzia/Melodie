using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class MusicGenreEntityRemainingArtists : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0c01eed9-0376-48bd-b16f-91217f1665ad"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8611), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0dc62de0-c14c-412f-8154-a0afd7cb836d"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8620), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3f62f85e-6bb6-4451-9f00-74d0060ef6d5"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8618), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("767d8289-6cde-4e1a-ad04-f1bfa6b2c7fa"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8622), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "TrackEntityId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("14b94b47-2307-4edb-874f-f9814b2d6a5f"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8528), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1dcd4ad0-4212-4990-a657-fa22aa5a28b5"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8537), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("25131598-c033-4c17-949b-129383426870"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8556), new Guid("00000000-0000-0000-0000-000000000000"), 0, "J-Pop", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3bd8241d-7db8-4b5e-b1cd-42584229f640"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8532), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("407c97ff-520b-430c-90ba-776d8aa655dc"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8552), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4754acfd-591a-4791-bfcf-f72e508e81f4"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8575), new Guid("00000000-0000-0000-0000-000000000000"), 0, "New wave", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4837958a-8d7f-4186-aa89-e4834f2d3273"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8562), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4d88109d-f407-450a-ab3d-7e87b84c7b62"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8560), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("706cf7b3-8b5e-4b52-9dc3-cce09647916c"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8568), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Power pop", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("829cf8a5-d1af-4613-921f-27ffcca29024"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8534), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8ed5f5e3-6fd8-48ce-978b-0559f5e3be0e"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8570), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Rock", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8f1f8fcb-f0f6-46bc-9286-9561c132efbd"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8565), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop punk", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a3acfa20-f25a-4d87-a495-082594494a5b"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8558), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hip-hop", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4223c5ad-08b6-4039-8094-0ee03cf70a8e"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8486), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b17f7faa-46d3-448e-9e80-f5dde629f7c2"), new DateTime(2024, 8, 10, 19, 51, 53, 181, DateTimeKind.Local).AddTicks(8430), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("0c01eed9-0376-48bd-b16f-91217f1665ad"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("0dc62de0-c14c-412f-8154-a0afd7cb836d"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("3f62f85e-6bb6-4451-9f00-74d0060ef6d5"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("767d8289-6cde-4e1a-ad04-f1bfa6b2c7fa"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("14b94b47-2307-4edb-874f-f9814b2d6a5f"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("1dcd4ad0-4212-4990-a657-fa22aa5a28b5"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("25131598-c033-4c17-949b-129383426870"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("3bd8241d-7db8-4b5e-b1cd-42584229f640"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("407c97ff-520b-430c-90ba-776d8aa655dc"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("4754acfd-591a-4791-bfcf-f72e508e81f4"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("4837958a-8d7f-4186-aa89-e4834f2d3273"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("4d88109d-f407-450a-ab3d-7e87b84c7b62"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("706cf7b3-8b5e-4b52-9dc3-cce09647916c"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("829cf8a5-d1af-4613-921f-27ffcca29024"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("8ed5f5e3-6fd8-48ce-978b-0559f5e3be0e"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("8f1f8fcb-f0f6-46bc-9286-9561c132efbd"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("a3acfa20-f25a-4d87-a495-082594494a5b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4223c5ad-08b6-4039-8094-0ee03cf70a8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b17f7faa-46d3-448e-9e80-f5dde629f7c2"));

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
    }
}
