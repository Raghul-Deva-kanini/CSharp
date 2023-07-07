using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Models;
using SocialMedia.data;
using Microsoft.AspNetCore.Authorization;
using SocialMedia.Repositories.User_Services;

namespace SocialMedia.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>?>> GetUsers()
        {
            return Ok(await _userServices.GetUsers());
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>?> GetUsers(int id)
        {
            var user = await _userServices.GetUsers(id);
            if (user == null) return NotFound("User id not matching");
            return Ok(user);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<List<User>?> PutUser(int id, User user)
        {
           return await _userServices.PutUser(id, user);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            var users = await _userServices.PostUser(user);
            return Ok(users);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var users = await _userServices.DeleteUser(id);
            if (users == null)
            {
                return NotFound("User Id Not matching");
            }
            return Ok(users);
        }

        [HttpGet]
        [Route("GetPostDetails")]
        public IEnumerable<UserPost> GetPostDetails()
        {
            return _userServices.GetPostDetails().ToList();
        }

        [HttpGet]
        [Route("GetUserCount")]
        public int GetUserCount()
        {
            return _userServices.GetUserCount();
        }

    }
}
