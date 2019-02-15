using System.Security.Claims;

namespace Pizza.Utilities
{
    public static class ClaimsPrincipalExtension
    {
        public static string GetId(this ClaimsPrincipal self)
        {
            return self.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static bool IsAdmin(this ClaimsPrincipal self)
        {
            return self.IsInRole("Administrator");
        }


    }
}
