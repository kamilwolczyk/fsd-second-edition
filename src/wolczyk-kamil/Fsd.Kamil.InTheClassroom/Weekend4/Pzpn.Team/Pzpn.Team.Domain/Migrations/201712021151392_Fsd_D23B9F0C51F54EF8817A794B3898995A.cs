namespace Pzpn.Team.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fsd_D23B9F0C51F54EF8817A794B3898995A : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClubPlayers", "IsActual", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClubPlayers", "IsActual");
        }
    }
}
