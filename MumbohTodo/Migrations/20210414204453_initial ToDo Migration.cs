using Microsoft.EntityFrameworkCore.Migrations;

namespace MumbohTodo.Migrations
{
    public partial class initialToDoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ToDoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Done = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoneDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddToDoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ToDoID);
                    table.ForeignKey(
                        name: "FK_ToDos_AddToDos_AddToDoID",
                        column: x => x.AddToDoID,
                        principalTable: "AddToDos",
                        principalColumn: "AddToDoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_AddToDoID",
                table: "ToDos",
                column: "AddToDoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.DropTable(
                name: "AddToDos");
        }
    }
}
