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
    [Migration("20230509184318_exter")]
    partial class exter
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
                            Id = new Guid("1fc7f1da-7968-406a-9108-c8d0af034bdc"),
                            Age = 1,
                            CreationTimeUtc = new DateTime(2023, 5, 9, 18, 43, 17, 422, DateTimeKind.Utc).AddTicks(4655),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Djawed"
                        },
                        new
                        {
                            Id = new Guid("cd9023e2-488e-4958-bd08-c090d4233339"),
                            Age = 32,
                            CreationTimeUtc = new DateTime(2023, 5, 9, 18, 43, 17, 422, DateTimeKind.Utc).AddTicks(4683),
                            IsDeleted = false,
                            Nom = "Djehinet",
                            Prenom = "Nadjib"
                        },
                        new
                        {
                            Id = new Guid("46e51fbf-8b66-45f7-ab5d-5042934085d4"),
                            Age = 30,
                            CreationTimeUtc = new DateTime(2023, 5, 9, 18, 43, 17, 422, DateTimeKind.Utc).AddTicks(4689),
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