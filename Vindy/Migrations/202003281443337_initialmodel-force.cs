namespace Vindy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmodelforce : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
