using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dnc300_personal_portfolio.Pages
{
    public class ThanksModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public  void OnPost(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
