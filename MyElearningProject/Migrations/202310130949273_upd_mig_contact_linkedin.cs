namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upd_mig_contact_linkedin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses", "LinkedIn", c => c.String());
            DropColumn("dbo.Addresses", "Twitter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "Twitter", c => c.String());
            DropColumn("dbo.Addresses", "LinkedIn");
        }
    }
}
