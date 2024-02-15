using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FanDescription = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guruhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GuruhName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    FanId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false),
                    XonaId = table.Column<int>(type: "integer", nullable: false),
                    HaftaKunlari = table.Column<List<int>>(type: "integer[]", nullable: true),
                    Start = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Narxi = table.Column<decimal>(type: "numeric", nullable: false),
                    Davomiyligi = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guruhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Talabas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talabas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    XonaName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Qavat = table.Column<int>(type: "integer", nullable: false),
                    Sigimi = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalabaGuruhDavomats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalabaId = table.Column<int>(type: "integer", nullable: false),
                    GuruhId = table.Column<int>(type: "integer", nullable: false),
                    Qachon = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    KeldiKemadi = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalabaGuruhDavomats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalabaGuruhDavomats_Guruhs_GuruhId",
                        column: x => x.GuruhId,
                        principalTable: "Guruhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TalabaGuruhDavomats_Talabas_TalabaId",
                        column: x => x.TalabaId,
                        principalTable: "Talabas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalabaGuruhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalabaId = table.Column<int>(type: "integer", nullable: false),
                    GuruhId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalabaGuruhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalabaGuruhs_Guruhs_GuruhId",
                        column: x => x.GuruhId,
                        principalTable: "Guruhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TalabaGuruhs_Talabas_TalabaId",
                        column: x => x.TalabaId,
                        principalTable: "Talabas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalabaTolovs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TalabaId = table.Column<int>(type: "integer", nullable: false),
                    GuruhId = table.Column<int>(type: "integer", nullable: false),
                    QachonTolagan = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    QanchaTolagan = table.Column<decimal>(type: "numeric", nullable: false),
                    TolovTuri = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalabaTolovs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalabaTolovs_Guruhs_GuruhId",
                        column: x => x.GuruhId,
                        principalTable: "Guruhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TalabaTolovs_Talabas_TalabaId",
                        column: x => x.TalabaId,
                        principalTable: "Talabas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherFans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanId = table.Column<int>(type: "integer", nullable: false),
                    TeacherId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherFans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherFans_Fans_FanId",
                        column: x => x.FanId,
                        principalTable: "Fans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherFans_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TalabaGuruhDavomats_GuruhId",
                table: "TalabaGuruhDavomats",
                column: "GuruhId");

            migrationBuilder.CreateIndex(
                name: "IX_TalabaGuruhDavomats_TalabaId",
                table: "TalabaGuruhDavomats",
                column: "TalabaId");

            migrationBuilder.CreateIndex(
                name: "IX_TalabaGuruhs_GuruhId",
                table: "TalabaGuruhs",
                column: "GuruhId");

            migrationBuilder.CreateIndex(
                name: "IX_TalabaGuruhs_TalabaId",
                table: "TalabaGuruhs",
                column: "TalabaId");

            migrationBuilder.CreateIndex(
                name: "IX_TalabaTolovs_GuruhId",
                table: "TalabaTolovs",
                column: "GuruhId");

            migrationBuilder.CreateIndex(
                name: "IX_TalabaTolovs_TalabaId",
                table: "TalabaTolovs",
                column: "TalabaId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherFans_FanId",
                table: "TeacherFans",
                column: "FanId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherFans_TeacherId",
                table: "TeacherFans",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TalabaGuruhDavomats");

            migrationBuilder.DropTable(
                name: "TalabaGuruhs");

            migrationBuilder.DropTable(
                name: "TalabaTolovs");

            migrationBuilder.DropTable(
                name: "TeacherFans");

            migrationBuilder.DropTable(
                name: "Xonas");

            migrationBuilder.DropTable(
                name: "Guruhs");

            migrationBuilder.DropTable(
                name: "Talabas");

            migrationBuilder.DropTable(
                name: "Fans");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
