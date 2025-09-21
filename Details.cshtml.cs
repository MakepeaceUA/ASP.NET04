using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Books
{
    public class DetailsModel : PageModel
    {
        public Book? Book { get; set; }

        public IActionResult OnGet(int id)
        {
            Book = BookService.Get(id);
            if (Book == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
