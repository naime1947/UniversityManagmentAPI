namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationsemesterchanged : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Semesters", "Code");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Semesters", "Code", c => c.String());
        }
    }
}
