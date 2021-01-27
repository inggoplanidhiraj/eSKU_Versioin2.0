import { ToastrModule, ToastrService } from 'ngx-toastr';
import { AccountService } from './../_services/account.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private AccountService:AccountService,private toastr :ToastrService){}
  canActivate():Observable<boolean>{
    return this.AccountService.currentUser$.pipe(map(
    user => {

               if (user)
               return true;
               else
               this.toastr.error("Please select a country before proceeding");
               return false;

    }))


}}
