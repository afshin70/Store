using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderNumber",
                table: "MainCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActivationCode", "ActivationCodeExpireDate", "BlockedDate", "DeletedDate", "Password", "RegisterDate", "Salt", "Token" },
                values: new object[] { "a5a17372ba0c4291a207edcfce471aef", new DateTime(2019, 7, 22, 10, 42, 47, 845, DateTimeKind.Local).AddTicks(9020), new DateTime(2019, 7, 22, 10, 42, 47, 849, DateTimeKind.Local).AddTicks(4430), new DateTime(2019, 7, 22, 10, 42, 47, 849, DateTimeKind.Local).AddTicks(5835), "ah96NkysmupODN1qDNR4sg==", new DateTime(2019, 7, 22, 10, 42, 47, 849, DateTimeKind.Local).AddTicks(9166), "e3b21e9fe75f4409ab26b80e8255e3c1", "4a270d56f2a74b499eb3444c8f171df8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "MainCategories");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActivationCode", "ActivationCodeExpireDate", "BlockedDate", "DeletedDate", "Password", "RegisterDate", "Salt", "Token" },
                values: new object[] { "f69848b78933438db1a2f3fe0354c6cf", new DateTime(2019, 7, 19, 8, 28, 56, 79, DateTimeKind.Local).AddTicks(5350), new DateTime(2019, 7, 19, 8, 28, 56, 96, DateTimeKind.Local).AddTicks(1557), new DateTime(2019, 7, 19, 8, 28, 56, 96, DateTimeKind.Local).AddTicks(2147), "tYrR5KCiuiHwp5qG4ZLinQ==", new DateTime(2019, 7, 19, 8, 28, 56, 96, DateTimeKind.Local).AddTicks(3642), "653079a1f0384eadb89279b7bebb4fba", "993ce7cd1ce2411b9c5e340451989f85" });
        }
    }
}
