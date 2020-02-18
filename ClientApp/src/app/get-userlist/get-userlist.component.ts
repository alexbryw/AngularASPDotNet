import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-userlist',
  templateUrl: './get-userlist.component.html'
})

//Route path and setup is done in app.module.ts.
//Export classname needs to end with "Component".
export class GetUserListComponent {
  public UserList: User[];

  //Server adress comes from main.ts as BASE_URL and "userapi" is appended.
  //Json results are put in UserList.
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<User[]>(baseUrl + 'userapi').subscribe(result => {
      this.UserList = result;
      this.UserList.sort((a, b) => a.UserId - b.UserId);
    }, error => console.error(error));
    // console.log(this.userlist + ' from angular')
    //sort userlist by userId
  }
}

//Interface to match incoming json api data, it's case sensetive.
interface User {
  Name: string;
  UserId: number;
  LastLogin: string;
}
