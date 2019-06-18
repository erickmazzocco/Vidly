namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requireDateTime : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Customers SET Birthdate = '2010-01-01' WHERE Birthdate is null");
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
        }
    }
}
