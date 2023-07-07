using JWTAuthenticationApp.Models.DTO;
using JWTAuthenticationApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleBasedAuthorization.Data;
using RoleBasedAuthorization.Models;
using System.Data;

namespace RoleBasedAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AngularCORS")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        private readonly RoleBasedAuthorizationDbContext _filtercontext;
            public UserController(UserService service, RoleBasedAuthorizationDbContext filtercontext)
            {
                _service = service;
                _filtercontext = filtercontext;
            }
            [HttpPost("Register")]
            public ActionResult<UserDTO> Register([FromBody] UserRegisterDTO userDTO)
            {
                var user = _service.Register(userDTO);
                if (user == null)
                {
                    return BadRequest("Unable to register");
                }
                return Created("Home", user);
            }
            [HttpPost("Login")]
            public ActionResult<UserDTO> Login([FromBody] UserDTO userDTO)
            {
                var user = _service.Login(userDTO);
                if (user == null)
                {
                    return BadRequest("Invalid username or password");
                }
            return Ok(user);
        }

        [HttpGet]
        
        public async Task<ActionResult<List<User>?>> GettDoctor()
        {
            return await _service.GettDoctor();
        }

        [HttpGet("Patients")]
        public async Task<ActionResult<List<User>?>> GetPatient()
        {
            return await _service.GetPatient();
        }

        [HttpDelete("{id}")]
        
        public async Task<ActionResult<List<User>>> DeleteStaff(string id)
        {
            var staff = await _service.DeleteStaff(id);

            if (staff == null)
            {
                return NotFound("Staff id not matching");
            }
            return Ok(staff);
        }

        [HttpGet("filter")]
        public ActionResult<IEnumerable<User>> FilterDoctors(string Specialization)
        {
            try
            {
                var doctors = _filtercontext.Users.Where(d => d.Specialization == Specialization).ToList();

                if (doctors.Count == 0)
                {
                    return NotFound("No doctors found with the specified specialization.");
                }

                return Ok(doctors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
