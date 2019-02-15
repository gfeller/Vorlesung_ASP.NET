using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.PropertyBindings
{

    public class PostWithClassModel : PageModel
    {

        [BindProperty]
        public EchoModel Data { get; set; }

        public void OnPost(EchoModel data)
        {
            Data = data;
        }
    }

    public class EchoModel
    {
        public string EchoText { get; set; }
        public long Times { get; set; }
    }
}