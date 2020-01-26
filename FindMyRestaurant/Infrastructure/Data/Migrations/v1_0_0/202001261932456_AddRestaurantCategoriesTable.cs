namespace FindMyRestaurant.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestaurantCategoriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RestaurantCategories");
        }
    }
}
