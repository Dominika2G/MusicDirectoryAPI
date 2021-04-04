using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicDirectoryAPI.DAL;
using MusicDirectoryAPI.Models.Albums;
using MusicDirectoryAPI.Models.Messages;
using MusicDirectoryAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Controllers.Albums
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumReadController : ControllerBase
    {
        //string userId = User.Claims.First(c => c.Type == "UserID").Value;
        //var user = await _userManager.FindByIdAsync(userId);
        private UserManager<UserExtension> _userManager;
        private DatabaseContext _databaseContext;


        #region Constructor
        public AlbumReadController(UserManager<UserExtension> userManager, DatabaseContext databaseContext)
        {
            _userManager = userManager;
            _databaseContext = databaseContext;
        }
        #endregion

        #region GetAlbums
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Album>> GetAlbums(){
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            return _databaseContext.Albums.Where(x => x.ProviderId == userId).ToList();
         } 
        /*public async Task<ActionResult<Object>> GetAlbums()
        {
            
            //string userId = null;
            string userId = "59e76131-c773-40a8-b705-8ab58ddbc9f3";
            //string userId = User.Claims.First(c => c.Type == "UserID").Value;
            if (userId == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "500", Message = "Id is not exist" });
            }
            var user = await _userManager.FindByIdAsync(userId);
            if(user == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "500", Message = "User is not exist" });
            }

            var Albums =  _databaseContext.Albums.Where(x => x.ProviderId == userId).ToList();
            return Ok(Albums);
        }*/
       /* public async Task<Object> GetAlbums()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            //string userId = "59e76131-c773-40a8-b705-8ab58ddbc9f3";
            var user = await _userManager.FindByIdAsync(userId);

            return new
            {
                user.UserName,
                user.Email,
                userId
            };
            //return Ok(_databaseContext.Albums.Where(x => x.ProviderId == userId).ToList());
        }*/
        #endregion
    }
}
