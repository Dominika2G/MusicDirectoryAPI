using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicDirectoryAPI.DAL;
using MusicDirectoryAPI.Models.Albums;
using MusicDirectoryAPI.Models.Users;
using System.Collections.Generic;
using System.Linq;

namespace MusicDirectoryAPI.Controllers.Albums
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumReadController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;


        #region Constructor
        public AlbumReadController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        #endregion

        #region GetAlbums
        [HttpGet]
        [Authorize]
        //POST: api/AlbumRead
        public ActionResult<IEnumerable<Album>> GetAlbums()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
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
