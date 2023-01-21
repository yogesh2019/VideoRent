namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthDateRecords : DbMigration
    {
        public override void Up()

        {
            Sql("update Customers  set BirthDate = '2023-01-01' where id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
