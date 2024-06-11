﻿using System;
using FederataFutbollit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace FederataFutbollit.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240609183206_NdeshjaSuperliges")]
    partial class NdeshjaSuperliges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FederataFutbollit.Data.ApplicationUser", b =>
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

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

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

                b.Property<string>("RefreshToken")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("RefreshTokenExpiryTime")
                    .HasColumnType("datetime2");

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

            modelBuilder.Entity("FederataFutbollit.Entities.AboutSection", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Content")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("AboutSections");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Bileta", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ApplicationUserID")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.Property<int>("Cmimi")
                    .HasColumnType("int");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NdeshjaID")
                    .HasColumnType("int");

                b.Property<DateTime>("OraBlerjes")
                    .HasColumnType("datetime2");

                b.Property<int?>("SektoriUlseveID")
                    .HasColumnType("int");

                b.Property<int>("UlesjaID")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ApplicationUserID");

                b.HasIndex("NdeshjaID");

                b.HasIndex("SektoriUlseveID");

                b.HasIndex("UlesjaID")
                    .IsUnique();

                b.ToTable("Biletat");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Cart", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("ApplicationUserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("ApplicationUserId");

                b.ToTable("Carts");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.CartSeat", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("CartId")
                    .HasColumnType("int");

                b.Property<double>("Cmimi")
                    .HasColumnType("float");

                b.Property<int>("NdeshjaId")
                    .HasColumnType("int");

                b.Property<int?>("OrderId")
                    .HasColumnType("int");

                b.Property<int>("Quantity")
                    .HasColumnType("int");

                b.Property<int>("SektoriUlseveId")
                    .HasColumnType("int");

                b.Property<int>("UlesjaId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("CartId");

                b.HasIndex("NdeshjaId");

                b.HasIndex("OrderId");

                b.HasIndex("SektoriUlseveId");

                b.HasIndex("UlesjaId")
                    .IsUnique();

                b.ToTable("CartSeats");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Contact", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Message")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Contacts");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ekipa", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("EmriKlubit")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NrTitujve")
                    .HasColumnType("int");

                b.Property<int>("SuperligaId")
                    .HasColumnType("int");

                b.Property<string>("Trajneri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("VitiThemelimit")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("SuperligaId");

                b.ToTable("Ekipa");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kombetarja", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("ShtetiID")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ShtetiID")
                    .IsUnique();

                b.ToTable("Kombetarja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kompeticionet", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Kompeticionet");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kontabiliteti", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("Data")
                    .HasColumnType("datetime2");

                b.Property<int>("ShpenzimetId")
                    .HasColumnType("int");

                b.Property<decimal>("ShumaTotale")
                    .HasColumnType("decimal(18,2)");

                b.Property<int>("StafiId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("ShpenzimetId");

                b.HasIndex("StafiId");

                b.ToTable("Kontabiliteti");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Lojtaret", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Asiste")
                    .HasColumnType("int");

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FotoPath")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Gola")
                    .HasColumnType("int");

                b.Property<int>("KombetarjaID")
                    .HasColumnType("int");

                b.Property<string>("Mbiemri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Mosha")
                    .HasColumnType("int");

                b.Property<int>("NrFaneles")
                    .HasColumnType("int");

                b.Property<string>("Pozicioni")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("KombetarjaID");

                b.ToTable("Lojtaret");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.LojtaretSuperlige", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Asiste")
                    .HasColumnType("int");

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FotoPath")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Gola")
                    .HasColumnType("int");

                b.Property<string>("Mbiemri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Mosha")
                    .HasColumnType("int");

                b.Property<int>("NrFaneles")
                    .HasColumnType("int");

                b.Property<string>("Pozicioni")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("SuperligaID")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("SuperligaID");

                b.ToTable("LojtaretSuperlige");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ndeshja", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("Data")
                    .HasColumnType("datetime2");

                b.Property<string>("EkipiKundershtar")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("GolaEkipiJone")
                    .HasColumnType("int");

                b.Property<int?>("GolaEkipiKundershtar")
                    .HasColumnType("int");

                b.Property<int>("KombetarjaId")
                    .HasColumnType("int");

                b.Property<int>("KompeticioniId")
                    .HasColumnType("int");

                b.Property<int>("StadiumiId")
                    .HasColumnType("int");

                b.Property<int>("StatusiId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("KombetarjaId");

                b.HasIndex("KompeticioniId");

                b.HasIndex("StadiumiId");

                b.HasIndex("StatusiId");

                b.ToTable("Ndeshja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.NdeshjaSuperliges", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("DataENdeshjes")
                    .HasColumnType("datetime2");

                b.Property<string>("Ekipa1")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Ekipa2")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("EkipaId")
                    .HasColumnType("int");

                b.Property<int>("StatusiId")
                    .HasColumnType("int");

                b.Property<int>("SuperligaId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("EkipaId");

                b.HasIndex("StatusiId");

                b.HasIndex("SuperligaId");

                b.ToTable("NdeshjetESuperliges");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Order", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("City")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Cmimi")
                    .HasColumnType("float");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NdeshjaId")
                    .HasColumnType("int");

                b.Property<DateTime>("OrderDate")
                    .HasColumnType("datetime2");

                b.Property<int>("Quantity")
                    .HasColumnType("int");

                b.Property<int>("SektoriUlseveId")
                    .HasColumnType("int");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UlesjaId")
                    .HasColumnType("int");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("nvarchar(450)");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("Orders");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Roli", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Roli");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.SektoriUlseve", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("SektoriUlseve");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Selektori", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("KombetarjaID")
                    .HasColumnType("int");

                b.Property<string>("Mbiemri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Mosha")
                    .HasColumnType("int");

                b.Property<string>("Nacionaliteti")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("VitetEKontrates")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("KombetarjaID")
                    .IsUnique();

                b.ToTable("Selektort");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Shpenzimet", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Pershkrimi")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Shuma")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("Id");

                b.ToTable("Shpenzimet");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Shteti", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Shteti");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Stadiumi", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Kapaciteti")
                    .HasColumnType("int");

                b.Property<int>("KombetarjaID")
                    .HasColumnType("int");

                b.Property<int>("VitiNdertuar")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("KombetarjaID");

                b.ToTable("Stadiumi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Stafi", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("KombetarjaID")
                    .HasColumnType("int");

                b.Property<string>("Mbiemri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Paga")
                    .HasColumnType("int");

                b.Property<int>("RoliID")
                    .HasColumnType("int");

                b.Property<int>("Telefoni")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("KombetarjaID");

                b.HasIndex("RoliID");

                b.ToTable("Stafi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Statusi", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Statusi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Superliga", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Emri")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("NumriSkuadrave")
                    .HasColumnType("int");

                b.Property<string>("Sponzori")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Superligat");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ulesja", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<double>("Cmimi")
                    .HasColumnType("float");

                b.Property<bool>("IsAvailable")
                    .HasColumnType("bit");

                b.Property<int>("Numri")
                    .HasColumnType("int");

                b.Property<int>("SektoriUlseveID")
                    .HasColumnType("int");

                b.Property<int>("StadiumiId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("SektoriUlseveID");

                b.HasIndex("StadiumiId");

                b.ToTable("Uleset");
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
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("ProviderKey")
                    .HasColumnType("nvarchar(450)");

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
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(450)");

                b.Property<string>("Value")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens", (string)null);
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Bileta", b =>
            {
                b.HasOne("FederataFutbollit.Data.ApplicationUser", "ApplicationUser")
                    .WithMany("Biletat")
                    .HasForeignKey("ApplicationUserID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Ndeshja", "Ndeshja")
                    .WithMany("Bileta")
                    .HasForeignKey("NdeshjaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.SektoriUlseve", "SektoriUlseve")
                    .WithMany("Bileta")
                    .HasForeignKey("SektoriUlseveID");

                b.HasOne("FederataFutbollit.Entities.Ulesja", "Ulesja")
                    .WithOne("Bileta")
                    .HasForeignKey("FederataFutbollit.Entities.Bileta", "UlesjaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("ApplicationUser");

                b.Navigation("Ndeshja");

                b.Navigation("SektoriUlseve");

                b.Navigation("Ulesja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Cart", b =>
            {
                b.HasOne("FederataFutbollit.Data.ApplicationUser", "ApplicationUser")
                    .WithMany()
                    .HasForeignKey("ApplicationUserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("ApplicationUser");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.CartSeat", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Cart", "Cart")
                    .WithMany("CartSeats")
                    .HasForeignKey("CartId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Ndeshja", "Ndeshja")
                    .WithMany("CartSeats")
                    .HasForeignKey("NdeshjaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Order", "Order")
                    .WithMany("Seats")
                    .HasForeignKey("OrderId");

                b.HasOne("FederataFutbollit.Entities.SektoriUlseve", "SektoriUlseve")
                    .WithMany()
                    .HasForeignKey("SektoriUlseveId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Ulesja", "Ulesja")
                    .WithOne("CartSeat")
                    .HasForeignKey("FederataFutbollit.Entities.CartSeat", "UlesjaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Cart");

                b.Navigation("Ndeshja");

                b.Navigation("Order");

                b.Navigation("SektoriUlseve");

                b.Navigation("Ulesja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ekipa", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Superliga", "Superliga")
                    .WithMany("Ekipa")
                    .HasForeignKey("SuperligaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Superliga");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kombetarja", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Shteti", "Shteti")
                    .WithOne("Kombetarja")
                    .HasForeignKey("FederataFutbollit.Entities.Kombetarja", "ShtetiID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Shteti");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kontabiliteti", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Shpenzimet", "Shpenzimet")
                    .WithMany()
                    .HasForeignKey("ShpenzimetId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Stafi", "Stafi")
                    .WithMany()
                    .HasForeignKey("StafiId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Shpenzimet");

                b.Navigation("Stafi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Lojtaret", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Kombetarja", "Kombetarja")
                    .WithMany("Lojtaret")
                    .HasForeignKey("KombetarjaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Kombetarja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.LojtaretSuperlige", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Superliga", "Superliga")
                    .WithMany()
                    .HasForeignKey("SuperligaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Superliga");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ndeshja", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Kombetarja", "Kombetarja")
                    .WithMany("Ndeshjet")
                    .HasForeignKey("KombetarjaId")
                    .OnDelete(DeleteBehavior.NoAction)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Kompeticionet", "Kompeticioni")
                    .WithMany("Ndeshja")
                    .HasForeignKey("KompeticioniId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Stadiumi", "Stadiumi")
                    .WithMany("Ndeshjet")
                    .HasForeignKey("StadiumiId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Statusi", "Statusi")
                    .WithMany("Ndeshjet")
                    .HasForeignKey("StatusiId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Kombetarja");

                b.Navigation("Kompeticioni");

                b.Navigation("Stadiumi");

                b.Navigation("Statusi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.NdeshjaSuperliges", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Ekipa", "Ekipa")
                    .WithMany("NdeshjetESuperliges")
                    .HasForeignKey("EkipaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Statusi", "Statusi")
                    .WithMany("NdeshjetESuperliges")
                    .HasForeignKey("StatusiId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Superliga", "Superliga")
                    .WithMany("NdeshjetESuperliges")
                    .HasForeignKey("SuperligaId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Ekipa");

                b.Navigation("Statusi");

                b.Navigation("Superliga");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Order", b =>
            {
                b.HasOne("FederataFutbollit.Data.ApplicationUser", "User")
                    .WithMany("Orders")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Selektori", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Kombetarja", "Kombetarja")
                    .WithOne("Selektori")
                    .HasForeignKey("FederataFutbollit.Entities.Selektori", "KombetarjaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Kombetarja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Stadiumi", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Kombetarja", "Kombetarja")
                    .WithMany("Stadiumet")
                    .HasForeignKey("KombetarjaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Kombetarja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Stafi", b =>
            {
                b.HasOne("FederataFutbollit.Entities.Kombetarja", "Kombetarja")
                    .WithMany("Stafi")
                    .HasForeignKey("KombetarjaID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Roli", "Roli")
                    .WithMany("Stafi")
                    .HasForeignKey("RoliID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Kombetarja");

                b.Navigation("Roli");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ulesja", b =>
            {
                b.HasOne("FederataFutbollit.Entities.SektoriUlseve", "SektoriUlseve")
                    .WithMany("Uleset")
                    .HasForeignKey("SektoriUlseveID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("FederataFutbollit.Entities.Stadiumi", "Stadiumi")
                    .WithMany("Uleset")
                    .HasForeignKey("StadiumiId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("SektoriUlseve");

                b.Navigation("Stadiumi");
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
                b.HasOne("FederataFutbollit.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.HasOne("FederataFutbollit.Data.ApplicationUser", null)
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

                b.HasOne("FederataFutbollit.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.HasOne("FederataFutbollit.Data.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("FederataFutbollit.Data.ApplicationUser", b =>
            {
                b.Navigation("Biletat");

                b.Navigation("Orders");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Cart", b =>
            {
                b.Navigation("CartSeats");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ekipa", b =>
            {
                b.Navigation("NdeshjetESuperliges");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kombetarja", b =>
            {
                b.Navigation("Lojtaret");

                b.Navigation("Ndeshjet");

                b.Navigation("Selektori")
                    .IsRequired();

                b.Navigation("Stadiumet");

                b.Navigation("Stafi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Kompeticionet", b =>
            {
                b.Navigation("Ndeshja");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ndeshja", b =>
            {
                b.Navigation("Bileta");

                b.Navigation("CartSeats");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Order", b =>
            {
                b.Navigation("Seats");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Roli", b =>
            {
                b.Navigation("Stafi");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.SektoriUlseve", b =>
            {
                b.Navigation("Bileta");

                b.Navigation("Uleset");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Shteti", b =>
            {
                b.Navigation("Kombetarja")
                    .IsRequired();
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Stadiumi", b =>
            {
                b.Navigation("Ndeshjet");

                b.Navigation("Uleset");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Statusi", b =>
            {
                b.Navigation("Ndeshjet");

                b.Navigation("NdeshjetESuperliges");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Superliga", b =>
            {
                b.Navigation("Ekipa");

                b.Navigation("NdeshjetESuperliges");
            });

            modelBuilder.Entity("FederataFutbollit.Entities.Ulesja", b =>
            {
                b.Navigation("Bileta")
                    .IsRequired();

                b.Navigation("CartSeat")
                    .IsRequired();
            });
        }
    }
}