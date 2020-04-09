using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Page
{
    public class ParametersModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public long Val1 { get; set; }

        [BindProperty(SupportsGet = true)]
        public long Val2 { get; set; }

        public void OnGet(long val1, long val2)
        {
            this.Val1 = val1;
            this.Val2 = val2;
        }
    }
}