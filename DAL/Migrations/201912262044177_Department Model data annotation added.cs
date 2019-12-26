namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentModeldataannotationadded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Code", c => c.String(nullable: false, maxLength: 7));
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
            AlterColumn("dbo.Departments", "Code", c => c.String());
        }
    }
}
