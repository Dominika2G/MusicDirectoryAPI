using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MusicDirectoryAPI.DAL;
using MusicDirectoryAPI.Models.Tracks;
using System.Collections.Generic;
using System.Linq;

namespace MusicDirectoryAPI.Controllers.Tracks
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;


        #region Constructor
        public TrackController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        #endregion

        #region GetTracks
        [HttpGet("{id}")]
        [Authorize]
        //GET: api/Track/{id}
        public ActionResult<IEnumerable<Track>> Get(int id)
        {
            return _databaseContext.Tracks.Where(x => x.AlbumId == id).ToList();
        }
        #endregion 
    }
}
