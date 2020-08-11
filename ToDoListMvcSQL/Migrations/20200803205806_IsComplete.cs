using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListMvcSqlEntityIdentity.Migrations
{
    public partial class IsComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "Items",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "Items");
        }
    }
}
