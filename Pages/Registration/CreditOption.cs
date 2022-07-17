using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Netflix.Pages.Registration
{
    public class CreditOptionModel : PageModel
    {
        public string? FirstName {get;set;}
        public string? LastName {get;set;}
        [StringLength(5)]
        public string? ExpirationDate {get;set;}
        [StringLength(3)]
        public string? SecurityCode {get;set;}   
    }
}