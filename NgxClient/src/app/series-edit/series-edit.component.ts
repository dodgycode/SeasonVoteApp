import { Component, OnInit } from '@angular/core';
import { Series } from '../series/series.component';

@Component({
  selector: 'app-series-edit',
  templateUrl: './series-edit.component.html',
  styleUrls: ['./series-edit.component.less']
})
export class SeriesEditComponent implements OnInit {
  series: Series = {Series: "Poop Series", Season: "Current Season"};

  constructor() { }

  ngOnInit(): void {
  }

}
