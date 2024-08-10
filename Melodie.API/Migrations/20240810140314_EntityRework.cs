using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class EntityRework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Users_UserEntityId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Users_UserEntityId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Singles_Users_UserEntityId",
                table: "Singles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Users_UserEntityId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_UserEntityId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Singles_UserEntityId",
                table: "Singles");

            migrationBuilder.DropIndex(
                name: "IX_Artists_UserEntityId",
                table: "Artists");

            migrationBuilder.DropIndex(
                name: "IX_Albums_UserEntityId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Singles");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Albums");

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
                    LikedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedAlbums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedAlbums_Albums_LikedId",
                        column: x => x.LikedId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedAlbums_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    LikedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedArtists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedArtists_Artists_LikedId",
                        column: x => x.LikedId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedArtists_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    LikedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedSingles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedSingles_Singles_LikedId",
                        column: x => x.LikedId,
                        principalTable: "Singles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedSingles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    LikedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedTracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedTracks_Tracks_LikedId",
                        column: x => x.LikedId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedTracks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LikedAlbums_LikedId",
                table: "LikedAlbums",
                column: "LikedId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedAlbums_UserId",
                table: "LikedAlbums",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedArtists_LikedId",
                table: "LikedArtists",
                column: "LikedId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedArtists_UserId",
                table: "LikedArtists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedSingles_LikedId",
                table: "LikedSingles",
                column: "LikedId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedSingles_UserId",
                table: "LikedSingles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedTracks_LikedId",
                table: "LikedTracks",
                column: "LikedId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedTracks_UserId",
                table: "LikedTracks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikedAlbums");

            migrationBuilder.DropTable(
                name: "LikedArtists");

            migrationBuilder.DropTable(
                name: "LikedSingles");

            migrationBuilder.DropTable(
                name: "LikedTracks");

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityId",
                table: "Tracks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityId",
                table: "Singles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityId",
                table: "Artists",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserEntityId",
                table: "Albums",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_UserEntityId",
                table: "Tracks",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Singles_UserEntityId",
                table: "Singles",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_UserEntityId",
                table: "Artists",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_UserEntityId",
                table: "Albums",
                column: "UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Users_UserEntityId",
                table: "Albums",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Users_UserEntityId",
                table: "Artists",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_Users_UserEntityId",
                table: "Singles",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Users_UserEntityId",
                table: "Tracks",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
