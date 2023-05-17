import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IUser, CognitoService } from '../cognito.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.less']
})
export class SignInComponent implements OnInit {
  loading: boolean;
  user: IUser;

  constructor(
    private router: Router,
    private cognitoService: CognitoService) {
    this.loading = false;
    this.user = {} as IUser;
  }

  public signIn(): void {
    this.loading = true;
    this.cognitoService.signIn(this.user)
    .then(() => {
      this.router.navigate(['/series']);
    })
    .catch((e) => {
      this.loading = false;
    });
  }

  ngOnInit(): void {
  }

}
