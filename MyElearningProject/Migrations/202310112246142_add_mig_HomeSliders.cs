namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_HomeSliders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HomeSliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        Slogan = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HomeSliders");
        }
    }
}
