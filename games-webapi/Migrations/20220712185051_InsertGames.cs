using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace games_webapi.Migrations
{
    public partial class InsertGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
                "VALUES('Call of Duty: Modern Warfare', 2019, 1)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
                "VALUES('Call of Duty: Modern Warfare 2', 2009, 1)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
                "VALUES('Call of Duty: Modern Warfare Remastered', 2016, 1)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
                "VALUES('Cuphead', 2017, 11)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
                "VALUES('Donkey Kong Country', 1994, 7)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
                "VALUES('Donkey Kong Country 2: Diddys Kong Quest', 1995, 7)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Donkey Kong Country 3: Dixie Kongs Double Trouble!', 1996, 7)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Grand Theft Auto: San Andreas', 2004, 9)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Grand Theft Auto: Vice City', 2002, 9)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Grand Theft Auto III', 2001, 9)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Grand Theft Auto V', 2013, 9)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('God of War', 2005, 10)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('God of War', 2018, 10)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('God of War 2', 2007, 10)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('God of War 3', 2010, 10)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('GoldenEye 007', 1997, 7)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Outlast', 2013, 8)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Outlast 2', 2017, 8)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Resident Evil 3: Nemesis', 1999, 2)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Resident Evil 4', 2005, 2)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Spider-Man', 2018, 3)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Super Mario 64', 1996, 6)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Super Mario World', 1990, 6)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('The Last of Us', 2013, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('The Last of Us Part II', 2020, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Uncharted: Drakes Fortune', 2007, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Uncharted: The Lost Legacy', 2017, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Uncharted 2: Among Thieves', 2009, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Uncarted 3: Drakes Deception', 2011, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Uncharted 4: A Thiefs End', 2016, 5)");
            migrationBuilder.Sql("INSERT INTO games(Name, Year, DeveloperId) " +
               "VALUES('Ultimate Mortal Kombat 3', 1995, 4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM games");
        }
    }
}
