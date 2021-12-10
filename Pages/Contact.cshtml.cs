using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dnc300_personal_portfolio.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string Message { get; set; } = "Feel free to contact me";
        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            this.FirstName = "Angelina";
            this.LastName = "Ossimetha";
            this.EmailAddress = "Angelina@cccareers.org"; 
        }
    }
}