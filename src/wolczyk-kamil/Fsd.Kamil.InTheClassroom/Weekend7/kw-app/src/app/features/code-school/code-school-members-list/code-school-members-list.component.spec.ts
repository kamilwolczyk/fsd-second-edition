import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeSchoolMembersListComponent } from './code-school-members-list.component';

describe('CodeSchoolMembersListComponent', () => {
  let component: CodeSchoolMembersListComponent;
  let fixture: ComponentFixture<CodeSchoolMembersListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CodeSchoolMembersListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeSchoolMembersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
