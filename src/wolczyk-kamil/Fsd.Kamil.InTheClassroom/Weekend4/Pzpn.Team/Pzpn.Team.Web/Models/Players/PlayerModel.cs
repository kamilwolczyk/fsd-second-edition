using System.ComponentModel.DataAnnotations;

namespace Pzpn.Team.Web.Models.Players
{
    public class PlayerModel
    {
        [Required(ErrorMessage ="Imię jest wymagane")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Number { get; set; }
    }
}