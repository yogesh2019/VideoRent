namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthDateNull : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers ALTER COLUMN BirthDate Datetime null");
        }
        
        public override void Down()
        {
        }
    }
}
