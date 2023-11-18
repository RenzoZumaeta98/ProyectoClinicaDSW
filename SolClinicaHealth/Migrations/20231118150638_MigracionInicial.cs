using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolClinicaHealth.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    IdDocumento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDocumento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.IdDocumento);
                });

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEspecialidad = table.Column<string>(nullable: true),
                    DescripcionEspecialidad = table.Column<string>(nullable: true),
                    PrecioConsultaEspecialidad = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.IdEspecialidad);
                });

            migrationBuilder.CreateTable(
                name: "HorarioTrabajo",
                columns: table => new
                {
                    IdHorarioTrabajo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHorarioTrabajo = table.Column<DateTime>(nullable: false),
                    HoraInicio = table.Column<string>(nullable: true),
                    HoraFin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioTrabajo", x => x.IdHorarioTrabajo);
                });

            migrationBuilder.CreateTable(
                name: "MotivoCitaAplazada",
                columns: table => new
                {
                    IdMotivoAplazo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMotivoAplazo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoCitaAplazada", x => x.IdMotivoAplazo);
                });

            migrationBuilder.CreateTable(
                name: "MotivoCitaCancelada",
                columns: table => new
                {
                    IdMotivoCancelado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMotivoCancelado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoCitaCancelada", x => x.IdMotivoCancelado);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDoctor = table.Column<string>(nullable: true),
                    ApellidoDoctor = table.Column<string>(nullable: true),
                    CorreoDoctor = table.Column<string>(nullable: true),
                    FechaNacDoctor = table.Column<DateTime>(nullable: false),
                    DocumentoIdDocumento = table.Column<int>(nullable: true),
                    NroDocumentoDoctor = table.Column<string>(nullable: true),
                    CelularDoctor = table.Column<string>(nullable: true),
                    GeneroDoctor = table.Column<string>(nullable: true),
                    DireccionDoctor = table.Column<string>(nullable: true),
                    EspecialidadIdEspecialidad = table.Column<int>(nullable: true),
                    DescripcionDoctor = table.Column<string>(nullable: true),
                    TitulosDoctor = table.Column<string>(nullable: true),
                    EstudiosDoctor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.IdDoctor);
                    table.ForeignKey(
                        name: "FK_Doctor_Documento_DocumentoIdDocumento",
                        column: x => x.DocumentoIdDocumento,
                        principalTable: "Documento",
                        principalColumn: "IdDocumento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Especialidad_EspecialidadIdEspecialidad",
                        column: x => x.EspecialidadIdEspecialidad,
                        principalTable: "Especialidad",
                        principalColumn: "IdEspecialidad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(nullable: true),
                    ApellidoUsuario = table.Column<string>(nullable: true),
                    CorreoUsuario = table.Column<string>(nullable: true),
                    ClaveUsuario = table.Column<string>(nullable: true),
                    FechaNacUsuario = table.Column<DateTime>(nullable: false),
                    DocumentoIdDocumento = table.Column<int>(nullable: true),
                    NroDocumentoUsuario = table.Column<string>(nullable: true),
                    CelularUsuario = table.Column<string>(nullable: true),
                    GeneroUsuario = table.Column<string>(nullable: true),
                    DireccionUsuario = table.Column<string>(nullable: true),
                    TipoUsuarioIdTipoUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Documento_DocumentoIdDocumento",
                        column: x => x.DocumentoIdDocumento,
                        principalTable: "Documento",
                        principalColumn: "IdDocumento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_TipoUsuario_TipoUsuarioIdTipoUsuario",
                        column: x => x.TipoUsuarioIdTipoUsuario,
                        principalTable: "TipoUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HorarioTrabajoDoctor",
                columns: table => new
                {
                    IdHorarioTrabajoDoctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorarioTrabajoIdHorarioTrabajo = table.Column<int>(nullable: true),
                    DoctorIdDoctor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioTrabajoDoctor", x => x.IdHorarioTrabajoDoctor);
                    table.ForeignKey(
                        name: "FK_HorarioTrabajoDoctor_Doctor_DoctorIdDoctor",
                        column: x => x.DoctorIdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HorarioTrabajoDoctor_HorarioTrabajo_HorarioTrabajoIdHorarioTrabajo",
                        column: x => x.HorarioTrabajoIdHorarioTrabajo,
                        principalTable: "HorarioTrabajo",
                        principalColumn: "IdHorarioTrabajo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cita",
                columns: table => new
                {
                    IdCita = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioIdUsuario = table.Column<int>(nullable: true),
                    EspecialidadIdEspecialidad = table.Column<int>(nullable: true),
                    DoctorIdDoctor = table.Column<int>(nullable: true),
                    FechaCita = table.Column<DateTime>(nullable: false),
                    HoraCita = table.Column<string>(nullable: true),
                    EstadoCita = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cita", x => x.IdCita);
                    table.ForeignKey(
                        name: "FK_Cita_Doctor_DoctorIdDoctor",
                        column: x => x.DoctorIdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cita_Especialidad_EspecialidadIdEspecialidad",
                        column: x => x.EspecialidadIdEspecialidad,
                        principalTable: "Especialidad",
                        principalColumn: "IdEspecialidad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cita_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ValoracionesDoctor",
                columns: table => new
                {
                    IdValoracion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorIdDoctor = table.Column<int>(nullable: true),
                    UsuarioIdUsuario = table.Column<int>(nullable: true),
                    ComentarioValoracion = table.Column<string>(nullable: true),
                    NivelValoracion = table.Column<int>(nullable: false),
                    TipoValoracion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValoracionesDoctor", x => x.IdValoracion);
                    table.ForeignKey(
                        name: "FK_ValoracionesDoctor_Doctor_DoctorIdDoctor",
                        column: x => x.DoctorIdDoctor,
                        principalTable: "Doctor",
                        principalColumn: "IdDoctor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ValoracionesDoctor_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CDP",
                columns: table => new
                {
                    IdCDP = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaIdCita = table.Column<int>(nullable: true),
                    PrecioCita = table.Column<double>(nullable: false),
                    EstadoCDP = table.Column<string>(nullable: true),
                    NroTarjeta = table.Column<string>(nullable: true),
                    TipoCDP = table.Column<string>(nullable: true),
                    NroFactura = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CDP", x => x.IdCDP);
                    table.ForeignKey(
                        name: "FK_CDP_Cita_CitaIdCita",
                        column: x => x.CitaIdCita,
                        principalTable: "Cita",
                        principalColumn: "IdCita",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitaAplazada",
                columns: table => new
                {
                    IdCitaAplazada = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaIdCita = table.Column<int>(nullable: true),
                    MotivoIdMotivoAplazo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitaAplazada", x => x.IdCitaAplazada);
                    table.ForeignKey(
                        name: "FK_CitaAplazada_Cita_CitaIdCita",
                        column: x => x.CitaIdCita,
                        principalTable: "Cita",
                        principalColumn: "IdCita",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CitaAplazada_MotivoCitaAplazada_MotivoIdMotivoAplazo",
                        column: x => x.MotivoIdMotivoAplazo,
                        principalTable: "MotivoCitaAplazada",
                        principalColumn: "IdMotivoAplazo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitaCancelada",
                columns: table => new
                {
                    IdCitaCancelada = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaIdCita = table.Column<int>(nullable: true),
                    MotivoCitaCanceladaEntityIdMotivoCancelado = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitaCancelada", x => x.IdCitaCancelada);
                    table.ForeignKey(
                        name: "FK_CitaCancelada_Cita_CitaIdCita",
                        column: x => x.CitaIdCita,
                        principalTable: "Cita",
                        principalColumn: "IdCita",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CitaCancelada_MotivoCitaCancelada_MotivoCitaCanceladaEntityIdMotivoCancelado",
                        column: x => x.MotivoCitaCanceladaEntityIdMotivoCancelado,
                        principalTable: "MotivoCitaCancelada",
                        principalColumn: "IdMotivoCancelado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DevolucionPago",
                columns: table => new
                {
                    IdDevolcuionPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CDPIdCDP = table.Column<int>(nullable: true),
                    EstadoDevolucion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevolucionPago", x => x.IdDevolcuionPago);
                    table.ForeignKey(
                        name: "FK_DevolucionPago_CDP_CDPIdCDP",
                        column: x => x.CDPIdCDP,
                        principalTable: "CDP",
                        principalColumn: "IdCDP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CDP_CitaIdCita",
                table: "CDP",
                column: "CitaIdCita");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_DoctorIdDoctor",
                table: "Cita",
                column: "DoctorIdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_EspecialidadIdEspecialidad",
                table: "Cita",
                column: "EspecialidadIdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Cita_UsuarioIdUsuario",
                table: "Cita",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_CitaAplazada_CitaIdCita",
                table: "CitaAplazada",
                column: "CitaIdCita");

            migrationBuilder.CreateIndex(
                name: "IX_CitaAplazada_MotivoIdMotivoAplazo",
                table: "CitaAplazada",
                column: "MotivoIdMotivoAplazo");

            migrationBuilder.CreateIndex(
                name: "IX_CitaCancelada_CitaIdCita",
                table: "CitaCancelada",
                column: "CitaIdCita");

            migrationBuilder.CreateIndex(
                name: "IX_CitaCancelada_MotivoCitaCanceladaEntityIdMotivoCancelado",
                table: "CitaCancelada",
                column: "MotivoCitaCanceladaEntityIdMotivoCancelado");

            migrationBuilder.CreateIndex(
                name: "IX_DevolucionPago_CDPIdCDP",
                table: "DevolucionPago",
                column: "CDPIdCDP");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DocumentoIdDocumento",
                table: "Doctor",
                column: "DocumentoIdDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_EspecialidadIdEspecialidad",
                table: "Doctor",
                column: "EspecialidadIdEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioTrabajoDoctor_DoctorIdDoctor",
                table: "HorarioTrabajoDoctor",
                column: "DoctorIdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioTrabajoDoctor_HorarioTrabajoIdHorarioTrabajo",
                table: "HorarioTrabajoDoctor",
                column: "HorarioTrabajoIdHorarioTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_DocumentoIdDocumento",
                table: "Usuario",
                column: "DocumentoIdDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_TipoUsuarioIdTipoUsuario",
                table: "Usuario",
                column: "TipoUsuarioIdTipoUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionesDoctor_DoctorIdDoctor",
                table: "ValoracionesDoctor",
                column: "DoctorIdDoctor");

            migrationBuilder.CreateIndex(
                name: "IX_ValoracionesDoctor_UsuarioIdUsuario",
                table: "ValoracionesDoctor",
                column: "UsuarioIdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitaAplazada");

            migrationBuilder.DropTable(
                name: "CitaCancelada");

            migrationBuilder.DropTable(
                name: "DevolucionPago");

            migrationBuilder.DropTable(
                name: "HorarioTrabajoDoctor");

            migrationBuilder.DropTable(
                name: "ValoracionesDoctor");

            migrationBuilder.DropTable(
                name: "MotivoCitaAplazada");

            migrationBuilder.DropTable(
                name: "MotivoCitaCancelada");

            migrationBuilder.DropTable(
                name: "CDP");

            migrationBuilder.DropTable(
                name: "HorarioTrabajo");

            migrationBuilder.DropTable(
                name: "Cita");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "TipoUsuario");
        }
    }
}
