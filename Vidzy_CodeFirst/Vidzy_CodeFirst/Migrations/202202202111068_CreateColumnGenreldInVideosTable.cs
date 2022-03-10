namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumnGenreldInVideosTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.VideoGenres", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.VideoGenres", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.VideoGenres", new[] { "Video_Id" });
            DropIndex("dbo.VideoGenres", new[] { "Genre_Id" });
            AddColumn("dbo.Genres", "Video_Id", c => c.Int());
            AddColumn("dbo.Videos", "Genreld_Id", c => c.Int());
            AddColumn("dbo.Videos", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Genres", "Video_Id");
            CreateIndex("dbo.Videos", "Genreld_Id");
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Genres", "Video_Id", "dbo.Videos", "Id");
            AddForeignKey("dbo.Videos", "Genreld_Id", "dbo.Genres", "Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
            DropTable("dbo.VideoGenres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        Video_Id = c.Int(nullable: false),
                        Genre_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Video_Id, t.Genre_Id });
            
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Videos", "Genreld_Id", "dbo.Genres");
            DropForeignKey("dbo.Genres", "Video_Id", "dbo.Videos");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropIndex("dbo.Videos", new[] { "Genreld_Id" });
            DropIndex("dbo.Genres", new[] { "Video_Id" });
            DropColumn("dbo.Videos", "Genre_Id");
            DropColumn("dbo.Videos", "Genreld_Id");
            DropColumn("dbo.Genres", "Video_Id");
            CreateIndex("dbo.VideoGenres", "Genre_Id");
            CreateIndex("dbo.VideoGenres", "Video_Id");
            AddForeignKey("dbo.VideoGenres", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.VideoGenres", "Video_Id", "dbo.Videos", "Id", cascadeDelete: true);
        }
    }
}
