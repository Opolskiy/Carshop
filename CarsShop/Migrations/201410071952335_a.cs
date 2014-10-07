namespace CarsShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Guid(nullable: false),
                        Mark = c.String(nullable: false),
                        Series = c.String(nullable: false),
                        BodyType = c.String(nullable: false),
                        FuelType = c.String(nullable: false),
                        Country = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Transmission = c.String(nullable: false),
                        Drive = c.String(nullable: false),
                        Color = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        Author = c.String(),
                        CountViews = c.Int(nullable: false),
                        Conditioner = c.Boolean(nullable: false),
                        LeatherSeats = c.Boolean(nullable: false),
                        HeatedSeats = c.Boolean(nullable: false),
                        Parktronic = c.Boolean(nullable: false),
                        Ksenon = c.Boolean(nullable: false),
                        Speakerphone = c.Boolean(nullable: false),
                        LegkosplavlennyeWheels = c.Boolean(nullable: false),
                        ESP = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CarId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PicId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
           
        }
        
        public override void Down()
        {
            
            DropTable("dbo.Pictures");
            DropTable("dbo.Cars");
        }
    }
}
