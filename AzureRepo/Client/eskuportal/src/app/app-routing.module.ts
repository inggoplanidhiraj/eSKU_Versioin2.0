import { AuthGuard } from './_guards/auth.guard';
import { CreateComponent } from './members/create/create.component';
import { RequestComponent } from './members/request/request.component';
import { HomeComponent } from './home/home.component';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
{path:'',component:HomeComponent},
{path:'request',component:RequestComponent,canActivate:[AuthGuard]},
{path:'create',component:CreateComponent,canActivate:[AuthGuard]},
{path:'**',component:HomeComponent,pathMatch:'full',canActivate:[AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
