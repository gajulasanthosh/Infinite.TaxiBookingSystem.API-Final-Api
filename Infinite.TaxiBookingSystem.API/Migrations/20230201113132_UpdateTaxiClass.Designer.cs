﻿// <auto-generated />
using System;
using Infinite.TaxiBookingSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infinite.TaxiBookingSystem.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230201113132_UpdateTaxiClass")]
    partial class UpdateTaxiClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("DestinationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SourceAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxiId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TripDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingId");

                    b.HasIndex("CustomerID");

                    b.HasIndex("TaxiId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesignationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designations");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("DrivingLicenseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DesignationId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.EmployeeRoster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OutTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeRosters");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Taxi", b =>
                {
                    b.Property<int>("TaxiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxiModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxiType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaxiId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Taxis");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.TaxiModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaxiModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxiModels");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.TaxiType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TaxiTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaxiTypes");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("LoginID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID")
                        .IsUnique()
                        .HasFilter("[CustomerID] IS NOT NULL");

                    b.HasIndex("EmployeeID")
                        .IsUnique()
                        .HasFilter("[EmployeeID] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Booking", b =>
                {
                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Taxi", "Taxi")
                        .WithMany()
                        .HasForeignKey("TaxiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Taxi");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Employee", b =>
                {
                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.EmployeeRoster", b =>
                {
                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.Taxi", b =>
                {
                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Infinite.TaxiBookingSystem.API.Models.User", b =>
                {
                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID");

                    b.HasOne("Infinite.TaxiBookingSystem.API.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
