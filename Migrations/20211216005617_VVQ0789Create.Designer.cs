﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VuVanQuyet789.Migrations
{
    [DbContext(typeof(VuVanQuyet789Context))]
    [Migration("20211216005617_VVQ0789Create")]
    partial class VVQ0789Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("VuVanQuyet789.Models.CompanyVVQ789", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("CompanyVVQ789");
                });

            modelBuilder.Entity("VuVanQuyet789.Models.VVQ0789", b =>
                {
                    b.Property<string>("VVQId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("VVQGender")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<string>("VVQName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("VVQId");

                    b.ToTable("VVQ0789");
                });
#pragma warning restore 612, 618
        }
    }
}