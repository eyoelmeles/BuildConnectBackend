using BuildConnectBackend.Context;
using BuildConnectBackend.DTO;
using BuildConnectBackend.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RecipesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly BuildConnectContext _context;
        public UserController(BuildConnectContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            List<User> users = await _context.Users.ToListAsync();
            return Ok(users.Select(user => new UserDTO()
            {
                Id = user.Id,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                ImageUrl = user.ImageURL,
            }));
        }
        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser(User user)
        {
            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(new UserDTO()
            {
                Id = user.Id,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                ImageUrl = user.ImageURL,
            });
        }
    }
}