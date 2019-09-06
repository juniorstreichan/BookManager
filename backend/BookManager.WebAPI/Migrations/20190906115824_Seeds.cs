using Microsoft.EntityFrameworkCore.Migrations;

namespace BookManager.WebAPI.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Matheus" },
                    { 2, "Marcos" },
                    { 3, "Lucas" },
                    { 4, "João" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Épico" },
                    { 2, "Fábula" },
                    { 3, "Epopeia" },
                    { 4, "Novela" }
                });

            migrationBuilder.InsertData(
                table: "PublishingCompanies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Simon & Schuster	EUA" },
                    { 2, "Egmont group	Dinamarca / Noruega " },
                    { 3, "Woongjin ThinkBig	Coréia do Sul" },
                    { 4, "RCS Libri	Itália	513	6063" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PublishingCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublishingCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PublishingCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PublishingCompanies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
