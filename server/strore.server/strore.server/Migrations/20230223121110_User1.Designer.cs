﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using strore.server.DataBase;

#nullable disable

namespace strore.server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230223121110_User1")]
    partial class User1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("strore.server.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("StoreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "88113449-fe1f-4bb0-9375-6da5674af38b",
                            Category = "category1",
                            Description = "product1 description",
                            ImageUrl = "https://picsum.photos/200/300",
                            Price = 10m,
                            Quantity = 10,
                            StoreId = "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b",
                            Title = "product1"
                        },
                        new
                        {
                            Id = "6f86a6cf-7aad-4f3b-8e77-daa9f733d4a9",
                            Category = "category1",
                            Description = "product2 description",
                            ImageUrl = "https://picsum.photos/200/300",
                            Price = 20m,
                            Quantity = 20,
                            StoreId = "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b",
                            Title = "product2"
                        },
                        new
                        {
                            Id = "bc02c36f-94c0-4826-b5f0-b3a69cbcfce2",
                            Category = "category1",
                            Description = "product3 description",
                            ImageUrl = "https://picsum.photos/200/300",
                            Price = 30m,
                            Quantity = 30,
                            StoreId = "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b",
                            Title = "product3"
                        });
                });

            modelBuilder.Entity("strore.server.Models.Store", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = "f6b6b6b6-6b6b-6b6b-6b6b-6b6b6b6b6b6b",
                            AdminId = "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                            Name = "store1"
                        },
                        new
                        {
                            Id = "f7b7b7b7-7b7b-7b7b-7b7b-7b7b7b7b7b7b",
                            AdminId = "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                            Name = "store2"
                        },
                        new
                        {
                            Id = "f8b8b8b8-8b8b-8b8b-8b8b-8b8b8b8b8b8b",
                            AdminId = "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                            Name = "store3"
                        });
                });

            modelBuilder.Entity("strore.server.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "13800524-be49-49de-9ec8-95ea01fce40e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd075fb5-9f30-4c76-b5b9-8d3f9f9943ee",
                            Email = "user1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Role = "user",
                            StoreId = "store1",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "be3ad322-e425-46c5-a8e4-1465df611c4b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f66fd87-7106-4345-8588-f537823867c0",
                            Email = "user2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Role = "user",
                            StoreId = "store2",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = "f5b5b5b5-5b5b-5b5b-5b5b-5b5b5b5b5b5b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "549feea2-8499-4b20-ab89-4f2b9108713b",
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            Role = "admin",
                            StoreId = "store1",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
