using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Razor
{
    public class TempDataModel : PageModel
    {
        [BindProperty]
        public string Pizzaname { get; set; }

        [BindProperty]
        public long Amount { get; set; }

        [TempData]
        public bool IsNew { get; set; }



        public IActionResult OnPost()
        {
            //Store in DB and redirect to detail page
            IsNew = true;
            return RedirectToPage("./TempDataDetail", new {Id = 1});
        }
    }
}