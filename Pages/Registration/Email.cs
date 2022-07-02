using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Netflix.Pages
{
    public class EmailModel : PageModel
    {
        [BindProperty]
        public string? Email {get;set;}
        public void OnGet(){}

        public IActionResult OnPost() {
            if(!string.IsNullOrWhiteSpace(Email)) {
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}