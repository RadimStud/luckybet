using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class lotteryModel : PageModel
    {
        public string Vysledek { get; set; }

        public void OnPost()
        {
            // Logika pro výpo?et výsledku losování
            Random random = new Random();
            int[] losovanaCisla = Enumerable.Range(0, 5)
                                             .Select(_ => random.Next(1, 100))
                                             .ToArray();

            Vysledek = $"Losovaná ?ísla: {string.Join(", ", losovanaCisla)}";
        }
    }
}
