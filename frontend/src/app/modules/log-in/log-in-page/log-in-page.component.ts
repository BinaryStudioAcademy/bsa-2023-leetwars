import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { faEye, faEyeSlash } from '@fortawesome/free-solid-svg-icons';

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

  showPassword: boolean = false;
  eyeIcon = faEyeSlash;
  hide = true;
  isDataIncorrect: boolean = false;

  constructor() { }

  ngOnInit(): void {
  }

  toggleShow() {
    this.showPassword = !this.showPassword;
    this.eyeIcon = this.showPassword ? faEye : faEyeSlash;
  }

  signIn() {
    const email: string = this.logInForm.controls['email'].value!
    const password: string = this.logInForm.controls['password'].value!

    if(email != "abcd@gmail.com" || password != "1111")
    {
      this.isDataIncorrect = true;
      return
    }

    this.isDataIncorrect = false;

  }
}
