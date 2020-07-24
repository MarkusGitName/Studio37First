using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Media.Server.Data;
using Media.Shared;

namespace Media.Server
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Tutorial Tutorial { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutorial = APILibrary.APIGet<Media.Shared.Tutorial>(id.ToString(),"Tutorials");

            if (Tutorial == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            try
            {
                APILibrary.APIPut<Tutorial>(Tutorial,Tutorial.id.ToString(), "Tutorials");
            }
            catch 
            {
                
            }

            return RedirectToPage("./Index");
        }

      /*  private bool TutorialExists(Guid id)
        {
            return _context.Tutorial.Any(e => e.id == id);
        }*/
    }
}
