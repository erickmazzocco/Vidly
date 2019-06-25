namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0804c9f1-f060-4a94-aa84-dd8b98360409', N'erickmazzocco@gmail.com', 0, N'AFWBXVe+B+BZ8P7X9QNMXnU9gLH0B5/7FAp8b8SMJAhmbUBZ6ptST2m/0sLR57B51A==', N'5f6d6d8a-9172-4e2a-be4d-9e32ffe128fd', NULL, 0, 0, NULL, 1, 0, N'erickmazzocco@gmail.com')                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6001f5d6-3727-4dc9-ab7c-bacd49b12903', N'admin@vidly.com', 0, N'AEXYeLGM6J6qbU9adKZqFoCp87fiFLRMb06+mQ/Oms1NrBg5AoISdFE7jZTP9rMI+g==', N'7e99512d-993e-4ee8-9f05-e9d9f125a4f8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5e78e31c-802a-4582-8aed-0c31d1280555', N'CanManageMovies')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6001f5d6-3727-4dc9-ab7c-bacd49b12903', N'5e78e31c-802a-4582-8aed-0c31d1280555')");
        }
        
        public override void Down()
        {
        }
    }
}
