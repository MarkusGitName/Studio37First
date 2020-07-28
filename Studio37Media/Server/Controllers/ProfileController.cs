using Studio37Media.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Studio37Media.Server.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
       /* private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };*/

        private readonly ILogger<ProfileController> logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Profile> Get()
        {
          
            IEnumerable<Profile> profiles = APILibrary.APIGetALL<IEnumerable<Profile>>("Profiles");
            return profiles;
        }
        [HttpPost]
        public Profile Post(Profile Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Profile ReturnProfile = APILibrary.APIPost<Profile>(Model,"Profiles");
            return ReturnProfile;
        }
    }
}