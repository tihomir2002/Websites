using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class GamesModel : PageModel
    {
        public void OnGet()
        {
            GamesTable.GetGames();
        }
    }
}
