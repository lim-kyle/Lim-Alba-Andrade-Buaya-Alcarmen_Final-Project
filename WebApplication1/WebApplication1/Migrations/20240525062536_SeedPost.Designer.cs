﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Services;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240525062536_SeedPost")]
    partial class SeedPost
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "47ef74a3-12a1-46be-92e2-101e65633f9f",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = "3e8d7ca6-ad20-47ee-953f-b1b68f27ff56",
                            Name = "client",
                            NormalizedName = "client"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorsePower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mileage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarBrand = "BMW",
                            CarName = "Territory",
                            CarType = "Automatic",
                            CarYear = "2000",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9621),
                            FuelType = "",
                            HorsePower = "700",
                            ImageFileName = "img/cars/car-1.jpg",
                            Mileage = "4000",
                            OwnerContact = "kyle@gmail.com",
                            OwnerLocation = "Cebu",
                            OwnerName = "Kyle",
                            Price = "40000",
                            SellType = "Rent"
                        },
                        new
                        {
                            Id = 2,
                            CarBrand = "BMW",
                            CarName = "Territory",
                            CarType = "Automatic",
                            CarYear = "2000",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9639),
                            FuelType = "",
                            HorsePower = "700",
                            ImageFileName = "img/cars/car-2.jpg",
                            Mileage = "4000",
                            OwnerContact = "alba@gmail.com",
                            OwnerLocation = "Cebu",
                            OwnerName = "Alba",
                            Price = "40000",
                            SellType = "Rent"
                        },
                        new
                        {
                            Id = 3,
                            CarBrand = "Honda",
                            CarName = "Civic",
                            CarType = "Manual",
                            CarYear = "2018",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9642),
                            FuelType = "",
                            HorsePower = "158",
                            ImageFileName = "img/cars/car-3.jpg",
                            Mileage = "30000",
                            OwnerContact = "john@gmail.com",
                            OwnerLocation = "Manila",
                            OwnerName = "John",
                            Price = "20000",
                            SellType = "Sale"
                        },
                        new
                        {
                            Id = 4,
                            CarBrand = "Toyota",
                            CarName = "Camry",
                            CarType = "Automatic",
                            CarYear = "2017",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9644),
                            FuelType = "",
                            HorsePower = "203",
                            ImageFileName = "img/cars/car-4.jpg",
                            Mileage = "35000",
                            OwnerContact = "jane@gmail.com",
                            OwnerLocation = "Davao",
                            OwnerName = "Jane",
                            Price = "22000",
                            SellType = "Sale"
                        },
                        new
                        {
                            Id = 5,
                            CarBrand = "Honda",
                            CarName = "Accord",
                            CarType = "Automatic",
                            CarYear = "2016",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9646),
                            FuelType = "",
                            HorsePower = "190",
                            ImageFileName = "img/cars/car-5.jpg",
                            Mileage = "40000",
                            OwnerContact = "michael@gmail.com",
                            OwnerLocation = "Quezon City",
                            OwnerName = "Michael",
                            Price = "18000",
                            SellType = "Sale"
                        },
                        new
                        {
                            Id = 6,
                            CarBrand = "Tesla",
                            CarName = "Model S",
                            CarType = "Automatic",
                            CarYear = "2020",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9647),
                            FuelType = "",
                            HorsePower = "670",
                            ImageFileName = "img/cars/car-6.jpg",
                            Mileage = "15000",
                            OwnerContact = "laura@gmail.com",
                            OwnerLocation = "Taguig",
                            OwnerName = "Laura",
                            Price = "80000",
                            SellType = "Sale"
                        },
                        new
                        {
                            Id = 7,
                            CarBrand = "Ford",
                            CarName = "Mustang",
                            CarType = "Manual",
                            CarYear = "2019",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9650),
                            FuelType = "",
                            HorsePower = "450",
                            ImageFileName = "img/cars/car-7.jpg",
                            Mileage = "20000",
                            OwnerContact = "peter@gmail.com",
                            OwnerLocation = "Makati",
                            OwnerName = "Peter",
                            Price = "35000",
                            SellType = "Sale"
                        },
                        new
                        {
                            Id = 8,
                            CarBrand = "Tesla",
                            CarName = "Model 3",
                            CarType = "Automatic",
                            CarYear = "2021",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9651),
                            FuelType = "",
                            HorsePower = "283",
                            ImageFileName = "img/cars/car-1.jpg",
                            Mileage = "10000",
                            OwnerContact = "emma@gmail.com",
                            OwnerLocation = "Pasig",
                            OwnerName = "Emma",
                            Price = "55000",
                            SellType = "Sale"
                        },
                        new
                        {
                            Id = 9,
                            CarBrand = "Ford",
                            CarName = "Ranger",
                            CarType = "Manual",
                            CarYear = "2018",
                            CreatedAt = new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9653),
                            FuelType = "",
                            HorsePower = "300",
                            ImageFileName = "img/cars/car-2.jpg",
                            Mileage = "25000",
                            OwnerContact = "lucas@gmail.com",
                            OwnerLocation = "Cebu",
                            OwnerName = "Lucas",
                            Price = "29000",
                            SellType = "Sale"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApplication1.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
