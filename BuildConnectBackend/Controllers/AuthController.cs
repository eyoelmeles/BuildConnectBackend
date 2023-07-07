﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BuildConnectBackend.Context;
using BuildConnectBackend.DTO;
using BuildConnectBackend.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BuildConnectBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly BuildConnectContext _context;

    public AuthController(BuildConnectContext context)
    {
        _context = context;
    }
    [HttpPost]
    public string CreateToken(User user)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this_is_really_reall_long_big_black_furry_keyboard_cat"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var issuer = "https://localhost:7172";
        var audience = "https://localhost:7172";
        var jwtValidity = DateTime.Now.AddMinutes(10);

        var token = new JwtSecurityToken(issuer, audience, new List<Claim>() {
            new Claim("Id", user.id.ToString()),
            new Claim("UserName", user.user_name.ToString()),
        }, expires: jwtValidity, signingCredentials: creds);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    [HttpPost("/Login")]
    public async Task<ActionResult<string>> Login(Credentials UserData)
    {
        var foundUser = await _context.Users.Where(u => u.user_name == UserData.Username).FirstOrDefaultAsync();
        if (foundUser == null)
        {
            return NotFound(new { message = "User not found" });
        }
        bool valid = BCrypt.Net.BCrypt.Verify(UserData.Password, foundUser.password);
        if (valid)
        {
            return Ok(new { token = CreateToken(foundUser) });
        }

        return BadRequest(new { message = "Not Authorized" });
    }
}

