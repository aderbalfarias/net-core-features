using Microsoft.EntityFrameworkCore.Migrations;

namespace AboutNetCore.Version1_0.DefaultTemplate.Data.Migrations
{
    public partial class AlterTests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tests",
                table: "Tests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tests",
                table: "Tests",
                column: "Id")
                .Annotation("SqlServer:Clustered", true);
        }
    }
}
