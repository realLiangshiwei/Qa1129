using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Qa.Pages
{
    public class IndexModel : QaPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}