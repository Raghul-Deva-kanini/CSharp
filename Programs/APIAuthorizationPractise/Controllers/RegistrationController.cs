using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAuthorizationPractise.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIAuthorizationPractise.Controllers
{
    //[Route("api/[Registration]")]
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly DataBaseContext _dataBaseContext;

        public RegistrationController(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        [HttpPost]
        [Route("Register")]
        public UserMaster AddUser(UserMaster obj)
        {
            _dataBaseContext.UserMasters.Add(obj);
            _dataBaseContext.SaveChanges();
            return obj;
        }

        [HttpPost]
        [Route("Login")]
        public LoginModel Login(LoginModel obj)
        {
            var isUserExist = _dataBaseContext.UserMasters.SingleOrDefault(m => m.UserName == obj.UserName && m.Password == obj.Password);
            if (isUserExist != null)
            {
                obj.UserId = isUserExist.UserId;
                obj.Result = true;
                obj.Message = "Login Success";
            }
            else
            {
                obj.Result = false;
                obj.Message = "UserName or Password is Wrong";

            }
            return obj;
        }
    }
}
