using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace games_webapi.Migrations
{
    public partial class InsertDevelopers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Activision')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Capcom')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Insomniac Games')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Midway Games')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Naughty Dog')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Nintendo')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Rare')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Red Barrels Studio')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Rockstar')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Santa Monica Studio')");
            migrationBuilder.Sql("INSERT INTO developers(Name) VALUES ('Studio MDHR')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM developers");
        }
    }
}
