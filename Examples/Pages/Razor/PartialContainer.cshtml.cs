using Examples.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Razor
{
    public class PartialContainerModel : PageModel
    {
        public CardViewModel Card1 { get; set; } = new CardViewModel(){Message = "Success", Type = CardType.Info};
        public CardViewModel Card2 { get; set; } = new CardViewModel() { Message = "Something went wrong", Type = CardType.Warning };
        public void OnGet()
        {

        }
    }
}