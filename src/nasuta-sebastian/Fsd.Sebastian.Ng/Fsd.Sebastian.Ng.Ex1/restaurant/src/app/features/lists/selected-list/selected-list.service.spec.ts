import { TestBed, inject } from '@angular/core/testing';

import { SelectedListService } from './selected-list.service';

describe('SelectedListService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SelectedListService]
    });
  });

  it('should be created', inject([SelectedListService], (service: SelectedListService) => {
    expect(service).toBeTruthy();
  }));
});
