using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Validation
{

    public class Item
    {
        [Required]
        [StringLength(100, MinimumLength = 5 )]
        public string Name { get; set; }
    }
    public class ValidationModel : PageModel
    {
        public Item Item { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost(Item item)
        {
            return Content(ModelState.IsValid ? "Valid" : "Invalid");
        }
    }
}