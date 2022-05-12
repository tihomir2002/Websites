using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        public IActionResult OnGet(string url)
        {
            if (HttpContext.Session.GetString("password") == "")
                return new RedirectToPageResult("Login");
            return Page();
        }
    }
}
