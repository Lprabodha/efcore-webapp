using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace c_webproject.Migrations
{
    /// <inheritdoc />
    public partial class alter_table_add_date_of_publish_column_books_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "books",
                newName: "DateOfPublish");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfPublish",
                table: "books",
                newName: "Isbn");
        }
    }
}
