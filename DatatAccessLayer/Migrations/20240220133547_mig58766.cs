using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatatAccessLayer.Migrations
{
    public partial class mig58766 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MessageStatus",
                table: "contactUses",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageStatus",
                table: "contactUses");
        }
    }
}
