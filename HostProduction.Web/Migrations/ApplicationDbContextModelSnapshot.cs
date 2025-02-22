﻿// <auto-generated />
using System;
using HostProduction.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HostProduction.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HostProduction.Data.EquipmentPlacementContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipmentQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ProcessEquipmentTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductionFacilityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EquipmentPlacementContracts");
                });

            modelBuilder.Entity("HostProduction.Data.ProcessEquipmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("ProcessEquipmentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 15.0m,
                            Code = "EQP001",
                            Name = "Conveyor Belt"
                        },
                        new
                        {
                            Id = 2,
                            Area = 10.0m,
                            Code = "EQP002",
                            Name = "Mixer"
                        },
                        new
                        {
                            Id = 3,
                            Area = 30.0m,
                            Code = "EQP003",
                            Name = "Furnace"
                        },
                        new
                        {
                            Id = 4,
                            Area = 25.0m,
                            Code = "EQP004",
                            Name = "Press Machine"
                        },
                        new
                        {
                            Id = 5,
                            Area = 12.0m,
                            Code = "EQP005",
                            Name = "Cutter"
                        },
                        new
                        {
                            Id = 6,
                            Area = 18.0m,
                            Code = "EQP006",
                            Name = "Packaging Machine"
                        },
                        new
                        {
                            Id = 7,
                            Area = 16.5m,
                            Code = "EQP007",
                            Name = "Drilling Machine"
                        },
                        new
                        {
                            Id = 8,
                            Area = 22.0m,
                            Code = "EQP008",
                            Name = "Welding Robot"
                        },
                        new
                        {
                            Id = 9,
                            Area = 27.0m,
                            Code = "EQP009",
                            Name = "Injection Molding Machine"
                        },
                        new
                        {
                            Id = 10,
                            Area = 23.0m,
                            Code = "EQP010",
                            Name = "Heat Exchanger"
                        });
                });

            modelBuilder.Entity("HostProduction.Data.ProductionFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StandardArea")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("ProductionFacilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "FAC001",
                            Name = "Factory A",
                            StandardArea = 1000.0m
                        },
                        new
                        {
                            Id = 2,
                            Code = "FAC002",
                            Name = "Factory B",
                            StandardArea = 1500.0m
                        },
                        new
                        {
                            Id = 3,
                            Code = "FAC003",
                            Name = "Factory C",
                            StandardArea = 1200.0m
                        },
                        new
                        {
                            Id = 4,
                            Code = "FAC004",
                            Name = "Factory D",
                            StandardArea = 2000.0m
                        },
                        new
                        {
                            Id = 5,
                            Code = "FAC005",
                            Name = "Factory E",
                            StandardArea = 1800.0m
                        },
                        new
                        {
                            Id = 6,
                            Code = "FAC006",
                            Name = "Factory F",
                            StandardArea = 2500.0m
                        },
                        new
                        {
                            Id = 7,
                            Code = "FAC007",
                            Name = "Factory G",
                            StandardArea = 3000.0m
                        },
                        new
                        {
                            Id = 8,
                            Code = "FAC008",
                            Name = "Factory H",
                            StandardArea = 3200.0m
                        },
                        new
                        {
                            Id = 9,
                            Code = "FAC009",
                            Name = "Factory I",
                            StandardArea = 2800.0m
                        },
                        new
                        {
                            Id = 10,
                            Code = "FAC010",
                            Name = "Factory J",
                            StandardArea = 3500.0m
                        });
                });

            modelBuilder.Entity("HostProduction.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasData(
                        new
                        {
                            Id = "654bced5-375b-5291-0a59-1dc59923d1b0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "56a686f5-3d00-4d4d-83d7-9b1689c1c85b",
                            Email = "admin@localhost.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@LOCALHOST.COM",
                            NormalizedUserName = "ADMIN@LOCALHOST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJLRuaiFvQGD5WOBmRlIRDtC7pK5Yc1L3dY3Z1Q34ecPFMkCT06QedvzYprMfdo28g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0385fa8c-8313-4410-927b-e0cf36cfc5b9",
                            TwoFactorEnabled = false,
                            UserName = "admin@localhost.com"
                        });
                });

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
                    b.HasOne("HostProduction.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HostProduction.Data.User", null)
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

                    b.HasOne("HostProduction.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HostProduction.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
