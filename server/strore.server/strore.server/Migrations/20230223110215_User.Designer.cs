// <auto-generated />
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
    [Migration("20230223110215_User")]
    partial class User
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
                            Id = "8628179e-1edf-4c77-b511-3f5fa7ccd884",
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
                            Id = "ee089d02-315a-40bd-91c7-5bcca5b25475",
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
                            Id = "38850218-0568-4c77-b3c3-b984925e9e49",
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
                        .IsRequired()
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

                    b.Property<string>("Password")
                        .IsRequired()
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
                            Id = "a96798f1-16d0-415d-b826-71ef0db46ea4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7dfead15-73ed-4a0c-ba66-190cd908a40c",
                            Email = "user1@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123456",
                            PhoneNumberConfirmed = false,
                            Role = "user",
                            StoreId = "store1",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "519531cc-3ef7-410f-864f-6ff3d70bcff5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fe33e4e2-a4a9-4486-aa15-0416dfe6ff1a",
                            Email = "user2@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123456",
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
                            ConcurrencyStamp = "ea882bbb-86e7-4e59-863a-45ce3c61a55e",
                            Email = "admin@email.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Password = "123456",
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
