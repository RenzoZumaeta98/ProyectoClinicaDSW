﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolClinicaHealth.DataAccess;

namespace SolClinicaHealth.Migrations
{
    [DbContext(typeof(ProyectoClinicaContext))]
    [Migration("20231118150638_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CDPEntity", b =>
                {
                    b.Property<int>("IdCDP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CitaIdCita")
                        .HasColumnType("int");

                    b.Property<string>("EstadoCDP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroFactura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroTarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioCita")
                        .HasColumnType("float");

                    b.Property<string>("TipoCDP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCDP");

                    b.HasIndex("CitaIdCita");

                    b.ToTable("CDP");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CitaAplazadaEntity", b =>
                {
                    b.Property<int>("IdCitaAplazada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CitaIdCita")
                        .HasColumnType("int");

                    b.Property<int?>("MotivoIdMotivoAplazo")
                        .HasColumnType("int");

                    b.HasKey("IdCitaAplazada");

                    b.HasIndex("CitaIdCita");

                    b.HasIndex("MotivoIdMotivoAplazo");

                    b.ToTable("CitaAplazada");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CitaCanceladaEntity", b =>
                {
                    b.Property<int>("IdCitaCancelada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CitaIdCita")
                        .HasColumnType("int");

                    b.Property<int?>("MotivoCitaCanceladaEntityIdMotivoCancelado")
                        .HasColumnType("int");

                    b.HasKey("IdCitaCancelada");

                    b.HasIndex("CitaIdCita");

                    b.HasIndex("MotivoCitaCanceladaEntityIdMotivoCancelado");

                    b.ToTable("CitaCancelada");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CitaEntity", b =>
                {
                    b.Property<int>("IdCita")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<int?>("EspecialidadIdEspecialidad")
                        .HasColumnType("int");

                    b.Property<string>("EstadoCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<string>("HoraCita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdCita");

                    b.HasIndex("DoctorIdDoctor");

                    b.HasIndex("EspecialidadIdEspecialidad");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.DevolucionPagoEntity", b =>
                {
                    b.Property<int>("IdDevolcuionPago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CDPIdCDP")
                        .HasColumnType("int");

                    b.Property<string>("EstadoDevolucion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDevolcuionPago");

                    b.HasIndex("CDPIdCDP");

                    b.ToTable("DevolucionPago");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.DoctorEntity", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelularDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DocumentoIdDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("EspecialidadIdEspecialidad")
                        .HasColumnType("int");

                    b.Property<string>("EstudiosDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacDoctor")
                        .HasColumnType("datetime2");

                    b.Property<string>("GeneroDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroDocumentoDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitulosDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDoctor");

                    b.HasIndex("DocumentoIdDocumento");

                    b.HasIndex("EspecialidadIdEspecialidad");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.DocumentoEntity", b =>
                {
                    b.Property<int>("IdDocumento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDocumento");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.EspecialidadEntity", b =>
                {
                    b.Property<int>("IdEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionEspecialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEspecialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrecioConsultaEspecialidad")
                        .HasColumnType("float");

                    b.HasKey("IdEspecialidad");

                    b.ToTable("Especialidad");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.HorarioTrabajoDoctorEntity", b =>
                {
                    b.Property<int>("IdHorarioTrabajoDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<int?>("HorarioTrabajoIdHorarioTrabajo")
                        .HasColumnType("int");

                    b.HasKey("IdHorarioTrabajoDoctor");

                    b.HasIndex("DoctorIdDoctor");

                    b.HasIndex("HorarioTrabajoIdHorarioTrabajo");

                    b.ToTable("HorarioTrabajoDoctor");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.HorarioTrabajoEntity", b =>
                {
                    b.Property<int>("IdHorarioTrabajo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaHorarioTrabajo")
                        .HasColumnType("datetime2");

                    b.Property<string>("HoraFin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraInicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHorarioTrabajo");

                    b.ToTable("HorarioTrabajo");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.MotivoCitaAplazadaEntity", b =>
                {
                    b.Property<int>("IdMotivoAplazo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreMotivoAplazo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMotivoAplazo");

                    b.ToTable("MotivoCitaAplazada");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.MotivoCitaCanceladaEntity", b =>
                {
                    b.Property<int>("IdMotivoCancelado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreMotivoCancelado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMotivoCancelado");

                    b.ToTable("MotivoCitaCancelada");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.TipoUsuarioEntity", b =>
                {
                    b.Property<int>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreTipoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TipoUsuario");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.UsuarioEntity", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelularUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaveUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DocumentoIdDocumento")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacUsuario")
                        .HasColumnType("datetime2");

                    b.Property<string>("GeneroUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NroDocumentoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoUsuarioIdTipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario");

                    b.HasIndex("DocumentoIdDocumento");

                    b.HasIndex("TipoUsuarioIdTipoUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.ValoracionesDoctorEntity", b =>
                {
                    b.Property<int>("IdValoracion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComentarioValoracion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorIdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("NivelValoracion")
                        .HasColumnType("int");

                    b.Property<string>("TipoValoracion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdValoracion");

                    b.HasIndex("DoctorIdDoctor");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("ValoracionesDoctor");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CDPEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.CitaEntity", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaIdCita");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CitaAplazadaEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.CitaEntity", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaIdCita");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.MotivoCitaAplazadaEntity", "Motivo")
                        .WithMany()
                        .HasForeignKey("MotivoIdMotivoAplazo");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CitaCanceladaEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.CitaEntity", "Cita")
                        .WithMany()
                        .HasForeignKey("CitaIdCita");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.MotivoCitaCanceladaEntity", "MotivoCitaCanceladaEntity")
                        .WithMany()
                        .HasForeignKey("MotivoCitaCanceladaEntityIdMotivoCancelado");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.CitaEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.DoctorEntity", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorIdDoctor");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.EspecialidadEntity", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadIdEspecialidad");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.UsuarioEntity", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.DevolucionPagoEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.CDPEntity", "CDP")
                        .WithMany()
                        .HasForeignKey("CDPIdCDP");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.DoctorEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.DocumentoEntity", "Documento")
                        .WithMany()
                        .HasForeignKey("DocumentoIdDocumento");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.EspecialidadEntity", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadIdEspecialidad");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.HorarioTrabajoDoctorEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.DoctorEntity", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorIdDoctor");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.HorarioTrabajoEntity", "HorarioTrabajo")
                        .WithMany()
                        .HasForeignKey("HorarioTrabajoIdHorarioTrabajo");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.UsuarioEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.DocumentoEntity", "Documento")
                        .WithMany()
                        .HasForeignKey("DocumentoIdDocumento");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.TipoUsuarioEntity", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioIdTipoUsuario");
                });

            modelBuilder.Entity("SolClinicaHealth.DataAccess.Entities.ValoracionesDoctorEntity", b =>
                {
                    b.HasOne("SolClinicaHealth.DataAccess.Entities.DoctorEntity", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorIdDoctor");

                    b.HasOne("SolClinicaHealth.DataAccess.Entities.UsuarioEntity", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
