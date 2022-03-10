namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Science')");
            Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (Name) VALUES ('RPG')");
            Sql("INSERT INTO Genres (Name) VALUES ('Terror')");
            Sql("INSERT INTO Genres (Name) VALUES ('Shounen')");
            Sql("INSERT INTO Genres (Name) VALUES ('Isekai')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name = 'Action'");
            Sql("DELETE FROM Genres WHERE Name = 'Romance'");
            Sql("DELETE FROM Genres WHERE Name = 'Science'");
            Sql("DELETE FROM Genres WHERE Name = 'Adventure'");
            Sql("DELETE FROM Genres WHERE Name = 'RPG'");
            Sql("DELETE FROM Genres WHERE Name = 'Terror'");
            Sql("DELETE FROM Genres WHERE Name = 'Shounen'");
            Sql("DELETE FROM Genres WHERE Name = 'Isekai'");
        }
    }
}
