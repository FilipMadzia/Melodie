using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Melodie.API.Migrations
{
    /// <inheritdoc />
    public partial class TrackManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Singles_Tracks_TrackEntityId",
                table: "Singles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Albums_AlbumEntityId",
                table: "Tracks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Queues_QueueEntityId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_AlbumEntityId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_QueueEntityId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Singles_TrackEntityId",
                table: "Singles");

            migrationBuilder.DropColumn(
                name: "AlbumEntityId",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "QueueEntityId",
                table: "Tracks");

            migrationBuilder.RenameColumn(
                name: "TrackEntityId",
                table: "Singles",
                newName: "SingleTrackEntity");

            migrationBuilder.CreateTable(
                name: "AlbumTrackEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForeignEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTrackEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlbumTrackEntities_Albums_ForeignEntityId",
                        column: x => x.ForeignEntityId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumTrackEntities_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QueueTrackEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForeignEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueueTrackEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueueTrackEntities_Queues_ForeignEntityId",
                        column: x => x.ForeignEntityId,
                        principalTable: "Queues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QueueTrackEntities_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SingleTrackEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntityStatus = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingleTrackEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SingleTrackEntities_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Singles_SingleTrackEntity",
                table: "Singles",
                column: "SingleTrackEntity",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTrackEntities_ForeignEntityId",
                table: "AlbumTrackEntities",
                column: "ForeignEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumTrackEntities_TrackId",
                table: "AlbumTrackEntities",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_QueueTrackEntities_ForeignEntityId",
                table: "QueueTrackEntities",
                column: "ForeignEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_QueueTrackEntities_TrackId",
                table: "QueueTrackEntities",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_SingleTrackEntities_TrackId",
                table: "SingleTrackEntities",
                column: "TrackId");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_SingleTrackEntities_SingleTrackEntity",
                table: "Singles",
                column: "SingleTrackEntity",
                principalTable: "SingleTrackEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Singles_SingleTrackEntities_SingleTrackEntity",
                table: "Singles");

            migrationBuilder.DropTable(
                name: "AlbumTrackEntities");

            migrationBuilder.DropTable(
                name: "QueueTrackEntities");

            migrationBuilder.DropTable(
                name: "SingleTrackEntities");

            migrationBuilder.DropIndex(
                name: "IX_Singles_SingleTrackEntity",
                table: "Singles");

            migrationBuilder.RenameColumn(
                name: "SingleTrackEntity",
                table: "Singles",
                newName: "TrackEntityId");

            migrationBuilder.AddColumn<Guid>(
                name: "AlbumEntityId",
                table: "Tracks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "QueueEntityId",
                table: "Tracks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumEntityId",
                table: "Tracks",
                column: "AlbumEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_QueueEntityId",
                table: "Tracks",
                column: "QueueEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Singles_TrackEntityId",
                table: "Singles",
                column: "TrackEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Singles_Tracks_TrackEntityId",
                table: "Singles",
                column: "TrackEntityId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Albums_AlbumEntityId",
                table: "Tracks",
                column: "AlbumEntityId",
                principalTable: "Albums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Queues_QueueEntityId",
                table: "Tracks",
                column: "QueueEntityId",
                principalTable: "Queues",
                principalColumn: "Id");
        }
    }
}
