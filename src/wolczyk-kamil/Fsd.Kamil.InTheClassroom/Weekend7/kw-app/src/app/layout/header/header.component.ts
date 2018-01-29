import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  currentDate: string;

  constructor() {
    const now = new Date();
    const day = this.setTwoDigits(now.getDate());
    const month = this.setTwoDigits(now.getMonth() + 1);
    const year = this.setTwoDigits(now.getFullYear());

    this.currentDate = `${day}.${month}.${year}`;
  }

  private setTwoDigits(value: number): string {
    return value > 9 ? value.toString() : `0${value}`;
  }

  ngOnInit() {
  }

}
