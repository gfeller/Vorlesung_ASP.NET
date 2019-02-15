using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Session
{
    public class SessionModel : PageModel
    {
        public string[] Themes { get; } = new[] {"Dark", "Light"};

        [ViewData]
        public string SelectedTheme { get; set; }

        public void OnGet(string theme)
        {
            if (!string.IsNullOrEmpty(theme))
            {
                SelectedTheme = theme;
                HttpContext.Session.SetString("theme", theme);
            }
            else
            {
                SelectedTheme = HttpContext.Session.GetString("theme") ?? Themes.First();
            }
        }
    }
}