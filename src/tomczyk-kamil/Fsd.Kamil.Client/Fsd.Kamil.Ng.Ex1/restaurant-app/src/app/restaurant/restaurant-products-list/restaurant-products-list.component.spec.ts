import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RestaurantProductsListComponent } from './restaurant-products-list.component';

describe('RestaurantProductsListComponent', () => {
  let component: RestaurantProductsListComponent;
  let fixture: ComponentFixture<RestaurantProductsListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RestaurantProductsListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RestaurantProductsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
