﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(TiendaCampusContext))]
    [Migration("20231010173058_Update3")]
    partial class Update3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMascotaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdServicioFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdMascotaFk");

                    b.HasIndex("IdServicioFk");

                    b.ToTable("Cita", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("Ciudad", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ClienteDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("Cardinal")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CardinalSec")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("CodigoPostal")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<string>("Letra")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("varchar(1)");

                    b.Property<string>("LetraSec")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("LetraTer")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("NumeroPri")
                        .HasColumnType("int");

                    b.Property<int>("NumeroSec")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTer")
                        .HasColumnType("int");

                    b.Property<string>("TipoDeVia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk")
                        .IsUnique();

                    b.HasIndex("IdClienteFk")
                        .IsUnique();

                    b.ToTable("ClienteDireccion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ClienteTelefono", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.ToTable("ClienteTelefono", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRazaFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdRazaFk");

                    b.ToTable("Mascota", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Raza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Raza", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Servicio", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Cita", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Clientes")
                        .WithMany("Citas")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Mascota", "Mascotas")
                        .WithMany("Citas")
                        .HasForeignKey("IdMascotaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Servicio", "Servicios")
                        .WithMany("Citas")
                        .HasForeignKey("IdServicioFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Mascotas");

                    b.Navigation("Servicios");
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.HasOne("Core.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.ClienteDireccion", b =>
                {
                    b.HasOne("Core.Entities.Ciudad", "Ciudades")
                        .WithOne("ClienteDirecciones")
                        .HasForeignKey("Core.Entities.ClienteDireccion", "IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Cliente", "Clientes")
                        .WithOne("ClienteDireccion")
                        .HasForeignKey("Core.Entities.ClienteDireccion", "IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Core.Entities.ClienteTelefono", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Clientes")
                        .WithMany("ClienteTelefonos")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.HasOne("Core.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Core.Entities.Mascota", b =>
                {
                    b.HasOne("Core.Entities.Cliente", "Clientes")
                        .WithMany("Mascotas")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Raza", "Raza")
                        .WithMany("Mascotas")
                        .HasForeignKey("IdRazaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Raza");
                });

            modelBuilder.Entity("Core.Entities.Ciudad", b =>
                {
                    b.Navigation("ClienteDirecciones");
                });

            modelBuilder.Entity("Core.Entities.Cliente", b =>
                {
                    b.Navigation("Citas");

                    b.Navigation("ClienteDireccion");

                    b.Navigation("ClienteTelefonos");

                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Core.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Core.Entities.Mascota", b =>
                {
                    b.Navigation("Citas");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.Raza", b =>
                {
                    b.Navigation("Mascotas");
                });

            modelBuilder.Entity("Core.Entities.Servicio", b =>
                {
                    b.Navigation("Citas");
                });
#pragma warning restore 612, 618
        }
    }
}
