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
    public class UserAPIController : ControllerBase
    {
        UserList userList = new UserList();

        //This is return when you visit the api page.
        [HttpGet]
        public string Get(){
            string userListString = JsonConvert.SerializeObject(userList.getListOfUsers());
            Console.WriteLine(userListString);
            return userListString;
        }
    }
}