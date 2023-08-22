import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-log-in-page',
  templateUrl: './log-in-page.component.html',
  styleUrls: ['./log-in-page.component.sass']
})
export class LogInPageComponent implements OnInit {
  logInForm = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', Validators.required),
  });
  hide = true;

  constructor() { }

  ngOnInit(): void {
  }

  get passwordInput() { return this.logInForm.get('password'); }  

}
