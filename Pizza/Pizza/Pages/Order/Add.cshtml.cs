using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza.Data;

namespace Pizza.Pages.Order
{
    public class AddModel : PageModel
    {
        private readonly ApplicationDbContext _context;


        [TempData]
        public bool IsNew { get; set; }

        [BindProperty]
        public ViewModels.NewOrderViewModel Order { get; set; }


        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var toAdd = new Models.Order() {Name = Order.Name};
            _context.Order.Add(toAdd);
            await _context.SaveChangesAsync();

            IsNew = true;
            return RedirectToPage("./Detail", new {toAdd.Id});
        }
    }
}