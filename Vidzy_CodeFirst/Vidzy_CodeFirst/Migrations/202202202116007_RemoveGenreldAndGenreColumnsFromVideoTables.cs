namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveGenreldAndGenreColumnsFromVideoTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Genres", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.Videos", "Genreld_Id", "dbo.Genres");
            DropIndex("dbo.Genres", new[] { "Video_Id" });
            DropIndex("dbo.Videos", new[] { "Genreld_Id" });
            DropColumn("dbo.Genres", "Video_Id");
            DropColumn("dbo.Videos", "Genreld_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "Genreld_Id", c => c.Int());
            AddColumn("dbo.Genres", "Video_Id", c => c.Int());
            CreateIndex("dbo.Videos", "Genreld_Id");
            CreateIndex("dbo.Genres", "Video_Id");
            AddForeignKey("dbo.Videos", "Genreld_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Genres", "Video_Id", "dbo.Videos", "Id");
        }
    }
}
