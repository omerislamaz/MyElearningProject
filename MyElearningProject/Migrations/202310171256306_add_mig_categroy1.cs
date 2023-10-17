namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_categroy1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImageURl", c => c.String());
            AddColumn("dbo.Categories", "CoursePieces", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CoursePieces");
            DropColumn("dbo.Categories", "ImageURl");
        }
    }
}
