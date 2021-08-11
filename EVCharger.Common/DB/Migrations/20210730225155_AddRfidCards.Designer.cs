﻿// <auto-generated />
using System;
using System.Collections.Generic;
using EVCharger.Common.Protobuf.DB;
using EVCharger.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EVCharger.DB.Migrations
{
    [DbContext(typeof(ChargerContext))]
    [Migration("20210730225155_AddRfidCards")]
    partial class AddRfidCards
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.4.21253.1")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ConstellationUser", b =>
                {
                    b.Property<string>("ConstellationsId")
                        .HasColumnType("text");

                    b.Property<string>("UsersId")
                        .HasColumnType("text");

                    b.HasKey("ConstellationsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("ConstellationUser");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.Charger", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("ChargerStatus")
                        .HasColumnType("integer");

                    b.Property<string>("ConstellationId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ConstellationId");

                    b.ToTable("Chargers");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.ChargingSession", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ChargerId")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<List<double>>("EnergyUsed")
                        .HasColumnType("double precision[]");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("Tariff")
                        .HasColumnType("double precision");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ChargerId");

                    b.HasIndex("UserId");

                    b.ToTable("ChargingSessions");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.Constellation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Constellations");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.RfidCard", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RfidCard");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ConstellationUser", b =>
                {
                    b.HasOne("EVCharger.Base.Models.Models.Constellation", null)
                        .WithMany()
                        .HasForeignKey("ConstellationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EVCharger.Base.Models.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.Charger", b =>
                {
                    b.HasOne("EVCharger.Base.Models.Models.Constellation", "Constellation")
                        .WithMany("Chargers")
                        .HasForeignKey("ConstellationId");

                    b.Navigation("Constellation");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.ChargingSession", b =>
                {
                    b.HasOne("EVCharger.Base.Models.Models.Charger", "Charger")
                        .WithMany()
                        .HasForeignKey("ChargerId");

                    b.HasOne("EVCharger.Base.Models.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Charger");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.RfidCard", b =>
                {
                    b.HasOne("EVCharger.Base.Models.Models.User", null)
                        .WithMany("RfidCards")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.Constellation", b =>
                {
                    b.Navigation("Chargers");
                });

            modelBuilder.Entity("EVCharger.Base.Models.Models.User", b =>
                {
                    b.Navigation("RfidCards");
                });
#pragma warning restore 612, 618
        }
    }
}
