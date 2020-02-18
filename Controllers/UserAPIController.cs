using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AngularASPDotNet.Models;
using Newtonsoft.Json;

namespace AngularASPDotNet.Controllers
{
    //rout is localhost:5000/userapi
    //same as controllername but without "controller".
    [Route("[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        public UserList userList{get;}

        //Startup.cs sends a new Userlist from services.addTransient<UserList>() to this constructor.
        public UserAPIController(UserList userList){
            this.userList = userList;
        }

        //This is return when you visit the api page.
        [HttpGet]
        public string Get(){
            string userListString = JsonConvert.SerializeObject(userList.getListOfUsers());
            Console.WriteLine(userListString);
            return userListString;
        }
    }
}