namespace Pzpn.Team.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fsd5_362BA5C345FC4B979E57FC10E0499D6C : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FootballTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Number = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FootballTeams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "TeamId", "dbo.FootballTeams");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropTable("dbo.Players");
            DropTable("dbo.FootballTeams");
        }
    }
}
