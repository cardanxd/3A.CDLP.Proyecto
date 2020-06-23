﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkIO.Services;

namespace WorkIO.Services.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200619190101_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkIO.Models.Candidato", b =>
                {
                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("ECivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("FNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Nombre");

                    b.HasIndex("NomEmpresa");

                    b.ToTable("Candidato");
                });

            modelBuilder.Entity("WorkIO.Models.Documentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Antecedentes")
                        .HasColumnType("bit");

                    b.Property<bool>("Cartilla")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Curp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imss")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ine")
                        .HasColumnType("bit");

                    b.Property<bool>("Licencia")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Pasaporte")
                        .HasColumnType("bit");

                    b.Property<string>("Rfc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Visa")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Nombre");

                    b.ToTable("Documentos");
                });

            modelBuilder.Entity("WorkIO.Models.Empresa", b =>
                {
                    b.Property<string>("NomEmpresa")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NomEmpresa");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("WorkIO.Models.Orden", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("NomEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("NomEmpresa");

                    b.HasIndex("Nombre");

                    b.ToTable("Orden");
                });

            modelBuilder.Entity("WorkIO.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("WorkIO.Models.Referencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contrato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinSeparacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Funcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InicioLabores")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomInformante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomJefe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PuestoCandidato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PuestoInformante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PuestoJefe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("SueldoMensual")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Nombre");

                    b.ToTable("Referencia");
                });

            modelBuilder.Entity("WorkIO.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAT")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WorkIO.Models.Candidato", b =>
                {
                    b.HasOne("WorkIO.Models.Empresa", "Empresa")
                        .WithMany("Candidato")
                        .HasForeignKey("NomEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkIO.Models.Documentos", b =>
                {
                    b.HasOne("WorkIO.Models.Candidato", "Candidato")
                        .WithMany("Documento")
                        .HasForeignKey("Nombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkIO.Models.Orden", b =>
                {
                    b.HasOne("WorkIO.Models.Empresa", "Empresa")
                        .WithMany("Orden")
                        .HasForeignKey("NomEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkIO.Models.Candidato", "Candidato")
                        .WithMany("Orden")
                        .HasForeignKey("Nombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkIO.Models.Persona", b =>
                {
                    b.HasOne("WorkIO.Models.Usuario", "Usuario")
                        .WithOne("Persona")
                        .HasForeignKey("WorkIO.Models.Persona", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkIO.Models.Referencia", b =>
                {
                    b.HasOne("WorkIO.Models.Candidato", "Candidato")
                        .WithMany("Referencia")
                        .HasForeignKey("Nombre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
