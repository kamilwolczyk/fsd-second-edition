import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-clock-panel',
  templateUrl: './clock-panel.component.html',
  styleUrls: ['./clock-panel.component.css']
})
export class ClockPanelComponent implements OnInit {
  hours: number;
  minutes: number;
  seconds: number;

  constructor() {  }

  ngOnInit(): void {
    this.refreshTime();

    setInterval(() => {
      this.refreshTime();
    }, 1000);
  }

  private refreshTime() {
    const now = new Date();

    this.hours = now.getHours();
    this.minutes = now.getMinutes();
    this.seconds = now.getSeconds();
  }
}
