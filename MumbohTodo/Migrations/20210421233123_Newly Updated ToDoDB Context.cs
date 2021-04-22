using Microsoft.EntityFrameworkCore.Migrations;

namespace MumbohTodo.Migrations
{
    public partial class NewlyUpdatedToDoDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_AddToDos_AddToDoID",
                table: "ToDos");

            migrationBuilder.DropTable(
                name: "AddToDos");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_AddToDoID",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "AddToDoID",
                table: "ToDos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddToDoID",
                table: "ToDos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AddToDos",
                columns: table => new
                {
                    AddToDoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddToDos", x => x.AddToDoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_AddToDoID",
                table: "ToDos",
                column: "AddToDoID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_AddToDos_AddToDoID",
                table: "ToDos",
                column: "AddToDoID",
                principalTable: "AddToDos",
                principalColumn: "AddToDoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
