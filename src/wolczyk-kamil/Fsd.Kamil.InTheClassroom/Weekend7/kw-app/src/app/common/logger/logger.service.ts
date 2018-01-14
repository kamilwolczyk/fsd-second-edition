import { Injectable } from '@angular/core';

@Injectable()
export class LoggerService {
  logs: string[];

  constructor() {
    this.logs = [];
  }

}
