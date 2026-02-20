using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Talabat_System.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantRefferenceToAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_RestaurantId",
                table: "Admins",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Restaurants_RestaurantId",
                table: "Admins",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Restaurants_RestaurantId",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_RestaurantId",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Admins");
        }
    }
}
