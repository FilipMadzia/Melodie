using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class ArtistMusicGenresSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("103e759a-0d7c-4b39-a172-4cf0cb916446"), new Guid("e0cd5f57-37e8-4176-9785-d9cb9811c50f"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(834), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("25333132-1f48-400d-91d5-2e417a432ad1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2928ef36-ed81-45d1-8e31-b6751109b9c9"), new Guid("14ab9112-d6ab-4754-97da-6316dc295146"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2454), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("a815ce49-9798-48c1-bfba-d0e36b6ffb94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("35ca2a87-56f9-479a-b5df-1d64ef0ef3f2"), new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2460), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("04c61a1a-7e17-4dab-8fe7-a07db7e48d97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("504b42a0-2f61-4c2b-aeeb-7a99f045fb16"), new Guid("e0cd5f57-37e8-4176-9785-d9cb9811c50f"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2439), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("0d154867-ee90-4431-a66e-644c3abe228a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("64c19254-de61-4dd3-98cc-c0da3b378309"), new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2539), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("f4e6edc3-604d-4bf2-9a78-242e2f21d60b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6d2b5a2a-0238-42bf-af50-942ec5b22214"), new Guid("e0cd5f57-37e8-4176-9785-d9cb9811c50f"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2414), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("9cfbb764-2260-449f-af5a-02f9a15edbc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6e98c023-ce40-474b-9c06-87f0bb8ee34f"), new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2533), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("27b642bb-cea2-4a2f-8d8d-b51a0a2a7738"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("78ec5ffa-f58c-4f8c-b1c9-6a3f2154aced"), new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2470), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("b019947a-0b59-4d03-8a7c-9a8897f09c51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9972e5cf-94a4-4bf1-8e69-e7d86d29d483"), new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2476), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("0b9ea545-b198-4e69-b060-0283d46a5f6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c69f0817-8580-410d-804a-c13dfe743950"), new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2465), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("13effa26-5b06-4524-a56c-59f200e9a8ed"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d17ecc82-af7a-4b50-bf5f-fa603c42a79a"), new Guid("a881772b-c108-4278-9aa1-cba082e5ab17"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2444), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("0306ffc7-b250-4128-97fe-ff30dc849b8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("edaa1ff7-bcdf-4748-bdee-b539aaf508bf"), new Guid("e0cd5f57-37e8-4176-9785-d9cb9811c50f"), new DateTime(2024, 8, 13, 21, 20, 6, 511, DateTimeKind.Local).AddTicks(2433), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("30ece9f8-d929-487b-8a79-55b2e04d2516"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("14ab9112-d6ab-4754-97da-6316dc295146"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(1916), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a881772b-c108-4278-9aa1-cba082e5ab17"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(1907), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e0cd5f57-37e8-4176-9785-d9cb9811c50f"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(1589), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(1919), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0306ffc7-b250-4128-97fe-ff30dc849b8d"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5178), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("04c61a1a-7e17-4dab-8fe7-a07db7e48d97"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5183), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hip-hop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0b9ea545-b198-4e69-b060-0283d46a5f6e"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5191), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop punk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0d154867-ee90-4431-a66e-644c3abe228a"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5175), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("13effa26-5b06-4524-a56c-59f200e9a8ed"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5186), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("25333132-1f48-400d-91d5-2e417a432ad1"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(4862), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27b642bb-cea2-4a2f-8d8d-b51a0a2a7738"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5196), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Power pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("30ece9f8-d929-487b-8a79-55b2e04d2516"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5171), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5861cfa0-ce63-44be-8fb9-38cac7580e7c"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5202), new Guid("00000000-0000-0000-0000-000000000000"), 0, "New wave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9cfbb764-2260-449f-af5a-02f9a15edbc6"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5153), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a815ce49-9798-48c1-bfba-d0e36b6ffb94"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5181), new Guid("00000000-0000-0000-0000-000000000000"), 0, "J-Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b019947a-0b59-4d03-8a7c-9a8897f09c51"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5189), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f4e6edc3-604d-4bf2-9a78-242e2f21d60b"), new DateTime(2024, 8, 13, 21, 20, 6, 510, DateTimeKind.Local).AddTicks(5199), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4ab15196-b59b-4492-a5f6-5c1eb1bf390c"), new DateTime(2024, 8, 13, 21, 20, 6, 509, DateTimeKind.Local).AddTicks(8541), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7662ff5d-24e1-4364-b674-e7787f6521b5"), new DateTime(2024, 8, 13, 21, 20, 6, 507, DateTimeKind.Local).AddTicks(7386), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("103e759a-0d7c-4b39-a172-4cf0cb916446"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("2928ef36-ed81-45d1-8e31-b6751109b9c9"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("35ca2a87-56f9-479a-b5df-1d64ef0ef3f2"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("504b42a0-2f61-4c2b-aeeb-7a99f045fb16"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("64c19254-de61-4dd3-98cc-c0da3b378309"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("6d2b5a2a-0238-42bf-af50-942ec5b22214"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("6e98c023-ce40-474b-9c06-87f0bb8ee34f"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("78ec5ffa-f58c-4f8c-b1c9-6a3f2154aced"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("9972e5cf-94a4-4bf1-8e69-e7d86d29d483"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("c69f0817-8580-410d-804a-c13dfe743950"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("d17ecc82-af7a-4b50-bf5f-fa603c42a79a"));

            migrationBuilder.DeleteData(
                table: "ArtistMusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("edaa1ff7-bcdf-4748-bdee-b539aaf508bf"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("14ab9112-d6ab-4754-97da-6316dc295146"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("a881772b-c108-4278-9aa1-cba082e5ab17"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("e0cd5f57-37e8-4176-9785-d9cb9811c50f"));

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: new Guid("ffa1ac14-72cc-4b7b-9b0e-3306b1531cfa"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("0306ffc7-b250-4128-97fe-ff30dc849b8d"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("04c61a1a-7e17-4dab-8fe7-a07db7e48d97"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("0b9ea545-b198-4e69-b060-0283d46a5f6e"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("0d154867-ee90-4431-a66e-644c3abe228a"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("13effa26-5b06-4524-a56c-59f200e9a8ed"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("25333132-1f48-400d-91d5-2e417a432ad1"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("27b642bb-cea2-4a2f-8d8d-b51a0a2a7738"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("30ece9f8-d929-487b-8a79-55b2e04d2516"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("5861cfa0-ce63-44be-8fb9-38cac7580e7c"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("9cfbb764-2260-449f-af5a-02f9a15edbc6"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("a815ce49-9798-48c1-bfba-d0e36b6ffb94"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("b019947a-0b59-4d03-8a7c-9a8897f09c51"));

            migrationBuilder.DeleteData(
                table: "MusicGenres",
                keyColumn: "Id",
                keyValue: new Guid("f4e6edc3-604d-4bf2-9a78-242e2f21d60b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ab15196-b59b-4492-a5f6-5c1eb1bf390c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7662ff5d-24e1-4364-b674-e7787f6521b5"));

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
    }
}
