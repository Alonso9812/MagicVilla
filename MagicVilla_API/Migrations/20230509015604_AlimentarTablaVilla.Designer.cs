﻿// <auto-generated />
using System;
using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_API.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230509015604_AlimentarTablaVilla")]
    partial class AlimentarTablaVilla
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.Modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Detalle de la Villa",
                            FechaActualizacion = new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2576),
                            FechaCreacion = new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2564),
                            ImagenUrl = "",
                            MetrosCuadrados = 50,
                            Nombre = "Villa Real",
                            Ocupantes = 5,
                            Tarifa = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Detalle de la Villa",
                            FechaActualizacion = new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2580),
                            FechaCreacion = new DateTime(2023, 5, 8, 19, 56, 4, 635, DateTimeKind.Local).AddTicks(2579),
                            ImagenUrl = "",
                            MetrosCuadrados = 100,
                            Nombre = "Villa Premiun",
                            Ocupantes = 10,
                            Tarifa = 500.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
