using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Examples.ViewComponents
{
    public class ToDoList : ViewComponent
    {
        public string[] Todos { get; set; }


        public ToDoList()
        {
            Todos = new string[new Random().Next(1, 10)].Select((item, index) => $"{index} TODO").ToArray();
        }

        public IViewComponentResult Invoke()
        {
            return View(Todos);
        }
    }
}
