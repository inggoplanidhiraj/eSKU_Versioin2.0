
import { Users } from './../_models/Users';
import { AccountService } from './../_services/account.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  userID:number;
  windowsid :string;

  user:Users;
  users:Users[];


  constructor(public accountservice:AccountService) {


  }

  ngOnInit(){
    debugger;
    if(!localStorage.getItem('user')){
           this.GetAllUsers();
          }
         else{
          this.GetAllUsers();
           if(this.users){
           this.user = JSON.parse(localStorage.getItem('user') || '{}');
           this.userID = this.user.usersID;
           this.GetCountrySpecificUser();

           }
           else
           localStorage.clear();
         }
          }

  GetAllUsers()
  {
    debugger;
     this.accountservice.CheckUser().subscribe(response => {

       this.users =   JSON.parse(localStorage.getItem("users") || '{}');

      this.windowsid = JSON.parse(localStorage.getItem("WindowsID")|| '{}')!;
      }
     ,error => {

      console.log(error);
     })

  }
  GetCountrySpecificUser(){



    this.accountservice.GetUserForCountry(this.userID).subscribe();

  }

}
