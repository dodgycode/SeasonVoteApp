import { Component, OnInit, Injectable, ChangeDetectorRef } from '@angular/core';
import { BehaviorSubject, combineLatest, merge, Observable, Subject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { } from '@angular/core';

@Component({
  selector: 'app-series',
  templateUrl: './series.component.html',
  styleUrls: ['./series.component.less']
})

export class SeriesComponent implements OnInit {
  public currentSeries: Series[] = [];

  constructor(private ref: ChangeDetectorRef, private httpClient: HttpClient) {
  }

  ngOnInit(): void {
    this.getSeries()
      .subscribe((data) => {
        this.currentSeries = data;
        this.ref.detectChanges();
      });
  }

  getSeries = (): Observable<Series[]> => {
    const url = 'https://vt7oz4nqbdzdtzyqjko623age40eagha.lambda-url.ap-southeast-2.on.aws/';
    return this.httpClient.get<Series[]>(url);
  }
}

export interface Series {
  id: string;
  name: string;
  description: string;
  seasonId: string;
}
