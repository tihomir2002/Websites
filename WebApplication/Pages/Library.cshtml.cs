using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Pages
{
    [Authorize]
    public class LibraryModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("password") == "")
                return new RedirectToPageResult("Login");
            GamesTable.GetOwnedGames();
            return Page();
        }
    }
}
