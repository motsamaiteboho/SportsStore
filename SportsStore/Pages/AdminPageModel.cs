using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsStore.Pages
{
    [Authorize(Roles="Administrator")]
    public class AdminPageModel: PageModel
    {
    }
}
