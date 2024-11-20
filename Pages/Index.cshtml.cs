using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public string Vysledek { get; set; } = string.Empty;

        public void OnGet()
        {
            Vysledek = "Welcome to the Casino!";
        }
    }
}