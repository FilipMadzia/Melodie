using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class MusicGenreEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Users_UserId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Users_UserId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Users_UserId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Singles_Artists_ArtistId",
                table: "Singles");

            migrationBuilder.DropForeignKey(
                name: "FK_Singles_Users_UserId",
                table: "Singles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Artists_ArtistId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Playlists_PlaylistId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Queues_QueueId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Users_UserId",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tracks",
                newName: "UserEntityId");

            migrationBuilder.RenameColumn(
                name: "QueueId",
                table: "Tracks",
                newName: "QueueEntityId");

            migrationBuilder.RenameColumn(
                name: "PlaylistId",
                table: "Tracks",
                newName: "PlaylistEntityId");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Tracks",
                newName: "ArtistEntityId");

            migrationBuilder.RenameColumn(
                name: "AlbumId",
                table: "Tracks",
                newName: "AlbumEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_UserId",
                table: "Tracks",
                newName: "IX_Tracks_UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_QueueId",
                table: "Tracks",
                newName: "IX_Tracks_QueueEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_PlaylistId",
                table: "Tracks",
                newName: "IX_Tracks_PlaylistEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_ArtistId",
                table: "Tracks",
                newName: "IX_Tracks_ArtistEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                newName: "IX_Tracks_AlbumEntityId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Singles",
                newName: "UserEntityId");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Singles",
                newName: "ArtistEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Singles_UserId",
                table: "Singles",
                newName: "IX_Singles_UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Singles_ArtistId",
                table: "Singles",
                newName: "IX_Singles_ArtistEntityId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Playlists",
                newName: "UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_UserId",
                table: "Playlists",
                newName: "IX_Playlists_UserEntityId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Artists",
                newName: "UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Artists_UserId",
                table: "Artists",
                newName: "IX_Artists_UserEntityId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Albums",
                newName: "UserEntityId");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Albums",
                newName: "ArtistEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_UserId",
                table: "Albums",
                newName: "IX_Albums_UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                newName: "IX_Albums_ArtistEntityId");

            migrationBuilder.CreateTable(
                name: "MusicGenres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusicGenres_Tracks_TrackEntityId",
                        column: x => x.TrackEntityId,
                        principalTable: "Tracks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicGenres_TrackEntityId",
                table: "MusicGenres",
                column: "TrackEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistEntityId",
                table: "Albums",
                column: "ArtistEntityId",
                principalTable: "Artists",
                principalColumn: "Id");

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
                name: "FK_Playlists_Users_UserEntityId",
                table: "Playlists",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_Artists_ArtistEntityId",
                table: "Singles",
                column: "ArtistEntityId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_Users_UserEntityId",
                table: "Singles",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumEntityId",
                table: "Tracks",
                column: "AlbumEntityId",
                principalTable: "Albums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Artists_ArtistEntityId",
                table: "Tracks",
                column: "ArtistEntityId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Playlists_PlaylistEntityId",
                table: "Tracks",
                column: "PlaylistEntityId",
                principalTable: "Playlists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Queues_QueueEntityId",
                table: "Tracks",
                column: "QueueEntityId",
                principalTable: "Queues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Users_UserEntityId",
                table: "Tracks",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistEntityId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Users_UserEntityId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Users_UserEntityId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Users_UserEntityId",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Singles_Artists_ArtistEntityId",
                table: "Singles");

            migrationBuilder.DropForeignKey(
                name: "FK_Singles_Users_UserEntityId",
                table: "Singles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumEntityId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Artists_ArtistEntityId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Playlists_PlaylistEntityId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Queues_QueueEntityId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Users_UserEntityId",
                table: "Tracks");

            migrationBuilder.DropTable(
                name: "MusicGenres");

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "Tracks",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "QueueEntityId",
                table: "Tracks",
                newName: "QueueId");

            migrationBuilder.RenameColumn(
                name: "PlaylistEntityId",
                table: "Tracks",
                newName: "PlaylistId");

            migrationBuilder.RenameColumn(
                name: "ArtistEntityId",
                table: "Tracks",
                newName: "ArtistId");

            migrationBuilder.RenameColumn(
                name: "AlbumEntityId",
                table: "Tracks",
                newName: "AlbumId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_UserEntityId",
                table: "Tracks",
                newName: "IX_Tracks_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_QueueEntityId",
                table: "Tracks",
                newName: "IX_Tracks_QueueId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_PlaylistEntityId",
                table: "Tracks",
                newName: "IX_Tracks_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_ArtistEntityId",
                table: "Tracks",
                newName: "IX_Tracks_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Tracks_AlbumEntityId",
                table: "Tracks",
                newName: "IX_Tracks_AlbumId");

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "Singles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ArtistEntityId",
                table: "Singles",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Singles_UserEntityId",
                table: "Singles",
                newName: "IX_Singles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Singles_ArtistEntityId",
                table: "Singles",
                newName: "IX_Singles_ArtistId");

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "Playlists",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Playlists_UserEntityId",
                table: "Playlists",
                newName: "IX_Playlists_UserId");

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "Artists",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Artists_UserEntityId",
                table: "Artists",
                newName: "IX_Artists_UserId");

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "Albums",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "ArtistEntityId",
                table: "Albums",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_UserEntityId",
                table: "Albums",
                newName: "IX_Albums_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Albums_ArtistEntityId",
                table: "Albums",
                newName: "IX_Albums_ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Users_UserId",
                table: "Albums",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Users_UserId",
                table: "Artists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Users_UserId",
                table: "Playlists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_Artists_ArtistId",
                table: "Singles",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_Users_UserId",
                table: "Singles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumId",
                table: "Tracks",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Artists_ArtistId",
                table: "Tracks",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Playlists_PlaylistId",
                table: "Tracks",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Queues_QueueId",
                table: "Tracks",
                column: "QueueId",
                principalTable: "Queues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Users_UserId",
                table: "Tracks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
