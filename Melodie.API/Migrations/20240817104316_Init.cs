using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlbumTrack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTrack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtistMusicGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MusicGenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistMusicGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LikedAlbums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedAlbums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LikedArtists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedArtists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LikedSingles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedSingles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LikedTracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedTracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueueTrack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueTrack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Singles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArtistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SingleTrack",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingleTrack", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ArtistMusicGenres",
                columns: new[] { "Id", "ArtistId", "CreatedAt", "CreatedBy", "EntityStatus", "MusicGenreId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1b37b8b0-ef09-45be-a533-4f311a961f2d"), new Guid("608a8a2f-c35f-469f-9200-8be082ccd625"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(6268), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("4c3bf51c-b3f2-407c-9aea-95f4606e57fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27f4572a-d512-48de-ad8d-7db2f3886fcb"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7999), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("71787e50-98f2-421d-8cb9-a7147032e5ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3549a770-0240-4c9a-8a64-e64814971681"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7974), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("d5ae2db2-8042-4e61-9497-a9eb86e5818f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("43ebef7b-4b72-43b9-a538-30712c8dd8c4"), new Guid("608a8a2f-c35f-469f-9200-8be082ccd625"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7929), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("97407a1a-26ec-4e55-ba42-de5241fe3334"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4a56f37b-d20d-451f-b5b2-9d43c0287986"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7983), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("5c969512-a829-49fb-83b4-9baacc165d79"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a130a5d8-396e-4af0-b20d-e2966a59c9cf"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7992), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("d8b5d2f9-9c5f-4444-8ad2-80d0de7a5e93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1b2cdea-97f6-497f-ae40-ada84aaddca6"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7987), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("db2878c3-9c9f-40b2-bd5d-082cc2d61c5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a5322655-97eb-43f3-ab9c-7b8277b5e260"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7978), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("187d526b-95ba-4665-b39d-74136d3f02f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c5b3fc74-5cd9-4140-b1ef-e204f2790b2a"), new Guid("fbe92a61-d187-463b-9dde-b4f090caeecf"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7969), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("74f836ff-6b7a-4276-a315-5efe3b347f80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e24137b4-0cbe-473c-b1c8-11fcb6d26a6d"), new Guid("98850abe-a85d-4f31-832f-6fca01023bfc"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7964), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("ea8363d0-0a24-4388-aebf-9375659f515f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e284489f-9879-4335-bcfb-aa777e1d90e2"), new Guid("608a8a2f-c35f-469f-9200-8be082ccd625"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7959), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("d37169ce-f63e-4f85-a746-91d4f1dc2799"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3812f72-0a0d-4ae5-9d8f-75189225265e"), new Guid("608a8a2f-c35f-469f-9200-8be082ccd625"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(7949), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("1532f07c-fb9a-46fa-b293-8809b41fa2f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("608a8a2f-c35f-469f-9200-8be082ccd625"), new DateTime(2024, 8, 17, 12, 43, 15, 907, DateTimeKind.Local).AddTicks(6432), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 907, DateTimeKind.Local).AddTicks(6725), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("98850abe-a85d-4f31-832f-6fca01023bfc"), new DateTime(2024, 8, 17, 12, 43, 15, 907, DateTimeKind.Local).AddTicks(6714), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fbe92a61-d187-463b-9dde-b4f090caeecf"), new DateTime(2024, 8, 17, 12, 43, 15, 907, DateTimeKind.Local).AddTicks(6723), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1532f07c-fb9a-46fa-b293-8809b41fa2f7"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(445), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("187d526b-95ba-4665-b39d-74136d3f02f4"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(456), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4c3bf51c-b3f2-407c-9aea-95f4606e57fa"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(136), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("592a073e-0079-4f72-a47b-e2df4b8d0c94"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(471), new Guid("00000000-0000-0000-0000-000000000000"), 0, "New wave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5c969512-a829-49fb-83b4-9baacc165d79"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(462), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("71787e50-98f2-421d-8cb9-a7147032e5ba"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(469), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("74f836ff-6b7a-4276-a315-5efe3b347f80"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(452), new Guid("00000000-0000-0000-0000-000000000000"), 0, "J-Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("97407a1a-26ec-4e55-ba42-de5241fe3334"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(436), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d37169ce-f63e-4f85-a746-91d4f1dc2799"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(447), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d5ae2db2-8042-4e61-9497-a9eb86e5818f"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(454), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hip-hop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d8b5d2f9-9c5f-4444-8ad2-80d0de7a5e93"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(467), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Power pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("db2878c3-9c9f-40b2-bd5d-082cc2d61c5a"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(465), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop punk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ea8363d0-0a24-4388-aebf-9375659f515f"), new DateTime(2024, 8, 17, 12, 43, 15, 908, DateTimeKind.Local).AddTicks(449), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SingleTrack",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityId", "EntityStatus", "TrackId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("01a8d865-bfb9-4b5d-b371-067c835bfe83"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(9061), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("259a594f-1322-4993-89c6-b11e3f7e3bba"), 0, new Guid("a1b787af-ed92-45ec-990d-5182d1ae0d9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3121b6ef-d97c-4ae6-99b3-f13d58c71c62"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(9894), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("eb83f7c7-8442-4097-83b9-24846b0696ee"), 0, new Guid("6b770726-1e00-46d4-b904-45c247628732"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a4607573-6778-4302-a640-1a07a27ee5d2"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(9889), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("2857111f-e1e0-4080-a473-67c7c3337970"), 0, new Guid("46e924c3-cad3-4eb3-a947-ae533eb1d6b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d244c816-5ec3-4831-a73e-2ab3389eed4a"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(9884), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("27e447d1-3f42-45fa-840a-b2d544f9b93b"), 0, new Guid("719e6fa2-fccf-474b-93df-368f5601def4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e8a8ddff-d33e-4463-abab-3739242aca24"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(9867), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c1b8f045-ac32-4bca-afd4-3f1d2897a206"), 0, new Guid("e0d58df5-4841-47f5-9cca-9349f92a5bb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Singles",
                columns: new[] { "Id", "ArtistId", "CreatedAt", "CreatedBy", "EntityStatus", "ReleaseDate", "TrackId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("259a594f-1322-4993-89c6-b11e3f7e3bba"), new Guid("608a8a2f-c35f-469f-9200-8be082ccd625"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(4244), new Guid("00000000-0000-0000-0000-000000000000"), 0, new DateOnly(2009, 9, 1), new Guid("a1b787af-ed92-45ec-990d-5182d1ae0d9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("27e447d1-3f42-45fa-840a-b2d544f9b93b"), new Guid("98850abe-a85d-4f31-832f-6fca01023bfc"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(5535), new Guid("00000000-0000-0000-0000-000000000000"), 0, new DateOnly(2023, 11, 17), new Guid("719e6fa2-fccf-474b-93df-368f5601def4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2857111f-e1e0-4080-a473-67c7c3337970"), new Guid("fbe92a61-d187-463b-9dde-b4f090caeecf"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(5541), new Guid("00000000-0000-0000-0000-000000000000"), 0, new DateOnly(2024, 4, 5), new Guid("46e924c3-cad3-4eb3-a947-ae533eb1d6b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c1b8f045-ac32-4bca-afd4-3f1d2897a206"), new Guid("98850abe-a85d-4f31-832f-6fca01023bfc"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(5505), new Guid("00000000-0000-0000-0000-000000000000"), 0, new DateOnly(2024, 2, 21), new Guid("e0d58df5-4841-47f5-9cca-9349f92a5bb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("eb83f7c7-8442-4097-83b9-24846b0696ee"), new Guid("7308c47f-2918-4e02-b6aa-25895536414a"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(5547), new Guid("00000000-0000-0000-0000-000000000000"), 0, new DateOnly(2020, 9, 24), new Guid("6b770726-1e00-46d4-b904-45c247628732"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("46e924c3-cad3-4eb3-a947-ae533eb1d6b2"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(519), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nic na mnie", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6b770726-1e00-46d4-b904-45c247628732"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(521), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Skinny Skinny", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("719e6fa2-fccf-474b-93df-368f5601def4"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(516), new Guid("00000000-0000-0000-0000-000000000000"), 0, "yattyattawa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1b787af-ed92-45ec-990d-5182d1ae0d9a"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(227), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Break", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e0d58df5-4841-47f5-9cca-9349f92a5bb7"), new DateTime(2024, 8, 17, 12, 43, 15, 909, DateTimeKind.Local).AddTicks(507), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Inochizuna", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("026f9875-97f5-48da-b1bc-f638edb87325"), new DateTime(2024, 8, 17, 12, 43, 15, 907, DateTimeKind.Local).AddTicks(4307), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fec32de7-126c-47c6-956f-02ef170ee1db"), new DateTime(2024, 8, 17, 12, 43, 15, 905, DateTimeKind.Local).AddTicks(2772), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "AlbumTrack");

            migrationBuilder.DropTable(
                name: "ArtistMusicGenres");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "LikedAlbums");

            migrationBuilder.DropTable(
                name: "LikedArtists");

            migrationBuilder.DropTable(
                name: "LikedSingles");

            migrationBuilder.DropTable(
                name: "LikedTracks");

            migrationBuilder.DropTable(
                name: "MusicGenres");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Queues");

            migrationBuilder.DropTable(
                name: "QueueTrack");

            migrationBuilder.DropTable(
                name: "Singles");

            migrationBuilder.DropTable(
                name: "SingleTrack");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
