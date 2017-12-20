using System.ComponentModel.DataAnnotations;

namespace Pzpn.Team.Web.Models.Players
{
    public class PlayerModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public uint Number { get; set; }
    }
}