﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RDKSDatabase.Data;

#nullable disable

namespace RDKSDatabase.Migrations
{
    [DbContext(typeof(RDKSDatabaseContext))]
    [Migration("20220519214104_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RDKSDatabase.Models.ABCRecycling", b =>
                {
                    b.Property<DateTime?>("ABCDateID")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("ABC_COMPLETED")
                        .HasColumnType("bit");

                    b.Property<string>("ABC_LOCATION")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ABC_MATERIAL")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float?>("TOTAL_POUND_NETWEIGHT")
                        .IsRequired()
                        .HasColumnType("real")
                        .HasColumnName("ABC_NET_WEIGHT_IN_POUND");

                    b.Property<float?>("TOTAL_TONNAGE_MATERIAL")
                        .IsRequired()
                        .HasColumnType("real")
                        .HasColumnName("ABC_TOTAL_METRIC_TON");

                    b.Property<float?>("TOTAL_TONNAGE_NETWEIGHT")
                        .IsRequired()
                        .HasColumnType("real")
                        .HasColumnName("ABC_TOTAL_NET_WEIGHT_IN_TONNAGE");

                    b.HasKey("ABCDateID");

                    b.ToTable("ABCRecycling");
                });

            modelBuilder.Entity("RDKSDatabase.Models.Address", b =>
                {
                    b.Property<int>("ADDR_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ADDR_ID"), 1L, 1);

                    b.Property<string>("ADDR_CITY")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ADDR_POCODE")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("ADDR_PROV")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ADDR_STREET")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("CustomerCUS_ID")
                        .HasColumnType("int");

                    b.HasKey("ADDR_ID");

                    b.HasIndex("CustomerCUS_ID");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("RDKSDatabase.Models.Customer", b =>
                {
                    b.Property<int>("CUS_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CUS_ID"), 1L, 1);

                    b.Property<int>("ADDR_ID")
                        .HasColumnType("int")
                        .HasColumnName("CUS_ADDRESS");

                    b.Property<int>("ALT_ADDR_ID")
                        .HasColumnType("int")
                        .HasColumnName("CUS_ALT_ADDRESS");

                    b.Property<string>("CUS_ACCNUM")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("CUS_ALT_EMAIL")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CUS_ALT_PHONE")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CUS_COMPNAME")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("CUS_DEACTIVATED_COUNT")
                        .HasColumnType("int");

                    b.Property<string>("CUS_EMAIL")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CUS_FNAME")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("CUS_FR")
                        .HasColumnType("bit");

                    b.Property<string>("CUS_LNAME")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("CUS_MEZ")
                        .HasColumnType("bit");

                    b.Property<string>("CUS_NOTE")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CUS_PHONE")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("CUS_TTS")
                        .HasColumnType("bit");

                    b.HasKey("CUS_ID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("RDKSDatabase.Models.Address", b =>
                {
                    b.HasOne("RDKSDatabase.Models.Customer", null)
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerCUS_ID");
                });

            modelBuilder.Entity("RDKSDatabase.Models.Customer", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}