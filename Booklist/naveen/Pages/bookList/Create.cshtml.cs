using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using naveen.Model;
using System.Threading.Tasks;

namespace naveen.Pages.bookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
                   
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public book book1 { get; set; }
        public void OnGet()
        {

        }
        public async Task<ActionResult> OnPost()
        { 
        if(ModelState.IsValid)
			{
                await _db.book.AddAsync(book1);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
			}
			else
			{
                return Page();
			}
        }

    }
}
