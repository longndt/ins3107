using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web2.Migrations
{
    /// <inheritdoc />
    public partial class addnewcolumnaddresstostudenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Student");
        }
    }
}
