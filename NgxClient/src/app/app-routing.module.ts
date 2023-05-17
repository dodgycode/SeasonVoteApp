import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { SeriesEditComponent } from './series-edit/series-edit.component';
import { SeriesComponent } from './series/series.component';
import { SeasonComponent } from './season/season.component';

import { ProfileComponent } from './profile/profile.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'signIn',
    pathMatch: 'full',
  },
  {
    path: 'profile',
    component: ProfileComponent,
  },
  {
    path: 'signIn',
    component: SignInComponent,
  },
  {
    path: 'signUp',
    component: SignUpComponent,
  },
  {
    path: '**',
    redirectTo: 'signIn',
  },
  { 
    path: 'series/edit', 
    component: SeriesEditComponent 
  },
  { 
    path: 'series', 
    component: SeriesComponent  
  },
  { 
    path: 'season', 
    component: SeasonComponent 
  },
  { 
    path: '', 
    component: SeriesComponent 
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
