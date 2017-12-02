using Pzpn.Team.Domain.Api.Entities;
using System.Data.Entity;

namespace Pzpn.Team.Domain.Ef
{
    public class PzpnDbContext : DbContext
    {
        public PzpnDbContext() : base("name=PzpnDbContext")
        {
        }

        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<FootballTeam> FootballTeams { get; set; }
    }
}