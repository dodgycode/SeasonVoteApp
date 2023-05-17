import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { Series } from '../series/series.component';

@Component({
  selector: 'app-series-edit',
  templateUrl: './series-edit.component.html',
  styleUrls: ['./series-edit.component.less']
})
export class SeriesEditComponent implements OnInit {
  series: Series;
  constructor(
    private router: Router
  ) {
    this.series = this.router.getCurrentNavigation()?.extras?.state?.series;
   }

  ngOnInit(): void {
  }

}
