namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataCustumersAndMembership : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name = 'Pay as You Go' where Id = 1");
            Sql("UPDATE MembershipTypes set Name = 'Monthy' where Id = 2");
            Sql("UPDATE MembershipTypes set Name = 'Weekly' where Id = 3");
            Sql("UPDATE MembershipTypes set Name = 'Membership' where Id = 4");

            Sql("INSERT INTO Custumers VALUES ('Érick', 1, 1)");
            Sql("INSERT INTO Custumers VALUES ('Maria', 1, 2)");
            Sql("INSERT INTO Custumers VALUES ('Xuxu', 1, 3)");
            Sql("INSERT INTO Custumers VALUES ('Pacoca', 0, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
