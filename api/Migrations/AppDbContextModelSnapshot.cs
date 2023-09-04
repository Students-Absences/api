﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("api.Models.AppSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ID");

                    b.Property<string>("SchoolLogoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("SCHOOLLOGOURL");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("SCHOOLNAME");

                    b.HasKey("Id");

                    b.ToTable("APPSETTINGS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SchoolLogoUrl = "https://5lykeiovyrona.gr/img/logo-mobile.png",
                            SchoolName = "5ο Λύκειο Βύρωνα"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}