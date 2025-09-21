using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Books
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Book NewBook { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            BookService.Add(NewBook);
            return RedirectToPage("./Index");
        }
    }
}
