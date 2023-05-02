using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class _020523 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListOfScripts");

            migrationBuilder.DropIndex(
                name: "IX_Script_NumberOfStep",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "IdActivity",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "IdBackground",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "IdBlocks",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "IdScript",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "NumberOfStep",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "ObjectId",
                table: "Activity");

            migrationBuilder.RenameColumn(
                name: "IdObject",
                table: "ObjectCast",
                newName: "IdObjectSpent");

            migrationBuilder.RenameColumn(
                name: "CastName",
                table: "CastTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "IdBackground",
                table: "Block",
                newName: "IdScript");

            migrationBuilder.RenameColumn(
                name: "NumberOfZoom",
                table: "Activity",
                newName: "IdBackground");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Script",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Script",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ObjectCast",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdActivity",
                table: "ObjectCast",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdBlock",
                table: "ObjectCast",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdObjectRecive",
                table: "ObjectCast",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Access",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Access", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessLevelId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Access",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "Reader" }
                });

            migrationBuilder.InsertData(
                table: "ActivityType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Zoom" },
                    { 2, "", "Hidden object" },
                    { 3, "", "Dialog" },
                    { 4, "", "Mini-game" }
                });

            migrationBuilder.InsertData(
                table: "Script",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "First scenario" },
                    { 2, "Same as first, but coller!", "Second scenario" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessLevelId", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 1, "dev", "123" },
                    { 2, 2, "reader", "123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Access");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ActivityType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Script",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Script");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ObjectCast");

            migrationBuilder.DropColumn(
                name: "IdActivity",
                table: "ObjectCast");

            migrationBuilder.DropColumn(
                name: "IdBlock",
                table: "ObjectCast");

            migrationBuilder.DropColumn(
                name: "IdObjectRecive",
                table: "ObjectCast");

            migrationBuilder.RenameColumn(
                name: "IdObjectSpent",
                table: "ObjectCast",
                newName: "IdObject");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CastTypes",
                newName: "CastName");

            migrationBuilder.RenameColumn(
                name: "IdScript",
                table: "Block",
                newName: "IdBackground");

            migrationBuilder.RenameColumn(
                name: "IdBackground",
                table: "Activity",
                newName: "NumberOfZoom");

            migrationBuilder.AddColumn<int>(
                name: "IdActivity",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdBackground",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdBlocks",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdScript",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfStep",
                table: "Script",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ObjectId",
                table: "Activity",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListOfScripts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdScript = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
