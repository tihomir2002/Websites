using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User User{ get; set; }

        public IActionResult OnPost()
        {
            User.Username = Request.Form["username"];
            User.Password = Request.Form["password"];

            if (ModelState.IsValid && User.TryLogin())
            {
                return new RedirectToPageResult("Home");
            }
            return Page();
        }
    }
}
