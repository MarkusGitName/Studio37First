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
    public class PostCategoryController : ControllerBase
    {
        [HttpPost("{apiname}", Name = "NewPostCategory")]
        public PostCattegory Post(Post Model)
        {
            PostCattegory ReturnPostCategory = APILibrary.APIPost<PostCattegory>(Model, "PostCattegories");
            return ReturnPostCategory;
        }

    }
}