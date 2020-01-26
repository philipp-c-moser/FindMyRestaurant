namespace FindMyRestaurant.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationBetweenRestaurantsAndRestaurantCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantRestaurantCategories",
                c => new
                    {
                        Restaurant_Id = c.Int(nullable: false),
                        RestaurantCategory_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Restaurant_Id, t.RestaurantCategory_Id })
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id, cascadeDelete: true)
                .ForeignKey("dbo.RestaurantCategories", t => t.RestaurantCategory_Id, cascadeDelete: true)
                .Index(t => t.Restaurant_Id)
                .Index(t => t.RestaurantCategory_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurantRestaurantCategories", "RestaurantCategory_Id", "dbo.RestaurantCategories");
            DropForeignKey("dbo.RestaurantRestaurantCategories", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.RestaurantRestaurantCategories", new[] { "RestaurantCategory_Id" });
            DropIndex("dbo.RestaurantRestaurantCategories", new[] { "Restaurant_Id" });
            DropTable("dbo.RestaurantRestaurantCategories");
        }
    }
}
