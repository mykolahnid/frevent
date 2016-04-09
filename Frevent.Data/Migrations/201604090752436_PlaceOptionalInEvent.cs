namespace Frevent.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlaceOptionalInEvent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "PlaceID", "dbo.Places");
            DropIndex("dbo.Events", new[] { "PlaceID" });
            AlterColumn("dbo.Events", "PlaceID", c => c.Int());
            CreateIndex("dbo.Events", "PlaceID");
            AddForeignKey("dbo.Events", "PlaceID", "dbo.Places", "PlaceID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "PlaceID", "dbo.Places");
            DropIndex("dbo.Events", new[] { "PlaceID" });
            AlterColumn("dbo.Events", "PlaceID", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "PlaceID");
            AddForeignKey("dbo.Events", "PlaceID", "dbo.Places", "PlaceID", cascadeDelete: true);
        }
    }
}
