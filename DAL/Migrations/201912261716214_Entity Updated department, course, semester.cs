namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityUpdateddepartmentcoursesemester : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Courses", "DepartmentId");
            CreateIndex("dbo.Courses", "SemesterId");
            AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters", "SemesterId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
        }
    }
}
