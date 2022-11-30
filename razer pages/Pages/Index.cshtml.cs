using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razer_pages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        // Users input value
        public double? GBP { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        
        // On post method, used when submit button is pressed
        public void Onpost()
        {
            // checks if user inputted value is equal to null
            if(GBP == null)
            {
                // sets viewdata conversion string to the string below
                ViewData["Convert"] = "Please enter a value";
                // returns method 
                return;
            }
            
            // Sets viewdata convert string to the string below
            // multiplys GBP by 1.14 and rounds to 2 decimal places
            ViewData["Convert"] = $"The Converted Amount Is {Math.Round((double)(1.14 * GBP), 2)}";
        }
    }
}