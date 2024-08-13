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
                    { new Guid("1112ecec-650a-4031-af21-e119f4b105f7"), new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3540), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("5beb7ac0-0b1b-4683-8f9a-7781e45eeabe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("11e9fed8-2a6c-4ef1-af1b-3ff2ad4e0412"), new Guid("5ea691bc-c715-4f6a-b269-d1f24b775184"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(1437), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("4f5da7ab-e93f-47c6-b118-95ec29f206ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("18f70795-2d7d-4598-90fe-954d8896c572"), new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3526), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("2082c19f-4779-46c7-99e8-a15052c497f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2d892ed1-39bb-4e48-9e59-5f8eecdd8bf0"), new Guid("5ea691bc-c715-4f6a-b269-d1f24b775184"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3496), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("26cf26a5-2a94-4e3d-af6e-f9ea822551c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6972d035-0869-4cd0-b13d-041de54fa8c1"), new Guid("5ea691bc-c715-4f6a-b269-d1f24b775184"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3481), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("4bd4e850-e517-48d9-afed-06ea21f37f73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("87ea187c-22ee-48c9-b349-7c6d680ddb20"), new Guid("a85be9e6-10ec-49ac-b128-57d62c381186"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3501), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("901b5528-7a47-486b-a902-0b3ce32ffee6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8c819d28-ac3d-4b6e-9adc-7dee3f6805ed"), new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3516), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("2fe32e20-5dd1-439d-b9c4-58606198fa07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("946cd5f5-a57d-4cd0-bce9-418920b4ce09"), new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3521), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("467d0e6f-24bf-4367-90c4-9cd3c9c10448"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ad19115c-047d-4aa0-967b-6fa9943a11c1"), new Guid("143344c4-c357-410f-bd08-f30de66ac46f"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3506), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("c38dd7f4-3151-4650-95be-5be92304fbca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cc6d3254-58fa-45fc-9ccd-ffc93a08eb64"), new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3531), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("15212128-9808-4e5c-8785-22710bc2f720"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e6488bd0-bbe5-40b3-9e2a-4d04be13418e"), new Guid("5ea691bc-c715-4f6a-b269-d1f24b775184"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3460), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("5242acc6-ec8e-4790-9125-ba63b1894ac6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fca1b221-e924-49f3-a3fd-9c5872b066f7"), new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(3511), new Guid("00000000-0000-0000-0000-000000000000"), 0, new Guid("9333bafb-9af5-431b-993b-a45d1c9e7553"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("143344c4-c357-410f-bd08-f30de66ac46f"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(999), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Gibbs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5ea691bc-c715-4f6a-b269-d1f24b775184"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(701), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Three Days Grace", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a85be9e6-10ec-49ac-b128-57d62c381186"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(991), new Guid("00000000-0000-0000-0000-000000000000"), 0, "syudou", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cc45cd11-c522-4785-ae6c-22b7af97c4e6"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(1001), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Ashton Irwin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "MusicGenres",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("15212128-9808-4e5c-8785-22710bc2f720"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4452), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Power pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2082c19f-4779-46c7-99e8-a15052c497f1"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4450), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop punk", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("26cf26a5-2a94-4e3d-af6e-f9ea822551c7"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4432), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2fe32e20-5dd1-439d-b9c4-58606198fa07"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4441), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("467d0e6f-24bf-4367-90c4-9cd3c9c10448"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4447), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4bd4e850-e517-48d9-afed-06ea21f37f73"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4429), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Alternative rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4f5da7ab-e93f-47c6-b118-95ec29f206ae"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4119), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Post-grunge", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5242acc6-ec8e-4790-9125-ba63b1894ac6"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4420), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hard rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5961ec45-4d10-4a0a-8902-0ec20022d3d9"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4456), new Guid("00000000-0000-0000-0000-000000000000"), 0, "New wave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5beb7ac0-0b1b-4683-8f9a-7781e45eeabe"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4454), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Rock", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("901b5528-7a47-486b-a902-0b3ce32ffee6"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4434), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Nu metal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9333bafb-9af5-431b-993b-a45d1c9e7553"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4439), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Hip-hop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c38dd7f4-3151-4650-95be-5be92304fbca"), new DateTime(2024, 8, 13, 21, 35, 32, 784, DateTimeKind.Local).AddTicks(4436), new Guid("00000000-0000-0000-0000-000000000000"), 0, "J-Pop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SingleTrack",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityId", "EntityStatus", "TrackId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("bd6dfe3f-1ce8-4f32-b162-90e3e1aa4b7f"), new DateTime(2024, 8, 13, 21, 35, 32, 786, DateTimeKind.Local).AddTicks(302), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("f094f816-653c-4c43-aa88-74a36a69b3c8"), 0, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Singles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "ReleaseDate", "TrackId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("f094f816-653c-4c43-aa88-74a36a69b3c8"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(7416), new Guid("00000000-0000-0000-0000-000000000000"), 0, new DateOnly(2009, 9, 1), new Guid("ad956407-0384-4946-898d-c269e78013d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EntityStatus", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("ad956407-0384-4946-898d-c269e78013d8"), new DateTime(2024, 8, 13, 21, 35, 32, 785, DateTimeKind.Local).AddTicks(5197), new Guid("00000000-0000-0000-0000-000000000000"), 0, "Break", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Email", "EntityStatus", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("39b2c64e-6626-4a92-8e0a-e4a22a717989"), new DateTime(2024, 8, 13, 21, 35, 32, 781, DateTimeKind.Local).AddTicks(6691), new Guid("00000000-0000-0000-0000-000000000000"), "seed@seed", 0, "seed", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4fa9a124-6a2a-4751-82c0-6f63201e84a6"), new DateTime(2024, 8, 13, 21, 35, 32, 783, DateTimeKind.Local).AddTicks(8483), new Guid("00000000-0000-0000-0000-000000000000"), "seed2@seed2", 0, "seed2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000") }
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
