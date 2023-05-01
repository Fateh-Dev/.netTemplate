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
    [Migration("20230512192305_addNoteIdPersonne")]
    partial class addNoteIdPersonne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Template.Models.ExternalEntity", b =>
                {
                    b.Property<string>("ServerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Port")
                        .HasColumnType("int");

                    b.Property<string>("ServerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServerName");

                    b.ToTable("ExternalEntities");
                });

            modelBuilder.Entity("template.Models.Notation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Coefficient")
                        .HasColumnType("float");

                    b.Property<string>("Descipline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DesciplineCode")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdPersonne")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRevision")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTest")
                        .HasColumnType("bit");

                    b.Property<double>("Note")
                        .HasColumnType("float");

                    b.Property<int>("PhaseFormationCode")
                        .HasColumnType("int");

                    b.Property<string>("PhaseFormationDisplay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notations");
                });

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
                            Id = new Guid("69428ad2-56c3-48e2-ab32-8f2282145038"),
                            Age = 1,
                            CreationTimeUtc = new DateTime(2023, 5, 12, 19, 23, 5, 97, DateTimeKind.Utc).AddTicks(5965),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Djawed"
                        },
                        new
                        {
                            Id = new Guid("df418748-01fa-4849-93e8-20d213dee1df"),
                            Age = 32,
                            CreationTimeUtc = new DateTime(2023, 5, 12, 19, 23, 5, 97, DateTimeKind.Utc).AddTicks(5974),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Nadjib"
                        },
                        new
                        {
                            Id = new Guid("4ba26e97-8dae-4d31-9995-4418b5f4952c"),
                            Age = 30,
                            CreationTimeUtc = new DateTime(2023, 5, 12, 19, 23, 5, 97, DateTimeKind.Utc).AddTicks(5979),
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
