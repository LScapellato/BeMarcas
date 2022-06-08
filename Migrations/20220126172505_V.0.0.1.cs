using Microsoft.EntityFrameworkCore.Migrations;

namespace BeMarcas.Migrations
{
    public partial class V001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id_Marca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Den_marca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cmarca = table.Column<string>(type: "varchar(25)", nullable: false),
                    RegistroMca = table.Column<string>(type: "varchar(50)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(25)", nullable: false),
                    Viña = table.Column<string>(type: "varchar(50)", nullable: false),
                    FECHA_CARGA = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id_Marca);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
