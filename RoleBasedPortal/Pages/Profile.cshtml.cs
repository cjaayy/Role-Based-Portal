using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoleBasedPortal.Data;
using RoleBasedPortal.Models;

namespace RoleBasedPortal.Pages
{
    public class ProfileModel : PageModel
    {
        public User? CurrentUser { get; set; }

        public IActionResult OnGet()
        {
            string? username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToPage("/Index");
            }

            CurrentUser = ApplicationData.Users.FirstOrDefault(
                u => u.Username == username);

            if (CurrentUser == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
