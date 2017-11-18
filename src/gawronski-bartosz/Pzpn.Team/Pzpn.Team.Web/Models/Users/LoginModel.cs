using System.ComponentModel.DataAnnotations;

namespace Pzpn.Team.Web.Models.Users
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Login jest wymagany")]
        [EmailAddress(ErrorMessage = "Login nusi być iepoprawnym adresem email")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Hasło jest wymagane")]
        public string Password { get; set; }

        public bool LoginFailed { get; set; }
    }
}