namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdmebeshipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationinMounths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Custumers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Custumers", "MembershipTypeId");
            AddForeignKey("dbo.Custumers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Custumers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Custumers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Custumers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
