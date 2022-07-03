using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Netflix.Pages.Registration
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        public string? Email {get;set;}
        public string? Password {get;set;}

        public void OnGet(){}
        public IActionResult OnPost() {
            if(!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password)) {
                return RedirectToPage("signup");
            }
            return Page();
        }
    }
}