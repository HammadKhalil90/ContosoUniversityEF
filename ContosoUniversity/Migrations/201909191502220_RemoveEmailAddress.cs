namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEmailAddress : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "EmailAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "EmailAddress", c => c.String());
        }
    }
}
