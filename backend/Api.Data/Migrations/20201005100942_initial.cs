using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Removed = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Removed = table.Column<bool>(nullable: false, defaultValue: false),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Director = table.Column<string>(maxLength: 60, nullable: false),
                    GenreId = table.Column<Guid>(nullable: false),
                    Synopsis = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreateAt", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("645269ed-2287-4fd1-90de-5649d340cb8f"), new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(398), "Terror", null },
                    { new Guid("9ab171af-3604-4375-b87c-14fdb8706a53"), new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(745), "Comédia", null },
                    { new Guid("e502ddce-bb51-445b-980d-650a3d37b4a0"), new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(755), "Romance", null },
                    { new Guid("5fad4f3f-3ba6-4f84-a642-1c4c5d5269e4"), new DateTime(2020, 10, 5, 10, 9, 42, 135, DateTimeKind.Utc).AddTicks(757), "Aventura", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genre_Name",
                table: "Genre",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenreId",
                table: "Movie",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
