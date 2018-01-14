import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClockPanelComponent } from './clock-panel.component';

describe('ClockPanelComponent', () => {
  let component: ClockPanelComponent;
  let fixture: ComponentFixture<ClockPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClockPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClockPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
