import { Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { } from '@angular/core';

@Component({
  selector: 'app-series',
  templateUrl: './series.component.html',
  styleUrls: ['./series.component.less']
})

export class SeriesComponent implements OnInit {
  public currentSeries: Series[] = [];

  constructor(private httpClient: HttpClient) {
  }

  ngOnInit(): void {
    this.getSeries()
      .subscribe((data) => {
        this.currentSeries = data;
      });
  }

  getSeries = (): Observable<Series[]> => {
    const url = 'https://vt7oz4nqbdzdtzyqjko623age40eagha.lambda-url.ap-southeast-2.on.aws/';
    return this.httpClient.get<Series[]>(url);
  }
}

export interface Series {
  Id: string;
  Name: string;
  Description: string;
  SeasonId: string;
}
