using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Razor
{
    public class ViewDataModel : PageModel
    {
        [ViewData]
        public string Error { get; set; }

        public void OnGet()
        {
            Error = "Something went wrong";
        }
    }
}