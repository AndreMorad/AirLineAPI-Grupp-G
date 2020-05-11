﻿// <auto-generated />
using System;
using AirLineAPI.Db_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirLineAPI.Migrations
{
    [DbContext(typeof(AirLineContext))]
    [Migration("20200506144211_RemovedColumn")]
    partial class RemovedColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirLineAPI.Model.Destination", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("AirLineAPI.Model.Flight", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AirLineAPI.Model.Passenger", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("AirLineAPI.Model.PassengerTimeTable", b =>
                {
                    b.Property<long>("PassengerId")
                        .HasColumnType("bigint");

                    b.Property<long>("TimeTableId")
                        .HasColumnType("bigint");

                    b.HasKey("PassengerId", "TimeTableId");

                    b.HasIndex("TimeTableId");

                    b.ToTable("PassengerTimeTables");
                });

            modelBuilder.Entity("AirLineAPI.Model.Route", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EndDestinationID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("StartDestinationID")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("TravelTime")
                        .HasColumnType("time");

                    b.HasKey("ID");

                    b.HasIndex("EndDestinationID");

                    b.HasIndex("StartDestinationID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("AirLineAPI.Model.TimeTable", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<long?>("FlightID")
                        .HasColumnType("bigint");

                    b.Property<long?>("RouteID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("FlightID");

                    b.HasIndex("RouteID");

                    b.ToTable("TimeTables");
                });

            modelBuilder.Entity("AirLineAPI.Model.PassengerTimeTable", b =>
                {
                    b.HasOne("AirLineAPI.Model.Passenger", "Passenger")
                        .WithMany("PassengerTimeTables")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AirLineAPI.Model.TimeTable", "TimeTable")
                        .WithMany("PassengerTimeTables")
                        .HasForeignKey("TimeTableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AirLineAPI.Model.Route", b =>
                {
                    b.HasOne("AirLineAPI.Model.Destination", "EndDestination")
                        .WithMany()
                        .HasForeignKey("EndDestinationID");

                    b.HasOne("AirLineAPI.Model.Destination", "StartDestination")
                        .WithMany()
                        .HasForeignKey("StartDestinationID");
                });

            modelBuilder.Entity("AirLineAPI.Model.TimeTable", b =>
                {
                    b.HasOne("AirLineAPI.Model.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightID");

                    b.HasOne("AirLineAPI.Model.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteID");
                });
#pragma warning restore 612, 618
        }
    }
}