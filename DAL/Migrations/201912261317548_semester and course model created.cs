namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class semesterandcoursemodelcreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Credit = c.Double(nullable: false),
                        Description = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        SemesterId = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SemesterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Semesters");
            DropTable("dbo.Courses");
        }
    }
}
