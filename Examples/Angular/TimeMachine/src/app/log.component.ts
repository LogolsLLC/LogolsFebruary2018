import { Component } from '@angular/core';
import { Log } from './entities/log'
import { LogService } from './services/logService'

@Component({
  selector: 'log',
  templateUrl: './log.component.html',
  styleUrls: ['./log.component.css']
})
export class LogComponent {
  public title:string = 'Time Machine Travel Log';
  public logs:Log[];

  public constructor(logService: LogService) {
    this.logs = [];
    logService.getAll().subscribe(result => {
      this.logs.push(...result);
    }, error => console.error(error));
  }
}
