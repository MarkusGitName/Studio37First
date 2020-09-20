using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Studio37Media.Server.Controllers.FileController
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {

        private readonly ILogger<ProfileController> logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("{apiname}", Name = "GetProfiles")]
        public IEnumerable<Profile> Get()
        {
            IEnumerable<Profile> profiles = APILibrary.APIGetALL<IEnumerable<Profile>>("Profiles");
            return profiles;
        }
        [HttpGet("{apiname}/{id}", Name = "GetProfileById")]
        public Profile Get(string id)
        {

            Profile profiles = APILibrary.APIGet<Profile>(id,"Profiles");
            return profiles;
        }

        [HttpPost("{apiname}", Name = "PostProfile")]
        public Profile Post(Profile Model)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Profile ReturnProfile = APILibrary.APIPost<Profile>(Model, "Profiles");
            return ReturnProfile;
        }
        [HttpPut("{apiname}/{id}", Name = "PutProfile")]
        public Profile Edit(Profile Model, string id)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Profile ReturnProfile = APILibrary.APIPut<Profile>(Model,id, "Profiles");
            return ReturnProfile;
        }
        [HttpPut("{apiname}/{id}", Name = "DeleteProfile")]
        public Profile Delete(Profile Model, string id)
        {
            Model.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Profile ReturnProfile = APILibrary.APIDelete<Profile>(id, "Profiles");
            return ReturnProfile;
        }
    }
    
}
