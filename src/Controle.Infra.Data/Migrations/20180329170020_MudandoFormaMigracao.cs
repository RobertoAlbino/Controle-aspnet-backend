using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Controle.Infra.Data.Migrations
{
    public partial class MudandoFormaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_TiposEquipamento_IdTipoEquipamento",
                table: "Equipamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposEquipamento",
                table: "TiposEquipamento");

            migrationBuilder.RenameTable(
                name: "TiposEquipamento",
                newName: "TipoEquipamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoEquipamento",
                table: "TipoEquipamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_TipoEquipamento_IdTipoEquipamento",
                table: "Equipamentos",
                column: "IdTipoEquipamento",
                principalTable: "TipoEquipamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipamentos_TipoEquipamento_IdTipoEquipamento",
                table: "Equipamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoEquipamento",
                table: "TipoEquipamento");

            migrationBuilder.RenameTable(
                name: "TipoEquipamento",
                newName: "TiposEquipamento");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposEquipamento",
                table: "TiposEquipamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipamentos_TiposEquipamento_IdTipoEquipamento",
                table: "Equipamentos",
                column: "IdTipoEquipamento",
                principalTable: "TiposEquipamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
