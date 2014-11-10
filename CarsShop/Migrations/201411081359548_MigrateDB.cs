namespace CarsShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pictures", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pictures", "Image");
        }
    }
}
