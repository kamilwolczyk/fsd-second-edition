import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClockSeparatorComponent } from './clock-separator.component';

describe('ClockSeparatorComponent', () => {
  let component: ClockSeparatorComponent;
  let fixture: ComponentFixture<ClockSeparatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClockSeparatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClockSeparatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
