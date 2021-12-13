using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MailChimp.Net;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;


namespace dnc300_personal_portfolio.Pages
{
    public class ThanksModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string ApiKey = "e51d7db42a3df40797e529a18f9c8807-us20";
        private string AudienceID = "e8e452fdd0";

        public  async void OnPost(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            IMailChimpManager mailChimpManager = new MailChimpManager(ApiKey);
            
            Member member = new Member { EmailAddress = email, StatusIfNew = Status.Subscribed };
            member.MergeFields.Add("FNAME", firstName);
            member.MergeFields.Add("LNAME", lastName);
            await mailChimpManager.Members.AddOrUpdateAsync(AudienceID, member);
        }
    }
}
