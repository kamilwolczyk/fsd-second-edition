using Pzpn.Team.Domain.Api.Entities;
using Pzpn.Team.Web.Models.Users;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Pzpn.Team.Web.Controllers.Api
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {
        public List<User> Users { get; set; }

        public UsersController()
        {
            Users = new List<User>
            {
                new User(){Id = 1, Email = "jan@kowalski.com", Password="króliczek"},
                new User(){Id = 2, Email = "maria@gmail.com", Password="123456"},
                new User(){Id = 3, Email = "stefan@gmail.com", Password="qwerty"},
            };
        }

        [Route("")]
        public IHttpActionResult GetAllUsers()
        {
            return  Ok(Users);
        }

        [Route("id/{id}")]
        public IHttpActionResult GetById(int id)
        {
            if (id == 0)
                return BadRequest("Nie tym razem :)");

            return Ok(Users.FirstOrDefault(user=>user.Id == id));
        }

        [Route("email/{email}")]
        public User GetByEmail(string email)
        {
            return Users.FirstOrDefault(user => user.Email == email);
        }

        [HttpPost]
        [Route("")]
        public void CreateNewUser([FromBody]UserDto user)
        {
            Users.Add(new User()
            {
                Id = user.Id,
                Email = user.Email,
                Password = user.Password,
            });
        }
    }
}
