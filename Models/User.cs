using System;
namespace AngularASPDotNet.Models
{
    public class User
    {
        readonly string Name;
        readonly int UserId;

        readonly DateTime LastLogin;

        public User(string Name, int UserId, DateTime LastLogin){
            this.Name = Name;
            this.UserId = UserId;
            this.LastLogin = LastLogin;
        }
    }
}