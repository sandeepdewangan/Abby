using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }
        public ApplicationDbContext _db { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            // Custom Model Validation - <div asp-validation-summary="All"></div>
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(String.Empty, "The display order cannot exactly match the Name.");
            }

            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return Page();

        }
    }
}
