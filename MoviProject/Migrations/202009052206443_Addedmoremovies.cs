namespace MoviProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedmoremovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES ('Me Before You',4,'2016-06-12','2016-08-14',40)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES ('Avatar',1,'2009-12-23','2010-02-28',50)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES ('The Secret Life of Pets',5,'2018-05-29','2018-07-28',47)");
            Sql("INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) VALUES ('Charlie and the Chocolate Factory',3,'2005-07-14','2005-09-28',39)");
        }
        
        public override void Down()
        {
        }
    }
}
