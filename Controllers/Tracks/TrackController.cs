using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicDirectoryAPI.DAL;
using MusicDirectoryAPI.Models.Tracks;
using MusicDirectoryAPI.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDirectoryAPI.Controllers.Tracks
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private UserManager<UserExtension> _userManager;
        private DatabaseContext _databaseContext;


        #region Constructor
        public TrackController(UserManager<UserExtension> userManager, DatabaseContext databaseContext)
        {
            _userManager = userManager;
            _databaseContext = databaseContext;
        }
        #endregion

        [HttpGet("{id}")]
        //[Authorize]
        public ActionResult<IEnumerable<Track>> Get(int id)
        {
            //var id = 1;
            return _databaseContext.Tracks.Where(x => x.AlbumId == id).ToList();
        }

    }
}
