import { Component, OnInit, Input } from '@angular/core';
import { LoggerService } from './logger.service';

@Component({
  selector: 'app-logger',
  templateUrl: './logger.component.html',
  styleUrls: ['./logger.component.css']
})
export class LoggerComponent {
  logs: string[];

  constructor(logService: LoggerService) {
    this.logs = logService.logs;
  }
}
