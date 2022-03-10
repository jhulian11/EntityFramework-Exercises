namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveVideo_IdColumnFromGenresTables : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropColumn("dbo.Videos", "Genre_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Videos", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
