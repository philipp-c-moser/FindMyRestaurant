namespace FindMyRestaurant.Infrastructure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RatedRatingCriterias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Comment = c.String(),
                        RatingDate = c.DateTime(nullable: false),
                        RatingId = c.Int(nullable: false),
                        RatingCriteriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ratings", t => t.RatingId, cascadeDelete: true)
                .ForeignKey("dbo.RatingCriterias", t => t.RatingCriteriaId, cascadeDelete: true)
                .Index(t => t.RatingId)
                .Index(t => t.RatingCriteriaId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RatingCriterias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RatedRatingCriterias", "RatingCriteriaId", "dbo.RatingCriterias");
            DropForeignKey("dbo.RatedRatingCriterias", "RatingId", "dbo.Ratings");
            DropIndex("dbo.RatedRatingCriterias", new[] { "RatingCriteriaId" });
            DropIndex("dbo.RatedRatingCriterias", new[] { "RatingId" });
            DropTable("dbo.RatingCriterias");
            DropTable("dbo.Ratings");
            DropTable("dbo.RatedRatingCriterias");
        }
    }
}
