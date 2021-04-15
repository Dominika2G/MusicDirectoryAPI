using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MusicDirectoryAPI.Models.Messages;
using MusicDirectoryAPI.Models.Settings;
using MusicDirectoryAPI.Models.Users;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private UserManager<UserExtension> _userManager;
        private readonly JWTSettings _appSettings;

        #region Constructor
        public LoginController(UserManager<UserExtension> userManager, IOptions<JWTSettings> appSettings)
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
        }
        #endregion

        #region Login
        [HttpPost]
        //POST: api/Login
        public async Task<IActionResult> PostLogin(UserLoginModel model)
        {
            var currentUser = await _userManager.FindByNameAsync(model.UserName);

            if (currentUser != null && await _userManager.CheckPasswordAsync(currentUser, model.Password))
            {

                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                        new Claim("UserID", currentUser.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT)), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescription);
                var token = tokenHandler.WriteToken(securityToken);

                return Ok(new { token });
            }
            else
            {
                return NotFound(new Response { Status = "Error", Message = "Password or login is incorrect" });
            }
        }
        #endregion
    }
}
