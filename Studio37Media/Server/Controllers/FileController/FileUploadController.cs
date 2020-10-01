using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;



namespace Studio37Media.Server.Controllers.FileController
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public FileUploadController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }


        [HttpPost(Name = "FileUpload")]
        public async Task Post()
        {
            if (HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {
                    try
                    {
                        var path = Path.Combine(environment.ContentRootPath, file.Name, file.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                    }
                    catch (Exception e)
                    {

                    }

                }
            }

        }
    }
}
