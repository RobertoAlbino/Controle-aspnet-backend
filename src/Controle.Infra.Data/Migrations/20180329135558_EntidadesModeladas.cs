using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Controle.Infra.Data.Migrations
{
    public partial class EntidadesModeladas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CascadeMode",
                table: "Paises");

            migrationBuilder.RenameColumn(
                name: "CascadeMode",
                table: "Estados",
                newName: "IdPais");

            migrationBuilder.RenameColumn(
                name: "CascadeMode",
                table: "Clientes",
                newName: "IdEndereco");

            migrationBuilder.RenameColumn(
                name: "CascadeMode",
                table: "Cidades",
                newName: "IdEstado");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bairro = table.Column<string>(type: "varchar(150)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    IdCidade = table.Column<int>(nullable: false),
                    Rua = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Cidades_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposEquipamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposEquipamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTipoEquipamento = table.Column<int>(nullable: false),
                    Marca = table.Column<string>(type: "varchar(150)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipamentos_TiposEquipamento_IdTipoEquipamento",
                        column: x => x.IdTipoEquipamento,
                        principalTable: "TiposEquipamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Atendida = table.Column<bool>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdEquipamento = table.Column<int>(nullable: false),
                    Problema = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Equipamentos_IdEquipamento",
                        column: x => x.IdEquipamento,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estados_IdPais",
                table: "Estados",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdEndereco",
                table: "Clientes",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_IdEstado",
                table: "Cidades",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_IdCidade",
                table: "Enderecos",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_IdTipoEquipamento",
                table: "Equipamentos",
                column: "IdTipoEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_IdCliente",
                table: "OrdemServico",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_IdEquipamento",
                table: "OrdemServico",
                column: "IdEquipamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Estados_IdEstado",
                table: "Cidades",
                column: "IdEstado",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Enderecos_IdEndereco",
                table: "Clientes",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Estados_Paises_IdPais",
                table: "Estados",
                column: "IdPais",
                principalTable: "Paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Estados_IdEstado",
                table: "Cidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Enderecos_IdEndereco",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Estados_Paises_IdPais",
                table: "Estados");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "TiposEquipamento");

            migrationBuilder.DropIndex(
                name: "IX_Estados_IdPais",
                table: "Estados");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_IdEndereco",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Cidades_IdEstado",
                table: "Cidades");

            migrationBuilder.RenameColumn(
                name: "IdPais",
                table: "Estados",
                newName: "CascadeMode");

            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "Clientes",
                newName: "CascadeMode");

            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "Cidades",
                newName: "CascadeMode");

            migrationBuilder.AddColumn<int>(
                name: "CascadeMode",
                table: "Paises",
                nullable: false,
                defaultValue: 0);
        }
    }
}
