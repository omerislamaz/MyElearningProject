namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_categroy1_divclass3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "divclassstyle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "divclassstyle");
        }
    }
}
