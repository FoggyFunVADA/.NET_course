﻿// <auto-generated />
using System;
using CarService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarService.Entities.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221125190357_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarService.Entities.Models.CarService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdOwnerOfCarService")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkSchedule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdOwnerOfCarService");

                    b.ToTable("CarServices", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.MeanOfPayment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOfMeanOfPayment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MeansOfPayment", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.OwnerOfCarService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OwnersOfCarServices", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.ReviewForCarService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCarService")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCarService");

                    b.HasIndex("IdUser");

                    b.ToTable("ReviewsForCarService", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOfService")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.ServiceOfCarService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCarService")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdService")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCarService");

                    b.HasIndex("IdService");

                    b.ToTable("ServicesOfCarService", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdMeanOfPayment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdMeanOfPayment");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("CarService.Entities.Models.CarService", b =>
                {
                    b.HasOne("CarService.Entities.Models.OwnerOfCarService", "OwnerOfCarService")
                        .WithMany("CarServices")
                        .HasForeignKey("IdOwnerOfCarService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OwnerOfCarService");
                });

            modelBuilder.Entity("CarService.Entities.Models.ReviewForCarService", b =>
                {
                    b.HasOne("CarService.Entities.Models.CarService", "CarService")
                        .WithMany("ReviewsForCarService")
                        .HasForeignKey("IdCarService")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("CarService.Entities.Models.User", "User")
                        .WithMany("ReviewsForCarService")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CarService");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CarService.Entities.Models.ServiceOfCarService", b =>
                {
                    b.HasOne("CarService.Entities.Models.CarService", "CarService")
                        .WithMany("ServicesOfCarService")
                        .HasForeignKey("IdCarService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarService.Entities.Models.Service", "Service")
                        .WithMany("ServicesOfCarService")
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CarService");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("CarService.Entities.Models.User", b =>
                {
                    b.HasOne("CarService.Entities.Models.MeanOfPayment", "MeanOfPayment")
                        .WithMany("Users")
                        .HasForeignKey("IdMeanOfPayment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MeanOfPayment");
                });

            modelBuilder.Entity("CarService.Entities.Models.CarService", b =>
                {
                    b.Navigation("ReviewsForCarService");

                    b.Navigation("ServicesOfCarService");
                });

            modelBuilder.Entity("CarService.Entities.Models.MeanOfPayment", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("CarService.Entities.Models.OwnerOfCarService", b =>
                {
                    b.Navigation("CarServices");
                });

            modelBuilder.Entity("CarService.Entities.Models.Service", b =>
                {
                    b.Navigation("ServicesOfCarService");
                });

            modelBuilder.Entity("CarService.Entities.Models.User", b =>
                {
                    b.Navigation("ReviewsForCarService");
                });
#pragma warning restore 612, 618
        }
    }
}