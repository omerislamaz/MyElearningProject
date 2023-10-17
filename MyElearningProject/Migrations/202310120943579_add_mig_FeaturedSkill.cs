namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_FeaturedSkill : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FeatureSkills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Comment = c.String(),
                        IconUrl = c.String(),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FeatureSkills");
        }
    }
}
