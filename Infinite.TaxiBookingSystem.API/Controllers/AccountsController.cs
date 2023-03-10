using Infinite.TaxiBookingSystem.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infinite.TaxiBookingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _dbContext;
        

        public AccountsController(IConfiguration configuration, ApplicationDbContext dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            //user.Role = "Customer";
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("RegisterEmployee")]
        public async Task<IActionResult> RegisterEmployee(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            var currentUser = _dbContext.Users.FirstOrDefault(x => x.LoginID == login.LoginID && x.Password == login.Password);
            if (currentUser == null)
            {
                return NotFound("Invalid LoginID  or  Password");
            }
            var token = GenerateToken(currentUser);
            if (token == null)
            {
                return NotFound("Invalid credentials");
            }
            
            
            return Ok(token);
        }
        [NonAction]
        public string GenerateToken(User user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secretkey"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha512);
            var myclaims = new List<Claim>
            {
                new Claim(ClaimTypes.Role,user.Role),
                new Claim(ClaimTypes.Name,user.LoginID),
                
            };
            var token = new JwtSecurityToken(issuer: _configuration["JWT:issuer"],
                                            
                                            claims: myclaims, expires: DateTime.Now.AddDays(1),
                                            signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        [HttpGet("GetName")]
        public IActionResult GetName()
        {
            var login = User.FindFirstValue(ClaimTypes.Name);
            return Ok(login);
        }

        [HttpGet("GetRole")]
        public IActionResult GetRole()
        {
            var Role = User.FindFirstValue(ClaimTypes.Role);
            return Ok(Role);
        }

    }
}
