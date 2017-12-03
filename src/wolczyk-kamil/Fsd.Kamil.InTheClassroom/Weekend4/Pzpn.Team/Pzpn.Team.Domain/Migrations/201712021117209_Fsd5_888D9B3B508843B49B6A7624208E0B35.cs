namespace Pzpn.Team.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fsd5_888D9B3B508843B49B6A7624208E0B35 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FootballTeams", "CoachName", c => c.String());
            AddColumn("dbo.Players", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Age");
            DropColumn("dbo.FootballTeams", "CoachName");
        }
    }
}
