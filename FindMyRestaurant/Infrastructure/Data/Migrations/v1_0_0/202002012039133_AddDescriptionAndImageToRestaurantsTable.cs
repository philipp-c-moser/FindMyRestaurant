namespace FindMyRestaurant.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDescriptionAndImageToRestaurantsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Description", c => c.String());
            AddColumn("dbo.Restaurants", "ImageName", c => c.String());
            Sql("UPDATE dbo.Restaurants SET ImageName = 'bjwm3z00g70vf2qwao3j.jpg'");

        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "ImageName");
            DropColumn("dbo.Restaurants", "Description");
        }
    }
}
