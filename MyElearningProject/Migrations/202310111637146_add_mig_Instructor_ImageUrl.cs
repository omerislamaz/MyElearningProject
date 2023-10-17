namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_Instructor_ImageUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "ImageURl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "ImageURl");
        }
    }
}
