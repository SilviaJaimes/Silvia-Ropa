using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class YourMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sueldoBase = table.Column<double>(type: "double", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valorUnit = table.Column<double>(type: "double", maxLength: 100, nullable: false),
                    stockMin = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    stockMax = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "talla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talla", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoEstado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoProteccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoProteccion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    correoElectronico = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contraseña = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamento_pais_IdPais",
                        column: x => x.IdPais,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estado_tipoEstado_IdTipoEstado",
                        column: x => x.IdTipoEstado,
                        principalTable: "tipoEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rolUsuario",
                columns: table => new
                {
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolUsuario", x => new { x.IdUsuarioFk, x.IdRolFk });
                    table.ForeignKey(
                        name: "FK_rolUsuario_rol_IdRolFk",
                        column: x => x.IdRolFk,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rolUsuario_usuario_IdUsuarioFk",
                        column: x => x.IdUsuarioFk,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipio_Departamento_IdDep",
                        column: x => x.IdDep,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPrenda = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valorUnitCop = table.Column<double>(type: "double", maxLength: 200, nullable: false),
                    valorUnitUsd = table.Column<double>(type: "double", maxLength: 200, nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdTipoProteccion = table.Column<int>(type: "int", nullable: false),
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prenda_estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prenda_genero_IdGenero",
                        column: x => x.IdGenero,
                        principalTable: "genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prenda_tipoProteccion_IdTipoProteccion",
                        column: x => x.IdTipoProteccion,
                        principalTable: "tipoProteccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idCliente = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersona = table.Column<int>(type: "int", nullable: false),
                    fechaRegistro = table.Column<DateOnly>(type: "date", nullable: false),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cliente_TipoPersona_IdTipoPersona",
                        column: x => x.IdTipoPersona,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEmpleado = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCargo = table.Column<int>(type: "int", nullable: false),
                    fechaIngreso = table.Column<DateOnly>(type: "date", nullable: false),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empleado_cargo_IdCargo",
                        column: x => x.IdCargo,
                        principalTable: "cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nit = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    razonSocial = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    representanteLegal = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaCreacion = table.Column<DateOnly>(type: "date", nullable: false),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idProveedor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nombre = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersona = table.Column<int>(type: "int", nullable: false),
                    IdMunicipio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proveedor_TipoPersona_IdTipoPersona",
                        column: x => x.IdTipoPersona,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_municipio_IdMunicipio",
                        column: x => x.IdMunicipio,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumoPrenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdInsumo = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumoPrenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_insumoPrenda_insumo_IdInsumo",
                        column: x => x.IdInsumo,
                        principalTable: "insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_insumoPrenda_prenda_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codInv = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPrenda = table.Column<int>(type: "int", nullable: false),
                    valorVtaCop = table.Column<double>(type: "double", maxLength: 150, nullable: false),
                    valorVtaUsd = table.Column<double>(type: "double", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventario_prenda_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orden_cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orden_empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orden_estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdFormaPago = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_venta_cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_empleado_IdEmpleado",
                        column: x => x.IdEmpleado,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_formaPago_IdFormaPago",
                        column: x => x.IdFormaPago,
                        principalTable: "formaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumoProveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdInsumo = table.Column<int>(type: "int", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumoProveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_insumoProveedor_insumo_IdInsumo",
                        column: x => x.IdInsumo,
                        principalTable: "insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_insumoProveedor_proveedor_IdProveedor",
                        column: x => x.IdProveedor,
                        principalTable: "proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventarioTalla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdInventario = table.Column<int>(type: "int", nullable: false),
                    IdTalla = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventarioTalla", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventarioTalla_inventario_IdInventario",
                        column: x => x.IdInventario,
                        principalTable: "inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventarioTalla_talla_IdTalla",
                        column: x => x.IdTalla,
                        principalTable: "talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleOrden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdOrden = table.Column<int>(type: "int", nullable: false),
                    IdPrenda = table.Column<int>(type: "int", nullable: false),
                    cantidadProducir = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    IdColor = table.Column<int>(type: "int", nullable: false),
                    cantidadProducida = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleOrden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleOrden_color_IdColor",
                        column: x => x.IdColor,
                        principalTable: "color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleOrden_estado_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleOrden_orden_IdOrden",
                        column: x => x.IdOrden,
                        principalTable: "orden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleOrden_prenda_IdPrenda",
                        column: x => x.IdPrenda,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVenta = table.Column<int>(type: "int", nullable: false),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    IdTalla = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    valorUnit = table.Column<double>(type: "double", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleVenta_inventario_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleVenta_talla_IdTalla",
                        column: x => x.IdTalla,
                        principalTable: "talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleVenta_venta_IdVenta",
                        column: x => x.IdVenta,
                        principalTable: "venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_IdMunicipio",
                table: "cliente",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_IdTipoPersona",
                table: "cliente",
                column: "IdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_IdPais",
                table: "Departamento",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_IdColor",
                table: "detalleOrden",
                column: "IdColor");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_IdEstado",
                table: "detalleOrden",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_IdOrden",
                table: "detalleOrden",
                column: "IdOrden");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_IdPrenda",
                table: "detalleOrden",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_IdProducto",
                table: "detalleVenta",
                column: "IdProducto");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_IdTalla",
                table: "detalleVenta",
                column: "IdTalla");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_IdVenta",
                table: "detalleVenta",
                column: "IdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdCargo",
                table: "empleado",
                column: "IdCargo");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_IdMunicipio",
                table: "empleado",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_IdMunicipio",
                table: "empresa",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_estado_IdTipoEstado",
                table: "estado",
                column: "IdTipoEstado");

            migrationBuilder.CreateIndex(
                name: "IX_insumoPrenda_IdInsumo",
                table: "insumoPrenda",
                column: "IdInsumo");

            migrationBuilder.CreateIndex(
                name: "IX_insumoPrenda_IdPrenda",
                table: "insumoPrenda",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_insumoProveedor_IdInsumo",
                table: "insumoProveedor",
                column: "IdInsumo");

            migrationBuilder.CreateIndex(
                name: "IX_insumoProveedor_IdProveedor",
                table: "insumoProveedor",
                column: "IdProveedor");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_IdPrenda",
                table: "inventario",
                column: "IdPrenda");

            migrationBuilder.CreateIndex(
                name: "IX_inventarioTalla_IdInventario",
                table: "inventarioTalla",
                column: "IdInventario");

            migrationBuilder.CreateIndex(
                name: "IX_inventarioTalla_IdTalla",
                table: "inventarioTalla",
                column: "IdTalla");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_IdDep",
                table: "municipio",
                column: "IdDep");

            migrationBuilder.CreateIndex(
                name: "IX_orden_IdCliente",
                table: "orden",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_orden_IdEmpleado",
                table: "orden",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_orden_IdEstado",
                table: "orden",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_IdEstado",
                table: "prenda",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_IdGenero",
                table: "prenda",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_IdTipoProteccion",
                table: "prenda",
                column: "IdTipoProteccion");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdMunicipio",
                table: "proveedor",
                column: "IdMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_IdTipoPersona",
                table: "proveedor",
                column: "IdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UsuarioId",
                table: "RefreshToken",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_rolUsuario_IdRolFk",
                table: "rolUsuario",
                column: "IdRolFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdCliente",
                table: "venta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdEmpleado",
                table: "venta",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_venta_IdFormaPago",
                table: "venta",
                column: "IdFormaPago");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleOrden");

            migrationBuilder.DropTable(
                name: "detalleVenta");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "insumoPrenda");

            migrationBuilder.DropTable(
                name: "insumoProveedor");

            migrationBuilder.DropTable(
                name: "inventarioTalla");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "rolUsuario");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "orden");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "insumo");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "talla");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "formaPago");

            migrationBuilder.DropTable(
                name: "prenda");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "tipoProteccion");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "tipoEstado");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
