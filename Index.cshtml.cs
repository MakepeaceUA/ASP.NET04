using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Books
{
    public class IndexModel : PageModel
    {
        public List<Book> BookList { get; set; } = new();

        public void OnGet()
        {
            BookList = BookService.GetAll();
        }
    }
}
