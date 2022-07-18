using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.Categories
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }
        public ApplicationDbContext _db { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int Id)
        {
            Category = _db.Category.Find(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            var catFromDb = _db.Category.Find(Category.Id);
            if(catFromDb != null)
            {
                _db.Category.Remove(catFromDb);
                await _db.SaveChangesAsync();

                TempData["success"] = "Category deleted successfully.";
                return RedirectToPage("Index");
            }

            return Page();
            

        }
    }
}
