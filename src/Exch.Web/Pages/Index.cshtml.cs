using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Exch.Web.Pages;

public class IndexModel : ExchPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
