using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSocialMediaLinkController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewUserSocialMediaLink")]
        public UserSocialMediaLink Post(UserSocialMediaLink Model)
        {
            UserSocialMediaLink ReturnUserSocialMediaLink = APILibrary.APIPost<UserSocialMediaLink>(Model, "UserSocialMediaLinks");
            return ReturnUserSocialMediaLink;
        }

    }
}