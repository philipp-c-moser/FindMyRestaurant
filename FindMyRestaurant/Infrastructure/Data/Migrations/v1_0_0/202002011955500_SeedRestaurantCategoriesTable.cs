namespace FindMyRestaurant.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRestaurantCategoriesTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO [dbo].[RestaurantCategories] ([Name]) VALUES (N'Gourmet')");
            Sql("INSERT INTO [dbo].[RestaurantCategories] ([Name]) VALUES (N'Pizzeria')");
            Sql("INSERT INTO [dbo].[RestaurantCategories] ([Name]) VALUES (N'Steakhose')");
            Sql("INSERT INTO [dbo].[RestaurantCategories] ([Name]) VALUES (N'Burger')");
            Sql("INSERT INTO [dbo].[RestaurantCategories] ([Name]) VALUES (N'Fast-Food')");

        }

        public override void Down()
        {
        }
    }
}
