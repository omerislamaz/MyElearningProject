namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_categroy1_divclass2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "divclassposition", c => c.String());
            AddColumn("dbo.Categories", "wowdelay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "wowdelay");
            DropColumn("dbo.Categories", "divclassposition");
        }
    }
}
