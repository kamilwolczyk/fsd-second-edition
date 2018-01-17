import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeSchoolMembersComponent } from './code-school-members.component';

describe('CodeSchoolMembersComponent', () => {
  let component: CodeSchoolMembersComponent;
  let fixture: ComponentFixture<CodeSchoolMembersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeSchoolMembersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeSchoolMembersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
