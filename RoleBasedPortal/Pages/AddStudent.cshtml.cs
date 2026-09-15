using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RoleBasedPortal.Data;
using RoleBasedPortal.Models;

namespace RoleBasedPortal.Pages
{
    public class AddStudentModel : PageModel
    {
        [BindProperty]
        public string StudentName { get; set; } = "";

        [BindProperty]
        public string Course { get; set; } = "";

        [BindProperty]
        public string YearLevel { get; set; } = "";

        [BindProperty]
        public string Section { get; set; } = "";

        public User? CurrentUser { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public string Message { get; set; } = "";

        public IActionResult OnGet()
        {
            string? username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToPage("/Index");
            }

            CurrentUser = ApplicationData.Users.FirstOrDefault(u => u.Username == username);

            if (CurrentUser == null || CurrentUser.Role != "Instructor")
            {
                return RedirectToPage("/Profile");
            }

            Students = ApplicationData.Students;

            return Page();
        }

        public IActionResult OnPost()
        {
            string? username = HttpContext.Session.GetString("Username");

            if (string.IsNullOrEmpty(username))
            {
                return RedirectToPage("/Index");
            }

            CurrentUser = ApplicationData.Users.FirstOrDefault(u => u.Username == username);

            if (CurrentUser == null || CurrentUser.Role != "Instructor")
            {
                return RedirectToPage("/Profile");
            }

            ApplicationData.Students.Add(new Student
            {
                Name = StudentName,
                Course = Course,
                YearLevel = YearLevel,
                Section = Section
            });

            ApplicationData.Users.Add(new User
            {
                Username = StudentName.Replace(" ", "").ToLower(),
                Password = "12345",
                FullName = StudentName,
                Role = "Student",
                Course = Course,
                YearLevel = YearLevel,
                Section = Section
            });

            Message = "Student successfully added.";

            Students = ApplicationData.Students;

            return Page();
        }
    }
}
