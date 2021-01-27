import { Users } from './../_models/Users';
import { Component, Input, OnInit } from '@angular/core';

import { AccountService } from '../_services/account.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  ngOnInit(): void {

  }

}
