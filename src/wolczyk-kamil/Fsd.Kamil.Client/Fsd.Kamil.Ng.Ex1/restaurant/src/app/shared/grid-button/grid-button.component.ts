import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';

@Component({
  selector: 'kw-grid-button',
  templateUrl: './grid-button.component.html',
  styleUrls: ['./grid-button.component.css']
})
export class GridButtonComponent {
  @Output() action = new EventEmitter();
  @Input() text: string;

  clickAction() {
    this.action.emit();
  }

}
