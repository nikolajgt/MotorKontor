﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotorKontor.Backend.Models;

namespace MotorKontor.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220310084523_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MotorKontor.Backend.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UserCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MotorKontor.Backend.Models.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginID");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("MotorKontor.Backend.Models.Registration", b =>
                {
                    b.Property<int>("RegistrationID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("RegistrationID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("MotorKontor.Backend.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.Property<int>("Fuel")
                        .HasColumnType("int");

                    b.Property<DateTime>("LeasedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegistrationID")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleID");

                    b.HasIndex("RegistrationID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("MotorKontor.Backend.Models.Registration", b =>
                {
                    b.HasOne("MotorKontor.Backend.Models.Customer", null)
                        .WithMany("UserVehicleRegistration")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MotorKontor.Backend.Models.Vehicle", b =>
                {
                    b.HasOne("MotorKontor.Backend.Models.Registration", "VehicleRegistration")
                        .WithMany()
                        .HasForeignKey("RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}