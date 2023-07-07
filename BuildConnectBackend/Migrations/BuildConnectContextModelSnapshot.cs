﻿// <auto-generated />
using System;
using BuildConnectBackend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuildConnectBackend.Migrations
{
    [DbContext(typeof(BuildConnectContext))]
    partial class BuildConnectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BuildConnectBackend.Model.DailyReport", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("site_id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("site_id");

                    b.ToTable("DailyReports");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.MaterialReport", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("daily_report_id")
                        .HasColumnType("uuid");

                    b.Property<string>("delivered")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("remark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("to_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("type_of_material")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("daily_report_id");

                    b.ToTable("MaterialReports");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.Site", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("image_url")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("character varying(2048)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.Weather", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("daily_report_id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("weather")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("id");

                    b.HasIndex("daily_report_id");

                    b.ToTable("Weathers");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.WorkHour", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("daily_report_id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("work_hour")
                        .HasMaxLength(50)
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("daily_report_id");

                    b.ToTable("WorkHrs");
                });

            modelBuilder.Entity("RecipesApi.Model.WorkProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("daily_report_id")
                        .HasColumnType("uuid");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("quantity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("remark")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("type_of_material")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("unit")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("update_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("daily_report_id");

                    b.ToTable("WorkProgresses");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.DailyReport", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.Site", "site")
                        .WithMany()
                        .HasForeignKey("site_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("site");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.MaterialReport", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "daily_report")
                        .WithMany()
                        .HasForeignKey("daily_report_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daily_report");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.Weather", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "daily_report")
                        .WithMany()
                        .HasForeignKey("daily_report_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daily_report");
                });

            modelBuilder.Entity("BuildConnectBackend.Model.WorkHour", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "daily_report")
                        .WithMany()
                        .HasForeignKey("daily_report_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daily_report");
                });

            modelBuilder.Entity("RecipesApi.Model.WorkProgress", b =>
                {
                    b.HasOne("BuildConnectBackend.Model.DailyReport", "daily_report")
                        .WithMany()
                        .HasForeignKey("daily_report_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daily_report");
                });
#pragma warning restore 612, 618
        }
    }
}
