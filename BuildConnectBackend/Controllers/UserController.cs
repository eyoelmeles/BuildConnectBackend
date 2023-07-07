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
                Id = user.id,
                UserName = user.user_name,
                CreatedAt = user.created_at,
                UpdatedAt = user.update_at,
            }));
        }
        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateUser(User user)
        {
            user.password = BCrypt.Net.BCrypt.HashPassword(user.password);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(new UserDTO()
            {
                Id = user.id,
                UserName = user.user_name,
                CreatedAt = user.created_at,
                UpdatedAt = user.update_at,
            });
        }
    }
}