﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studio37Media.Shared;
using Studio37Media.Shared.ViewModels;

namespace Studio37Media.Server.Controllers.ModelControllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPost")]
        public Post Post(Post Model)
        {
            Model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Post ReturnPost = APILibrary.APIPost<Post>(Model, "Posts");
            return ReturnPost;
        }
       [HttpGet("{apiname}", Name = "GetPosts")]
        public List<Post> Get()

        {
            List<Post> ReturnPosts = APILibrary.APIGetALL<List<Post>>("Posts");
            return ReturnPosts;
        }

    }
}