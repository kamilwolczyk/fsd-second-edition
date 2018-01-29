namespace Pzpn.Team.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fsd5_18FD946917584B3EA33FA0E954C80D05 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClubPlayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FootballClubId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FootballClubs", t => t.FootballClubId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.FootballClubId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.FootballClubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClubPlayers", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.ClubPlayers", "FootballClubId", "dbo.FootballClubs");
            DropIndex("dbo.ClubPlayers", new[] { "PlayerId" });
            DropIndex("dbo.ClubPlayers", new[] { "FootballClubId" });
            DropTable("dbo.FootballClubs");
            DropTable("dbo.ClubPlayers");
        }
    }
}
