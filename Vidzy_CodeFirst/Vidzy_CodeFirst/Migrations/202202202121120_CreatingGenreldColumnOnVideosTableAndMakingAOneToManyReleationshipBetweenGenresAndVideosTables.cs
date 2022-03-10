namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingGenreldColumnOnVideosTableAndMakingAOneToManyReleationshipBetweenGenresAndVideosTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Genreld_Id", c => c.Int());
            CreateIndex("dbo.Videos", "Genreld_Id");
            AddForeignKey("dbo.Videos", "Genreld_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genreld_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genreld_Id" });
            DropColumn("dbo.Videos", "Genreld_Id");
        }
    }
}
