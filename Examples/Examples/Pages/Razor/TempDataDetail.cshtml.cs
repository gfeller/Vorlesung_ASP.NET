using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Razor
{
    public class TempDataErrorModel : PageModel
    {
        [TempData]
        public bool IsNew { get; set; }

        [BindProperty(SupportsGet = true)]
        public long Id { get; set; }


        public string Pizzaname { get; set; }


        public long Amount { get; set; }


        public void OnGet()
        {

            // Fake Data: Get the Data of Order with Id
            this.Pizzaname = "Hawaii";
            this.Amount = 2;
        }
    }
}