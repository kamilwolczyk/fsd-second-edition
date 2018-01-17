import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { SchoolMember } from '../models/school-member';

@Component({
  selector: 'app-code-school-members-list',
  templateUrl: './code-school-members-list.component.html',
  styleUrls: ['./code-school-members-list.component.css']
})
export class CodeSchoolMembersListComponent {
  @Input() items: SchoolMember[];
  @Output() someAction = new EventEmitter();

  addEmpty() {
    this.items.unshift(new SchoolMember('', ''));
    this.someAction.emit('Add empty button clicked');
  }

  showMemberDetails(member: SchoolMember) {
    alert(`${member.firstName} ${member.lastName}`);
    this.someAction.emit(`Details button for item ${member.lastName} clicked`);
  }
}
