using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace WebApplication.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User user{ get; set; }

        public void OnGet()
        {            
            if (!HttpContext.Session.Keys.Contains("username"))
            {
                HttpContext.Session.SetString("username", "");
                HttpContext.Session.SetString("password", "");
            }
        }

        public IActionResult OnPost()
        {
            bool logged = user.TryLogin();
            bool connected = false;
            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection con = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    connected = con.Ping();
                }
            }
            catch { connected = false; }

            if (!ModelState.IsValid) return Page();

            if (logged)
            {
                if (user.RememberMe)
                {
                    HttpContext.Session.SetString("username", user.Username);
                    HttpContext.Session.SetString("password", user.Password);
                }
                else
                {
                    HttpContext.Session.Remove("username");
                    HttpContext.Session.Remove("password");
                }

                List<Claim> claims = new();
                claims.Add(new Claim(ClaimTypes.Name, user.Username));
                claims.Add(new Claim("id", WebApplication.User.ID.ToString()));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                ModelState.Clear();//fixes bug where modelstate is always invalid
                return new RedirectToPageResult("Home");
            }
            else if(!connected) return Redirect("Error?error=VPN error");
            else return Redirect("Error?error=Login error");
        }
    }
}
