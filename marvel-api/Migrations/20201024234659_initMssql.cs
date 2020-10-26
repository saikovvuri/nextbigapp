using Microsoft.EntityFrameworkCore.Migrations;

namespace marvel_api.Migrations
{
    public partial class initMssql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "FirstName", "LastName", "Status" },
                values: new object[,]
                {
                    { 1, "Anthony", "Stark", "Deceased" },
                    { 2, "Steven", "Rogers", "Alive" },
                    { 3, "Peter", "Quill", "Alive" },
                    { 4, "Thor", "Odinson", "Alive" },
                    { 5, "Natalia", "Romanoff", "Deceased" },
                    { 6, "T'Challa", null, "Alive" },
                    { 7, "Bruce", "Banner", "Alive" },
                    { 8, "Scott", "Lang", "Alive" },
                    { 9, "Phillip", "Coulson", "Deceased" },
                    { 10, "Nick", "Fury", "Alive" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
