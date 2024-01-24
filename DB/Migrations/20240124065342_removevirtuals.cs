using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class removevirtuals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciboes_Users_userID",
                table: "Reciboes");

            migrationBuilder.DropIndex(
                name: "IX_Reciboes_userID",
                table: "Reciboes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reciboes_userID",
                table: "Reciboes",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciboes_Users_userID",
                table: "Reciboes",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
