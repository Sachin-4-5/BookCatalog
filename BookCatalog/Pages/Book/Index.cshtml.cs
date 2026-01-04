using BookCatalog.Data;
using BookCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookCatalog.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext context;
        public IndexModel(AppDbContext context)
        {
            this.context = context;
        }

        public IList<Books> Books { get; set; }
        public async Task OnGetAsync()
        {
            Books = await context.Books.ToListAsync();
        }
    }
}