using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Utils
{

    public class SessionFilter : IPageFilter
    { 
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (context.HandlerInstance is PageModel page)
            {
                page.ViewData.Add("SelectedTheme", context.HttpContext.Session.GetString("theme") ?? "Dark");
            }
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            
        }
    }
}
