using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class EditGameModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return new RedirectToPageResult("Store");
            }
            return Page();
        }
    }
}
