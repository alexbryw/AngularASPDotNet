using System;
using System.Collections.Generic;
namespace AngularASPDotNet.Models
{
    public class UserList
    {
        List<User> userList = new List<User>();

        public UserList(){
            userList.Add(new User("Alex", 1000, DateTime.Now));
            userList.Add(new User("Lex", 1000, DateTime.Now));
            Console.WriteLine(userList[0]);
            Console.WriteLine(userList[1]);
        }
    }
}