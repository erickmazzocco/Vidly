namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyCustomerName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Custumers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Custumers", "Name", c => c.String());
        }
    }
}
