using System.Data.Entity.Migrations.Model;

namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Custumers", "Birthdate", c => c.DateTime());

            Sql("UPDATE dbo.Custumers set Birthdate = '1995-01-30' where id = 1");
            Sql("UPDATE dbo.Custumers set Birthdate = '2019-06-16' where id = 2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Custumers", "Birthdate");
        }
    }
}
