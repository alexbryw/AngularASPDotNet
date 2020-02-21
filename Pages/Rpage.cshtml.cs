using Microsoft.AspNetCore.Mvc.RazorPages;
using AngularASPDotNet.Models;

namespace AngularASPDotNet.Pages
{
    public class RpageModel : PageModel
    {
        public UserList UserList;
        public RpageModel(UserList userList)
        {
            UserList = userList;
        }

        public UserList OnGet()
        {
            return UserList;
        }
    }
}