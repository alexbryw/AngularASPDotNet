using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AngularASPDotNet.Models;

namespace AngularASPDotNet.Pages
{
    public class RpageModel : PageModel
    {
        public UserList UserList;
        public List<User> ListOfUsers;
        public RpageModel(UserList userList)
        {
            UserList = userList;
        }

        public void OnGet()
        {
            ListOfUsers =  UserList.getListOfUsers();
        }
    }
}