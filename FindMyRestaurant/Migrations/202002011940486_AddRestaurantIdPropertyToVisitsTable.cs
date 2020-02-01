namespace FindMyRestaurant.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestaurantIdPropertyToVisitsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Visits", "Restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Visits", new[] { "Restaurant_Id" });
            RenameColumn(table: "dbo.Visits", name: "Restaurant_Id", newName: "RestaurantId");
            AlterColumn("dbo.Visits", "RestaurantId", c => c.Int(nullable: false));
            CreateIndex("dbo.Visits", "RestaurantId");
            AddForeignKey("dbo.Visits", "RestaurantId", "dbo.Restaurants", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visits", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.Visits", new[] { "RestaurantId" });
            AlterColumn("dbo.Visits", "RestaurantId", c => c.Int());
            RenameColumn(table: "dbo.Visits", name: "RestaurantId", newName: "Restaurant_Id");
            CreateIndex("dbo.Visits", "Restaurant_Id");
            AddForeignKey("dbo.Visits", "Restaurant_Id", "dbo.Restaurants", "Id");
        }
    }
}
