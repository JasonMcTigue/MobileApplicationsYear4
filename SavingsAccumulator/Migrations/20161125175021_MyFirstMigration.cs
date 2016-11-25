using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SavingsAccumulator.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    TargetId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CurrentBalance = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    SavingTarget = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.TargetId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Amount = table.Column<decimal>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    TargetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "TargetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TargetId",
                table: "Transactions",
                column: "TargetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Targets");
        }
    }
}
