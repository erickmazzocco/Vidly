namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationinMounths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DurationinMounths", c => c.Byte(nullable: false));
            DropColumn("dbo.MembershipTypes", "DurationInMonths");
        }
    }
}
