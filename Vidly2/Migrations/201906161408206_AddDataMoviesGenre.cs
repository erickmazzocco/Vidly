namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataMoviesGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres Values (1, 'Action')");
            Sql("INSERT INTO Genres Values (2, 'Comedy')");
            Sql("INSERT INTO Genres Values (3, 'Horror')");
            Sql("INSERT INTO Genres Values (4, 'The Witcher 3')");

            Sql("INSERT INTO Movies VALUES ('Avengers 3', '2018-10-10', '2019-06-16', 5, 1)");
            Sql("INSERT INTO Movies VALUES ('Love song', '2018-05-10', '2019-06-16', 10, 2)");
            Sql("INSERT INTO Movies VALUES ('Jason', '2018-10-10', '2019-06-16', 5, 3)");
            Sql("INSERT INTO Movies VALUES ('The fucking witcher 3', '2018-10-02', '2019-10-05', 5, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
