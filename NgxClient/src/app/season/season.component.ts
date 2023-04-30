import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-season',
  templateUrl: './season.component.html',
  styleUrls: ['./season.component.less']
})
export class SeasonComponent implements OnInit {
currentSeason: SeasonVm = {name: '2023 Season 2'}
  constructor() { }

  ngOnInit(): void {
  }

}

export interface SeasonVm{
  name: string;
}
