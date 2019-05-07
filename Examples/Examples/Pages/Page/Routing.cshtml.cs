using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Page
{
    public class RoutingModel : PageModel
    {
        public int Id { get; set; }


        [BindProperty(SupportsGet = true, Name = "Id")]
        public int Id2 { get; set; }



        public void OnGet(int id)
        {
            Id = id;
        }
    }
}