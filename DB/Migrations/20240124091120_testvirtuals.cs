using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class testvirtuals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reciboes_proveedorID",
                table: "Reciboes",
                column: "proveedorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reciboes_Proveedors_proveedorID",
                table: "Reciboes",
                column: "proveedorID",
                principalTable: "Proveedors",
                principalColumn: "proveedorID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reciboes_Proveedors_proveedorID",
                table: "Reciboes");

            migrationBuilder.DropIndex(
                name: "IX_Reciboes_proveedorID",
                table: "Reciboes");
        }
    }
}
