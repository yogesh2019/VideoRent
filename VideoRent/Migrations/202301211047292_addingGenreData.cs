namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("insert  into Genres (Name) values ('Comedy')");
            Sql("insert  into Genres (Name) values ('Action')");
            Sql("insert  into Genres (Name) values ('Romance')");
            Sql("insert  into Genres (Name) values ('Family')");
        }
        
        public override void Down()
        {
        }
    }
}
