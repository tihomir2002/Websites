using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication.Pages
{
    [Authorize]
    public class AddGameModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("password") == "")
                return new RedirectToPageResult("Login");
            return Page();
        }

        public IActionResult OnPostConfirm()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (MySqlConnection con = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                    {
                        con.Open();
                        MySqlCommand cmd = new("SELECT id FROM games WHERE id=@id", con);
                        cmd.Parameters.AddWithValue("@id", Game.ID);

                        if (cmd.ExecuteScalar() == null)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = "INSERT INTO games VALUES(@id,@name,@desc,@price)";
                            cmd.Parameters.AddWithValue("@id", Game.ID);
                            cmd.Parameters.AddWithValue("@name", Game.Name);
                            cmd.Parameters.AddWithValue("@desc", Game.Description);
                            cmd.Parameters.AddWithValue("@price", Game.Price);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            //no idea how to display message alert from here
                            return Page();
                        }
                    }

                    ModelState.Clear();//fixes bug where modelstate is always invalid
                    return new RedirectToPageResult("Store");
                }
                catch (AggregateException)
                {
                    return Redirect("Error?error=\"VPN error\"");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return Page();
                }
            }
            return Page();
        }
    }
}
