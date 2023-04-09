using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using comp_users_api.Data;
using Microsoft.EntityFrameworkCore;

namespace comp_users_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly CoreDbContext _userDbContext;

        public UserController(CoreDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userDbContext.User.ToListAsync();

            return Ok(users);
        }
    }
}
