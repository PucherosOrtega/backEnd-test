using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class NewColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciboes_Users_usuarioID",
                table: "Reciboes");

            migrationBuilder.DropIndex(
                name: "IX_Reciboes_usuarioID",
                table: "Reciboes");

            migrationBuilder.AddColumn<int>(
                name: "userID",
                table: "Reciboes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciboes_Users_userID",
                table: "Reciboes");

            migrationBuilder.DropIndex(
                name: "IX_Reciboes_userID",
                table: "Reciboes");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "Reciboes");

            migrationBuilder.CreateIndex(
                name: "IX_Reciboes_usuarioID",
                table: "Reciboes",
                column: "usuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciboes_Users_usuarioID",
                table: "Reciboes",
                column: "usuarioID",
                principalTable: "Users",
                principalColumn: "userID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
