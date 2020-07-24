using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Media.Server.Data;
using Media.Server.Models.DataModels;
using Media.Shared;

namespace Media.Server
{
    public class CreateModel : PageModel
    {
    
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Media.Shared.Tutorial Tutorial { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(Tutorials model)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                APILibrary.APIPost<Tutorials>(model,"Tutorials");
            }
            return RedirectToPage("./Index");
        }
    }
}
