namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_AboutUS_Featureds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutUs",
                c => new
                    {
                        AboutUsID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Comment = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AboutUsID);
            
            CreateTable(
                "dbo.AboutUsFeatureds",
                c => new
                    {
                        FeaturedID = c.Int(nullable: false, identity: true),
                        FeaturedName = c.String(),
                    })
                .PrimaryKey(t => t.FeaturedID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AboutUsFeatureds");
            DropTable("dbo.AboutUs");
        }
    }
}
