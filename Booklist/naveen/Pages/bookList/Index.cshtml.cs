//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using naveen.Model;
//using System;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace naveen.Pages.bookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IEnumerable<book> Books{ get; set; }
        public async Task OnGet()
        {
            Books = await _db.book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book=await _db.book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.book.Remove(book);
            await _db.SaveChangesAsync();   
            return RedirectToAction("Index");
        }
    }
}
