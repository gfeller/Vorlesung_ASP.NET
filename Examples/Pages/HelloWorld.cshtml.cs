using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages
{
    public class HelloWorldModel : PageModel
    {
        public string HelloWorld { get; set; }

        public void OnGet()
        {
            HelloWorld = "Hi World!";
        }
    }
}