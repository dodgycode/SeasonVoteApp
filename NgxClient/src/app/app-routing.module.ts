import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SeriesEditComponent } from './series-edit/series-edit.component';
import { SeriesComponent } from './series/series.component';
import { SeasonComponent } from './season/season.component';

const routes: Routes = [
  { path: 'series/edit', component: SeriesEditComponent },
  { path: 'series', component: SeriesComponent  },
  { path: 'season', component: SeasonComponent },
  { path: '', component: SeriesComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
