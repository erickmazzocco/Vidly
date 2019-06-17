namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixname : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Custumers", newName: "Customers");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customers", newName: "Custumers");
        }
    }
}
