using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Media.Server.Data;
using Media.Shared;

namespace Media.Server
{
    public class IndexModel : PageModel
    {

        public IList<Tutorial> Tutorial { get;set; }

        public async Task OnGetAsync()
        {
            try
            {
            Tutorial =APILibrary.APIGetALL<List<Tutorial>>("Tutorials");

            }catch{}
        }
    }
}
