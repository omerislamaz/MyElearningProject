namespace MyElearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_mig_video2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        VideoUrl = c.String(),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VideoID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
            AddColumn("dbo.Processes", "VideoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Processes", "VideoID");
            AddForeignKey("dbo.Processes", "VideoID", "dbo.Videos", "VideoID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Processes", "VideoID", "dbo.Videos");
            DropForeignKey("dbo.Videos", "CourseID", "dbo.Courses");
            DropIndex("dbo.Videos", new[] { "CourseID" });
            DropIndex("dbo.Processes", new[] { "VideoID" });
            DropColumn("dbo.Processes", "VideoID");
            DropTable("dbo.Videos");
        }
    }
}
