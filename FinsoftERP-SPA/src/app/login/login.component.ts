import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Response } from 'selenium-webdriver/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
values: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {

    this.getValues();

  }


  getValues() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.values = response;
    }, error => {
      console.log('Failed');
    });

  }
}
