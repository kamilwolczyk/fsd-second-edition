import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'kw-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  currentYear: number;

  ngOnInit() {
    this.currentYear = new Date().getFullYear();
  }
}
