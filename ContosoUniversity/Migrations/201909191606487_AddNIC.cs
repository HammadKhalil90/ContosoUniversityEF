namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNIC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "NIC", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "NIC");
        }
    }
}
