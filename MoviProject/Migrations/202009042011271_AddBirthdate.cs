namespace MoviProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '2000-01-01' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
