using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace AlanDemoProj.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? Name { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string name)
        {
            Name = name;
        }

        public IActionResult OnPostShow()
        {
            return RedirectToPage("Hello", new { name = Name });
        }

        public IActionResult OnPostClear()
        {
            return RedirectToPage("Hello");
        }
    }
}