using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Authorization;


namespace WebApplication.Pages
{
    [Authorize]
    public class EditGameModel : PageModel
    {
        [BindProperty]
        public Game Game { get; set; }
        public static int gameID = -1;


        public void OnGet()
        {   
            gameID = GetGameID(PageContext.HttpContext.Request.QueryString.Value);
        }

        public IActionResult OnPostConfirm()
        {
            if (HttpContext.Session.GetString("password") == "")
                return new RedirectToPageResult("Login");

            if (ModelState.IsValid)
            {
                try
                {
                    using (MySqlConnection con = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                    {
                        con.Open();
                        MySqlCommand cmd = new("UPDATE games " +
                            "SET name=@name, description=@desc, price=@price " +
                            "WHERE id=@id",con);
                        cmd.Parameters.AddWithValue("@id", gameID);
                        cmd.Parameters.AddWithValue("@name",Game.Name);
                        cmd.Parameters.AddWithValue("@desc", Game.Description);
                        cmd.Parameters.AddWithValue("@price", Game.Price);
                        cmd.ExecuteNonQuery();
                    }

                    ModelState.Clear();//fixes bug where modelstate is always invalid
                    return new RedirectToPageResult("Store");
                }
                catch
                {
                    return Page();
                }
            }
            return Page();
        }

        public IActionResult OnPostRemoveGame(int id)
        {
            if (HttpContext.Session.GetString("password") == "")
                return new RedirectToPageResult("Login");

            try
            {
                using (MySqlConnection con = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                {
                    con.Open();
                    MySqlCommand cmd = new("DELETE FROM games WHERE id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
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

        private int GetGameID(string query)
        {
            if (!PageContext.HttpContext.Request.QueryString.Value.Contains("?id="))
                return -1;
            
            int endIndex = query.IndexOf('&', query.IndexOf("id=") + 1) != -1 ? query.IndexOf('&', query.IndexOf("id=") + 1) : query.Length - 1;
            int length = endIndex - (query.IndexOf("id=") + 3);
            int prevGameID = -1;
            if (length == 0) prevGameID = int.Parse(query.Substring(query.IndexOf("id=") + 3));
            else prevGameID = int.Parse(query.Substring((query.IndexOf("id=") + 3), length));
            return prevGameID;
        }
    }
}
