namespace CarsShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableCooments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Guid(nullable: false),
                        CarId = c.Guid(nullable: false),
                        Author = c.String(),
                        Date = c.DateTime(nullable: false),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.CommentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Comments");
        }
    }
}
