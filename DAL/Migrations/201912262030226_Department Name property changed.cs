namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentNamepropertychanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DepartmentName", c => c.String());
            DropColumn("dbo.Departments", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Name", c => c.String());
            DropColumn("dbo.Departments", "DepartmentName");
        }
    }
}
