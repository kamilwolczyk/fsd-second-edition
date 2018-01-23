import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RestaurantProductTableComponent } from './restaurant-product-table.component';

describe('RestaurantProductTableComponent', () => {
  let component: RestaurantProductTableComponent;
  let fixture: ComponentFixture<RestaurantProductTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RestaurantProductTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RestaurantProductTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
