﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using JDSY.MyAirport.EF;

namespace JDSY.MyAirport.EF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200221150106_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JDSY.MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("ID_BAGAGE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CLASSE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CODE_IATA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DATE_CREATION")
                        .HasColumnType("datetime2");

                    b.Property<string>("DESTINATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ESCALE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_VOL")
                        .HasColumnType("int");

                    b.Property<bool>("PRIORITAIRE")
                        .HasColumnType("bit");

                    b.Property<string>("SSUR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STA")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_BAGAGE");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("JDSY.MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("ID_VOL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CIE")
                        .HasColumnType("int");

                    b.Property<string>("DES")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DHC")
                        .HasColumnType("datetime2");

                    b.Property<string>("IMM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("JEX")
                        .HasColumnType("smallint");

                    b.Property<string>("LIG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("PAX")
                        .HasColumnType("smallint");

                    b.Property<string>("PKG")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_VOL");

                    b.ToTable("Vols");
                });
#pragma warning restore 612, 618
        }
    }
}
