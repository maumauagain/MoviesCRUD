﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20201005100942_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.GenreEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<bool>("Removed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = new Guid("645269ed-2287-4fd1-90de-5649d340cb8f"),
                            CreateAt = new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(398),
                            Name = "Terror",
                            Removed = false
                        },
                        new
                        {
                            Id = new Guid("9ab171af-3604-4375-b87c-14fdb8706a53"),
                            CreateAt = new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(745),
                            Name = "Comédia",
                            Removed = false
                        },
                        new
                        {
                            Id = new Guid("e502ddce-bb51-445b-980d-650a3d37b4a0"),
                            CreateAt = new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(755),
                            Name = "Romance",
                            Removed = false
                        },
                        new
                        {
                            Id = new Guid("5fad4f3f-3ba6-4f84-a642-1c4c5d5269e4"),
                            CreateAt = new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(757),
                            Name = "Aventura",
                            Removed = false
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.MovieEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<Guid>("GenreId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("Removed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Synopsis")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Api.Domain.Entities.MovieEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.GenreEntity", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
