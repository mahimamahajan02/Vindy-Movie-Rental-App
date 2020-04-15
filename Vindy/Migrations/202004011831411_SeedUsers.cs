namespace Vindy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7560f628-00ff-4599-bb87-5369befabacf', N'mahima_mahajan97@yahoo.co.in', 0, N'ACVGmVPyejtSyCpIfUCn1SAxJjfB0BhrtXIGIbkimbpccbcNJWYOkQftgvuCL7gB1w==', N'ef83d48a-f907-4e1f-a729-d6e8c6944e3e', NULL, 0, 0, NULL, 1, 0, N'mahima_mahajan97@yahoo.co.in')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df696c9b-fa26-4f46-b2b1-ad753ea50361', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7560f628-00ff-4599-bb87-5369befabacf', N'df696c9b-fa26-4f46-b2b1-ad753ea50361')
");
           
        }
        
        public override void Down()
        {
        }
    }
}
