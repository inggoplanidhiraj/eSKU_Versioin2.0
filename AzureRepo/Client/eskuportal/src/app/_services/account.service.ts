import { country } from '../_models/country';
import { Users } from './../_models/Users';
import { environment } from './../../environments/environment';
import { DebugEventListener, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ReplaySubject } from 'rxjs';
import {map} from 'rxjs/operators'
import { UserRoleMap } from '../_models/UserRoleMap';


@Injectable({
  providedIn: 'root'
})
export class AccountService {
   users:Users[];
   user:Users;
   userRoles :UserRoleMap[];
   baseurl = environment.baseUrl;
  constructor(private http:HttpClient) { }
  private CurrentUserSource = new ReplaySubject<Users>(1);
  currentUser$ = this.CurrentUserSource.asObservable();

  CheckUser(){

     return this.http.get<Users[]>(this.baseurl + 'Login/Index').pipe(map((response:Users[]) =>{

      this.users = response;
     localStorage.setItem('WindowsID',JSON.stringify(this.users[0].windowsID!));
     localStorage.setItem('users',JSON.stringify(this.users));

     }));

  }
  GetUserForCountry(userId:number){




     return this.http.post<UserRoleMap[]>(this.baseurl+'Login/SetUserDetails?id='+userId,null).pipe(map((response:UserRoleMap[]) =>{

        this.userRoles = response;
        localStorage.setItem('AdminforCountries',JSON.stringify(this.userRoles.filter(x => x.userRole.userRoleName == "Administrator")?.map(x => x.country.countryCode)));
        localStorage.setItem('RequestorforCountries',JSON.stringify(this.userRoles.filter(x => x.userRole.userRoleName == "Requestor")?.map(x => x.country.countryCode)));
        localStorage.setItem('CreatorforCountries',JSON.stringify(this.userRoles.filter(x => x.userRole.userRoleName == "Creator")?.map(x => x.country.countryCode)));
        this.user = this.users.filter(x=>x.usersID == userId)[0];
        localStorage.setItem('user',JSON.stringify(this.user));
        this.CurrentUserSource.next(this.user);

     } ));
        }
}
