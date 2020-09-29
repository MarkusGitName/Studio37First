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
    public class PostController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPost")]
        public Post Post(Post Model)
        {
            Post ReturnPost = APILibrary.APIPost<Post>(Model, "Posts");
            return ReturnPost;
        }

    }
}