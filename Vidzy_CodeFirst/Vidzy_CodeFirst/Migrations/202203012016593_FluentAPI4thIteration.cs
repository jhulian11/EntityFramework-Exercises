namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentAPI4thIteration : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Videos", new[] { "Genreld_Id" });
            RenameColumn(table: "dbo.Videos", name: "Genreld_Id", newName: "Genreldd");
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Genreldd", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "Genreldd");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Videos", new[] { "Genreldd" });
            AlterColumn("dbo.Videos", "Genreldd", c => c.Int());
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            RenameColumn(table: "dbo.Videos", name: "Genreldd", newName: "Genreld_Id");
            CreateIndex("dbo.Videos", "Genreld_Id");
        }
    }
}
