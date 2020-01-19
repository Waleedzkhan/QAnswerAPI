using Microsoft.EntityFrameworkCore.Migrations;

namespace QAnswerAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Body = table.Column<string>(nullable: true),
                    Accepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Accepted", "Body" },
                values: new object[] { 1L, true, "Test1" });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Accepted", "Body" },
                values: new object[] { 2L, false, "Test2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");
        }
    }
}
