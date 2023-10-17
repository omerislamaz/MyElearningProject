namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_categroy1_divclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "divclass", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "divclass");
        }
    }
}
