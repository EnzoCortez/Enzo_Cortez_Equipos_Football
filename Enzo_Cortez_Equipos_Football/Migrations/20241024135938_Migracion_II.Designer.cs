﻿// <auto-generated />
using Enzo_Cortez_Equipos_Football.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Enzo_Cortez_Equipos_Football.Migrations
{
    [DbContext(typeof(Enzo_Cortez_Equipos_FootballContext))]
    [Migration("20241024135938_Migracion_II")]
    partial class Migracion_II
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Enzo_Cortez_Equipos_Football.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AceptaExtranjeros")
                        .HasColumnType("bit");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadioId")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadio")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Titulos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadioId");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("Enzo_Cortez_Equipos_Football.Models.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("Enzo_Cortez_Equipos_Football.Models.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("Enzo_Cortez_Equipos_Football.Models.Equipo", b =>
                {
                    b.HasOne("Enzo_Cortez_Equipos_Football.Models.Estadio", "Estadio")
                        .WithMany()
                        .HasForeignKey("EstadioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estadio");
                });

            modelBuilder.Entity("Enzo_Cortez_Equipos_Football.Models.Jugador", b =>
                {
                    b.HasOne("Enzo_Cortez_Equipos_Football.Models.Equipo", "Equipo")
                        .WithMany("Jugadores")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("Enzo_Cortez_Equipos_Football.Models.Equipo", b =>
                {
                    b.Navigation("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
