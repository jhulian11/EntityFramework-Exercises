namespace Vidzy_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingClassificationColumnInVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "Classification");
        }
    }
}
