﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace VuVanQuyet789.Migrations
{
    [DbContext(typeof(VuVanQuyet789Context))]
    partial class VuVanQuyet789ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
#pragma warning restore 612, 618
        }
    }
}