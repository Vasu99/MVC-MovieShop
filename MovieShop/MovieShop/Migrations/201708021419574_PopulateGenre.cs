namespace MovieShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (Id,Name) values(1,'Action')");
            Sql("insert into Genres (Id,Name) values(2,'Comedy')");
            Sql("insert into Genres (Id,Name) values(3,'Thriller')");
            Sql("insert into Genres (Id,Name) values(4,'Romantic')");
            Sql("insert into Genres (Id,Name) values(5,'Horror')");
            Sql("insert into Genres (Id,Name) values(6,'Sci-fi')");
        }
        
        public override void Down()
        {
        }
    }
}
