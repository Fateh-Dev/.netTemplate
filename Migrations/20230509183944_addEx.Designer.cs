﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Template.Data;

#nullable disable

namespace Template.Migrations
{
    [DbContext(typeof(TemplateContext))]
    [Migration("20230509183944_addEx")]
    partial class addEx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Template.Models.Personne", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personnes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4eb7c6c5-18af-4984-bfc4-2c25e4741a47"),
                            Age = 1,
                            CreationTimeUtc = new DateTime(2023, 5, 9, 18, 39, 43, 794, DateTimeKind.Utc).AddTicks(4018),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Djawed"
                        },
                        new
                        {
                            Id = new Guid("328a284b-7857-436c-a743-7f1fa0b3a9e7"),
                            Age = 32,
                            CreationTimeUtc = new DateTime(2023, 5, 9, 18, 39, 43, 794, DateTimeKind.Utc).AddTicks(4030),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Nadjib"
                        },
                        new
                        {
                            Id = new Guid("327f16f8-3b31-4e7b-819f-7b0e4673a877"),
                            Age = 30,
                            CreationTimeUtc = new DateTime(2023, 5, 9, 18, 39, 43, 794, DateTimeKind.Utc).AddTicks(4035),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Fateh"
                        });
                });

            modelBuilder.Entity("Template.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "djawed",
                            LastName = "djehinet",
                            PasswordHash = "$2a$11$EYjFiD/mUA9eCtNuS6O.du.ezBbIIaq1WQqUydaA8tmX/cC5bDVFK",
                            Username = "djawed"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}