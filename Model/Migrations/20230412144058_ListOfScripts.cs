using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class ListOfScripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Script",
                table: "Script");

            migrationBuilder.RenameColumn(
                name: "IdStep",
                table: "Script",
                newName: "NumberOfStep");

            migrationBuilder.AlterColumn<int>(
                name: "NumberOfStep",
                table: "Script",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdScript",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Script",
                table: "Script",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ListOfScripts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdScript = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfScripts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Script_NumberOfStep",
                table: "Script",
                column: "NumberOfStep",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListOfScripts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Script",
                table: "Script");

            migrationBuilder.DropIndex(
                name: "IX_Script_NumberOfStep",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "IdScript",
                table: "Script");

            migrationBuilder.RenameColumn(
                name: "NumberOfStep",
                table: "Script",
                newName: "IdStep");

            migrationBuilder.AlterColumn<int>(
                name: "IdStep",
                table: "Script",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Script",
                table: "Script",
                column: "IdStep");
        }
    }
}
