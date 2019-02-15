using System;
using Examples.Services;
using Examples.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages.Ajax
{
    public class AjaxModel : PageModel
    {
        private readonly CitiesService _citiesService;

        public AjaxModel(CitiesService citiesService)
        {
            _citiesService = citiesService;
        }
        public void OnGet()
        {
            throw new NotSupportedException();
        }
        
        public IActionResult OnPostEcho(string echoText)
        {
            return Content(echoText);
        }

        public IActionResult OnGetAutocomplete(string text)
        {
            return new JsonResult(_citiesService.GetCities(text));
        }

        public IActionResult OnGetTodoList()
        {
            return ViewComponent(typeof(ToDoList));
        }
    }
}