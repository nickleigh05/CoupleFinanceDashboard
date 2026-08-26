using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoupleFinanceDashboard.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddPartnerRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PartnerId",
                table: "Accounts",
                column: "PartnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Partners_PartnerId",
                table: "Accounts",
                column: "PartnerId",
                principalTable: "Partners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Partners_PartnerId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_PartnerId",
                table: "Accounts");
        }
    }
}
