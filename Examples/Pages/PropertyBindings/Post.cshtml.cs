using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.PropertyBindings
{
    public class PostModel : PageModel
    {

        public string EchoText { get; set; }

        public long Times { get; set; }

        public void OnGet()
        {

        }   

        public void OnPost(string echoText, long times)
        {
            EchoText = echoText;
            Times = times;            
        }
    }


    public class PostModel2 : PageModel
    {
        [BindProperty]
        public string EchoText { get; set; }

        [BindProperty]
        public long Times { get; set; }
    }
}