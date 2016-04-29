namespace DemoConsole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fluentapi1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Students", newName: "StudentTable");
            MoveTable(name: "dbo.Courses", newSchema: "school");
            MoveTable(name: "dbo.StudentTable", newSchema: "school");
        }
        
        public override void Down()
        {
            MoveTable(name: "school.StudentTable", newSchema: "dbo");
            MoveTable(name: "school.Courses", newSchema: "dbo");
            RenameTable(name: "dbo.StudentTable", newName: "Students");
        }
    }
}
