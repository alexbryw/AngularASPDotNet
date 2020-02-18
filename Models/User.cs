using System;
namespace AngularASPDotNet.Models
{
    public class User
    {
        public readonly string Name;
        public readonly int UserId;
        public DateTime LastLogin {get; private set;}

        public User(string Name, int UserId, DateTime LastLogin){
            this.Name = Name;
            this.UserId = UserId;
            this.LastLogin = LastLogin;
        }

        public void setLastLogin(DateTime newLastLogin){
            LastLogin = newLastLogin;
        }
        
    }
}