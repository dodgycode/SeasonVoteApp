import { Component, OnInit } from '@angular/core';
import { BehaviorSubject, combineLatest, merge, Observable, Subject } from 'rxjs';

@Component({
  selector: 'app-series',
  templateUrl: './series.component.html',
  styleUrls: ['./series.component.less']
})
export class SeriesComponent implements OnInit {
  currentSeries$ = new BehaviorSubject<Series[]>([]);
  constructor() { }

  ngOnInit(): void {
    this.currentSeries$.next(this.getSeries());
  }

  getSeries(): Series[] {
    var series: Series[] = ([]);
    series.push({id: 1, name: "Formula Renault 3.5", description: "the best"})
    return series;
  }
}

export interface Series {
  id: number;
  name: string;
  description: string;
}
