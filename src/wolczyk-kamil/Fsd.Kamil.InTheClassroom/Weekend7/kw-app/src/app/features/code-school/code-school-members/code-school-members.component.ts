import { Component, OnInit, Inject } from '@angular/core';
import { SchoolMember } from '../models/school-member';
import { LoggerService } from '../../../common/logger/logger.service';

@Component({
  selector: 'app-code-school-members',
  templateUrl: './code-school-members.component.html',
  styleUrls: ['./code-school-members.component.css']
})
export class CodeSchoolMembersComponent implements OnInit {
  members: SchoolMember[];
  buttonClass: string;
  isTableShown: boolean;
  toggleButtonText: string;

  logService: LoggerService;

  constructor(logService: LoggerService) {
    this.logService = logService;
  }

  ngOnInit(): void {
    this.buttonClass = 'btn';
    this.toggleTable();

    this.members = [
      new SchoolMember('Kamil', 'Wołczyk', 1, 28),
      new SchoolMember('Kamil', 'Tomczyk', 2, 31),
      new SchoolMember('Maciej', 'Grun', 3, 35),
      new SchoolMember('Sebastian', 'Nasuta', 4, 26),
      new SchoolMember('Damian', 'Janus', 5, 26),
      new SchoolMember('Artur', 'Mazela', 6, 19),
      new SchoolMember('Michał', 'Porowiec', 7, 18),
      new SchoolMember('Bartek', 'Gawroński', 8, 18),
      new SchoolMember('Jacek', 'Bielewicz', 9, 41),
      new SchoolMember('Arek', 'Pawelak', 10, 17)
    ];
  }

  toggleTable() {
    this.isTableShown = !this.isTableShown;
    this.toggleButtonText = this.isTableShown ? 'Ukryj' : 'Pokaż';
  }

  someActionHasBeenTriggered(message: string) {
    this.logService.logs.push(`${new Date().toLocaleTimeString()} - ${message}`);
  }
}
