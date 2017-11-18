using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pzpn.Team.Web.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Login jest wymagane")]
        [DataType(DataType.EmailAddress, ErrorMessage = "nie poprawny email")]
        public string Login { get; set; }

        [DataType(DataType.Password, ErrorMessage = "niepoprawne hasło")]
        [Required(ErrorMessage = "Hasło jest wymagane")]
        [MinLength(6, ErrorMessage = "Minimum 6 znaków")]
        public string Password { get; set; }
    }
}