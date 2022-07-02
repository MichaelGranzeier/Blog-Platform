﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace template_csharp_blog.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Video Games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Consoles" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Game Store" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 1, "Michael", "It's an amazing game", 1, new DateTime(2022, 7, 1, 19, 48, 21, 347, DateTimeKind.Local).AddTicks(5513), "Breath of the Wild" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 2, "Michael", "it's the fastest console ever", 2, new DateTime(2022, 7, 1, 19, 48, 21, 347, DateTimeKind.Local).AddTicks(5557), "Xbox Series X" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[] { 3, "Michael", "Great place for old games", 3, new DateTime(2022, 7, 1, 19, 48, 21, 347, DateTimeKind.Local).AddTicks(5559), "GOG" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
