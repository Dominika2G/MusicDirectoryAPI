using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicDirectoryAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Controllers.Authentication
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private UserManager<UserExtension> _userManager;


        #region Constructor
        public RegisterController(UserManager<UserExtension> userManager)
        {
            _userManager = userManager;

        }

        #endregion Constructor

        #region Register

        [HttpPost]
        //POST: api/Register
        public async Task<Object> PostAuthentication(UserRegisterModel model)
        {
            var newUser = new UserExtension()
            {
                UserName = model.UserName,
                Email = model.Email
            };
            try
            {
                var result = await _userManager.CreateAsync(newUser, model.Password);
                return Ok(result);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Register
    }
}
