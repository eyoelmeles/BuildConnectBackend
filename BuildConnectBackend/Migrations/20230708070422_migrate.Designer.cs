﻿// <auto-generated />
using System;
using BuildConnectBackend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuildConnectBackend.Migrations
{
    [DbContext(typeof(BuildConnectContext))]
    [Migration("20230708070422_migrate")]
    partial class migrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BuildConnectBackend.Model.DailyReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SiteId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("DailyReports");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.MaterialReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DailyReportId")
                        .HasColumnType("uuid");

                    b.Property<string>("Delivered")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TypeOfMaterial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DailyReportId");

                    b.ToTable("MaterialReports");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.Site", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.Weather", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DailyReportId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WeatherCondition")
                        .HasMaxLength(50)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DailyReportId");

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.WorkHour", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DailyReportId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("WorkHr")
                        .HasMaxLength(50)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DailyReportId");

                    b.ToTable("WorkHrs");
                });

            modelBuilder.Entity("RecipesApi.Model.WorkProgress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DailyReportId")
                        .HasColumnType("uuid");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Remark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeOfWork")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DailyReportId");

                    b.ToTable("WorkProgresses");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.DailyReport", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildConnectBackend.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.MaterialReport", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "DailyReport")
                        .WithMany()
                        .HasForeignKey("DailyReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyReport");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.Weather", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "DailyReport")
                        .WithMany()
                        .HasForeignKey("DailyReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyReport");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.WorkHour", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "DailyReport")
                        .WithMany()
                        .HasForeignKey("DailyReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyReport");
                });

            modelBuilder.Entity("RecipesApi.Model.WorkProgress", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "DailyReport")
                        .WithMany()
                        .HasForeignKey("DailyReportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DailyReport");
                });
#pragma warning restore 612, 618
        }
    }
}
