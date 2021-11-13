using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViajeSeguro.Migrations
{
    public partial class firstMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoPagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreIcono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoIcono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pasajeros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Movil = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CodigoID = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TipoID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaNacimiento_string = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenorDeEdad = table.Column<bool>(type: "bit", nullable: false),
                    PaisNacionalidad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DireccionCalle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    PaisResidencia = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasajeros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    IconoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconId = table.Column<int>(type: "int", nullable: true),
                    PrecioBaseDia = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Icons_IconId",
                        column: x => x.IconId,
                        principalTable: "Icons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CantidadPasajeros = table.Column<int>(type: "int", nullable: false),
                    TitularTarjeta = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EstadoPagoId = table.Column<int>(type: "int", nullable: true),
                    Tarjeta = table.Column<string>(type: "nvarchar(19)", maxLength: 19, nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaIda = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaIda_string = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaVuelta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVuelta_string = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadDiasViaje = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    OrigenId = table.Column<int>(type: "int", nullable: false),
                    DestinoId = table.Column<int>(type: "int", nullable: false),
                    PrecioBase = table.Column<double>(type: "float", nullable: false),
                    RecargoPorcentaje = table.Column<double>(type: "float", nullable: false),
                    ImpuestosPorcentaje = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    Activa = table.Column<bool>(type: "bit", nullable: false),
                    QrRuta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciboRuta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentacionRuta = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservas_EstadoPagos_EstadoPagoId",
                        column: x => x.EstadoPagoId,
                        principalTable: "EstadoPagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Reservas_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Reservas_Regions_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Reservas_Regions_OrigenId",
                        column: x => x.OrigenId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservaId = table.Column<int>(type: "int", nullable: false),
                    PasajeroId = table.Column<int>(type: "int", nullable: false),
                    CantidadDiasViaje = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotizacions_Pasajeros_PasajeroId",
                        column: x => x.PasajeroId,
                        principalTable: "Pasajeros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Cotizacions_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacions_PasajeroId",
                table: "Cotizacions",
                column: "PasajeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacions_ReservaId",
                table: "Cotizacions",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_IconId",
                table: "Plans",
                column: "IconId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_DestinoId",
                table: "Reservas",
                column: "DestinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_EstadoPagoId",
                table: "Reservas",
                column: "EstadoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_OrigenId",
                table: "Reservas",
                column: "OrigenId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_PlanId",
                table: "Reservas",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cotizacions");

            migrationBuilder.DropTable(
                name: "Pasajeros");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "EstadoPagos");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Icons");
        }
    }
}
