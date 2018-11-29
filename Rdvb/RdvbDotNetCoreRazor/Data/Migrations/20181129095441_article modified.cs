using Microsoft.EntityFrameworkCore.Migrations;

namespace RdvbDotNetCoreRazor.Data.Migrations
{
    public partial class articlemodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CtreatetBy",
                table: "Article",
                newName: "ModifiedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                table: "Article",
                newName: "CtreatetBy");
        }
    }
}
