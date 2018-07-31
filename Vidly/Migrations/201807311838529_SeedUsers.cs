namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'da4e0bc8-c72b-46c1-8a56-eead95225741', N'admin@vidly.com', 0, N'AOqgqfoDEqsJ3Oa/GBd9h6o3boJYSynMPpD5NhAHkuc9Sj/QRHAPmYSIxaR6vz2nqQ==', N'5ebb9dca-71a3-4a13-90f8-c1ceaa454e90', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e364a1fb-5981-4a45-a9c1-96828d05bbdb', N'guest@vidly.com', 0, N'AKwi2W6bmcy8cl+Eyy3ru754J7cZbZp8AsqswTXwAJ2lyIUZFCI4SZDdDNzfMmTrBw==', N'c6f00d33-e1f0-4afe-8a16-76ae26e1089d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'92db2554-f705-461f-909d-5c123bcf7f7b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'da4e0bc8-c72b-46c1-8a56-eead95225741', N'92db2554-f705-461f-909d-5c123bcf7f7b')
");
        }
        
        public override void Down()
        {
        }
    }
}
