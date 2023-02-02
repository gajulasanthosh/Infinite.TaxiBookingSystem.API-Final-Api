using Microsoft.EntityFrameworkCore.Migrations;

namespace Infinite.TaxiBookingSystem.API.Migrations
{
    public partial class UpdateTaxiClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taxis_TaxiModels_TaxiModelId",
                table: "Taxis");

            migrationBuilder.DropForeignKey(
                name: "FK_Taxis_TaxiTypes_TaxiTypeId",
                table: "Taxis");

            migrationBuilder.DropIndex(
                name: "IX_Taxis_TaxiModelId",
                table: "Taxis");

            migrationBuilder.DropIndex(
                name: "IX_Taxis_TaxiTypeId",
                table: "Taxis");

            migrationBuilder.DropColumn(
                name: "TaxiModelId",
                table: "Taxis");

            migrationBuilder.DropColumn(
                name: "TaxiTypeId",
                table: "Taxis");

            migrationBuilder.AddColumn<string>(
                name: "TaxiModel",
                table: "Taxis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxiType",
                table: "Taxis",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaxiModel",
                table: "Taxis");

            migrationBuilder.DropColumn(
                name: "TaxiType",
                table: "Taxis");

            migrationBuilder.AddColumn<int>(
                name: "TaxiModelId",
                table: "Taxis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TaxiTypeId",
                table: "Taxis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Taxis_TaxiModelId",
                table: "Taxis",
                column: "TaxiModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Taxis_TaxiTypeId",
                table: "Taxis",
                column: "TaxiTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Taxis_TaxiModels_TaxiModelId",
                table: "Taxis",
                column: "TaxiModelId",
                principalTable: "TaxiModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Taxis_TaxiTypes_TaxiTypeId",
                table: "Taxis",
                column: "TaxiTypeId",
                principalTable: "TaxiTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
