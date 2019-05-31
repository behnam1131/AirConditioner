﻿// <auto-generated />
using System;
using AirConditioner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AirConditioner.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AirConditioner.Core.Models.AirConditionerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AirConditionerModels");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.EngineVolume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("EngineVolume");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.EnumMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<int>("EnumTypeId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("EnumTypeId");

                    b.ToTable("EnumMembers");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.EnumType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Code");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("EnumTypes");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.Factor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AirConditionerModelId");

                    b.Property<DateTime>("ChangeDateTime");

                    b.Property<int>("Code");

                    b.Property<string>("Comment");

                    b.Property<int>("CustomerId");

                    b.Property<string>("DateFa");

                    b.Property<int>("EngineVolumeId");

                    b.Property<string>("Time");

                    b.Property<int>("UserAssistantId");

                    b.Property<int>("UserExpertId");

                    b.Property<int>("UserOperatorId");

                    b.Property<int>("UserTechnicianId");

                    b.HasKey("Id");

                    b.HasIndex("AirConditionerModelId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EngineVolumeId");

                    b.HasIndex("UserAssistantId");

                    b.HasIndex("UserExpertId");

                    b.HasIndex("UserOperatorId");

                    b.HasIndex("UserTechnicianId");

                    b.ToTable("Factors");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.FactorPiece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("FactorId");

                    b.Property<bool>("IsChange");

                    b.Property<int>("PieceId");

                    b.Property<double>("PriceOne");

                    b.Property<double>("PriceTotal");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FactorId");

                    b.HasIndex("PieceId");

                    b.ToTable("FactorPieces");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.FactorWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("FactorId");

                    b.Property<double>("Price");

                    b.Property<int>("WorkId");

                    b.HasKey("Id");

                    b.HasIndex("FactorId");

                    b.HasIndex("WorkId");

                    b.ToTable("FactorWorks");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.Piece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Percent");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Pieces");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.PiecePercent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ChangeDateTime");

                    b.Property<string>("DateFa");

                    b.Property<int>("Percent");

                    b.Property<int>("PieceId");

                    b.Property<string>("Time");

                    b.HasKey("Id");

                    b.HasIndex("PieceId");

                    b.ToTable("piecePercents");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.PiecePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ChangeDateTime");

                    b.Property<string>("DateFa");

                    b.Property<int>("PieceId");

                    b.Property<double>("Price");

                    b.Property<string>("Time");

                    b.HasKey("Id");

                    b.HasIndex("PieceId");

                    b.ToTable("PiecePrices");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.UserAssistant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("UserAssistants");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.UserExpert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("UserExperts");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.UserOperator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("UserOperators");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.UserTechnician", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("UserTechnicians");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Works");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AirConditioner.Core.Models.EnumMember", b =>
                {
                    b.HasOne("AirConditioner.Core.Models.EnumType", "EnumType")
                        .WithMany("EnumMembers")
                        .HasForeignKey("EnumTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AirConditioner.Core.Models.Factor", b =>
                {
                    b.HasOne("AirConditioner.Core.Models.AirConditionerModel", "AirConditionerModel")
                        .WithMany("Factors")
                        .HasForeignKey("AirConditionerModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.Customer", "Customer")
                        .WithMany("Factors")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.EngineVolume", "EngineVolume")
                        .WithMany("Factors")
                        .HasForeignKey("EngineVolumeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.UserAssistant", "UserAssistant")
                        .WithMany("Factors")
                        .HasForeignKey("UserAssistantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.UserExpert", "UserExpert")
                        .WithMany("Factors")
                        .HasForeignKey("UserExpertId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.UserOperator", "UserOperator")
                        .WithMany("Factors")
                        .HasForeignKey("UserOperatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.UserTechnician", "UserTechnician")
                        .WithMany("Factors")
                        .HasForeignKey("UserTechnicianId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AirConditioner.Core.Models.FactorPiece", b =>
                {
                    b.HasOne("AirConditioner.Core.Models.Factor", "Factor")
                        .WithMany("FactorPiecePrices")
                        .HasForeignKey("FactorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.Piece", "Piece")
                        .WithMany("FactorPieces")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AirConditioner.Core.Models.FactorWork", b =>
                {
                    b.HasOne("AirConditioner.Core.Models.Factor", "Factor")
                        .WithMany("FactorWorks")
                        .HasForeignKey("FactorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AirConditioner.Core.Models.Work", "Work")
                        .WithMany("FactorWorks")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AirConditioner.Core.Models.PiecePercent", b =>
                {
                    b.HasOne("AirConditioner.Core.Models.Piece", "Piece")
                        .WithMany("PiecePercents")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AirConditioner.Core.Models.PiecePrice", b =>
                {
                    b.HasOne("AirConditioner.Core.Models.Piece", "Piece")
                        .WithMany("PiecePrices")
                        .HasForeignKey("PieceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
