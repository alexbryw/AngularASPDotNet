using System;
using System.Collections.Generic;
namespace AngularASPDotNet.Models
{
    public class UserList
    {
        private List<User> ListOfUsers = new List<User>();

        //The constructor adds users to ListOfUsers when it's instantiated.
        public UserList(){
            var rnd = new Random();
            ListOfUsers.Add(new User("Alex", rnd.Next(), DateTime.Now));
            ListOfUsers.Add(new User("Lex", rnd.Next(), DateTime.Now));
            ListOfUsers.Add(new User("John", rnd.Next(), DateTime.Now));
            ListOfUsers.Add(new User("Pluto", rnd.Next(), DateTime.Now));
        }

        public List<User> getListOfUsers(){
            return ListOfUsers;
        }
    }
}