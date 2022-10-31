using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class ContactModel : PageModel
    {

        public string Email { get; get; } = "contactme@web.com";
        public void OnGet()
        {
        }
    }
}
