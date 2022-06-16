using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using naveen.Model;
using System.Threading.Tasks;

namespace naveen.Pages.bookList
{
    
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

		public EditModel(ApplicationDbContext db)
		{
			_db = db;
		}
        [BindProperty]
        public book book { get; set; }
		public async Task OnGet(int id)
        {
            book = await _db.book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookFromDb=await _db.book.FindAsync(book.Id);
                bookFromDb.Name=book.Name;
                bookFromDb.Author=book.Author;  
                bookFromDb.ISBN=book.ISBN;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
