using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class MusicGenresSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("2070d36e-c8df-41a7-bfbc-7d2659feb72f"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("66b22d70-6ab6-4770-8205-6e7532feb200"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("6bac9f88-bccd-4a9e-b7a3-6659744dd1a1"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("ff2ecc10-d4a3-4a88-88f5-90fdd9a3e0b1"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("2bf59995-b38f-4425-a4a4-649df23594ad"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("32b31e13-3897-438f-bd6f-63fc90046db0"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("b4f6eafa-1290-451d-a6fb-188e3b452824"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("b6fb8a2a-4f11-472f-a509-11140619670b"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("08fb9016-1ac1-4aa6-b868-684da4694757"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("2246ebd4-1087-4e01-b3e3-43b0b468d5e0"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("9eca5eaf-cec5-45f0-a914-f7c4c762c256"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("e791e87d-b84f-4fc3-a946-596d3f435963"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dfb60c62-69ac-4044-a73a-5b3e5c41aa11"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f92b3e40-0b64-4637-8837-0cc708669f02"));

            migrationBuilder.InsertData(
                table: "ArtistMusicGenres",
                columns: new[] { "Id", "ArtistId", "CreatedAt", "CreatedBy", "EntityStatus", "MusicGenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1f58272b-14b4-4ee9-b1ce-0b4d1cb34148"), new Guid("8e05ff08-4c3b-4226-8454-8060b95998c3"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(8486), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("dc07f14f-f590-4fc0-b416-c98f73ed70c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("30957b3b-06f6-47ca-a82b-ee8d3707d180"), new Guid("8e05ff08-4c3b-4226-8454-8060b95998c3"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(8481), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("7a893019-e033-4814-8b6a-bdc9a0ffc747"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4ce26075-e113-4ad7-b1fb-265f1d930396"), new Guid("8e05ff08-4c3b-4226-8454-8060b95998c3"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(8463), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("acacc132-d554-4bd9-9cb6-e2579e92d5ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6addaa0b-74d9-453e-a8e1-deaf1d5c882e"), new Guid("8e05ff08-4c3b-4226-8454-8060b95998c3"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(7072), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("c73a62f0-50b0-45d2-8a67-a825b4234a3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3a694cd2-16bf-4237-809b-6af3df77b321"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(746), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6ccc8d5e-4792-4a74-87c6-1cb5da69e5ed"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(735), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8e05ff08-4c3b-4226-8454-8060b95998c3"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(417), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e5e912a4-6a2f-4e28-9def-2ae091c751e5"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(744), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("08b5a778-d2c9-4fc1-8237-87215feaa5aa"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4036), new Guid("00000000-0000-0000-0000-000000000000"), 0, "J-Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c4dc5bd-9400-4010-825f-8e8a48c14d85"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4055), new Guid("00000000-0000-0000-0000-000000000000"), 0, "New wave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("462a4969-c22c-440c-a017-7b355c8a2e31"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4034), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5000e081-e612-44ca-8cc6-879d2f5929bc"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4053), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7a893019-e033-4814-8b6a-bdc9a0ffc747"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4029), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8177358c-d0a2-4493-bffb-8885330d719a"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4045), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop punk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8575e91b-c592-49e3-b303-492ab00914c5"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4038), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hip-hop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("aba7c265-11f6-40fc-9a36-2ad57ad4b981"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4041), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("acacc132-d554-4bd9-9cb6-e2579e92d5ac"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4013), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bae34181-a437-4a63-85d4-af1ce205b863"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4050), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Power pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c73a62f0-50b0-45d2-8a67-a825b4234a3e"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(3713), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d4589483-9ee4-483c-a8ab-7e263443080c"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4043), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dc07f14f-f590-4fc0-b416-c98f73ed70c2"), new DateTime(2024, 8, 13, 21, 14, 53, 536, DateTimeKind.Local).AddTicks(4032), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a2c0e834-33fb-485b-9ad2-ba5d4205d1c8"), new DateTime(2024, 8, 13, 21, 14, 53, 535, DateTimeKind.Local).AddTicks(8353), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fcbb681a-96b3-4bb1-b343-d7bff5d87a56"), new DateTime(2024, 8, 13, 21, 14, 53, 533, DateTimeKind.Local).AddTicks(6438), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("1f58272b-14b4-4ee9-b1ce-0b4d1cb34148"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("30957b3b-06f6-47ca-a82b-ee8d3707d180"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("4ce26075-e113-4ad7-b1fb-265f1d930396"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("6addaa0b-74d9-453e-a8e1-deaf1d5c882e"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("3a694cd2-16bf-4237-809b-6af3df77b321"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("6ccc8d5e-4792-4a74-87c6-1cb5da69e5ed"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("8e05ff08-4c3b-4226-8454-8060b95998c3"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("e5e912a4-6a2f-4e28-9def-2ae091c751e5"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("08b5a778-d2c9-4fc1-8237-87215feaa5aa"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("1c4dc5bd-9400-4010-825f-8e8a48c14d85"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("462a4969-c22c-440c-a017-7b355c8a2e31"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("5000e081-e612-44ca-8cc6-879d2f5929bc"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("7a893019-e033-4814-8b6a-bdc9a0ffc747"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("8177358c-d0a2-4493-bffb-8885330d719a"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("8575e91b-c592-49e3-b303-492ab00914c5"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("aba7c265-11f6-40fc-9a36-2ad57ad4b981"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("acacc132-d554-4bd9-9cb6-e2579e92d5ac"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("bae34181-a437-4a63-85d4-af1ce205b863"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("c73a62f0-50b0-45d2-8a67-a825b4234a3e"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("d4589483-9ee4-483c-a8ab-7e263443080c"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("dc07f14f-f590-4fc0-b416-c98f73ed70c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2c0e834-33fb-485b-9ad2-ba5d4205d1c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcbb681a-96b3-4bb1-b343-d7bff5d87a56"));

            migrationBuilder.InsertData(
                table: "ArtistMusicGenres",
                columns: new[] { "Id", "ArtistId", "CreatedAt", "CreatedBy", "EntityStatus", "MusicGenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2070d36e-c8df-41a7-bfbc-7d2659feb72f"), new Guid("b4f6eafa-1290-451d-a6fb-188e3b452824"), new DateTime(2024, 8, 12, 21, 57, 22, 102, DateTimeKind.Local).AddTicks(34), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("9eca5eaf-cec5-45f0-a914-f7c4c762c256"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("66b22d70-6ab6-4770-8205-6e7532feb200"), new Guid("b4f6eafa-1290-451d-a6fb-188e3b452824"), new DateTime(2024, 8, 12, 21, 57, 22, 102, DateTimeKind.Local).AddTicks(39), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("e791e87d-b84f-4fc3-a946-596d3f435963"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6bac9f88-bccd-4a9e-b7a3-6659744dd1a1"), new Guid("b4f6eafa-1290-451d-a6fb-188e3b452824"), new DateTime(2024, 8, 12, 21, 57, 22, 102, DateTimeKind.Local).AddTicks(15), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("2246ebd4-1087-4e01-b3e3-43b0b468d5e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ff2ecc10-d4a3-4a88-88f5-90fdd9a3e0b1"), new Guid("b4f6eafa-1290-451d-a6fb-188e3b452824"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(8529), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("08fb9016-1ac1-4aa6-b868-684da4694757"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2bf59995-b38f-4425-a4a4-649df23594ad"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(3278), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("32b31e13-3897-438f-bd6f-63fc90046db0"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(3290), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b4f6eafa-1290-451d-a6fb-188e3b452824"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(2960), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b6fb8a2a-4f11-472f-a509-11140619670b"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(3288), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("08fb9016-1ac1-4aa6-b868-684da4694757"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(5273), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2246ebd4-1087-4e01-b3e3-43b0b468d5e0"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(5574), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9eca5eaf-cec5-45f0-a914-f7c4c762c256"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(5583), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e791e87d-b84f-4fc3-a946-596d3f435963"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(5585), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("dfb60c62-69ac-4044-a73a-5b3e5c41aa11"), new DateTime(2024, 8, 12, 21, 57, 22, 98, DateTimeKind.Local).AddTicks(9581), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f92b3e40-0b64-4637-8837-0cc708669f02"), new DateTime(2024, 8, 12, 21, 57, 22, 101, DateTimeKind.Local).AddTicks(842), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }
    }
}
