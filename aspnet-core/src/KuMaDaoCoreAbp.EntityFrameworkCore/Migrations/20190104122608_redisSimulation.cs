using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace KuMaDaoCoreAbp.Migrations
{
    public partial class redisSimulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleLabel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArticleId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleLabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RedisSimulation",
                columns: table => new
                {
                    Key = table.Column<string>(type: "varchar(127)", nullable: false),
                    DeadlineTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedisSimulation", x => x.Key);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RedisSimulation_Key",
                table: "RedisSimulation",
                column: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleLabel");

            migrationBuilder.DropTable(
                name: "RedisSimulation");
        }
    }
}
