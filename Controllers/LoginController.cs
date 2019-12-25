using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TouchAntenna.Context;
using TouchAntenna.LibraryFunctions;
using TouchAntenna.Models;

namespace TouchAntenna.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ApplicationDbContext _context;

        public LoginController(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }

        
        [Route("Login")]
        public IActionResult Login(string userid)
        {
            IActionResult response = Unauthorized();
            UserServices._config = _config;
            UserServices.DB = _context;
            string tokenStr = UserServices.AuthenticationUser(userid);
            if(tokenStr!=null)
            {
                response = Ok(new { token = tokenStr });
            }
            return response;
        }
    }
}