namespace MovieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'PayAsYouGo' where Id=1");
            Sql("Update MembershipTypes set Name = 'Quaternally' where Id=2");
            Sql("Update MembershipTypes set Name = 'Half Yearly' where Id=3");
            Sql("Update MembershipTypes set Name = 'Annual' where Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
