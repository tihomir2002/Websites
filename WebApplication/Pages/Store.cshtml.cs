using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Pages
{
    [Authorize]
    public class GamesModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("password") == "")
                return new RedirectToPageResult("Login");

            try
            {
                GamesTable.GetGames();
            }
            catch (AggregateException)
            {
                return Redirect("Error?error=\"VPN error\"");
            }
            return Page();
        }
    }
}
