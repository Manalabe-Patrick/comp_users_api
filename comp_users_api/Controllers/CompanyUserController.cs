using comp_users_api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp_users_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyUserController : Controller
    {
        private readonly CompanyUserDbContext _companyUserDbContext;

        public CompanyUserController(CompanyUserDbContext companyUserDbContext)
        {
            _companyUserDbContext = companyUserDbContext;
        }

        [HttpGet("{User}")]
        public async Task<IActionResult> GetCompanyUser(string User)
        {
            var companyUserDetails = await _companyUserDbContext.CompanyUser.Where(cu => cu.User == User).ToListAsync(); 

            if (companyUserDetails == null)
            {
                return NotFound();
            }

            return Ok(companyUserDetails);
        }
    }
}
