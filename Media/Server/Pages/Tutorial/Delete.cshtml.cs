using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Media.Server.Data;
using Media.Server.Models.DataModels;
using Media.Shared;


namespace Media.Server
{
    public class DeleteModel : PageModel
    {

        [BindProperty]
        public Media.Shared.Tutorial Tutorial { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            APILibrary.APIGet<Tutorials>(id.ToString(), "Tutorials");

            if (Tutorial == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (Tutorial != null)
            {

                APILibrary.APIDelete<Tutorials>(id.ToString(), "Tutorials");
            }

            return RedirectToPage("./Index");
        }
    }
}
