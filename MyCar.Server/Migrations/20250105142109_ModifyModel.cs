﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCar.Server.Migrations
{
    /// <inheritdoc />
    public partial class ModifyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makes",
                table: "Makes");

            migrationBuilder.RenameTable(
                name: "Makes",
                newName: "Make");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Make",
                table: "Make",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Make_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Make_MakeId",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Make",
                table: "Make");

            migrationBuilder.RenameTable(
                name: "Make",
                newName: "Makes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makes",
                table: "Makes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
