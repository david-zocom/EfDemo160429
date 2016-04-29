namespace DemoConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedcourses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "CurrentCourse_Id", c => c.Int());
            CreateIndex("dbo.Students", "CurrentCourse_Id");
            AddForeignKey("dbo.Students", "CurrentCourse_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CurrentCourse_Id", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CurrentCourse_Id" });
            DropColumn("dbo.Students", "CurrentCourse_Id");
            DropTable("dbo.Courses");
        }
    }
}
