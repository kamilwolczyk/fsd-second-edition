namespace Pzpn.Team.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fsd5_E53E33480C904F04AA2C843D3E818B6B : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO FootballTeams(Name, CoachName) VALUES('Polska', 'Adam Nawa³ka')");
            Sql("INSERT INTO Players(FirstName, LastName, Number,Age, TeamId) VALUES('Robert','Lewandowski', 9, 29, 1)");
            Sql("INSERT INTO Players(FirstName, LastName, Number,Age, TeamId) VALUES('Kamil','Grosicki', 11, 32, 1)");
            Sql("INSERT INTO Players(FirstName, LastName, Number,Age, TeamId) VALUES('Kamil','Glik', 4, 24, 1)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Players");
            Sql("DELETE FROM FootballTeams WHERE Name='Polska'");
        }
    }
}
