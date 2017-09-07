namespace MovieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'51447e44-6a12-4027-acde-0feb0aecab3b', N'admin@moviestore.com', 0, N'AGVGVdk0Qg/yZ2kx6pVnle4s9xLoCDGRkj+JdNY/Rds1Vr+od1XW78yddzP3zgaq6w==', N'29957d43-fde0-44ef-adf1-fba31d501723', NULL, 0, 0, NULL, 1, 0, N'admin@moviestore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'540823d9-8a5f-4dc8-8ace-f4f36638e463', N'guest@moviestore.com', 0, N'AM9todAgkHGj3euMWAVeRLLPvobHYK2Qk9N7ffs6/1U6QxVATEe+dd5AFCgo2P1hjg==', N'7a33adf2-b983-45ab-9398-56ed3ab164cc', NULL, 0, 0, NULL, 1, 0, N'guest@moviestore.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'422309e9-e9ea-4447-b678-ded05099a04f', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'51447e44-6a12-4027-acde-0feb0aecab3b', N'422309e9-e9ea-4447-b678-ded05099a04f')

");
        }
        
        public override void Down()
        {
        }
    }
}
