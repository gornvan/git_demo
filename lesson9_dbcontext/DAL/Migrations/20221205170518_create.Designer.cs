﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(TireServiceDBContext))]
    [Migration("20221205170518_create")]
    partial class create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Car", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DAL.Entities.Tire", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ExpluatationStartDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("OnCarId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OnCarId");

                    b.ToTable("Tires");
                });

            modelBuilder.Entity("DAL.Entities.Tire", b =>
                {
                    b.HasOne("DAL.Entities.Car", "OnCar")
                        .WithMany("Tires")
                        .HasForeignKey("OnCarId");

                    b.Navigation("OnCar");
                });

            modelBuilder.Entity("DAL.Entities.Car", b =>
                {
                    b.Navigation("Tires");
                });
#pragma warning restore 612, 618
        }
    }
}
