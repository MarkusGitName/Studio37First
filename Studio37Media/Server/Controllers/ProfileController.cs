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

using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.Collections;

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

       /* IFileAccessLayer _file;
        [HttpPost]
        public async Task PostFile()
        {
            if (HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {
                    FileDatum filedata = new FileDatum { FileName = file.FileName };
                    _file.AddFile(filedata, file, environment);
                }
            }
        }*/
    }
    /*
    public class FileAccessLayer : IFileAccessLayer
    {
        public async void AddFile(FileDatum fileData, IFormFile file, IWebHostEnvironment environment)
        {
            try
            {
                
                var path = GetPath(environment.ContentRootPath, "uploads", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteFile(int FileId, IWebHostEnvironment environment)
        {
            throw new NotImplementedException();
        }

        public string GetContentType(string path)
        {
            throw new NotImplementedException();
        }

        public string GetPath(string environment, string folder, string fileName)
        {
            throw new NotImplementedException();
        }
    }
    public interface IFileAccessLayer
    {
        void DeleteFile(int FileId, IWebHostEnvironment environment);
        string GetPath(string environment, string folder, string fileName);

        string GetContentType(string path);
    }*/
}