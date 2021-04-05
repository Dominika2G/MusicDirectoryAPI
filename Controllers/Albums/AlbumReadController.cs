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
        /*public  ActionResult<IEnumerable<Album>> GetAlbums(){
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            return _databaseContext.Albums.Where(x => x.ProviderId == userId).ToList();   
         } */
        public ActionResult<IEnumerable<Album>> GetAlbums()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            //var user = await _userManager.FindByIdAsync(userId);
            var list = _databaseContext.Albums.Where(x => x.ProviderId == userId);
            return Ok(list.Select(p => new
            {
                albumId = p.AlbumId,
                author = p.Author,
                provider = p.Provider.UserName,
                providerId = p.ProviderId,
                releaseData = p.ReleaseData,
                title = p.Title,
                version = p.Version
            }).ToList());
        }
        #endregion
    }
}
