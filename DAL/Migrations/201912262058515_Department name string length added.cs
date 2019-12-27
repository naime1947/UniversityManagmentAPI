 namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Departmentnamestringlengthadded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Departments", "Code", unique: true);
            CreateIndex("dbo.Departments", "DepartmentName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Departments", new[] { "DepartmentName" });
            DropIndex("dbo.Departments", new[] { "Code" });
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
        }
    }
}
