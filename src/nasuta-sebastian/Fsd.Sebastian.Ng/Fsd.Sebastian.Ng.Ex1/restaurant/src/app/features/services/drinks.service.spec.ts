import { TestBed, inject } from '@angular/core/testing';

import { DrinksService } from './drinks.service';

describe('DrinksService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DrinksService]
    });
  });

  it('should be created', inject([DrinksService], (service: DrinksService) => {
    expect(service).toBeTruthy();
  }));
});
