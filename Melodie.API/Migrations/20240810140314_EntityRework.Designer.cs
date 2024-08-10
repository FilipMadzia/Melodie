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
    [Migration("20240810140314_EntityRework")]
    partial class EntityRework
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

                    b.HasKey("Id");

                    b.HasIndex("ArtistEntityId");

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

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedAlbumEntity", b =>
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

                    b.Property<Guid>("LikedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LikedId");

                    b.HasIndex("UserId");

                    b.ToTable("LikedAlbums");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedArtistEntity", b =>
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

                    b.Property<Guid>("LikedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LikedId");

                    b.HasIndex("UserId");

                    b.ToTable("LikedArtists");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedSingleEntity", b =>
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

                    b.Property<Guid>("LikedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LikedId");

                    b.HasIndex("UserId");

                    b.ToTable("LikedSingles");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedTrackEntity", b =>
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

                    b.Property<Guid>("LikedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LikedId");

                    b.HasIndex("UserId");

                    b.ToTable("LikedTracks");
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

                    b.HasKey("Id");

                    b.HasIndex("ArtistEntityId");

                    b.HasIndex("TrackEntityId");

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

                    b.HasKey("Id");

                    b.HasIndex("AlbumEntityId");

                    b.HasIndex("ArtistEntityId");

                    b.HasIndex("PlaylistEntityId");

                    b.HasIndex("QueueEntityId");

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
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.AlbumEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.ArtistEntity", null)
                        .WithMany("Albums")
                        .HasForeignKey("ArtistEntityId");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedAlbumEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.AlbumEntity", "Liked")
                        .WithMany()
                        .HasForeignKey("LikedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", "User")
                        .WithMany("LikedAlbums")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liked");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedArtistEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.ArtistEntity", "Liked")
                        .WithMany()
                        .HasForeignKey("LikedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", "User")
                        .WithMany("LikedArtists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liked");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedSingleEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.SingleEntity", "Liked")
                        .WithMany()
                        .HasForeignKey("LikedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", "User")
                        .WithMany("LikedSingles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liked");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodie.API.Data.Entities.LikedEntities.LikedTrackEntity", b =>
                {
                    b.HasOne("Melodie.API.Data.Entities.TrackEntity", "Liked")
                        .WithMany()
                        .HasForeignKey("LikedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodie.API.Data.Entities.UserEntity", "User")
                        .WithMany("LikedTracks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liked");

                    b.Navigation("User");
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