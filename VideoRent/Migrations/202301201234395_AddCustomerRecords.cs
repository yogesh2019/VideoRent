namespace VideoRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerRecords : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers( Name, IsSubscribedToNewLetter, MembershipTypeId) VALUES( 'John Smith', 0, 1)");
            Sql("INSERT INTO Customers( Name, IsSubscribedToNewLetter, MembershipTypeId) VALUES( 'Mary Smith', 1, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
