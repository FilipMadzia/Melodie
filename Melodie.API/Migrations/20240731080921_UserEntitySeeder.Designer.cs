﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Melodie.API.Migrations
{
    [DbContext(typeof(MelodieAPIContext))]
    [Migration("20240731080921_UserEntitySeeder")]
    partial class UserEntitySeeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Melodie.API.Data.Entities.AlbumEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArtistEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.ArtistEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.MusicGenreEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TrackEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TrackEntityId");

                    b.ToTable("MusicGenres");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.PlaylistEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.QueueEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Queues");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.SingleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("TrackEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ArtistEntityId");

                    b.HasIndex("TrackEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Singles");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.TrackEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AlbumEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<Guid?>("PlaylistEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("QueueEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AlbumEntityId");

                    b.HasIndex("ArtistEntityId");

                    b.HasIndex("PlaylistEntityId");

                    b.HasIndex("QueueEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b9420f81-942c-4e2c-940d-6a8a38a3c4a4"),
                            CreatedAt = new DateTime(2024, 7, 31, 10, 9, 20, 362, DateTimeKind.Local).AddTicks(8744),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Email = "seed@seed",
                            EntityStatus = 0,
                            Password = "seed",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = new Guid("de42d5f2-b086-437e-8ec0-cf059ea002da"),
                            CreatedAt = new DateTime(2024, 7, 31, 10, 9, 20, 362, DateTimeKind.Local).AddTicks(8801),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            Email = "seed2@seed2",
                            EntityStatus = 0,
                            Password = "seed2",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UpdatedBy = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.AlbumEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.ArtistEntity", null)
                        .WithMany("Albums")
                        .HasForeignKey("ArtistEntityId");

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", null)
                        .WithMany("LikedAlbums")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.ArtistEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.UserEntity", null)
                        .WithMany("LikedArtists")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.MusicGenreEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.TrackEntity", null)
                        .WithMany("MusicGenres")
                        .HasForeignKey("TrackEntityId");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.PlaylistEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.UserEntity", null)
                        .WithMany("Playlists")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.QueueEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.UserEntity", "User")
                        .WithOne("Queue")
                        .HasForeignKey("Melodie.API.Data.Entities.QueueEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.SingleEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.ArtistEntity", null)
                        .WithMany("Singles")
                        .HasForeignKey("ArtistEntityId");

                    b.HasOne("Melodie.API.Data.Entities.TrackEntity", "TrackEntity")
                        .WithMany()
                        .HasForeignKey("TrackEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", null)
                        .WithMany("LikedSingles")
                        .HasForeignKey("UserEntityId");

                    b.Navigation("TrackEntity");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.TrackEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.AlbumEntity", null)
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumEntityId");

                    b.HasOne("Melodie.API.Data.Entities.ArtistEntity", null)
                        .WithMany("Tracks")
                        .HasForeignKey("ArtistEntityId");

                    b.HasOne("Melodie.API.Data.Entities.PlaylistEntity", null)
                        .WithMany("Tracks")
                        .HasForeignKey("PlaylistEntityId");

                    b.HasOne("Melodie.API.Data.Entities.QueueEntity", null)
                        .WithMany("Tracks")
                        .HasForeignKey("QueueEntityId");

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", null)
                        .WithMany("LikedTracks")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.AlbumEntity", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.ArtistEntity", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Singles");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.PlaylistEntity", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.QueueEntity", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.TrackEntity", b =>
                {
                    b.Navigation("MusicGenres");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.UserEntity", b =>
                {
                    b.Navigation("LikedAlbums");

                    b.Navigation("LikedArtists");

                    b.Navigation("LikedSingles");

                    b.Navigation("LikedTracks");

                    b.Navigation("Playlists");

                    b.Navigation("Queue");
                });
#pragma warning restore 612, 618
        }
    }
}
