using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Filiais",
                columns: new[] { "Id", "NomeFilial" },
                values: new object[] { new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "Filial 001" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "DataInclusao", "Descricao", "TempoValidade" },
                values: new object[,]
                {
                    { "A0001", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produto 001", new TimeSpan(0, 4, 0, 0, 0) },
                    { "A0002", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produto 002", new TimeSpan(0, 3, 0, 0, 0) },
                    { "A0003", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produto 003", new TimeSpan(0, 6, 0, 0, 0) },
                    { "A0004", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produto 004", new TimeSpan(0, 5, 0, 0, 0) },
                    { "A0005", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produto 005", new TimeSpan(0, 4, 0, 0, 0) },
                    { "A0006", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Produto 006", new TimeSpan(0, 3, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Saldos",
                columns: new[] { "Id", "Data", "FilialId", "ProdutoId", "Saldo" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "A0001", 76 },
                    { 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "A0002", 8 },
                    { 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "A0003", 16 },
                    { 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "A0004", 31 },
                    { 5, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "A0005", 268 },
                    { 6, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"), "A0006", 302 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Saldos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Filiais",
                keyColumn: "Id",
                keyValue: new Guid("9d94c576-8ee6-46cb-9c1d-6de54b14ee27"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: "A0001");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: "A0002");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: "A0003");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: "A0004");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: "A0005");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: "A0006");
        }
    }
}
