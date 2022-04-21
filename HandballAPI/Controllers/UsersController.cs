using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HandballAPI.Data;
using HandballAPI.Model;
using HandballAPI.DataAccessUI;

namespace HandballAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersDataAccess dataAccess;

        public UsersController(IUsersDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(dataAccess.GetUsers());
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<User>> GetById(int userId)
        {
            var user = dataAccess.GetUserById(userId);

            if (user == null)
                return NotFound("User not found");

            return Ok(dataAccess.GetUsers());
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            dataAccess.AddUser(user);

            return Ok(dataAccess.GetUsers());
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User u)
        {
            var user = dataAccess.GetUserById(u.UserId);

            if (user == null)
                return NotFound("User not found");

            dataAccess.UpdateUser(u);

            return Ok(dataAccess.GetUsers());
        }

        [HttpDelete("{userId}")]
        public async Task<ActionResult<List<User>>> Delete(int userId)
        {
            var user = dataAccess.GetUserById(userId);

            if (user == null)
                return NotFound("User not found");

            dataAccess.DeleteUser(userId);

            return Ok(dataAccess.GetUsers());
        }
    }
}
