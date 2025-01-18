using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDASPNETCoreMVC.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTableField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cellphone",
                table: "Contact",
                newName: "CellPhone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CellPhone",
                table: "Contact",
                newName: "Cellphone");
        }
    }
}
