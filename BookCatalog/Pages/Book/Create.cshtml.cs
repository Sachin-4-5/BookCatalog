using BookCatalog.Data;
using BookCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookCatalog.Pages.Book
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext context;

        public CreateModel(AppDbContext context)
        {
            this.context = context;
        }


        [BindProperty]
        public Books Books { get; set; } = new();


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            context.Books.Add(Books);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}